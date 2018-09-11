using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Net;

// How to save user infos
// http://timtrott.co.uk/saving-user-preferences-settings-application/

// How to use wikipedia API
// http://www.labnol.org/internet/tools/using-wikipedia-api-demo-source-code-example/3076/

// How to center Message boxes on appli, not screen
// http://www.codeproject.com/Articles/9984/Centering-MessageBox-Common-DialogBox-or-Form-on-a

namespace RenSeries
{
    public partial class FormRenSeries : Form
    {
        string directory;
        string[] htmlRegexes = {
@"<tr style=""border-top:2px solid;border-top-color:#bbccff;"">
<td[^>]+>(?<number>[0-9]{2,2})</td>
<td><i>(?<title>[^<]+)</i></td>",
@"<li>(?<title>[^<]+)</li>",
@"<tr class=""vevent"" style=""text-align: center; background:#F2F2F2"">
<th scope=""row"" id=""ep[0-9]+"" [^>]+>(?<number>[0-9]+)</th>
<td class=""summary"" style=""text-align: left;"">""(?<title>[^""]+)""<br />"
                             };

        public FormRenSeries()
        {
            InitializeComponent();
        }

        private void UpdateFilesList()
        {
            // Clear files list
            dataGridViewFiles.Rows.Clear();
            dataGridViewFiles.Refresh();

            // Update files list
            string[] files = Directory.GetFiles(directory);
            Array.Sort(files);
            foreach (string file in files)
            {
                dataGridViewFiles.Rows.Add(Path.GetFileName(file));
            }
        }

        private void ParseEpisodes(string html)
        {
            // Adapt the regex new lines to only \n, by removing \r
            string pattern = textBoxRegex.Text;
            pattern = pattern.Replace("\r", "");

            // Find all matches
            Regex regex = new Regex(pattern, RegexOptions.Singleline);
            MatchCollection matches = regex.Matches(html);

            // Loop through the matches
            int numberAuto = 0;
            int skipped = 0;
            foreach(Match match in matches)
            {
                // Process skipping of the "Skip #" first matches (in case of multiple lists of episodes on the same page)
                skipped++;
                if (skipped <= numericUpDownSkiptItems.Value)
                    continue;

                // Get number and title
                numberAuto++;
                if (numberAuto > dataGridViewFiles.Rows.Count)
                    // More matches than files in the list: just stop it here
                    break;
                // Retrieve informations of episode from match
                string number = match.Groups["number"].Value;
                if (checkBoxAutoNumber.Checked)
                    number = string.Format("{0:D2}", numberAuto);
                string title = match.Groups["title"].Value;

                // Find matching number in files
                foreach (DataGridViewRow row in dataGridViewFiles.Rows)
                {
                    string file = row.Cells["OldFile"].Value.ToString();
                    Match m = Regex.Match(file, textBoxRegexFileNumber.Text);
                    bool bMatching = false;
                    bool bStrangeNumber = false;
                    try
                    {
                        // Do as if it was 2 numeric values
                        bMatching = (Convert.ToInt32(m.Groups["number"].Value) == Convert.ToInt32(number));
                    }
                    catch (Exception ex)
                    {
                        // Something is not that  numeric, just try to compare brute value
                        bMatching = (m.Groups["number"].Value == number);
                        bStrangeNumber = true;
                    }
                    if (bMatching)
                    {
                        // Update new file name with value parsed from the episode list
                        string newFile;
                        if (bStrangeNumber)
                            // Number is strange: use it as is
                            newFile = string.Format("{0} {1}{2}", number, title, Path.GetExtension(file));
                        else
                            // Number is a number: format it on 2 digits, 0 left padded
                            newFile = string.Format("{0:D2} {1}{2}", Convert.ToInt32(number), title, Path.GetExtension(file));
                            
                        row.Cells["NewFile"].Value = newFile;

                        // Check if file name is valid and signal invalid one
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        if (newFile.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                        {
                            style.BackColor = Color.Red;
                            style.ForeColor = Color.LightYellow;
                        }
                        row.Cells["NewFile"].Style = style;
                        //var isValid = !string.IsNullOrEmpty(fileName) &&
                        //              fileName.IndexOfAny(Path.GetInvalidFileNameChars()) < 0 &&
                        //              !File.Exists(Path.Combine(sourceFolder, fileName));
                    }
                }
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(directory))
            {
                // Adjust used path, in case directory was renamed eg.
                fbd.SelectedPath = directory;
                while (!Directory.Exists(fbd.SelectedPath))
                {
                    fbd.SelectedPath = Directory.GetParent(fbd.SelectedPath).FullName;
                }
            }
            // Display folder dialog
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                // Update folder info
                directory = fbd.SelectedPath;
                textBoxDirectory.Text = directory;

                // Update files list
                UpdateFilesList();
            }
        }

