using System;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

using static RustServerManager.Data.Config.ConfigManager;
using static RustServerManager.Tools.FormTools;
using static RustServerManager.Tools.ProcessTools;
using static RustServerManager.Tools.ConsoleTools;
using static RustServerManager.Server.Wipe.WipeManager;
using static RustServerManager.Server.Wipe.WipeTimerManager;
using static RustServerManager.Server.Backup.BackupManager;
using static RustServerManager.Server.RustDedicated.RustDedicatedProcess;
using static RustServerManager.Resources.ResourceReader;

using static RustServerManager.Global;

namespace RustServerManager
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (File.Exists("RustServerManager\\RustServerManager.dat"))
            {
                Tools.LogTools.LogEvent("MAIN/INFO", "Config exists.", false, false, ConsoleColor.DarkGray);

                CONFIG = ReadConfig("RustServerManager\\RustServerManager.dat");

                ForceInstallDirTextBox.Text = CONFIG.STEAMCMD_FORCE_INSTALL_DIR;

                ServerIdentityTextBox.Text = CONFIG.SERVER_IDENTITY;
                ServerSeedTextBox.Text = CONFIG.SERVER_SEED.ToString();
                RandomServerSeedCheckBox.Checked = CONFIG.SERVER_SEED_RANDOM_ENABLE;
                ServerArgumentsTextBox.Text = CONFIG.SERVER_ARGUMENTS;

                WipeHourTextBox.Text = CONFIG.WIPE_TIME_HOUR.ToString();
                WipeMinuteTextBox.Text = CONFIG.WIPE_TIME_MINUTE.ToString();
                WipeTimeIdentifierComboBox.Text = CONFIG.WIPE_TIME_IDENTIFIER;

                StartFromSundayCheckBox.Checked = CONFIG.WIPE_TIME_START_FROM_SUNDAY;

                switch (CONFIG.WIPE_TIME_INTERVAL)
                {
                    case "WEEKLY":
                        WipeIntervalWeeklyRadioButton.Checked = true;
                        break;

                    case "BIWEEKLY":
                        WipeIntervalBiWeeklyRadioButton.Checked = true;
                        break;

                    case "MONTHLY":
                        WipeIntervalMonthlyRadioButton.Checked = true;
                        break;
                }

                switch (CONFIG.FORCEWIPE_INTERVAL)
                {
                    case "FORCEWIPE":
                        BlueprintsForcewipeRadioButton.Checked = true;
                        break;

                    case "EVERYWIPE":
                        BlueprintsEveryWipeRadioButton.Checked = true;
                        break;

                    case "NEVER":
                        BlueprintsNeverRadioButton.Checked = true;
                        break;
                }

                AutoRestartAtTimeCheckBox.Checked = CONFIG.AUTO_RESTART_ENABLE;
                AutoRestartHourTextBox.Text = CONFIG.AUTO_RESTART_TIME_HOUR.ToString();
                AutoRestartMinuteTextBox.Text = CONFIG.AUTO_RESTART_TIME_MINUTE.ToString();
                AutoRestartTimeIdentifierComboBox.Text = CONFIG.AUTO_RESTART_TIME_IDENTIFIER;

                AutoRestartOnCrashCheckBox.Checked = CONFIG.AUTO_RESTART_ON_CRASH_ENABLE;

                BackupOnWipeCheckBox.Checked = CONFIG.BACKUP_BEFORE_WIPE_ENABLE;
                BackupOnRestartCheckBox.Checked = CONFIG.BACKUP_ON_RESTART_ENABLE;

                DisplayConsoleCheckBox.Checked = CONFIG.DISPLAY_CONSOLE_ENABLE;
            }
            else
            {
                Tools.LogTools.LogEvent("MAIN/INFO", "No config exists, configuring default settings...", false, false, ConsoleColor.DarkGray);

                ServerArgumentsTextBox.Text = ReadEmbeddedResource("RustServerManager.Scripts.Resources.Content.DefaultServerArguments");

                CONFIG.WIPE_DATETIME_SHOULD_UPDATE = true;
            }

            InitiateWipeTimer();

            System.Timers.Timer dedicatedServerScanner = new System.Timers.Timer();
            dedicatedServerScanner.Elapsed += new ElapsedEventHandler(ScanDedicatedServer);
            dedicatedServerScanner.Interval = 1000;
            dedicatedServerScanner.Enabled = true;

            if (IsProcessRunning("RustDedicated"))
            {
                Tools.LogTools.LogEvent("MAIN/INFO", "RustDedicated is currently running, attempting to recover wipe timer...", false, false, ConsoleColor.Gray);
                EnableWipeTimer();
            }

            TitleVersionLabel.Text = VERSION;
        }

        private bool serverAllowedToAutoRestart = true;
        private bool serverIsRunning = false;
        private bool wipeTimerShouldDisable = false;
        private void ScanDedicatedServer(object source, ElapsedEventArgs e)
        {
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    string serverSeedString = CONFIG.SERVER_SEED.ToString();
                    if (ServerSeedTextBox.Text != serverSeedString && CONFIG.SERVER_SEED != 0)
                    {
                        ServerSeedTextBox.Text = serverSeedString;
                    }
                });
            }
            catch { }

            if (IsProcessRunning("RustDedicated") || IsProcessRunning("steamcmd"))
            {
                serverIsRunning = true;

                wipeTimerShouldDisable = true;

                ServerStatusLabel.Invoke((MethodInvoker)delegate
                {
                    ServerStatusLabel.Text = "The server is online!";
                    ServerStatusLabel.ForeColor = Color.FromArgb(255, 180, 220, 180);
                });
            }
            else
            {
                serverIsRunning = false;

                if (wipeTimerShouldDisable)
                {
                    DisableWipeTimer();
                    wipeTimerShouldDisable = false;
                }

                ServerStatusLabel.Invoke((MethodInvoker)delegate
                {
                    ServerStatusLabel.Text = "The server is offline.";
                    ServerStatusLabel.ForeColor = Color.FromArgb(255, 180, 180, 180);
                });
            }

            if (AutoRestartOnCrashCheckBox.Checked && SERVER_ALLOWED_TO_AUTO_CRASH_RESTART && !serverIsRunning)
            {
                Tools.LogTools.LogEvent("MAIN/WARN", "Attempting to restart server from close...", false, false, ConsoleColor.Yellow);
                StartRustDedicated();
            }

            DateTime currentTime = DateTime.Now;
            DateTime compareTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day);

            int hour = 0;
            int minute = 0;

            Invoke((MethodInvoker)delegate
            {
                int.TryParse(AutoRestartHourTextBox.Text, out hour);
                int.TryParse(AutoRestartMinuteTextBox.Text, out minute);

                compareTime = compareTime.AddHours(hour % 12 + (AutoRestartTimeIdentifierComboBox.Text == "PM" ? 12 : 0)).AddMinutes(minute);
            });

            if (currentTime.Hour == compareTime.Hour && currentTime.Minute == compareTime.Minute)
            {
                if (AutoRestartAtTimeCheckBox.Checked && serverAllowedToAutoRestart)
                {
                    serverAllowedToAutoRestart = false;
                    RestartServer();
                }
            }
            else
            {
                serverAllowedToAutoRestart = true;
            }
        }

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            if (IsProcessRunning("RustDedicated") || IsProcessRunning("steamcmd"))
            {
                MessageBox.Show("A Rust dedicated server is already running!");
                return;
            }

            SERVER_ALLOWED_TO_AUTO_CRASH_RESTART = false;

            UpdateConfig();
            StartRustDedicated();
        }

        private void StopServerButton_Click(object sender, EventArgs e)
        {
            if (!IsProcessRunning("RustDedicated") && !IsProcessRunning("steamcmd"))
            {
                return;
            }

            StopRustDedicated(false);
        }

        private void RestartServerButton_Click(object sender, EventArgs e)
        {
            RestartServer();
        }

        private void RestartServer()
        {
            if (!IsProcessRunning("RustDedicated") && !IsProcessRunning("steamcmd"))
            {
                return;
            }

            Tools.LogTools.LogEvent("MAIN/INFO", "Attemping to restart RustDedicated...", false, false, ConsoleColor.Gray);
            
            SERVER_ALLOWED_TO_AUTO_CRASH_RESTART = false;

            if (AutoRestartOnCrashCheckBox.Checked)
            {
                StopRustDedicated(false);
                InvokeAutoRestartBackup();
                SERVER_ALLOWED_TO_AUTO_CRASH_RESTART = true;
            }
            else
            {
                StopRustDedicated(true);
                InvokeAutoRestartBackup();
                StartRustDedicated();
            }
        }

        private void InvokeAutoRestartBackup()
        {
            bool check = false;
            BackupOnRestartCheckBox.Invoke((MethodInvoker)delegate
            {
                if (BackupOnRestartCheckBox.Checked)
                    check = true;
            });

            if (check)
                BackupServer();
        }

        private void WipeServerButton_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("Are you sure you want to wipe the server now?\nIt will shutdown and you will need to restart it manually.", "", MessageBoxButtons.YesNo);

            if (prompt == DialogResult.No)
            {
                return;
            }

            UpdateConfig();
            InitiateServerWipe(BlueprintsEveryWipeRadioButton.Checked);
        }

        private void BackupServerButton_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("Are you sure you want to backup the server now?\nIt will shutdown and you will need to restart it manually.", "", MessageBoxButtons.YesNo);

            if (prompt == DialogResult.No)
            {
                return;
            }

            Tools.LogTools.LogEvent("MAIN/INFO", "Initiating server backup...", false, false, ConsoleColor.Gray);

            UpdateConfig();
            StopRustDedicated(true);
            BackupServer();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tools.LogTools.LogEvent("MAIN/INFO", "Preparing for shutdown...", false, false, ConsoleColor.Gray);

            if (IsProcessRunning("RustDedicated") || IsProcessRunning("steamcmd"))
            {
                DialogResult prompt = MessageBox.Show("A Rust dedicated server is currently running.\nIt is recommended that you stop it before closing RustServerManager.\n\nAre you sure you want to continue?", "", MessageBoxButtons.YesNo);

                if (prompt == DialogResult.No)
                {
                    Tools.LogTools.LogEvent("MAIN/INFO", "RustDedicated is running, aborting shutdown...", false, false, ConsoleColor.Gray);
                    e.Cancel = true;
                    return;
                }
            }

            UpdateConfig();

            WriteConfig(CONFIG, "RustServerManager\\RustServerManager.dat");
            Tools.LogTools.LogEvent("MAIN/INFO", "Shutting down...", false, false, ConsoleColor.Gray);
        }

        private void UpdateConfig()
        {
            Tools.LogTools.LogEvent("MAIN/INFO", "Updating config...", false, false, ConsoleColor.Gray);

            CONFIG.STEAMCMD_FORCE_INSTALL_DIR = ForceInstallDirTextBox.Text;

            CONFIG.SERVER_IDENTITY = ServerIdentityTextBox.Text;
            int.TryParse(ServerSeedTextBox.Text, out CONFIG.SERVER_SEED);
            CONFIG.SERVER_SEED_RANDOM_ENABLE = RandomServerSeedCheckBox.Checked;
            CONFIG.SERVER_ARGUMENTS = ServerArgumentsTextBox.Text;

            int.TryParse(WipeHourTextBox.Text, out CONFIG.WIPE_TIME_HOUR);
            int.TryParse(WipeMinuteTextBox.Text, out CONFIG.WIPE_TIME_MINUTE);
            CONFIG.WIPE_TIME_IDENTIFIER = WipeTimeIdentifierComboBox.Text;

            CONFIG.WIPE_TIME_START_FROM_SUNDAY = StartFromSundayCheckBox.Checked;

            if (WipeIntervalWeeklyRadioButton.Checked)
            {
                CONFIG.WIPE_TIME_INTERVAL = "WEEKLY";
            }
            else if (WipeIntervalBiWeeklyRadioButton.Checked)
            {
                CONFIG.WIPE_TIME_INTERVAL = "BIWEEKLY";
            }
            else if (WipeIntervalMonthlyRadioButton.Checked)
            {
                CONFIG.WIPE_TIME_INTERVAL = "MONTHLY";
            }

            if (BlueprintsForcewipeRadioButton.Checked)
            {
                CONFIG.FORCEWIPE_INTERVAL = "FORCEWIPE";
            }
            else if (BlueprintsEveryWipeRadioButton.Checked)
            {
                CONFIG.FORCEWIPE_INTERVAL = "EVERYWIPE";
            }
            else if (BlueprintsNeverRadioButton.Checked)
            {
                CONFIG.FORCEWIPE_INTERVAL = "NEVER";
            }

            CONFIG.AUTO_RESTART_ENABLE = AutoRestartAtTimeCheckBox.Checked;
            int.TryParse(AutoRestartHourTextBox.Text, out CONFIG.AUTO_RESTART_TIME_HOUR);
            int.TryParse(AutoRestartMinuteTextBox.Text, out CONFIG.AUTO_RESTART_TIME_MINUTE);
            CONFIG.AUTO_RESTART_TIME_IDENTIFIER = AutoRestartTimeIdentifierComboBox.Text;

            CONFIG.AUTO_RESTART_ON_CRASH_ENABLE = AutoRestartOnCrashCheckBox.Checked;

            CONFIG.BACKUP_BEFORE_WIPE_ENABLE = BackupOnWipeCheckBox.Checked;
            CONFIG.BACKUP_ON_RESTART_ENABLE = BackupOnRestartCheckBox.Checked;

            CONFIG.DISPLAY_CONSOLE_ENABLE = DisplayConsoleCheckBox.Checked;
        }

        private void ForceInstallDirBrowseButton_Click(object sender, EventArgs e)
        {
            ForceInstallDirTextBox.Text = OpenFolderBrowserDialog();
        }

        private void OpenServerPathButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", ForceInstallDirTextBox.Text + "\\server\\" + ServerIdentityTextBox.Text);
        }

        private void ServerSeedTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentServerSeedLabel.Text = "Current Seed: " + ServerSeedTextBox.Text;
        }

        private void RandomServerSeedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ServerSeedTextBox.Enabled = !RandomServerSeedCheckBox.Checked;

            if (RandomServerSeedCheckBox.Checked)
            {
                int seed = GenerateRandomSeed();
                CONFIG.SERVER_SEED = seed;
                ServerSeedTextBox.Text = seed.ToString();
            }
        }

        private void CurrentServerSeedLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ServerSeedTextBox.Text);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TitlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }

        private void DisplayConsoleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DisplayConsoleCheckBox.Checked)
            {
                HideConsole();
            }
            else
            {
                ShowConsole();
            }
        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            Console.Clear();
            LOG_DATETIME = DateTime.Now;
            Tools.LogTools.LogEvent("MAIN/INFO", "RustServerManager Logging Session Started", true, true, ConsoleColor.DarkGray);
        }
    }
}