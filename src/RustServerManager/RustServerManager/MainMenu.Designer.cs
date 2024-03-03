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
            this.WipeDayLabel = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BlueprintsNeverRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.BlueprintsForcewipeRadioButton = new System.Windows.Forms.RadioButton();
            this.BlueprintsEveryWipeRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BackupOnRestartCheckBox = new System.Windows.Forms.CheckBox();
            this.DisplayConsoleCheckBox = new System.Windows.Forms.CheckBox();
            this.TitlebarPanel.SuspendLayout();
            this.ServerSettingsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.StartServerPanel.SuspendLayout();
            this.StopServerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleIconPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.WipeServerButton.Size = new System.Drawing.Size(103, 21);
            this.WipeServerButton.TabIndex = 0;
            this.WipeServerButton.Text = "Wipe Server Now";
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
            this.StartServerButton.TabIndex = 1;
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
            this.ServerArgumentsTextBox.TabIndex = 17;
            this.ServerArgumentsTextBox.Text = "+server.level \"Procedural Map\" +server.worldsize 4000";
            // 
            // ServerArgumentsLabel
            // 
            this.ServerArgumentsLabel.AutoSize = true;
            this.ServerArgumentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ServerArgumentsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ServerArgumentsLabel.Location = new System.Drawing.Point(7, 143);
            this.ServerArgumentsLabel.Name = "ServerArgumentsLabel";
            this.ServerArgumentsLabel.Size = new System.Drawing.Size(107, 15);
            this.ServerArgumentsLabel.TabIndex = 18;
            this.ServerArgumentsLabel.Text = "Server Arguments:";
            // 
            // ForceInstallDirTextBox
            // 
            this.ForceInstallDirTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ForceInstallDirTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ForceInstallDirTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ForceInstallDirTextBox.Location = new System.Drawing.Point(10, 26);
            this.ForceInstallDirTextBox.Name = "ForceInstallDirTextBox";
            this.ForceInstallDirTextBox.Size = new System.Drawing.Size(293, 20);
            this.ForceInstallDirTextBox.TabIndex = 19;
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
            this.ServerInstallDirectoryLabel.TabIndex = 20;
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
            this.WipeHourTextBox.TabIndex = 23;
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
            this.WipeMinuteTextBox.TabIndex = 24;
            this.WipeMinuteTextBox.Text = "00";
            // 
            // WipeDayLabel
            // 
            this.WipeDayLabel.AutoSize = true;
            this.WipeDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.WipeDayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.WipeDayLabel.Location = new System.Drawing.Point(1, 2);
            this.WipeDayLabel.Name = "WipeDayLabel";
            this.WipeDayLabel.Size = new System.Drawing.Size(85, 15);
            this.WipeDayLabel.TabIndex = 25;
            this.WipeDayLabel.Text = "Wipe Settings:";
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
            this.WipeTimeIdentifierComboBox.TabIndex = 28;
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
            this.WipeDayTimeSeparatorLabel.TabIndex = 29;
            this.WipeDayTimeSeparatorLabel.Text = ":";
            // 
            // WipeIntervalBiWeeklyRadioButton
            // 
            this.WipeIntervalBiWeeklyRadioButton.AutoSize = true;
            this.WipeIntervalBiWeeklyRadioButton.Checked = true;
            this.WipeIntervalBiWeeklyRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.WipeIntervalBiWeeklyRadioButton.Location = new System.Drawing.Point(4, 35);
            this.WipeIntervalBiWeeklyRadioButton.Name = "WipeIntervalBiWeeklyRadioButton";
            this.WipeIntervalBiWeeklyRadioButton.Size = new System.Drawing.Size(73, 17);
            this.WipeIntervalBiWeeklyRadioButton.TabIndex = 35;
            this.WipeIntervalBiWeeklyRadioButton.TabStop = true;
            this.WipeIntervalBiWeeklyRadioButton.Text = "Bi-Weekly";
            this.WipeIntervalBiWeeklyRadioButton.UseVisualStyleBackColor = true;
            // 
            // WipeIntervalMonthlyRadioButton
            // 
            this.WipeIntervalMonthlyRadioButton.AutoSize = true;
            this.WipeIntervalMonthlyRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.WipeIntervalMonthlyRadioButton.Location = new System.Drawing.Point(4, 51);
            this.WipeIntervalMonthlyRadioButton.Name = "WipeIntervalMonthlyRadioButton";
            this.WipeIntervalMonthlyRadioButton.Size = new System.Drawing.Size(62, 17);
            this.WipeIntervalMonthlyRadioButton.TabIndex = 36;
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
            this.LocalServerIdentityLabel.TabIndex = 38;
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
            this.ServerIdentityTextBox.TabIndex = 37;
            this.ServerIdentityTextBox.Text = "server";
            // 
            // StartFromSundayCheckBox
            // 
            this.StartFromSundayCheckBox.AutoSize = true;
            this.StartFromSundayCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.StartFromSundayCheckBox.Location = new System.Drawing.Point(24, 39);
            this.StartFromSundayCheckBox.Name = "StartFromSundayCheckBox";
            this.StartFromSundayCheckBox.Size = new System.Drawing.Size(133, 17);
            this.StartFromSundayCheckBox.TabIndex = 39;
            this.StartFromSundayCheckBox.Text = "Begin from Week Start";
            this.StartFromSundayCheckBox.UseVisualStyleBackColor = true;
            // 
            // WipeIntervalWeeklyRadioButton
            // 
            this.WipeIntervalWeeklyRadioButton.AutoSize = true;
            this.WipeIntervalWeeklyRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.WipeIntervalWeeklyRadioButton.Location = new System.Drawing.Point(4, 19);
            this.WipeIntervalWeeklyRadioButton.Name = "WipeIntervalWeeklyRadioButton";
            this.WipeIntervalWeeklyRadioButton.Size = new System.Drawing.Size(61, 17);
            this.WipeIntervalWeeklyRadioButton.TabIndex = 34;
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
            this.ServerSeedLabel.TabIndex = 42;
            this.ServerSeedLabel.Text = "Server Seed (+server.seed):";
            // 
            // ServerSeedTextBox
            // 
            this.ServerSeedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ServerSeedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerSeedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ServerSeedTextBox.Location = new System.Drawing.Point(10, 105);
            this.ServerSeedTextBox.Name = "ServerSeedTextBox";
            this.ServerSeedTextBox.Size = new System.Drawing.Size(237, 20);
            this.ServerSeedTextBox.TabIndex = 41;
            this.ServerSeedTextBox.Text = "12345678";
            this.ServerSeedTextBox.TextChanged += new System.EventHandler(this.ServerSeedTextBox_TextChanged);
            // 
            // RandomServerSeedCheckBox
            // 
            this.RandomServerSeedCheckBox.AutoSize = true;
            this.RandomServerSeedCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.RandomServerSeedCheckBox.Location = new System.Drawing.Point(250, 107);
            this.RandomServerSeedCheckBox.Name = "RandomServerSeedCheckBox";
            this.RandomServerSeedCheckBox.Size = new System.Drawing.Size(66, 17);
            this.RandomServerSeedCheckBox.TabIndex = 43;
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
            this.ChangesOnWipeLabel.TabIndex = 44;
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
            this.CurrentServerSeedLabel.TabIndex = 45;
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
            this.AutoRestartOnCrashCheckBox.TabIndex = 46;
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
            this.BackupOnWipeCheckBox.TabIndex = 47;
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
            this.StopServerButton.TabIndex = 48;
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
            this.TitlebarPanel.TabIndex = 49;
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
            this.MinimizeButton.TabIndex = 1;
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
            this.CloseButton.TabIndex = 0;
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
            this.ServerSettingsPanel.TabIndex = 50;
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
            this.OpenServerPathButton.TabIndex = 46;
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
            this.ForceInstallDirBrowseButton.TabIndex = 40;
            this.ForceInstallDirBrowseButton.UseVisualStyleBackColor = false;
            this.ForceInstallDirBrowseButton.Click += new System.EventHandler(this.ForceInstallDirBrowseButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BlueprintsNeverRadioButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BlueprintsForcewipeRadioButton);
            this.panel2.Controls.Add(this.BlueprintsEveryWipeRadioButton);
            this.panel2.Location = new System.Drawing.Point(110, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 74);
            this.panel2.TabIndex = 59;
            // 
            // BlueprintsNeverRadioButton
            // 
            this.BlueprintsNeverRadioButton.AutoSize = true;
            this.BlueprintsNeverRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BlueprintsNeverRadioButton.Location = new System.Drawing.Point(5, 51);
            this.BlueprintsNeverRadioButton.Name = "BlueprintsNeverRadioButton";
            this.BlueprintsNeverRadioButton.Size = new System.Drawing.Size(54, 17);
            this.BlueprintsNeverRadioButton.TabIndex = 58;
            this.BlueprintsNeverRadioButton.Text = "Never";
            this.BlueprintsNeverRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 55;
            this.label4.Text = "Wipe Blueprints:";
            // 
            // BlueprintsForcewipeRadioButton
            // 
            this.BlueprintsForcewipeRadioButton.AutoSize = true;
            this.BlueprintsForcewipeRadioButton.Checked = true;
            this.BlueprintsForcewipeRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BlueprintsForcewipeRadioButton.Location = new System.Drawing.Point(5, 19);
            this.BlueprintsForcewipeRadioButton.Name = "BlueprintsForcewipeRadioButton";
            this.BlueprintsForcewipeRadioButton.Size = new System.Drawing.Size(74, 17);
            this.BlueprintsForcewipeRadioButton.TabIndex = 56;
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
            this.BlueprintsEveryWipeRadioButton.TabIndex = 57;
            this.BlueprintsEveryWipeRadioButton.Text = "Every Wipe";
            this.BlueprintsEveryWipeRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.WipeIntervalBiWeeklyRadioButton);
            this.panel1.Controls.Add(this.WipeIntervalWeeklyRadioButton);
            this.panel1.Controls.Add(this.WipeIntervalMonthlyRadioButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 74);
            this.panel1.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Wipe Interval:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(21, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "Thursday";
            // 
            // BackupSettingsLabel
            // 
            this.BackupSettingsLabel.AutoSize = true;
            this.BackupSettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BackupSettingsLabel.Location = new System.Drawing.Point(3, 3);
            this.BackupSettingsLabel.Name = "BackupSettingsLabel";
            this.BackupSettingsLabel.Size = new System.Drawing.Size(88, 13);
            this.BackupSettingsLabel.TabIndex = 48;
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
            this.TitleLabel.TabIndex = 53;
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
            this.TitleVersionLabel.TabIndex = 54;
            this.TitleVersionLabel.Text = "v1.0.0";
            // 
            // StartServerPanel
            // 
            this.StartServerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(34)))));
            this.StartServerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartServerPanel.Controls.Add(this.StartServerButton);
            this.StartServerPanel.Location = new System.Drawing.Point(338, 253);
            this.StartServerPanel.Name = "StartServerPanel";
            this.StartServerPanel.Size = new System.Drawing.Size(148, 56);
            this.StartServerPanel.TabIndex = 53;
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
            this.RestartServerButton.TabIndex = 49;
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
            this.StopServerPanel.TabIndex = 54;
            // 
            // TitleIconPictureBox
            // 
            this.TitleIconPictureBox.Image = global::RustServerManager.Properties.Resources.icon;
            this.TitleIconPictureBox.Location = new System.Drawing.Point(6, 36);
            this.TitleIconPictureBox.Name = "TitleIconPictureBox";
            this.TitleIconPictureBox.Size = new System.Drawing.Size(52, 47);
            this.TitleIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitleIconPictureBox.TabIndex = 55;
            this.TitleIconPictureBox.TabStop = false;
            // 
            // AutoRestartAtTimeCheckBox
            // 
            this.AutoRestartAtTimeCheckBox.AutoSize = true;
            this.AutoRestartAtTimeCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.AutoRestartAtTimeCheckBox.Location = new System.Drawing.Point(23, 18);
            this.AutoRestartAtTimeCheckBox.Name = "AutoRestartAtTimeCheckBox";
            this.AutoRestartAtTimeCheckBox.Size = new System.Drawing.Size(126, 17);
            this.AutoRestartAtTimeCheckBox.TabIndex = 60;
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
            this.AutoRestartHourTextBox.TabIndex = 61;
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
            this.AutoRestartMinuteTextBox.TabIndex = 62;
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
            this.AutoRestartTimeIdentifierComboBox.TabIndex = 63;
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
            this.AutoRestartTimeSeparatorLabel.TabIndex = 64;
            this.AutoRestartTimeSeparatorLabel.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(4, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Restart Settings:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label6.Location = new System.Drawing.Point(1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Server is not running...";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(338, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 16);
            this.panel3.TabIndex = 56;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.WipeDayLabel);
            this.panel4.Controls.Add(this.WipeDayTimeSeparatorLabel);
            this.panel4.Controls.Add(this.WipeTimeIdentifierComboBox);
            this.panel4.Controls.Add(this.WipeServerButton);
            this.panel4.Controls.Add(this.StartFromSundayCheckBox);
            this.panel4.Controls.Add(this.WipeMinuteTextBox);
            this.panel4.Controls.Add(this.WipeHourTextBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(338, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 160);
            this.panel4.TabIndex = 66;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.AutoRestartHourTextBox);
            this.panel5.Controls.Add(this.AutoRestartAtTimeCheckBox);
            this.panel5.Controls.Add(this.AutoRestartMinuteTextBox);
            this.panel5.Controls.Add(this.AutoRestartTimeSeparatorLabel);
            this.panel5.Controls.Add(this.AutoRestartTimeIdentifierComboBox);
            this.panel5.Controls.Add(this.AutoRestartOnCrashCheckBox);
            this.panel5.Location = new System.Drawing.Point(579, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 84);
            this.panel5.TabIndex = 67;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.BackupOnRestartCheckBox);
            this.panel6.Controls.Add(this.BackupSettingsLabel);
            this.panel6.Controls.Add(this.BackupOnWipeCheckBox);
            this.panel6.Location = new System.Drawing.Point(579, 176);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(160, 74);
            this.panel6.TabIndex = 68;
            // 
            // BackupOnRestartCheckBox
            // 
            this.BackupOnRestartCheckBox.AutoSize = true;
            this.BackupOnRestartCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BackupOnRestartCheckBox.Location = new System.Drawing.Point(23, 36);
            this.BackupOnRestartCheckBox.Name = "BackupOnRestartCheckBox";
            this.BackupOnRestartCheckBox.Size = new System.Drawing.Size(102, 17);
            this.BackupOnRestartCheckBox.TabIndex = 49;
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
            this.DisplayConsoleCheckBox.Location = new System.Drawing.Point(632, 71);
            this.DisplayConsoleCheckBox.Name = "DisplayConsoleCheckBox";
            this.DisplayConsoleCheckBox.Size = new System.Drawing.Size(114, 19);
            this.DisplayConsoleCheckBox.TabIndex = 69;
            this.DisplayConsoleCheckBox.Text = "Display Console";
            this.DisplayConsoleCheckBox.UseVisualStyleBackColor = true;
            this.DisplayConsoleCheckBox.CheckedChanged += new System.EventHandler(this.DisplayConsoleCheckBox_CheckedChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(744, 331);
            this.Controls.Add(this.DisplayConsoleCheckBox);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.StartServerPanel.ResumeLayout(false);
            this.StopServerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitleIconPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private System.Windows.Forms.Label WipeDayLabel;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton BlueprintsEveryWipeRadioButton;
        private System.Windows.Forms.RadioButton BlueprintsForcewipeRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton BlueprintsNeverRadioButton;
        private System.Windows.Forms.CheckBox AutoRestartAtTimeCheckBox;
        private System.Windows.Forms.TextBox AutoRestartHourTextBox;
        private System.Windows.Forms.TextBox AutoRestartMinuteTextBox;
        private System.Windows.Forms.ComboBox AutoRestartTimeIdentifierComboBox;
        private System.Windows.Forms.Label AutoRestartTimeSeparatorLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox BackupOnRestartCheckBox;
        private System.Windows.Forms.CheckBox DisplayConsoleCheckBox;
    }
}

