namespace RustServerManager
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.WipeServerButton = new System.Windows.Forms.Button();
            this.StartServerButton = new System.Windows.Forms.Button();
            this.ServerArgumentsTextBox = new System.Windows.Forms.RichTextBox();
            this.ServerArgumentsLabel = new System.Windows.Forms.Label();
            this.ForceInstallDirTextBox = new System.Windows.Forms.TextBox();
            this.ServerInstallDirectoryLabel = new System.Windows.Forms.Label();
            this.WipeHourTextBox = new System.Windows.Forms.TextBox();
            this.WipeMinuteTextBox = new System.Windows.Forms.TextBox();
            this.WipeSettingsLabel = new System.Windows.Forms.Label();
            this.WipeTimeIdentifierComboBox = new System.Windows.Forms.ComboBox();
            this.WipeDayTimeSeparatorLabel = new System.Windows.Forms.Label();
            this.WipeIntervalBiWeeklyRadioButton = new System.Windows.Forms.RadioButton();
            this.WipeIntervalMonthlyRadioButton = new System.Windows.Forms.RadioButton();
            this.LocalServerIdentityLabel = new System.Windows.Forms.Label();
            this.ServerIdentityTextBox = new System.Windows.Forms.TextBox();
            this.StartFromSundayCheckBox = new System.Windows.Forms.CheckBox();
            this.WipeIntervalWeeklyRadioButton = new System.Windows.Forms.RadioButton();
            this.ServerSeedLabel = new System.Windows.Forms.Label();
            this.ServerSeedTextBox = new System.Windows.Forms.TextBox();
            this.RandomServerSeedCheckBox = new System.Windows.Forms.CheckBox();
            this.ChangesOnWipeLabel = new System.Windows.Forms.Label();
            this.CurrentServerSeedLabel = new System.Windows.Forms.Label();
            this.AutoRestartOnCrashCheckBox = new System.Windows.Forms.CheckBox();
            this.BackupOnWipeCheckBox = new System.Windows.Forms.CheckBox();
            this.StopServerButton = new System.Windows.Forms.Button();
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ServerSettingsPanel = new System.Windows.Forms.Panel();
            this.OpenServerPathButton = new System.Windows.Forms.Button();
            this.ForceInstallDirBrowseButton = new System.Windows.Forms.Button();
            this.WipeBlueprintsPanel = new System.Windows.Forms.Panel();
            this.BlueprintsNeverRadioButton = new System.Windows.Forms.RadioButton();
            this.WipeBlueprintsLabel = new System.Windows.Forms.Label();
            this.BlueprintsForcewipeRadioButton = new System.Windows.Forms.RadioButton();
            this.BlueprintsEveryWipeRadioButton = new System.Windows.Forms.RadioButton();
            this.WipeIntervalPanel = new System.Windows.Forms.Panel();
            this.WipeIntervalLabel = new System.Windows.Forms.Label();
            this.WipeDayLabel = new System.Windows.Forms.Label();
            this.BackupSettingsLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleVersionLabel = new System.Windows.Forms.Label();
            this.StartServerPanel = new System.Windows.Forms.Panel();
            this.RestartServerButton = new System.Windows.Forms.Button();
            this.StopServerPanel = new System.Windows.Forms.Panel();
            this.TitleIconPictureBox = new System.Windows.Forms.PictureBox();
            this.AutoRestartAtTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoRestartHourTextBox = new System.Windows.Forms.TextBox();
            this.AutoRestartMinuteTextBox = new System.Windows.Forms.TextBox();
            this.AutoRestartTimeIdentifierComboBox = new System.Windows.Forms.ComboBox();
            this.AutoRestartTimeSeparatorLabel = new System.Windows.Forms.Label();
            this.RestartSettingsLabel = new System.Windows.Forms.Label();
            this.ServerStatusLabel = new System.Windows.Forms.Label();
            this.ServerStatusPanel = new System.Windows.Forms.Panel();
            this.WipeSettingsPanel = new System.Windows.Forms.Panel();
            this.RestartSettingsPanel = new System.Windows.Forms.Panel();
            this.BackupSettingsPanel = new System.Windows.Forms.Panel();
            this.BackupServerButton = new System.Windows.Forms.Button();
            this.BackupOnRestartCheckBox = new System.Windows.Forms.CheckBox();
            this.DisplayConsoleCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearLogButton = new System.Windows.Forms.Button();
            this.TitlebarPanel.SuspendLayout();
            this.ServerSettingsPanel.SuspendLayout();
            this.WipeBlueprintsPanel.SuspendLayout();
            this.WipeIntervalPanel.SuspendLayout();
            this.StartServerPanel.SuspendLayout();
            this.StopServerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleIconPictureBox)).BeginInit();
            this.ServerStatusPanel.SuspendLayout();
            this.WipeSettingsPanel.SuspendLayout();
            this.RestartSettingsPanel.SuspendLayout();
            this.BackupSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WipeServerButton
            // 
            this.WipeServerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.WipeServerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.WipeServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WipeServerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WipeServerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.WipeServerButton.Location = new System.Drawing.Point(22, 133);
            this.WipeServerButton.Name = "WipeServerButton";
            this.WipeServerButton.Size = new System.Drawing.Size(60, 21);
            this.WipeServerButton.TabIndex = 20;
            this.WipeServerButton.Text = "Wipe Now";
            this.WipeServerButton.UseVisualStyleBackColor = false;
            this.WipeServerButton.Click += new System.EventHandler(this.WipeServerButton_Click);
            // 
            // StartServerButton
            // 
            this.StartServerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(231)))), ((int)(((byte)(49)))));
            this.StartServerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(231)))), ((int)(((byte)(49)))));
            this.StartServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartServerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartServerButton.ForeColor = System.Drawing.Color.Black;
            this.StartServerButton.Location = new System.Drawing.Point(5, 5);
            this.StartServerButton.Name = "StartServerButton";
            this.StartServerButton.Size = new System.Drawing.Size(136, 44);
            this.StartServerButton.TabIndex = 29;
            this.StartServerButton.Text = "Start Server";
            this.StartServerButton.UseVisualStyleBackColor = false;
            this.StartServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
            // 
            // ServerArgumentsTextBox
            // 
            this.ServerArgumentsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ServerArgumentsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServerArgumentsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ServerArgumentsTextBox.Location = new System.Drawing.Point(10, 160);
            this.ServerArgumentsTextBox.Name = "ServerArgumentsTextBox";
            this.ServerArgumentsTextBox.Size = new System.Drawing.Size(312, 66);
            this.ServerArgumentsTextBox.TabIndex = 8;
            this.ServerArgumentsTextBox.Text = "";
            // 
            // ServerArgumentsLabel
            // 
            this.ServerArgumentsLabel.AutoSize = true;
            this.ServerArgumentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ServerArgumentsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ServerArgumentsLabel.Location = new System.Drawing.Point(7, 143);
            this.ServerArgumentsLabel.Name = "ServerArgumentsLabel";
            this.ServerArgumentsLabel.Size = new System.Drawing.Size(234, 15);
            this.ServerArgumentsLabel.TabIndex = 0;
            this.ServerArgumentsLabel.Text = "Server Arguments (separated by newline):";
            // 
            // ForceInstallDirTextBox
            // 
            this.ForceInstallDirTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ForceInstallDirTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ForceInstallDirTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ForceInstallDirTextBox.Location = new System.Drawing.Point(10, 26);
            this.ForceInstallDirTextBox.Name = "ForceInstallDirTextBox";
            this.ForceInstallDirTextBox.Size = new System.Drawing.Size(293, 20);
            this.ForceInstallDirTextBox.TabIndex = 2;
            this.ForceInstallDirTextBox.Text = "rustserver";
            // 
            // ServerInstallDirectoryLabel
            // 
            this.ServerInstallDirectoryLabel.AutoSize = true;
            this.ServerInstallDirectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerInstallDirectoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ServerInstallDirectoryLabel.Location = new System.Drawing.Point(6, 9);
            this.ServerInstallDirectoryLabel.Name = "ServerInstallDirectoryLabel";
            this.ServerInstallDirectoryLabel.Size = new System.Drawing.Size(236, 15);
            this.ServerInstallDirectoryLabel.TabIndex = 0;
            this.ServerInstallDirectoryLabel.Text = "Server Install Directory (+force_install_dir):";
            // 
            // WipeHourTextBox
            // 
            this.WipeHourTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.WipeHourTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WipeHourTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WipeHourTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.WipeHourTextBox.Location = new System.Drawing.Point(86, 18);
            this.WipeHourTextBox.Name = "WipeHourTextBox";
            this.WipeHourTextBox.Size = new System.Drawing.Size(22, 21);
            this.WipeHourTextBox.TabIndex = 10;
            this.WipeHourTextBox.Text = "2";
            // 
            // WipeMinuteTextBox
            // 
            this.WipeMinuteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.WipeMinuteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WipeMinuteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WipeMinuteTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.WipeMinuteTextBox.Location = new System.Drawing.Point(120, 18);
            this.WipeMinuteTextBox.Name = "WipeMinuteTextBox";
            this.WipeMinuteTextBox.Size = new System.Drawing.Size(29, 21);
            this.WipeMinuteTextBox.TabIndex = 11;
            this.WipeMinuteTextBox.Text = "00";
            // 
            // WipeSettingsLabel
            // 
            this.WipeSettingsLabel.AutoSize = true;
            this.WipeSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.WipeSettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.WipeSettingsLabel.Location = new System.Drawing.Point(1, 2);
            this.WipeSettingsLabel.Name = "WipeSettingsLabel";
            this.WipeSettingsLabel.Size = new System.Drawing.Size(85, 15);
            this.WipeSettingsLabel.TabIndex = 0;
            this.WipeSettingsLabel.Text = "Wipe Settings:";
            // 
            // WipeTimeIdentifierComboBox
            // 
            this.WipeTimeIdentifierComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.WipeTimeIdentifierComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WipeTimeIdentifierComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WipeTimeIdentifierComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.WipeTimeIdentifierComboBox.FormattingEnabled = true;
            this.WipeTimeIdentifierComboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.WipeTimeIdentifierComboBox.Location = new System.Drawing.Point(151, 18);
            this.WipeTimeIdentifierComboBox.Name = "WipeTimeIdentifierComboBox";
            this.WipeTimeIdentifierComboBox.Size = new System.Drawing.Size(40, 21);
            this.WipeTimeIdentifierComboBox.TabIndex = 12;
            this.WipeTimeIdentifierComboBox.Text = "PM";
            // 
            // WipeDayTimeSeparatorLabel
            // 
            this.WipeDayTimeSeparatorLabel.AutoSize = true;
            this.WipeDayTimeSeparatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WipeDayTimeSeparatorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.WipeDayTimeSeparatorLabel.Location = new System.Drawing.Point(108, 20);
            this.WipeDayTimeSeparatorLabel.Name = "WipeDayTimeSeparatorLabel";
            this.WipeDayTimeSeparatorLabel.Size = new System.Drawing.Size(11, 16);
            this.WipeDayTimeSeparatorLabel.TabIndex = 0;
            this.WipeDayTimeSeparatorLabel.Text = ":";
            // 
            // WipeIntervalBiWeeklyRadioButton
            // 
            this.WipeIntervalBiWeeklyRadioButton.AutoSize = true;
            this.WipeIntervalBiWeeklyRadioButton.Checked = true;
            this.WipeIntervalBiWeeklyRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.WipeIntervalBiWeeklyRadioButton.Location = new System.Drawing.Point(5, 35);
            this.WipeIntervalBiWeeklyRadioButton.Name = "WipeIntervalBiWeeklyRadioButton";
            this.WipeIntervalBiWeeklyRadioButton.Size = new System.Drawing.Size(73, 17);
            this.WipeIntervalBiWeeklyRadioButton.TabIndex = 15;
            this.WipeIntervalBiWeeklyRadioButton.TabStop = true;
            this.WipeIntervalBiWeeklyRadioButton.Text = "Bi-Weekly";
            this.WipeIntervalBiWeeklyRadioButton.UseVisualStyleBackColor = true;
            // 
            // WipeIntervalMonthlyRadioButton
            // 
            this.WipeIntervalMonthlyRadioButton.AutoSize = true;
            this.WipeIntervalMonthlyRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.WipeIntervalMonthlyRadioButton.Location = new System.Drawing.Point(5, 51);
            this.WipeIntervalMonthlyRadioButton.Name = "WipeIntervalMonthlyRadioButton";
            this.WipeIntervalMonthlyRadioButton.Size = new System.Drawing.Size(62, 17);
            this.WipeIntervalMonthlyRadioButton.TabIndex = 16;
            this.WipeIntervalMonthlyRadioButton.Text = "Monthly";
            this.WipeIntervalMonthlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // LocalServerIdentityLabel
            // 
            this.LocalServerIdentityLabel.AutoSize = true;
            this.LocalServerIdentityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LocalServerIdentityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.LocalServerIdentityLabel.Location = new System.Drawing.Point(6, 50);
            this.LocalServerIdentityLabel.Name = "LocalServerIdentityLabel";
            this.LocalServerIdentityLabel.Size = new System.Drawing.Size(211, 15);
            this.LocalServerIdentityLabel.TabIndex = 0;
            this.LocalServerIdentityLabel.Text = "Local Server Identity (+server.identity):";
            // 
            // ServerIdentityTextBox
            // 
            this.ServerIdentityTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ServerIdentityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerIdentityTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ServerIdentityTextBox.Location = new System.Drawing.Point(10, 67);
            this.ServerIdentityTextBox.Name = "ServerIdentityTextBox";
            this.ServerIdentityTextBox.Size = new System.Drawing.Size(293, 20);
            this.ServerIdentityTextBox.TabIndex = 4;
            this.ServerIdentityTextBox.Text = "server";
            // 
            // StartFromSundayCheckBox
            // 
            this.StartFromSundayCheckBox.AutoSize = true;
            this.StartFromSundayCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.StartFromSundayCheckBox.Location = new System.Drawing.Point(24, 39);
            this.StartFromSundayCheckBox.Name = "StartFromSundayCheckBox";
            this.StartFromSundayCheckBox.Size = new System.Drawing.Size(133, 17);
            this.StartFromSundayCheckBox.TabIndex = 13;
            this.StartFromSundayCheckBox.Text = "Begin from Week Start";
            this.StartFromSundayCheckBox.UseVisualStyleBackColor = true;
            // 
            // WipeIntervalWeeklyRadioButton
            // 
            this.WipeIntervalWeeklyRadioButton.AutoSize = true;
            this.WipeIntervalWeeklyRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.WipeIntervalWeeklyRadioButton.Location = new System.Drawing.Point(5, 19);
            this.WipeIntervalWeeklyRadioButton.Name = "WipeIntervalWeeklyRadioButton";
            this.WipeIntervalWeeklyRadioButton.Size = new System.Drawing.Size(61, 17);
            this.WipeIntervalWeeklyRadioButton.TabIndex = 14;
            this.WipeIntervalWeeklyRadioButton.Text = "Weekly";
            this.WipeIntervalWeeklyRadioButton.UseVisualStyleBackColor = true;
            // 
            // ServerSeedLabel
            // 
            this.ServerSeedLabel.AutoSize = true;
            this.ServerSeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ServerSeedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ServerSeedLabel.Location = new System.Drawing.Point(6, 89);
            this.ServerSeedLabel.Name = "ServerSeedLabel";
            this.ServerSeedLabel.Size = new System.Drawing.Size(158, 15);
            this.ServerSeedLabel.TabIndex = 0;
            this.ServerSeedLabel.Text = "Server Seed (+server.seed):";
            // 
            // ServerSeedTextBox
            // 
            this.ServerSeedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ServerSeedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerSeedTextBox.Enabled = false;
            this.ServerSeedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ServerSeedTextBox.Location = new System.Drawing.Point(10, 105);
            this.ServerSeedTextBox.Name = "ServerSeedTextBox";
            this.ServerSeedTextBox.Size = new System.Drawing.Size(237, 20);
            this.ServerSeedTextBox.TabIndex = 6;
            this.ServerSeedTextBox.Text = "12345678";
            this.ServerSeedTextBox.TextChanged += new System.EventHandler(this.ServerSeedTextBox_TextChanged);
            // 
            // RandomServerSeedCheckBox
            // 
            this.RandomServerSeedCheckBox.AutoSize = true;
            this.RandomServerSeedCheckBox.Checked = true;
            this.RandomServerSeedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RandomServerSeedCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.RandomServerSeedCheckBox.Location = new System.Drawing.Point(250, 107);
            this.RandomServerSeedCheckBox.Name = "RandomServerSeedCheckBox";
            this.RandomServerSeedCheckBox.Size = new System.Drawing.Size(66, 17);
            this.RandomServerSeedCheckBox.TabIndex = 7;
            this.RandomServerSeedCheckBox.Text = "Random";
            this.RandomServerSeedCheckBox.UseVisualStyleBackColor = true;
            this.RandomServerSeedCheckBox.CheckedChanged += new System.EventHandler(this.RandomServerSeedCheckBox_CheckedChanged);
            // 
            // ChangesOnWipeLabel
            // 
            this.ChangesOnWipeLabel.AutoSize = true;
            this.ChangesOnWipeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangesOnWipeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ChangesOnWipeLabel.Location = new System.Drawing.Point(247, 121);
            this.ChangesOnWipeLabel.Name = "ChangesOnWipeLabel";
            this.ChangesOnWipeLabel.Size = new System.Drawing.Size(80, 12);
            this.ChangesOnWipeLabel.TabIndex = 0;
            this.ChangesOnWipeLabel.Text = "(changes on wipe)";
            // 
            // CurrentServerSeedLabel
            // 
            this.CurrentServerSeedLabel.AutoSize = true;
            this.CurrentServerSeedLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentServerSeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentServerSeedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CurrentServerSeedLabel.Location = new System.Drawing.Point(8, 125);
            this.CurrentServerSeedLabel.Name = "CurrentServerSeedLabel";
            this.CurrentServerSeedLabel.Size = new System.Drawing.Size(104, 12);
            this.CurrentServerSeedLabel.TabIndex = 0;
            this.CurrentServerSeedLabel.Text = "Current Seed: 12345678";
            this.CurrentServerSeedLabel.Click += new System.EventHandler(this.CurrentServerSeedLabel_Click);
            // 
            // AutoRestartOnCrashCheckBox
            // 
            this.AutoRestartOnCrashCheckBox.AutoSize = true;
            this.AutoRestartOnCrashCheckBox.Checked = true;
            this.AutoRestartOnCrashCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoRestartOnCrashCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.AutoRestartOnCrashCheckBox.Location = new System.Drawing.Point(23, 59);
            this.AutoRestartOnCrashCheckBox.Name = "AutoRestartOnCrashCheckBox";
            this.AutoRestartOnCrashCheckBox.Size = new System.Drawing.Size(130, 17);
            this.AutoRestartOnCrashCheckBox.TabIndex = 25;
            this.AutoRestartOnCrashCheckBox.Text = "Auto Restart on Crash";
            this.AutoRestartOnCrashCheckBox.UseVisualStyleBackColor = true;
            // 
            // BackupOnWipeCheckBox
            // 
            this.BackupOnWipeCheckBox.AutoSize = true;
            this.BackupOnWipeCheckBox.Checked = true;
            this.BackupOnWipeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BackupOnWipeCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BackupOnWipeCheckBox.Location = new System.Drawing.Point(23, 18);
            this.BackupOnWipeCheckBox.Name = "BackupOnWipeCheckBox";
            this.BackupOnWipeCheckBox.Size = new System.Drawing.Size(68, 17);
            this.BackupOnWipeCheckBox.TabIndex = 26;
            this.BackupOnWipeCheckBox.Text = "On Wipe";
            this.BackupOnWipeCheckBox.UseVisualStyleBackColor = true;
            // 
            // StopServerButton
            // 
            this.StopServerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(67)))), ((int)(((byte)(49)))));
            this.StopServerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(67)))), ((int)(((byte)(49)))));
            this.StopServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopServerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopServerButton.ForeColor = System.Drawing.Color.Black;
            this.StopServerButton.Location = new System.Drawing.Point(5, 5);
            this.StopServerButton.Name = "StopServerButton";
            this.StopServerButton.Size = new System.Drawing.Size(114, 44);
            this.StopServerButton.TabIndex = 30;
            this.StopServerButton.Text = "Stop Server";
            this.StopServerButton.UseVisualStyleBackColor = false;
            this.StopServerButton.Click += new System.EventHandler(this.StopServerButton_Click);
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.TitlebarPanel.Controls.Add(this.MinimizeButton);
            this.TitlebarPanel.Controls.Add(this.CloseButton);
            this.TitlebarPanel.Location = new System.Drawing.Point(-3, -3);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(750, 33);
            this.TitlebarPanel.TabIndex = 0;
            this.TitlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarPanel_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MinimizeButton.Location = new System.Drawing.Point(687, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 0;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CloseButton.Location = new System.Drawing.Point(717, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "x";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ServerSettingsPanel
            // 
            this.ServerSettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ServerSettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerSettingsPanel.Controls.Add(this.OpenServerPathButton);
            this.ServerSettingsPanel.Controls.Add(this.ServerArgumentsTextBox);
            this.ServerSettingsPanel.Controls.Add(this.ServerArgumentsLabel);
            this.ServerSettingsPanel.Controls.Add(this.ServerSeedTextBox);
            this.ServerSettingsPanel.Controls.Add(this.ForceInstallDirTextBox);
            this.ServerSettingsPanel.Controls.Add(this.ServerInstallDirectoryLabel);
            this.ServerSettingsPanel.Controls.Add(this.ServerIdentityTextBox);
            this.ServerSettingsPanel.Controls.Add(this.LocalServerIdentityLabel);
            this.ServerSettingsPanel.Controls.Add(this.CurrentServerSeedLabel);
            this.ServerSettingsPanel.Controls.Add(this.ForceInstallDirBrowseButton);
            this.ServerSettingsPanel.Controls.Add(this.ChangesOnWipeLabel);
            this.ServerSettingsPanel.Controls.Add(this.ServerSeedLabel);
            this.ServerSettingsPanel.Controls.Add(this.RandomServerSeedCheckBox);
            this.ServerSettingsPanel.Location = new System.Drawing.Point(5, 90);
            this.ServerSettingsPanel.Name = "ServerSettingsPanel";
            this.ServerSettingsPanel.Size = new System.Drawing.Size(331, 236);
            this.ServerSettingsPanel.TabIndex = 2;
            // 
            // OpenServerPathButton
            // 
            this.OpenServerPathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.OpenServerPathButton.BackgroundImage = global::RustServerManager.Properties.Resources.folder_open;
            this.OpenServerPathButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenServerPathButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.OpenServerPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenServerPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenServerPathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.OpenServerPathButton.Location = new System.Drawing.Point(302, 67);
            this.OpenServerPathButton.Name = "OpenServerPathButton";
            this.OpenServerPathButton.Size = new System.Drawing.Size(20, 20);
            this.OpenServerPathButton.TabIndex = 5;
            this.OpenServerPathButton.UseVisualStyleBackColor = false;
            this.OpenServerPathButton.Click += new System.EventHandler(this.OpenServerPathButton_Click);
            // 
            // ForceInstallDirBrowseButton
            // 
            this.ForceInstallDirBrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ForceInstallDirBrowseButton.BackgroundImage = global::RustServerManager.Properties.Resources.folder;
            this.ForceInstallDirBrowseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ForceInstallDirBrowseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ForceInstallDirBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForceInstallDirBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForceInstallDirBrowseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ForceInstallDirBrowseButton.Location = new System.Drawing.Point(302, 26);
            this.ForceInstallDirBrowseButton.Name = "ForceInstallDirBrowseButton";
            this.ForceInstallDirBrowseButton.Size = new System.Drawing.Size(20, 20);
            this.ForceInstallDirBrowseButton.TabIndex = 3;
            this.ForceInstallDirBrowseButton.UseVisualStyleBackColor = false;
            this.ForceInstallDirBrowseButton.Click += new System.EventHandler(this.ForceInstallDirBrowseButton_Click);
            // 
            // WipeBlueprintsPanel
            // 
            this.WipeBlueprintsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WipeBlueprintsPanel.Controls.Add(this.BlueprintsNeverRadioButton);
            this.WipeBlueprintsPanel.Controls.Add(this.WipeBlueprintsLabel);
            this.WipeBlueprintsPanel.Controls.Add(this.BlueprintsForcewipeRadioButton);
            this.WipeBlueprintsPanel.Controls.Add(this.BlueprintsEveryWipeRadioButton);
            this.WipeBlueprintsPanel.Location = new System.Drawing.Point(110, 57);
            this.WipeBlueprintsPanel.Name = "WipeBlueprintsPanel";
            this.WipeBlueprintsPanel.Size = new System.Drawing.Size(119, 74);
            this.WipeBlueprintsPanel.TabIndex = 17;
            // 
            // BlueprintsNeverRadioButton
            // 
            this.BlueprintsNeverRadioButton.AutoSize = true;
            this.BlueprintsNeverRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BlueprintsNeverRadioButton.Location = new System.Drawing.Point(5, 51);
            this.BlueprintsNeverRadioButton.Name = "BlueprintsNeverRadioButton";
            this.BlueprintsNeverRadioButton.Size = new System.Drawing.Size(54, 17);
            this.BlueprintsNeverRadioButton.TabIndex = 19;
            this.BlueprintsNeverRadioButton.Text = "Never";
            this.BlueprintsNeverRadioButton.UseVisualStyleBackColor = true;
            // 
            // WipeBlueprintsLabel
            // 
            this.WipeBlueprintsLabel.AutoSize = true;
            this.WipeBlueprintsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.WipeBlueprintsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.WipeBlueprintsLabel.Location = new System.Drawing.Point(3, 2);
            this.WipeBlueprintsLabel.Name = "WipeBlueprintsLabel";
            this.WipeBlueprintsLabel.Size = new System.Drawing.Size(96, 15);
            this.WipeBlueprintsLabel.TabIndex = 0;
            this.WipeBlueprintsLabel.Text = "Wipe Blueprints:";
            // 
            // BlueprintsForcewipeRadioButton
            // 
            this.BlueprintsForcewipeRadioButton.AutoSize = true;
            this.BlueprintsForcewipeRadioButton.Checked = true;
            this.BlueprintsForcewipeRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BlueprintsForcewipeRadioButton.Location = new System.Drawing.Point(5, 19);
            this.BlueprintsForcewipeRadioButton.Name = "BlueprintsForcewipeRadioButton";
            this.BlueprintsForcewipeRadioButton.Size = new System.Drawing.Size(74, 17);
            this.BlueprintsForcewipeRadioButton.TabIndex = 17;
            this.BlueprintsForcewipeRadioButton.TabStop = true;
            this.BlueprintsForcewipeRadioButton.Text = "Forcewipe";
            this.BlueprintsForcewipeRadioButton.UseVisualStyleBackColor = true;
            // 
            // BlueprintsEveryWipeRadioButton
            // 
            this.BlueprintsEveryWipeRadioButton.AutoSize = true;
            this.BlueprintsEveryWipeRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BlueprintsEveryWipeRadioButton.Location = new System.Drawing.Point(5, 35);
            this.BlueprintsEveryWipeRadioButton.Name = "BlueprintsEveryWipeRadioButton";
            this.BlueprintsEveryWipeRadioButton.Size = new System.Drawing.Size(80, 17);
            this.BlueprintsEveryWipeRadioButton.TabIndex = 18;
            this.BlueprintsEveryWipeRadioButton.Text = "Every Wipe";
            this.BlueprintsEveryWipeRadioButton.UseVisualStyleBackColor = true;
            // 
            // WipeIntervalPanel
            // 
            this.WipeIntervalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WipeIntervalPanel.Controls.Add(this.WipeIntervalBiWeeklyRadioButton);
            this.WipeIntervalPanel.Controls.Add(this.WipeIntervalWeeklyRadioButton);
            this.WipeIntervalPanel.Controls.Add(this.WipeIntervalMonthlyRadioButton);
            this.WipeIntervalPanel.Controls.Add(this.WipeIntervalLabel);
            this.WipeIntervalPanel.Location = new System.Drawing.Point(22, 57);
            this.WipeIntervalPanel.Name = "WipeIntervalPanel";
            this.WipeIntervalPanel.Size = new System.Drawing.Size(84, 74);
            this.WipeIntervalPanel.TabIndex = 14;
            // 
            // WipeIntervalLabel
            // 
            this.WipeIntervalLabel.AutoSize = true;
            this.WipeIntervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.WipeIntervalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.WipeIntervalLabel.Location = new System.Drawing.Point(3, 2);
            this.WipeIntervalLabel.Name = "WipeIntervalLabel";
            this.WipeIntervalLabel.Size = new System.Drawing.Size(80, 15);
            this.WipeIntervalLabel.TabIndex = 0;
            this.WipeIntervalLabel.Text = "Wipe Interval:";
            // 
            // WipeDayLabel
            // 
            this.WipeDayLabel.AutoSize = true;
            this.WipeDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WipeDayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.WipeDayLabel.Location = new System.Drawing.Point(21, 19);
            this.WipeDayLabel.Name = "WipeDayLabel";
            this.WipeDayLabel.Size = new System.Drawing.Size(65, 15);
            this.WipeDayLabel.TabIndex = 0;
            this.WipeDayLabel.Text = "Thursday";
            // 
            // BackupSettingsLabel
            // 
            this.BackupSettingsLabel.AutoSize = true;
            this.BackupSettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BackupSettingsLabel.Location = new System.Drawing.Point(3, 3);
            this.BackupSettingsLabel.Name = "BackupSettingsLabel";
            this.BackupSettingsLabel.Size = new System.Drawing.Size(88, 13);
            this.BackupSettingsLabel.TabIndex = 0;
            this.BackupSettingsLabel.Text = "Backup Settings:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TitleLabel.Location = new System.Drawing.Point(59, 39);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(221, 25);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "RustServerManager";
            // 
            // TitleVersionLabel
            // 
            this.TitleVersionLabel.AutoSize = true;
            this.TitleVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleVersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TitleVersionLabel.Location = new System.Drawing.Point(62, 59);
            this.TitleVersionLabel.Name = "TitleVersionLabel";
            this.TitleVersionLabel.Size = new System.Drawing.Size(47, 18);
            this.TitleVersionLabel.TabIndex = 0;
            this.TitleVersionLabel.Text = "v0.0.0";
            // 
            // StartServerPanel
            // 
            this.StartServerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.StartServerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartServerPanel.Controls.Add(this.StartServerButton);
            this.StartServerPanel.Location = new System.Drawing.Point(338, 253);
            this.StartServerPanel.Name = "StartServerPanel";
            this.StartServerPanel.Size = new System.Drawing.Size(148, 56);
            this.StartServerPanel.TabIndex = 29;
            // 
            // RestartServerButton
            // 
            this.RestartServerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(125)))), ((int)(((byte)(49)))));
            this.RestartServerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(125)))), ((int)(((byte)(49)))));
            this.RestartServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartServerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartServerButton.ForeColor = System.Drawing.Color.Black;
            this.RestartServerButton.Location = new System.Drawing.Point(121, 5);
            this.RestartServerButton.Name = "RestartServerButton";
            this.RestartServerButton.Size = new System.Drawing.Size(123, 44);
            this.RestartServerButton.TabIndex = 31;
            this.RestartServerButton.Text = "Restart Server";
            this.RestartServerButton.UseVisualStyleBackColor = false;
            this.RestartServerButton.Click += new System.EventHandler(this.RestartServerButton_Click);
            // 
            // StopServerPanel
            // 
            this.StopServerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.StopServerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StopServerPanel.Controls.Add(this.RestartServerButton);
            this.StopServerPanel.Controls.Add(this.StopServerButton);
            this.StopServerPanel.Location = new System.Drawing.Point(489, 253);
            this.StopServerPanel.Name = "StopServerPanel";
            this.StopServerPanel.Size = new System.Drawing.Size(250, 56);
            this.StopServerPanel.TabIndex = 30;
            // 
            // TitleIconPictureBox
            // 
            this.TitleIconPictureBox.Image = global::RustServerManager.Properties.Resources.icon;
            this.TitleIconPictureBox.Location = new System.Drawing.Point(6, 36);
            this.TitleIconPictureBox.Name = "TitleIconPictureBox";
            this.TitleIconPictureBox.Size = new System.Drawing.Size(52, 47);
            this.TitleIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitleIconPictureBox.TabIndex = 0;
            this.TitleIconPictureBox.TabStop = false;
            // 
            // AutoRestartAtTimeCheckBox
            // 
            this.AutoRestartAtTimeCheckBox.AutoSize = true;
            this.AutoRestartAtTimeCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.AutoRestartAtTimeCheckBox.Location = new System.Drawing.Point(23, 18);
            this.AutoRestartAtTimeCheckBox.Name = "AutoRestartAtTimeCheckBox";
            this.AutoRestartAtTimeCheckBox.Size = new System.Drawing.Size(126, 17);
            this.AutoRestartAtTimeCheckBox.TabIndex = 21;
            this.AutoRestartAtTimeCheckBox.Text = "Auto Restart Daily at:";
            this.AutoRestartAtTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoRestartHourTextBox
            // 
            this.AutoRestartHourTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.AutoRestartHourTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AutoRestartHourTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoRestartHourTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.AutoRestartHourTextBox.Location = new System.Drawing.Point(42, 36);
            this.AutoRestartHourTextBox.Name = "AutoRestartHourTextBox";
            this.AutoRestartHourTextBox.Size = new System.Drawing.Size(22, 21);
            this.AutoRestartHourTextBox.TabIndex = 22;
            this.AutoRestartHourTextBox.Text = "12";
            // 
            // AutoRestartMinuteTextBox
            // 
            this.AutoRestartMinuteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.AutoRestartMinuteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AutoRestartMinuteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoRestartMinuteTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.AutoRestartMinuteTextBox.Location = new System.Drawing.Point(76, 36);
            this.AutoRestartMinuteTextBox.Name = "AutoRestartMinuteTextBox";
            this.AutoRestartMinuteTextBox.Size = new System.Drawing.Size(29, 21);
            this.AutoRestartMinuteTextBox.TabIndex = 23;
            this.AutoRestartMinuteTextBox.Text = "00";
            // 
            // AutoRestartTimeIdentifierComboBox
            // 
            this.AutoRestartTimeIdentifierComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.AutoRestartTimeIdentifierComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoRestartTimeIdentifierComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoRestartTimeIdentifierComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.AutoRestartTimeIdentifierComboBox.FormattingEnabled = true;
            this.AutoRestartTimeIdentifierComboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.AutoRestartTimeIdentifierComboBox.Location = new System.Drawing.Point(107, 36);
            this.AutoRestartTimeIdentifierComboBox.Name = "AutoRestartTimeIdentifierComboBox";
            this.AutoRestartTimeIdentifierComboBox.Size = new System.Drawing.Size(40, 21);
            this.AutoRestartTimeIdentifierComboBox.TabIndex = 24;
            this.AutoRestartTimeIdentifierComboBox.Text = "AM";
            // 
            // AutoRestartTimeSeparatorLabel
            // 
            this.AutoRestartTimeSeparatorLabel.AutoSize = true;
            this.AutoRestartTimeSeparatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoRestartTimeSeparatorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.AutoRestartTimeSeparatorLabel.Location = new System.Drawing.Point(64, 38);
            this.AutoRestartTimeSeparatorLabel.Name = "AutoRestartTimeSeparatorLabel";
            this.AutoRestartTimeSeparatorLabel.Size = new System.Drawing.Size(11, 16);
            this.AutoRestartTimeSeparatorLabel.TabIndex = 0;
            this.AutoRestartTimeSeparatorLabel.Text = ":";
            // 
            // RestartSettingsLabel
            // 
            this.RestartSettingsLabel.AutoSize = true;
            this.RestartSettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.RestartSettingsLabel.Location = new System.Drawing.Point(4, 3);
            this.RestartSettingsLabel.Name = "RestartSettingsLabel";
            this.RestartSettingsLabel.Size = new System.Drawing.Size(85, 13);
            this.RestartSettingsLabel.TabIndex = 0;
            this.RestartSettingsLabel.Text = "Restart Settings:";
            // 
            // ServerStatusLabel
            // 
            this.ServerStatusLabel.AutoSize = true;
            this.ServerStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ServerStatusLabel.Location = new System.Drawing.Point(1, 0);
            this.ServerStatusLabel.Name = "ServerStatusLabel";
            this.ServerStatusLabel.Size = new System.Drawing.Size(124, 13);
            this.ServerStatusLabel.TabIndex = 0;
            this.ServerStatusLabel.Text = "Checking server status...";
            // 
            // ServerStatusPanel
            // 
            this.ServerStatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ServerStatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerStatusPanel.Controls.Add(this.ServerStatusLabel);
            this.ServerStatusPanel.Location = new System.Drawing.Point(338, 310);
            this.ServerStatusPanel.Name = "ServerStatusPanel";
            this.ServerStatusPanel.Size = new System.Drawing.Size(401, 16);
            this.ServerStatusPanel.TabIndex = 0;
            // 
            // WipeSettingsPanel
            // 
            this.WipeSettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.WipeSettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WipeSettingsPanel.Controls.Add(this.WipeSettingsLabel);
            this.WipeSettingsPanel.Controls.Add(this.WipeDayTimeSeparatorLabel);
            this.WipeSettingsPanel.Controls.Add(this.WipeTimeIdentifierComboBox);
            this.WipeSettingsPanel.Controls.Add(this.WipeServerButton);
            this.WipeSettingsPanel.Controls.Add(this.StartFromSundayCheckBox);
            this.WipeSettingsPanel.Controls.Add(this.WipeMinuteTextBox);
            this.WipeSettingsPanel.Controls.Add(this.WipeHourTextBox);
            this.WipeSettingsPanel.Controls.Add(this.WipeDayLabel);
            this.WipeSettingsPanel.Controls.Add(this.WipeIntervalPanel);
            this.WipeSettingsPanel.Controls.Add(this.WipeBlueprintsPanel);
            this.WipeSettingsPanel.Location = new System.Drawing.Point(338, 90);
            this.WipeSettingsPanel.Name = "WipeSettingsPanel";
            this.WipeSettingsPanel.Size = new System.Drawing.Size(239, 160);
            this.WipeSettingsPanel.TabIndex = 9;
            // 
            // RestartSettingsPanel
            // 
            this.RestartSettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.RestartSettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RestartSettingsPanel.Controls.Add(this.RestartSettingsLabel);
            this.RestartSettingsPanel.Controls.Add(this.AutoRestartHourTextBox);
            this.RestartSettingsPanel.Controls.Add(this.AutoRestartAtTimeCheckBox);
            this.RestartSettingsPanel.Controls.Add(this.AutoRestartMinuteTextBox);
            this.RestartSettingsPanel.Controls.Add(this.AutoRestartTimeSeparatorLabel);
            this.RestartSettingsPanel.Controls.Add(this.AutoRestartTimeIdentifierComboBox);
            this.RestartSettingsPanel.Controls.Add(this.AutoRestartOnCrashCheckBox);
            this.RestartSettingsPanel.Location = new System.Drawing.Point(579, 90);
            this.RestartSettingsPanel.Name = "RestartSettingsPanel";
            this.RestartSettingsPanel.Size = new System.Drawing.Size(160, 82);
            this.RestartSettingsPanel.TabIndex = 21;
            // 
            // BackupSettingsPanel
            // 
            this.BackupSettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BackupSettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackupSettingsPanel.Controls.Add(this.BackupServerButton);
            this.BackupSettingsPanel.Controls.Add(this.BackupOnRestartCheckBox);
            this.BackupSettingsPanel.Controls.Add(this.BackupSettingsLabel);
            this.BackupSettingsPanel.Controls.Add(this.BackupOnWipeCheckBox);
            this.BackupSettingsPanel.Location = new System.Drawing.Point(579, 174);
            this.BackupSettingsPanel.Name = "BackupSettingsPanel";
            this.BackupSettingsPanel.Size = new System.Drawing.Size(160, 76);
            this.BackupSettingsPanel.TabIndex = 26;
            // 
            // BackupServerButton
            // 
            this.BackupServerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BackupServerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BackupServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackupServerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupServerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BackupServerButton.Location = new System.Drawing.Point(23, 49);
            this.BackupServerButton.Name = "BackupServerButton";
            this.BackupServerButton.Size = new System.Drawing.Size(69, 22);
            this.BackupServerButton.TabIndex = 28;
            this.BackupServerButton.Text = "Backup now";
            this.BackupServerButton.UseVisualStyleBackColor = false;
            this.BackupServerButton.Click += new System.EventHandler(this.BackupServerButton_Click);
            // 
            // BackupOnRestartCheckBox
            // 
            this.BackupOnRestartCheckBox.AutoSize = true;
            this.BackupOnRestartCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BackupOnRestartCheckBox.Location = new System.Drawing.Point(23, 33);
            this.BackupOnRestartCheckBox.Name = "BackupOnRestartCheckBox";
            this.BackupOnRestartCheckBox.Size = new System.Drawing.Size(102, 17);
            this.BackupOnRestartCheckBox.TabIndex = 27;
            this.BackupOnRestartCheckBox.Text = "On Auto Restart";
            this.BackupOnRestartCheckBox.UseVisualStyleBackColor = true;
            // 
            // DisplayConsoleCheckBox
            // 
            this.DisplayConsoleCheckBox.AutoSize = true;
            this.DisplayConsoleCheckBox.Checked = true;
            this.DisplayConsoleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplayConsoleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayConsoleCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.DisplayConsoleCheckBox.Location = new System.Drawing.Point(615, 67);
            this.DisplayConsoleCheckBox.Name = "DisplayConsoleCheckBox";
            this.DisplayConsoleCheckBox.Size = new System.Drawing.Size(90, 19);
            this.DisplayConsoleCheckBox.TabIndex = 32;
            this.DisplayConsoleCheckBox.Text = "Display Log";
            this.DisplayConsoleCheckBox.UseVisualStyleBackColor = true;
            this.DisplayConsoleCheckBox.CheckedChanged += new System.EventHandler(this.DisplayConsoleCheckBox_CheckedChanged);
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClearLogButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ClearLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearLogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLogButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClearLogButton.Location = new System.Drawing.Point(702, 65);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(37, 24);
            this.ClearLogButton.TabIndex = 33;
            this.ClearLogButton.Text = "Clear";
            this.ClearLogButton.UseVisualStyleBackColor = false;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(744, 331);
            this.Controls.Add(this.ClearLogButton);
            this.Controls.Add(this.DisplayConsoleCheckBox);
            this.Controls.Add(this.BackupSettingsPanel);
            this.Controls.Add(this.RestartSettingsPanel);
            this.Controls.Add(this.WipeSettingsPanel);
            this.Controls.Add(this.ServerStatusPanel);
            this.Controls.Add(this.StopServerPanel);
            this.Controls.Add(this.StartServerPanel);
            this.Controls.Add(this.TitleIconPictureBox);
            this.Controls.Add(this.TitleVersionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ServerSettingsPanel);
            this.Controls.Add(this.TitlebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "RustServerManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.TitlebarPanel.ResumeLayout(false);
            this.ServerSettingsPanel.ResumeLayout(false);
            this.ServerSettingsPanel.PerformLayout();
            this.WipeBlueprintsPanel.ResumeLayout(false);
            this.WipeBlueprintsPanel.PerformLayout();
            this.WipeIntervalPanel.ResumeLayout(false);
            this.WipeIntervalPanel.PerformLayout();
            this.StartServerPanel.ResumeLayout(false);
            this.StopServerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitleIconPictureBox)).EndInit();
            this.ServerStatusPanel.ResumeLayout(false);
            this.ServerStatusPanel.PerformLayout();
            this.WipeSettingsPanel.ResumeLayout(false);
            this.WipeSettingsPanel.PerformLayout();
            this.RestartSettingsPanel.ResumeLayout(false);
            this.RestartSettingsPanel.PerformLayout();
            this.BackupSettingsPanel.ResumeLayout(false);
            this.BackupSettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WipeServerButton;
        private System.Windows.Forms.Button StartServerButton;
        private System.Windows.Forms.RichTextBox ServerArgumentsTextBox;
        private System.Windows.Forms.Label ServerArgumentsLabel;
        private System.Windows.Forms.TextBox ForceInstallDirTextBox;
        private System.Windows.Forms.Label ServerInstallDirectoryLabel;
        private System.Windows.Forms.TextBox WipeHourTextBox;
        private System.Windows.Forms.TextBox WipeMinuteTextBox;
        private System.Windows.Forms.Label WipeSettingsLabel;
        private System.Windows.Forms.ComboBox WipeTimeIdentifierComboBox;
        private System.Windows.Forms.Label WipeDayTimeSeparatorLabel;
        private System.Windows.Forms.RadioButton WipeIntervalBiWeeklyRadioButton;
        private System.Windows.Forms.RadioButton WipeIntervalMonthlyRadioButton;
        private System.Windows.Forms.Label LocalServerIdentityLabel;
        private System.Windows.Forms.TextBox ServerIdentityTextBox;
        private System.Windows.Forms.CheckBox StartFromSundayCheckBox;
        private System.Windows.Forms.RadioButton WipeIntervalWeeklyRadioButton;
        private System.Windows.Forms.Button ForceInstallDirBrowseButton;
        private System.Windows.Forms.Label ServerSeedLabel;
        private System.Windows.Forms.TextBox ServerSeedTextBox;
        private System.Windows.Forms.CheckBox RandomServerSeedCheckBox;
        private System.Windows.Forms.Label ChangesOnWipeLabel;
        private System.Windows.Forms.Label CurrentServerSeedLabel;
        private System.Windows.Forms.CheckBox AutoRestartOnCrashCheckBox;
        private System.Windows.Forms.CheckBox BackupOnWipeCheckBox;
        private System.Windows.Forms.Button StopServerButton;
        private System.Windows.Forms.Panel TitlebarPanel;
        private System.Windows.Forms.Panel ServerSettingsPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TitleVersionLabel;
        private System.Windows.Forms.PictureBox TitleIconPictureBox;
        private System.Windows.Forms.Panel StartServerPanel;
        private System.Windows.Forms.Button RestartServerButton;
        private System.Windows.Forms.Panel StopServerPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label BackupSettingsLabel;
        private System.Windows.Forms.Button OpenServerPathButton;
        private System.Windows.Forms.Label WipeIntervalLabel;
        private System.Windows.Forms.Label WipeDayLabel;
        private System.Windows.Forms.Label WipeBlueprintsLabel;
        private System.Windows.Forms.RadioButton BlueprintsEveryWipeRadioButton;
        private System.Windows.Forms.RadioButton BlueprintsForcewipeRadioButton;
        private System.Windows.Forms.Panel WipeIntervalPanel;
        private System.Windows.Forms.Panel WipeBlueprintsPanel;
        private System.Windows.Forms.RadioButton BlueprintsNeverRadioButton;
        private System.Windows.Forms.CheckBox AutoRestartAtTimeCheckBox;
        private System.Windows.Forms.TextBox AutoRestartHourTextBox;
        private System.Windows.Forms.TextBox AutoRestartMinuteTextBox;
        private System.Windows.Forms.ComboBox AutoRestartTimeIdentifierComboBox;
        private System.Windows.Forms.Label AutoRestartTimeSeparatorLabel;
        private System.Windows.Forms.Label RestartSettingsLabel;
        private System.Windows.Forms.Label ServerStatusLabel;
        private System.Windows.Forms.Panel ServerStatusPanel;
        private System.Windows.Forms.Panel WipeSettingsPanel;
        private System.Windows.Forms.Panel RestartSettingsPanel;
        private System.Windows.Forms.Panel BackupSettingsPanel;
        private System.Windows.Forms.CheckBox BackupOnRestartCheckBox;
        private System.Windows.Forms.CheckBox DisplayConsoleCheckBox;
        private System.Windows.Forms.Button ClearLogButton;
        private System.Windows.Forms.Button BackupServerButton;
    }
}