        private void FormRenSeries_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            if (string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("directory")))
            {
                config.AppSettings.Settings.Add("directory", directory);
            }
            else
            {
                config.AppSettings.Settings["directory"].Value = directory;
            }
            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void FormRenSeries_Load(object sender, EventArgs e)
        {
            // For test only
            textBoxUrl.Text = @"http://fr.wikipedia.org/wiki/Ghost_Hound#Liste_des_.C3.A9pisodes";
            textBoxRegex.Text = @"<tr style=""border-top:2px solid;border-top-color:#bbccff;"">
<td[^>]+>(?<number>[0-9]{2,2})</td>
<td><i>(?<title>[^<]+)</i></td>";

            textBoxUrl.Text = @"http://fr.wikipedia.org/wiki/Gilgamesh_%28s%C3%A9rie_t%C3%A9l%C3%A9vis%C3%A9e_d%27animation%29";
            textBoxRegex.Text = @"<li>(?<title>[^<]+)</li>
";

            textBoxUrl.Text = @"http://en.wikipedia.org/wiki/List_of_Gravion_episodes";
            textBoxRegex.Text = @"<tr class=""vevent"" style=""text-align: center; background:#F2F2F2"">
<th scope=""row"" id=""ep[0-9]+"" style=""text-align: center; font-weight: normal; background:#F2F2F2"">(?<number>[0-9]+)</th>
<td class=""summary"" style=""text-align: left;"">""(?<title>[^""]+)""<br />";

            textBoxRegex.Text = htmlRegexes[0];
            textBoxRegexFileNumber.Text = "(?<number>[0-9]+) ";

            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("directory")))
            {
                directory = config.AppSettings.Settings["directory"].Value;
                textBoxDirectory.Text = directory;

                // Update files list
                UpdateFilesList();
            }
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            // Check inputs
            if (string.IsNullOrEmpty(textBoxUrl.Text))
            {
                MessageBox.Show("Please enter the URL of the page containing the list of episodes", "Missing parameter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxUrl.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxRegex.Text))
            {
                MessageBox.Show("Please enter the regex for the parsing of the list of episodes", "Missing parameter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxRegex.Focus();
                return;
            }
            if (textBoxRegex.Text.IndexOf("?<number>") < 0 &&
                !checkBoxAutoNumber.Checked)
            {
                MessageBox.Show("No ?<number> group in regex, nor auto numbering.\nAdjust those parameters.", "Missing parameter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxRegex.Focus();
                return;
            }
            if (textBoxRegex.Text.IndexOf("?<title>") < 0)
            {
                MessageBox.Show("No ?<title> group in regex, nor auto numbering.\nAdjust those parameters.", "Missing parameter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxRegex.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxDirectory.Text))
            {
                MessageBox.Show("Please enter the directory of the file of the episodes", "Missing parameter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDirectory.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBoxRegexFileNumber.Text))
            {
                MessageBox.Show("Please enter the regex for the extraction \nof the file number from the file name", "Missing parameter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxRegexFileNumber.Focus();
                return;
            }

            // Get web page
            string html;
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                try
                {
                    html = wc.DownloadString(textBoxUrl.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Parse the web page
            ParseEpisodes(html);
        }

        private void dataGridViewFiles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewFiles.Rows[e.RowIndex];
            if (row.Cells["NewFile"].Value == null)
                return;
            string newFile = row.Cells["NewFile"].Value.ToString();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            if (newFile.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                style.BackColor = Color.Red;
                style.ForeColor = Color.LightYellow;
            }
            row.Cells["NewFile"].Style = style;
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            // Check the root path for the files (just in case it has been modified)
            if (string.IsNullOrEmpty(textBoxDirectory.Text))
            {
                MessageBox.Show("Please enter the directory of the file of the episodes", "Missing parameter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDirectory.Focus();
                return;
            }
            if (dataGridViewFiles.Rows.Count <= 0)
            {
                MessageBox.Show(@"Please enter the directory of the file of the episodes\n and click on ""Preview"" button", "Missing parameter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDirectory.Focus();
                return;
            }

            // Loop through the list of files to check the validity of the names
            foreach (DataGridViewRow row in dataGridViewFiles.Rows)
            {
                if (row.Cells["NewFile"].Value != null)
                {
                    string newFile = row.Cells["NewFile"].Value.ToString();
                    if (!string.IsNullOrWhiteSpace(newFile))
                    {
                        // Check file name
                        if (newFile.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                        {
                            DialogResult dr = MessageBox.Show("Invalid file name.\nAutomatical correction (Yes)\nInterrupt and Manual correction (No)", "Invalid file name", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                            if (dr == DialogResult.Yes)
                            {
                                // Clean file name
                                foreach (char c in Path.GetInvalidFileNameChars())
                                {
                                    newFile = newFile.Replace(c.ToString(), "");
                                }

                                // Update the file name list
                                row.Cells["NewFile"].Value = newFile;
                                DataGridViewCellStyle style = new DataGridViewCellStyle();
                                if (newFile.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                                {
                                    style.BackColor = Color.Red;
                                    style.ForeColor = Color.LightYellow;
                                }
                                row.Cells["NewFile"].Style = style;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
            }

            // Loop through the list of files to check the validity of the names
            int nbFilesRenamed = 0;
            foreach (DataGridViewRow row in dataGridViewFiles.Rows)
            {
                if (row.Cells["OldFile"].Value != null &&
                    row.Cells["NewFile"].Value != null)
                {
                    string oldFile = row.Cells["OldFile"].Value.ToString();
                    string newFile = row.Cells["NewFile"].Value.ToString();
                    if (!string.IsNullOrWhiteSpace(oldFile) &&
                        !string.IsNullOrWhiteSpace(newFile))
                    {
                        try
                        {
                            // Rename the files
                            File.Move(Path.Combine(directory, oldFile), Path.Combine(directory, newFile));
                            nbFilesRenamed++;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

            MessageBox.Show(string.Format("{0} files have been renamed", nbFilesRenamed), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRegexHelp_Click(object sender, EventArgs e)
        {
            FormRegexHelp frh = new FormRegexHelp();
            frh.Regexes = htmlRegexes;
            if (frh.ShowDialog() == DialogResult.OK)
            {
                textBoxRegex.Text = htmlRegexes[frh.SelectedRegex];
            }
        }

        private void buttonRegexFileNumber_Click(object sender, EventArgs e)
        {
            textBoxRegexFileNumber.SelectedText = "(?<number>[0-9]+)";
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            textBoxRegex.SelectedText = "(?<number>[0-9]+)";
        }

        private void buttonTitle_Click(object sender, EventArgs e)
        {
            textBoxRegex.SelectedText = "(?<title>[^<]+)";
        }
    }
}
