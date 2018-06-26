namespace FileRenamer
{
	partial class MainForm
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
			this.panel_directory = new System.Windows.Forms.Panel();
			this.textBox_directoryPath = new System.Windows.Forms.TextBox();
			this.panel_spacer1 = new System.Windows.Forms.Panel();
			this.label_directory = new System.Windows.Forms.Label();
			this.button_selectDirectory = new System.Windows.Forms.Button();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.checkedListBox_files = new System.Windows.Forms.CheckedListBox();
			this.panel_fileLabels = new System.Windows.Forms.Panel();
			this.label_checkedCount = new System.Windows.Forms.Label();
			this.label_files = new System.Windows.Forms.Label();
			this.textBox_log = new System.Windows.Forms.TextBox();
			this.label_results = new System.Windows.Forms.Label();
			this.panel_spacer2 = new System.Windows.Forms.Panel();
			this.panel_spacer3 = new System.Windows.Forms.Panel();
			this.panel_controls = new System.Windows.Forms.Panel();
			this.statusStrip_progress = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel_status = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.panel_spacer6 = new System.Windows.Forms.Panel();
			this.button_reset = new System.Windows.Forms.Button();
			this.panel_spacer5 = new System.Windows.Forms.Panel();
			this.button_processFiles = new System.Windows.Forms.Button();
			this.panel_spacer4 = new System.Windows.Forms.Panel();
			this.panel_renamingOptions = new System.Windows.Forms.Panel();
			this.radioButton_numerical = new System.Windows.Forms.RadioButton();
			this.groupBox_numericOptions = new System.Windows.Forms.GroupBox();
			this.radioButton_sort_random = new System.Windows.Forms.RadioButton();
			this.radioButton_sort_descending = new System.Windows.Forms.RadioButton();
			this.radioButton_sort_ascending = new System.Windows.Forms.RadioButton();
			this.comboBox_sortBy = new System.Windows.Forms.ComboBox();
			this.label_sortBy = new System.Windows.Forms.Label();
			this.checkBox_padWithLeadingZeroes = new System.Windows.Forms.CheckBox();
			this.panel_spacer7 = new System.Windows.Forms.Panel();
			this.radioButton_random = new System.Windows.Forms.RadioButton();
			this.groupBox_randomOptions = new System.Windows.Forms.GroupBox();
			this.checkBox_allowSpaces = new System.Windows.Forms.CheckBox();
			this.checkBox_allowSymbols = new System.Windows.Forms.CheckBox();
			this.checkBox_allowNumbers = new System.Windows.Forms.CheckBox();
			this.checkBox_allowLetters = new System.Windows.Forms.CheckBox();
			this.checkBox_allowUppercase = new System.Windows.Forms.CheckBox();
			this.checkBox_allowLowercase = new System.Windows.Forms.CheckBox();
			this.panel_directory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.panel_fileLabels.SuspendLayout();
			this.panel_controls.SuspendLayout();
			this.statusStrip_progress.SuspendLayout();
			this.panel_renamingOptions.SuspendLayout();
			this.groupBox_numericOptions.SuspendLayout();
			this.groupBox_randomOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_directory
			// 
			this.panel_directory.Controls.Add(this.textBox_directoryPath);
			this.panel_directory.Controls.Add(this.panel_spacer1);
			this.panel_directory.Controls.Add(this.label_directory);
			this.panel_directory.Controls.Add(this.button_selectDirectory);
			this.panel_directory.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_directory.Location = new System.Drawing.Point(5, 5);
			this.panel_directory.Name = "panel_directory";
			this.panel_directory.Size = new System.Drawing.Size(619, 25);
			this.panel_directory.TabIndex = 0;
			// 
			// textBox_directoryPath
			// 
			this.textBox_directoryPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_directoryPath.Location = new System.Drawing.Point(65, 0);
			this.textBox_directoryPath.Name = "textBox_directoryPath";
			this.textBox_directoryPath.ReadOnly = true;
			this.textBox_directoryPath.Size = new System.Drawing.Size(507, 23);
			this.textBox_directoryPath.TabIndex = 3;
			// 
			// panel_spacer1
			// 
			this.panel_spacer1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel_spacer1.Location = new System.Drawing.Point(572, 0);
			this.panel_spacer1.Name = "panel_spacer1";
			this.panel_spacer1.Size = new System.Drawing.Size(5, 25);
			this.panel_spacer1.TabIndex = 999;
			// 
			// label_directory
			// 
			this.label_directory.Dock = System.Windows.Forms.DockStyle.Left;
			this.label_directory.Location = new System.Drawing.Point(0, 0);
			this.label_directory.Name = "label_directory";
			this.label_directory.Size = new System.Drawing.Size(65, 25);
			this.label_directory.TabIndex = 1;
			this.label_directory.Text = "Directory:";
			this.label_directory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button_selectDirectory
			// 
			this.button_selectDirectory.Dock = System.Windows.Forms.DockStyle.Right;
			this.button_selectDirectory.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button_selectDirectory.Location = new System.Drawing.Point(577, 0);
			this.button_selectDirectory.Name = "button_selectDirectory";
			this.button_selectDirectory.Size = new System.Drawing.Size(42, 25);
			this.button_selectDirectory.TabIndex = 2;
			this.button_selectDirectory.Text = "...";
			this.button_selectDirectory.UseVisualStyleBackColor = true;
			this.button_selectDirectory.Click += new System.EventHandler(this.button_selectDirectory_Click);
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Enabled = false;
			this.splitContainer.Location = new System.Drawing.Point(5, 185);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.checkedListBox_files);
			this.splitContainer.Panel1.Controls.Add(this.panel_fileLabels);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.textBox_log);
			this.splitContainer.Panel2.Controls.Add(this.label_results);
			this.splitContainer.Size = new System.Drawing.Size(619, 241);
			this.splitContainer.SplitterDistance = 207;
			this.splitContainer.SplitterWidth = 5;
			this.splitContainer.TabIndex = 4;
			// 
			// checkedListBox_files
			// 
			this.checkedListBox_files.CheckOnClick = true;
			this.checkedListBox_files.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkedListBox_files.FormattingEnabled = true;
			this.checkedListBox_files.IntegralHeight = false;
			this.checkedListBox_files.Location = new System.Drawing.Point(0, 25);
			this.checkedListBox_files.Name = "checkedListBox_files";
			this.checkedListBox_files.Size = new System.Drawing.Size(207, 216);
			this.checkedListBox_files.TabIndex = 4;
			this.checkedListBox_files.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_files_ItemCheck);
			// 
			// panel_fileLabels
			// 
			this.panel_fileLabels.Controls.Add(this.label_checkedCount);
			this.panel_fileLabels.Controls.Add(this.label_files);
			this.panel_fileLabels.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_fileLabels.Location = new System.Drawing.Point(0, 0);
			this.panel_fileLabels.Name = "panel_fileLabels";
			this.panel_fileLabels.Size = new System.Drawing.Size(207, 25);
			this.panel_fileLabels.TabIndex = 5;
			// 
			// label_checkedCount
			// 
			this.label_checkedCount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_checkedCount.Location = new System.Drawing.Point(60, 0);
			this.label_checkedCount.Name = "label_checkedCount";
			this.label_checkedCount.Size = new System.Drawing.Size(147, 25);
			this.label_checkedCount.TabIndex = 7;
			this.label_checkedCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_files
			// 
			this.label_files.Dock = System.Windows.Forms.DockStyle.Left;
			this.label_files.Location = new System.Drawing.Point(0, 0);
			this.label_files.Name = "label_files";
			this.label_files.Size = new System.Drawing.Size(60, 25);
			this.label_files.TabIndex = 6;
			this.label_files.Text = "Files:";
			this.label_files.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox_log
			// 
			this.textBox_log.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_log.Location = new System.Drawing.Point(0, 25);
			this.textBox_log.Multiline = true;
			this.textBox_log.Name = "textBox_log";
			this.textBox_log.ReadOnly = true;
			this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_log.Size = new System.Drawing.Size(407, 216);
			this.textBox_log.TabIndex = 7;
			// 
			// label_results
			// 
			this.label_results.Dock = System.Windows.Forms.DockStyle.Top;
			this.label_results.Location = new System.Drawing.Point(0, 0);
			this.label_results.Name = "label_results";
			this.label_results.Size = new System.Drawing.Size(407, 25);
			this.label_results.TabIndex = 6;
			this.label_results.Text = "Log:";
			this.label_results.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel_spacer2
			// 
			this.panel_spacer2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_spacer2.Location = new System.Drawing.Point(5, 30);
			this.panel_spacer2.Name = "panel_spacer2";
			this.panel_spacer2.Size = new System.Drawing.Size(619, 5);
			this.panel_spacer2.TabIndex = 1000;
			// 
			// panel_spacer3
			// 
			this.panel_spacer3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_spacer3.Location = new System.Drawing.Point(5, 180);
			this.panel_spacer3.Name = "panel_spacer3";
			this.panel_spacer3.Size = new System.Drawing.Size(619, 5);
			this.panel_spacer3.TabIndex = 1001;
			// 
			// panel_controls
			// 
			this.panel_controls.Controls.Add(this.statusStrip_progress);
			this.panel_controls.Controls.Add(this.panel_spacer6);
			this.panel_controls.Controls.Add(this.button_reset);
			this.panel_controls.Controls.Add(this.panel_spacer5);
			this.panel_controls.Controls.Add(this.button_processFiles);
			this.panel_controls.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel_controls.Location = new System.Drawing.Point(5, 431);
			this.panel_controls.Name = "panel_controls";
			this.panel_controls.Size = new System.Drawing.Size(619, 25);
			this.panel_controls.TabIndex = 1002;
			// 
			// statusStrip_progress
			// 
			this.statusStrip_progress.AllowMerge = false;
			this.statusStrip_progress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.statusStrip_progress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_status,
            this.toolStripProgressBar});
			this.statusStrip_progress.Location = new System.Drawing.Point(0, 0);
			this.statusStrip_progress.Name = "statusStrip_progress";
			this.statusStrip_progress.Size = new System.Drawing.Size(404, 25);
			this.statusStrip_progress.SizingGrip = false;
			this.statusStrip_progress.TabIndex = 1001;
			this.statusStrip_progress.Text = "statusStrip1";
			// 
			// toolStripStatusLabel_status
			// 
			this.toolStripStatusLabel_status.Name = "toolStripStatusLabel_status";
			this.toolStripStatusLabel_status.Size = new System.Drawing.Size(389, 20);
			this.toolStripStatusLabel_status.Spring = true;
			this.toolStripStatusLabel_status.Text = "Select a directory to get started.";
			this.toolStripStatusLabel_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripProgressBar
			// 
			this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripProgressBar.Margin = new System.Windows.Forms.Padding(1, 7, 1, 3);
			this.toolStripProgressBar.Maximum = 0;
			this.toolStripProgressBar.Name = "toolStripProgressBar";
			this.toolStripProgressBar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.toolStripProgressBar.Size = new System.Drawing.Size(100, 15);
			this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.toolStripProgressBar.Visible = false;
			// 
			// panel_spacer6
			// 
			this.panel_spacer6.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel_spacer6.Location = new System.Drawing.Point(404, 0);
			this.panel_spacer6.Name = "panel_spacer6";
			this.panel_spacer6.Size = new System.Drawing.Size(10, 25);
			this.panel_spacer6.TabIndex = 1002;
			// 
			// button_reset
			// 
			this.button_reset.Dock = System.Windows.Forms.DockStyle.Right;
			this.button_reset.Enabled = false;
			this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button_reset.Location = new System.Drawing.Point(414, 0);
			this.button_reset.Name = "button_reset";
			this.button_reset.Size = new System.Drawing.Size(100, 25);
			this.button_reset.TabIndex = 4;
			this.button_reset.Text = "Reset";
			this.button_reset.UseVisualStyleBackColor = true;
			this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
			// 
			// panel_spacer5
			// 
			this.panel_spacer5.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel_spacer5.Location = new System.Drawing.Point(514, 0);
			this.panel_spacer5.Name = "panel_spacer5";
			this.panel_spacer5.Size = new System.Drawing.Size(5, 25);
			this.panel_spacer5.TabIndex = 1000;
			// 
			// button_processFiles
			// 
			this.button_processFiles.Dock = System.Windows.Forms.DockStyle.Right;
			this.button_processFiles.Enabled = false;
			this.button_processFiles.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button_processFiles.Location = new System.Drawing.Point(519, 0);
			this.button_processFiles.Name = "button_processFiles";
			this.button_processFiles.Size = new System.Drawing.Size(100, 25);
			this.button_processFiles.TabIndex = 3;
			this.button_processFiles.Text = "Process files";
			this.button_processFiles.UseVisualStyleBackColor = true;
			this.button_processFiles.Click += new System.EventHandler(this.button_processFiles_Click);
			// 
			// panel_spacer4
			// 
			this.panel_spacer4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel_spacer4.Location = new System.Drawing.Point(5, 426);
			this.panel_spacer4.Name = "panel_spacer4";
			this.panel_spacer4.Size = new System.Drawing.Size(619, 5);
			this.panel_spacer4.TabIndex = 1003;
			// 
			// panel_renamingOptions
			// 
			this.panel_renamingOptions.Controls.Add(this.radioButton_numerical);
			this.panel_renamingOptions.Controls.Add(this.groupBox_numericOptions);
			this.panel_renamingOptions.Controls.Add(this.panel_spacer7);
			this.panel_renamingOptions.Controls.Add(this.radioButton_random);
			this.panel_renamingOptions.Controls.Add(this.groupBox_randomOptions);
			this.panel_renamingOptions.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_renamingOptions.Enabled = false;
			this.panel_renamingOptions.Location = new System.Drawing.Point(5, 35);
			this.panel_renamingOptions.Name = "panel_renamingOptions";
			this.panel_renamingOptions.Size = new System.Drawing.Size(619, 145);
			this.panel_renamingOptions.TabIndex = 3;
			// 
			// radioButton_numerical
			// 
			this.radioButton_numerical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton_numerical.Checked = true;
			this.radioButton_numerical.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton_numerical.Location = new System.Drawing.Point(5, 0);
			this.radioButton_numerical.Name = "radioButton_numerical";
			this.radioButton_numerical.Size = new System.Drawing.Size(157, 20);
			this.radioButton_numerical.TabIndex = 1003;
			this.radioButton_numerical.TabStop = true;
			this.radioButton_numerical.Text = "Rename files numerically";
			this.radioButton_numerical.UseVisualStyleBackColor = true;
			this.radioButton_numerical.CheckedChanged += new System.EventHandler(this.radioButton_numerical_CheckedChanged);
			// 
			// groupBox_numericOptions
			// 
			this.groupBox_numericOptions.Controls.Add(this.radioButton_sort_random);
			this.groupBox_numericOptions.Controls.Add(this.radioButton_sort_descending);
			this.groupBox_numericOptions.Controls.Add(this.radioButton_sort_ascending);
			this.groupBox_numericOptions.Controls.Add(this.comboBox_sortBy);
			this.groupBox_numericOptions.Controls.Add(this.label_sortBy);
			this.groupBox_numericOptions.Controls.Add(this.checkBox_padWithLeadingZeroes);
			this.groupBox_numericOptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox_numericOptions.Enabled = false;
			this.groupBox_numericOptions.Location = new System.Drawing.Point(0, 0);
			this.groupBox_numericOptions.Name = "groupBox_numericOptions";
			this.groupBox_numericOptions.Size = new System.Drawing.Size(332, 145);
			this.groupBox_numericOptions.TabIndex = 1;
			this.groupBox_numericOptions.TabStop = false;
			// 
			// radioButton_sort_random
			// 
			this.radioButton_sort_random.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton_sort_random.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton_sort_random.Location = new System.Drawing.Point(80, 120);
			this.radioButton_sort_random.Name = "radioButton_sort_random";
			this.radioButton_sort_random.Size = new System.Drawing.Size(237, 20);
			this.radioButton_sort_random.TabIndex = 1007;
			this.radioButton_sort_random.Tag = "2";
			this.radioButton_sort_random.Text = "Random order";
			this.radioButton_sort_random.UseVisualStyleBackColor = true;
			this.radioButton_sort_random.CheckedChanged += new System.EventHandler(this.radioButton_sortOrders_CheckChanged);
			// 
			// radioButton_sort_descending
			// 
			this.radioButton_sort_descending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton_sort_descending.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton_sort_descending.Location = new System.Drawing.Point(80, 100);
			this.radioButton_sort_descending.Name = "radioButton_sort_descending";
			this.radioButton_sort_descending.Size = new System.Drawing.Size(237, 20);
			this.radioButton_sort_descending.TabIndex = 1006;
			this.radioButton_sort_descending.Tag = "1";
			this.radioButton_sort_descending.Text = "Descending order";
			this.radioButton_sort_descending.UseVisualStyleBackColor = true;
			this.radioButton_sort_descending.CheckedChanged += new System.EventHandler(this.radioButton_sortOrders_CheckChanged);
			// 
			// radioButton_sort_ascending
			// 
			this.radioButton_sort_ascending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton_sort_ascending.Checked = true;
			this.radioButton_sort_ascending.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton_sort_ascending.Location = new System.Drawing.Point(80, 80);
			this.radioButton_sort_ascending.Name = "radioButton_sort_ascending";
			this.radioButton_sort_ascending.Size = new System.Drawing.Size(237, 20);
			this.radioButton_sort_ascending.TabIndex = 1004;
			this.radioButton_sort_ascending.TabStop = true;
			this.radioButton_sort_ascending.Tag = "0";
			this.radioButton_sort_ascending.Text = "Ascending order";
			this.radioButton_sort_ascending.UseVisualStyleBackColor = true;
			this.radioButton_sort_ascending.CheckedChanged += new System.EventHandler(this.radioButton_sortOrders_CheckChanged);
			// 
			// comboBox_sortBy
			// 
			this.comboBox_sortBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox_sortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_sortBy.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboBox_sortBy.FormattingEnabled = true;
			this.comboBox_sortBy.Items.AddRange(new object[] {
            "Name",
            "Size",
            "Date created",
            "Date modified"});
			this.comboBox_sortBy.Location = new System.Drawing.Point(80, 50);
			this.comboBox_sortBy.Name = "comboBox_sortBy";
			this.comboBox_sortBy.Size = new System.Drawing.Size(242, 23);
			this.comboBox_sortBy.TabIndex = 1004;
			// 
			// label_sortBy
			// 
			this.label_sortBy.Location = new System.Drawing.Point(20, 50);
			this.label_sortBy.Name = "label_sortBy";
			this.label_sortBy.Size = new System.Drawing.Size(55, 23);
			this.label_sortBy.TabIndex = 1005;
			this.label_sortBy.Text = "Sort by:";
			this.label_sortBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBox_padWithLeadingZeroes
			// 
			this.checkBox_padWithLeadingZeroes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox_padWithLeadingZeroes.Checked = true;
			this.checkBox_padWithLeadingZeroes.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_padWithLeadingZeroes.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox_padWithLeadingZeroes.Location = new System.Drawing.Point(20, 20);
			this.checkBox_padWithLeadingZeroes.Name = "checkBox_padWithLeadingZeroes";
			this.checkBox_padWithLeadingZeroes.Size = new System.Drawing.Size(302, 23);
			this.checkBox_padWithLeadingZeroes.TabIndex = 1003;
			this.checkBox_padWithLeadingZeroes.Text = "Pad with leading zeroes";
			this.checkBox_padWithLeadingZeroes.UseVisualStyleBackColor = true;
			// 
			// panel_spacer7
			// 
			this.panel_spacer7.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel_spacer7.Location = new System.Drawing.Point(332, 0);
			this.panel_spacer7.Name = "panel_spacer7";
			this.panel_spacer7.Size = new System.Drawing.Size(10, 145);
			this.panel_spacer7.TabIndex = 1009;
			// 
			// radioButton_random
			// 
			this.radioButton_random.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton_random.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton_random.Location = new System.Drawing.Point(347, 0);
			this.radioButton_random.Name = "radioButton_random";
			this.radioButton_random.Size = new System.Drawing.Size(205, 20);
			this.radioButton_random.TabIndex = 0;
			this.radioButton_random.Text = "Assign a random name to each file";
			this.radioButton_random.UseVisualStyleBackColor = true;
			this.radioButton_random.CheckedChanged += new System.EventHandler(this.radioButton_random_CheckedChanged);
			// 
			// groupBox_randomOptions
			// 
			this.groupBox_randomOptions.Controls.Add(this.checkBox_allowLowercase);
			this.groupBox_randomOptions.Controls.Add(this.checkBox_allowUppercase);
			this.groupBox_randomOptions.Controls.Add(this.checkBox_allowSpaces);
			this.groupBox_randomOptions.Controls.Add(this.checkBox_allowSymbols);
			this.groupBox_randomOptions.Controls.Add(this.checkBox_allowNumbers);
			this.groupBox_randomOptions.Controls.Add(this.checkBox_allowLetters);
			this.groupBox_randomOptions.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox_randomOptions.Enabled = false;
			this.groupBox_randomOptions.Location = new System.Drawing.Point(342, 0);
			this.groupBox_randomOptions.Name = "groupBox_randomOptions";
			this.groupBox_randomOptions.Size = new System.Drawing.Size(277, 145);
			this.groupBox_randomOptions.TabIndex = 1008;
			this.groupBox_randomOptions.TabStop = false;
			// 
			// checkBox_allowSpaces
			// 
			this.checkBox_allowSpaces.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox_allowSpaces.Location = new System.Drawing.Point(20, 120);
			this.checkBox_allowSpaces.Name = "checkBox_allowSpaces";
			this.checkBox_allowSpaces.Size = new System.Drawing.Size(195, 20);
			this.checkBox_allowSpaces.TabIndex = 1006;
			this.checkBox_allowSpaces.Text = "Allow spaces";
			this.checkBox_allowSpaces.UseVisualStyleBackColor = true;
			// 
			// checkBox_allowSymbols
			// 
			this.checkBox_allowSymbols.Checked = true;
			this.checkBox_allowSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_allowSymbols.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox_allowSymbols.Location = new System.Drawing.Point(20, 100);
			this.checkBox_allowSymbols.Name = "checkBox_allowSymbols";
			this.checkBox_allowSymbols.Size = new System.Drawing.Size(195, 20);
			this.checkBox_allowSymbols.TabIndex = 1005;
			this.checkBox_allowSymbols.Text = "Allow symbols";
			this.checkBox_allowSymbols.UseVisualStyleBackColor = true;
			// 
			// checkBox_allowNumbers
			// 
			this.checkBox_allowNumbers.Checked = true;
			this.checkBox_allowNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_allowNumbers.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox_allowNumbers.Location = new System.Drawing.Point(20, 80);
			this.checkBox_allowNumbers.Name = "checkBox_allowNumbers";
			this.checkBox_allowNumbers.Size = new System.Drawing.Size(195, 20);
			this.checkBox_allowNumbers.TabIndex = 1004;
			this.checkBox_allowNumbers.Text = "Allow numbers";
			this.checkBox_allowNumbers.UseVisualStyleBackColor = true;
			// 
			// checkBox_allowLetters
			// 
			this.checkBox_allowLetters.Checked = true;
			this.checkBox_allowLetters.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_allowLetters.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox_allowLetters.Location = new System.Drawing.Point(20, 20);
			this.checkBox_allowLetters.Name = "checkBox_allowLetters";
			this.checkBox_allowLetters.Size = new System.Drawing.Size(195, 20);
			this.checkBox_allowLetters.TabIndex = 1003;
			this.checkBox_allowLetters.Text = "Allow letters";
			this.checkBox_allowLetters.UseVisualStyleBackColor = true;
			// 
			// checkBox_allowUppercase
			// 
			this.checkBox_allowUppercase.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox_allowUppercase.Location = new System.Drawing.Point(35, 40);
			this.checkBox_allowUppercase.Name = "checkBox_allowUppercase";
			this.checkBox_allowUppercase.Size = new System.Drawing.Size(195, 20);
			this.checkBox_allowUppercase.TabIndex = 1007;
			this.checkBox_allowUppercase.Text = "Allow uppercase";
			this.checkBox_allowUppercase.UseVisualStyleBackColor = true;
			// 
			// checkBox_allowLowercase
			// 
			this.checkBox_allowLowercase.Checked = true;
			this.checkBox_allowLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_allowLowercase.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox_allowLowercase.Location = new System.Drawing.Point(35, 60);
			this.checkBox_allowLowercase.Name = "checkBox_allowLowercase";
			this.checkBox_allowLowercase.Size = new System.Drawing.Size(195, 20);
			this.checkBox_allowLowercase.TabIndex = 1008;
			this.checkBox_allowLowercase.Text = "Allow lowercase";
			this.checkBox_allowLowercase.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AcceptButton = this.button_processFiles;
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 461);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.panel_spacer4);
			this.Controls.Add(this.panel_controls);
			this.Controls.Add(this.panel_spacer3);
			this.Controls.Add(this.panel_renamingOptions);
			this.Controls.Add(this.panel_spacer2);
			this.Controls.Add(this.panel_directory);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.Text = "File Renamer";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			this.panel_directory.ResumeLayout(false);
			this.panel_directory.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.panel_fileLabels.ResumeLayout(false);
			this.panel_controls.ResumeLayout(false);
			this.panel_controls.PerformLayout();
			this.statusStrip_progress.ResumeLayout(false);
			this.statusStrip_progress.PerformLayout();
			this.panel_renamingOptions.ResumeLayout(false);
			this.groupBox_numericOptions.ResumeLayout(false);
			this.groupBox_randomOptions.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_directory;
		private System.Windows.Forms.TextBox textBox_directoryPath;
		private System.Windows.Forms.Panel panel_spacer1;
		private System.Windows.Forms.Label label_directory;
		private System.Windows.Forms.Button button_selectDirectory;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.CheckedListBox checkedListBox_files;
		private System.Windows.Forms.Panel panel_spacer2;
		private System.Windows.Forms.Panel panel_spacer3;
		private System.Windows.Forms.TextBox textBox_log;
		private System.Windows.Forms.Label label_results;
		private System.Windows.Forms.Panel panel_controls;
		private System.Windows.Forms.Button button_processFiles;
		private System.Windows.Forms.Button button_reset;
		private System.Windows.Forms.Panel panel_spacer5;
		private System.Windows.Forms.Panel panel_spacer4;
		private System.Windows.Forms.StatusStrip statusStrip_progress;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_status;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
		private System.Windows.Forms.Panel panel_spacer6;
		private System.Windows.Forms.Panel panel_fileLabels;
		private System.Windows.Forms.Label label_files;
		private System.Windows.Forms.Label label_checkedCount;
		private System.Windows.Forms.Panel panel_renamingOptions;
		private System.Windows.Forms.RadioButton radioButton_random;
		private System.Windows.Forms.RadioButton radioButton_numerical;
		private System.Windows.Forms.GroupBox groupBox_numericOptions;
		private System.Windows.Forms.RadioButton radioButton_sort_random;
		private System.Windows.Forms.RadioButton radioButton_sort_descending;
		private System.Windows.Forms.RadioButton radioButton_sort_ascending;
		private System.Windows.Forms.ComboBox comboBox_sortBy;
		private System.Windows.Forms.Label label_sortBy;
		private System.Windows.Forms.CheckBox checkBox_padWithLeadingZeroes;
		private System.Windows.Forms.GroupBox groupBox_randomOptions;
		private System.Windows.Forms.CheckBox checkBox_allowSpaces;
		private System.Windows.Forms.CheckBox checkBox_allowSymbols;
		private System.Windows.Forms.CheckBox checkBox_allowNumbers;
		private System.Windows.Forms.CheckBox checkBox_allowLetters;
		private System.Windows.Forms.Panel panel_spacer7;
		private System.Windows.Forms.CheckBox checkBox_allowLowercase;
		private System.Windows.Forms.CheckBox checkBox_allowUppercase;

	}
}

