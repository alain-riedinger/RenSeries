namespace RenSeries
{
    partial class FormRenSeries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelUrl = new System.Windows.Forms.Label();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelRegex = new System.Windows.Forms.Label();
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.buttonRegexHelp = new System.Windows.Forms.Button();
            this.labelFlies = new System.Windows.Forms.Label();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.OldFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxAutoNumber = new System.Windows.Forms.CheckBox();
            this.labelSkipItems = new System.Windows.Forms.Label();
            this.numericUpDownSkiptItems = new System.Windows.Forms.NumericUpDown();
            this.labelRegexFileNumber = new System.Windows.Forms.Label();
            this.textBoxRegexFileNumber = new System.Windows.Forms.TextBox();
            this.buttonRegexFileNumberHelp = new System.Windows.Forms.Button();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.buttonNumber = new System.Windows.Forms.Button();
            this.buttonTitle = new System.Windows.Forms.Button();
            this.buttonRegexFileNumber = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSkiptItems)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(64, 26);
            this.labelUrl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(56, 25);
            this.labelUrl.TabIndex = 0;
            this.labelUrl.Text = "URL:";
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Location = new System.Drawing.Point(28, 74);
            this.labelDirectory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(95, 25);
            this.labelDirectory.TabIndex = 2;
            this.labelDirectory.Text = "Directory:";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.Location = new System.Drawing.Point(134, 20);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(855, 29);
            this.textBoxUrl.TabIndex = 1;
            this.toolTipHelp.SetToolTip(this.textBoxUrl, "URL of the web page containing episode list");
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.AllowDrop = true;
            this.textBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirectory.Location = new System.Drawing.Point(134, 68);
            this.textBoxDirectory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(855, 29);
            this.textBoxDirectory.TabIndex = 3;
            this.toolTipHelp.SetToolTip(this.textBoxDirectory, "Directory containing the files to be renamed");
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(1003, 65);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(44, 42);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "...";
            this.toolTipHelp.SetToolTip(this.buttonBrowse, "Browse for a directory with files");
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelRegex
            // 
            this.labelRegex.AutoSize = true;
            this.labelRegex.Location = new System.Drawing.Point(48, 124);
            this.labelRegex.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRegex.Name = "labelRegex";
            this.labelRegex.Size = new System.Drawing.Size(74, 25);
            this.labelRegex.TabIndex = 5;
            this.labelRegex.Text = "Regex:";
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.AcceptsReturn = true;
            this.textBoxRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegex.Location = new System.Drawing.Point(134, 118);
            this.textBoxRegex.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxRegex.Multiline = true;
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(855, 144);
            this.textBoxRegex.TabIndex = 6;
            this.toolTipHelp.SetToolTip(this.textBoxRegex, "Regex for the extraction of:\r\n+ the number of the episodes\r\n+ the title of the ep" +
        "îsodes");
            // 
            // buttonRegexHelp
            // 
            this.buttonRegexHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegexHelp.Location = new System.Drawing.Point(1003, 120);
            this.buttonRegexHelp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRegexHelp.Name = "buttonRegexHelp";
            this.buttonRegexHelp.Size = new System.Drawing.Size(44, 42);
            this.buttonRegexHelp.TabIndex = 7;
            this.buttonRegexHelp.Text = "?";
            this.toolTipHelp.SetToolTip(this.buttonRegexHelp, "Select a regex among a list of existing");
            this.buttonRegexHelp.UseVisualStyleBackColor = true;
            this.buttonRegexHelp.Click += new System.EventHandler(this.buttonRegexHelp_Click);
            // 
            // labelFlies
            // 
            this.labelFlies.AutoSize = true;
            this.labelFlies.Location = new System.Drawing.Point(66, 384);
            this.labelFlies.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFlies.Name = "labelFlies";
            this.labelFlies.Size = new System.Drawing.Size(59, 25);
            this.labelFlies.TabIndex = 10;
            this.labelFlies.Text = "Files:";
            // 
            // buttonRename
            // 
            this.buttonRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRename.Location = new System.Drawing.Point(854, 330);
            this.buttonRename.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(138, 42);
            this.buttonRename.TabIndex = 9;
            this.buttonRename.Text = "Rename";
            this.toolTipHelp.SetToolTip(this.buttonRename, "Actually rename the files with the content of the preview list");
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPreview.Location = new System.Drawing.Point(706, 330);
            this.buttonPreview.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(138, 42);
            this.buttonPreview.TabIndex = 8;
            this.buttonPreview.Text = "Preview";
            this.toolTipHelp.SetToolTip(this.buttonPreview, "Update the file list with the title of the episodes");
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AllowUserToAddRows = false;
            this.dataGridViewFiles.AllowUserToDeleteRows = false;
            this.dataGridViewFiles.AllowUserToResizeRows = false;
            this.dataGridViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OldFile,
            this.NewFile});
            this.dataGridViewFiles.Location = new System.Drawing.Point(134, 384);
            this.dataGridViewFiles.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.RowHeadersVisible = false;
            this.dataGridViewFiles.Size = new System.Drawing.Size(858, 412);
            this.dataGridViewFiles.TabIndex = 12;
            this.dataGridViewFiles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFiles_CellEndEdit);
            // 
            // OldFile
            // 
            this.OldFile.HeaderText = "File";
            this.OldFile.MinimumWidth = 90;
            this.OldFile.Name = "OldFile";
            this.OldFile.ReadOnly = true;
            this.OldFile.Width = 120;
            // 
            // NewFile
            // 
            this.NewFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NewFile.HeaderText = "New File";
            this.NewFile.MinimumWidth = 90;
            this.NewFile.Name = "NewFile";
            // 
            // checkBoxAutoNumber
            // 
            this.checkBoxAutoNumber.AutoSize = true;
            this.checkBoxAutoNumber.Location = new System.Drawing.Point(134, 281);
            this.checkBoxAutoNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxAutoNumber.Name = "checkBoxAutoNumber";
            this.checkBoxAutoNumber.Size = new System.Drawing.Size(176, 29);
            this.checkBoxAutoNumber.TabIndex = 13;
            this.checkBoxAutoNumber.Text = "Auto numbering";
            this.toolTipHelp.SetToolTip(this.checkBoxAutoNumber, "To be checked when no number in HTML source\r\neg HTML source with auto <li> only");
            this.checkBoxAutoNumber.UseVisualStyleBackColor = true;
            // 
            // labelSkipItems
            // 
            this.labelSkipItems.AutoSize = true;
            this.labelSkipItems.Location = new System.Drawing.Point(343, 286);
            this.labelSkipItems.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSkipItems.Name = "labelSkipItems";
            this.labelSkipItems.Size = new System.Drawing.Size(73, 25);
            this.labelSkipItems.TabIndex = 14;
            this.labelSkipItems.Text = "Skip #:";
            // 
            // numericUpDownSkiptItems
            // 
            this.numericUpDownSkiptItems.Location = new System.Drawing.Point(422, 281);
            this.numericUpDownSkiptItems.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numericUpDownSkiptItems.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownSkiptItems.Name = "numericUpDownSkiptItems";
            this.numericUpDownSkiptItems.Size = new System.Drawing.Size(66, 29);
            this.numericUpDownSkiptItems.TabIndex = 15;
            this.toolTipHelp.SetToolTip(this.numericUpDownSkiptItems, "Skip this number of matching items before associating.\r\nEg when 2 seasons are on " +
        "the same HTML page.");
            // 
            // labelRegexFileNumber
            // 
            this.labelRegexFileNumber.AutoSize = true;
            this.labelRegexFileNumber.Location = new System.Drawing.Point(524, 288);
            this.labelRegexFileNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRegexFileNumber.Name = "labelRegexFileNumber";
            this.labelRegexFileNumber.Size = new System.Drawing.Size(135, 25);
            this.labelRegexFileNumber.TabIndex = 16;
            this.labelRegexFileNumber.Text = "Regex File Nr:";
            // 
            // textBoxRegexFileNumber
            // 
            this.textBoxRegexFileNumber.Location = new System.Drawing.Point(664, 282);
            this.textBoxRegexFileNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxRegexFileNumber.Name = "textBoxRegexFileNumber";
            this.textBoxRegexFileNumber.Size = new System.Drawing.Size(270, 29);
            this.textBoxRegexFileNumber.TabIndex = 17;
            this.toolTipHelp.SetToolTip(this.textBoxRegexFileNumber, "Regex for the extraction of the file number");
            // 
            // buttonRegexFileNumberHelp
            // 
            this.buttonRegexFileNumberHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegexFileNumberHelp.Location = new System.Drawing.Point(1003, 281);
            this.buttonRegexFileNumberHelp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRegexFileNumberHelp.Name = "buttonRegexFileNumberHelp";
            this.buttonRegexFileNumberHelp.Size = new System.Drawing.Size(44, 42);
            this.buttonRegexFileNumberHelp.TabIndex = 18;
            this.buttonRegexFileNumberHelp.Text = "?";
            this.toolTipHelp.SetToolTip(this.buttonRegexFileNumberHelp, "Select a regex among a list of existing");
            this.buttonRegexFileNumberHelp.UseVisualStyleBackColor = true;
            // 
            // buttonNumber
            // 
            this.buttonNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNumber.Location = new System.Drawing.Point(1003, 174);
            this.buttonNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonNumber.Name = "buttonNumber";
            this.buttonNumber.Size = new System.Drawing.Size(44, 42);
            this.buttonNumber.TabIndex = 19;
            this.buttonNumber.Text = "N";
            this.toolTipHelp.SetToolTip(this.buttonNumber, "Add the default number regex pattern at cursor.\r\nReplaces the selected text, if s" +
        "ome.");
            this.buttonNumber.UseVisualStyleBackColor = true;
            this.buttonNumber.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonTitle
            // 
            this.buttonTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTitle.Location = new System.Drawing.Point(1003, 223);
            this.buttonTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonTitle.Name = "buttonTitle";
            this.buttonTitle.Size = new System.Drawing.Size(44, 42);
            this.buttonTitle.TabIndex = 20;
            this.buttonTitle.Text = "T";
            this.toolTipHelp.SetToolTip(this.buttonTitle, "Add the default title regex pattern at cursor.\r\nReplaces the selected text, if so" +
        "me.");
            this.buttonTitle.UseVisualStyleBackColor = true;
            this.buttonTitle.Click += new System.EventHandler(this.buttonTitle_Click);
            // 
            // buttonRegexFileNumber
            // 
            this.buttonRegexFileNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegexFileNumber.Location = new System.Drawing.Point(948, 281);
            this.buttonRegexFileNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRegexFileNumber.Name = "buttonRegexFileNumber";
            this.buttonRegexFileNumber.Size = new System.Drawing.Size(44, 42);
            this.buttonRegexFileNumber.TabIndex = 21;
            this.buttonRegexFileNumber.Text = "N";
            this.toolTipHelp.SetToolTip(this.buttonRegexFileNumber, "Add the default number regex pattern at cursor.\r\nReplaces the selected text, if s" +
        "ome.");
            this.buttonRegexFileNumber.UseVisualStyleBackColor = true;
            this.buttonRegexFileNumber.Click += new System.EventHandler(this.buttonRegexFileNumber_Click);
            // 
            // FormRenSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 820);
            this.Controls.Add(this.buttonRegexFileNumber);
            this.Controls.Add(this.buttonTitle);
            this.Controls.Add(this.buttonNumber);
            this.Controls.Add(this.buttonRegexFileNumberHelp);
            this.Controls.Add(this.textBoxRegexFileNumber);
            this.Controls.Add(this.labelRegexFileNumber);
            this.Controls.Add(this.numericUpDownSkiptItems);
            this.Controls.Add(this.labelSkipItems);
            this.Controls.Add(this.checkBoxAutoNumber);
            this.Controls.Add(this.dataGridViewFiles);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.labelFlies);
            this.Controls.Add(this.buttonRegexHelp);
            this.Controls.Add(this.textBoxRegex);
            this.Controls.Add(this.labelRegex);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.labelDirectory);
            this.Controls.Add(this.labelUrl);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1080, 767);
            this.Name = "FormRenSeries";
            this.Text = "RenSeries";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRenSeries_FormClosing);
            this.Load += new System.EventHandler(this.FormRenSeries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSkiptItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelRegex;
        private System.Windows.Forms.TextBox textBoxRegex;
        private System.Windows.Forms.Button buttonRegexHelp;
        private System.Windows.Forms.Label labelFlies;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn OldFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewFile;
        private System.Windows.Forms.CheckBox checkBoxAutoNumber;
        private System.Windows.Forms.Label labelSkipItems;
        private System.Windows.Forms.NumericUpDown numericUpDownSkiptItems;
        private System.Windows.Forms.Label labelRegexFileNumber;
        private System.Windows.Forms.TextBox textBoxRegexFileNumber;
        private System.Windows.Forms.Button buttonRegexFileNumberHelp;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.Button buttonNumber;
        private System.Windows.Forms.Button buttonTitle;
        private System.Windows.Forms.Button buttonRegexFileNumber;
    }
}

