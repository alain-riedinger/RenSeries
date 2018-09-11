using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenSeries
{
    public partial class FormRegexHelp : Form
    {
        public string[] Regexes { get ; set; }
        public int SelectedRegex { get; set; }

        public FormRegexHelp()
        {
            InitializeComponent();

            SelectedRegex = 0;
        }

        private void FormRegexHelp_Load(object sender, EventArgs e)
        {
            // Fill the list
            foreach (string regex in Regexes)
            {
                dataGridViewRegex.Rows.Add(regex);
            }

            // Select the one
            int sel = 0;
            if (SelectedRegex >= 0 && SelectedRegex < dataGridViewRegex.Rows.Count)
                sel = SelectedRegex;
            dataGridViewRegex.Rows[sel].Selected = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewRegex.Rows.Count; i++)
            {
                if (dataGridViewRegex.Rows[i].Selected)
                {
                    SelectedRegex = i;
                    break;
                }
            }
        }
    }
}
