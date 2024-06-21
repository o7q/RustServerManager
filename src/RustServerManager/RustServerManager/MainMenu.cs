using System;
using System.IO;
using System.Linq;
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

                ServerSeedTextBox.Text = GenerateRandomSeed().ToString();

                ServerArgumentsTextBox.Text = ReadEmbeddedResource("RustServerManager.Scripts.Resources.Content.DefaultServerArguments");

                CONFIG.WIPE_DATETIME_SHOULD_UPDATE = true;
            }

            InitiateWipeTimer();

            // define the update event timer, this will run every second and is used for anything that needs to run every second
            System.Timers.Timer updateEventTimer = new System.Timers.Timer();
            updateEventTimer.Elapsed += new ElapsedEventHandler(ScanDedicatedServer);
            updateEventTimer.Interval = 1000;
            updateEventTimer.Enabled = true;

            if (IsProcessRunning("RustDedicated"))
            {
                Tools.LogTools.LogEvent("MAIN/INFO", "RustDedicated is currently running, attempting to recover wipe timer...", false, false, ConsoleColor.Gray);
                EnableWipeTimer();
            }

            TitleVersionLabel.Text = VERSION;
        }

        // will be true when server is running, checked and updated every second
        private static bool serverIsRunning = false;

        // tells the server manager to disable the unnecessary use of a wipe timer if the server is offline
        private static bool wipeTimerShouldDisable = false;
        // tells the server manager if it can auto restart, if even enabled by the user
        private static bool serverAllowedToAutoRestart = true;
        // prevents the status text from updating if false
        private static bool statusTextAllowedToUpdate = true;

        // this is used as a 3 second timer to prevent the user from starting the server manually after a crash IF auto restart on crash is ENABLED
        // this will prevent the server from accidently starting twice
        private static int serverDeadCounter = 0;

        private void ScanDedicatedServer(object source, ElapsedEventArgs e)
        {
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    // auto display server seed
                    string serverSeedString = CONFIG.SERVER_SEED.ToString();
                    if (ServerSeedTextBox.Text == "")
                    {
                        ServerSeedTextBox.Text = serverSeedString;
                    }

                    // auto display the wipe dates
                    if (CONFIG.WIPE_DATETIME != DateTime.MinValue)
                        WipeDateLabel.Text = "Wipe: " + CONFIG.WIPE_DATETIME.ToString();
                    else
                        WipeDateLabel.Text = "Wipe: (unset)";

                    if (CONFIG.FORCEWIPE_DATETIME != DateTime.MinValue)
                        ForcewipeDateLabel.Text = "Forcewipe: " + CONFIG.FORCEWIPE_DATETIME.ToString();
                    else
                        ForcewipeDateLabel.Text = "Forcewipe: (unset)";

                });
            }
            catch { }

            // openStatus 0 means steamcmd and RustDedicated are not running
            // openStatus 1 means either are running
            int openStatus = 0;

            if (IsProcessRunning("steamcmd"))
            {
                openStatus = 1;

                // set steamcmd status text
                if (statusTextAllowedToUpdate)
                {
                    ServerStatusLabel.Invoke((MethodInvoker)delegate
                    {
                        ServerStatusLabel.Text = "RustDedicated (" + CONFIG.SERVER_IDENTITY + ") is updating...";
                        ServerStatusLabel.ForeColor = Color.FromArgb(255, 220, 220, 180);
                    });
                }
            }

            if (IsProcessRunning("RustDedicated"))
            {
                openStatus = 1;

                // set server running status text
                if (statusTextAllowedToUpdate)
                {
                    ServerStatusLabel.Invoke((MethodInvoker)delegate
                    {
                        ServerStatusLabel.Text = "RustDedicated (" + CONFIG.SERVER_IDENTITY + ") is running!";
                        ServerStatusLabel.ForeColor = Color.FromArgb(255, 180, 220, 180);
                    });
                }
            }

            if (openStatus == 1)
            {
                serverIsRunning = true;
                wipeTimerShouldDisable = true;
            }
            else
            {
                serverIsRunning = false;

                if (wipeTimerShouldDisable)
                {
                    DisableWipeTimer();
                    wipeTimerShouldDisable = false;
                }

                statusTextAllowedToUpdate = true;

                if (serverDeadCounter == 0)
                {
                    ServerStatusLabel.Invoke((MethodInvoker)delegate
                    {
                        ServerStatusLabel.Text = "RustDedicated is offline.";
                        ServerStatusLabel.ForeColor = Color.FromArgb(255, 180, 180, 180);
                    });
                }

                // decrease serverDeadCounter until it reaches 0
                if (serverDeadCounter > 0)
                    serverDeadCounter--;
            }

            // check if the server should auto restart
            DateTime currentTime = DateTime.Now;
            DateTime compareTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day);

            Invoke((MethodInvoker)delegate
            {
                int hour, minute;

                int.TryParse(AutoRestartHourTextBox.Text, out hour);
                int.TryParse(AutoRestartMinuteTextBox.Text, out minute);

                // add the amount of time to match the auto restart time
                compareTime = compareTime.AddHours(hour % 12 + (AutoRestartTimeIdentifierComboBox.Text == "PM" ? 12 : 0)).AddMinutes(minute);
            });

            // compare hours & minutes
            if (currentTime.Hour == compareTime.Hour && currentTime.Minute == compareTime.Minute)
            {
                // if auto restarts are enabled, and the server is allowed to auto restart, restart the server
                if (AutoRestartAtTimeCheckBox.Checked && serverAllowedToAutoRestart)
                {
                    // disallow the server restart, to prevent double restarts
                    serverAllowedToAutoRestart = false;
                    RestartServer();
                }
            }
            else
            {
                // keep enabled if the times do not match
                serverAllowedToAutoRestart = true;
            }
            //

            // auto restart server from crash if the user enablerd it, if the rest of the program allows it, and if the server is not currently running
            if (AutoRestartOnCrashCheckBox.Checked && SERVER_ALLOWED_TO_AUTO_CRASH_RESTART && !serverIsRunning)
            {
                SERVER_ALLOWED_TO_AUTO_CRASH_RESTART = false;

                Tools.LogTools.LogEvent("MAIN/WARN", "Attempting to restart server from close...", false, false, ConsoleColor.Yellow);
                StartRustDedicated();

                serverDeadCounter = 3;
            }
        }

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            if (IsProcessRunning("RustDedicated") || IsProcessRunning("steamcmd"))
            {
                return;
            }

            if (serverDeadCounter != 0)
            {
                ServerStatusLabel.Invoke((MethodInvoker)delegate
                {
                    ServerStatusLabel.Text = "RSM is cleaning up. Please try again in a few seconds...";
                    ServerStatusLabel.ForeColor = Color.FromArgb(255, 220, 220, 180);
                });
                return;
            }

            // initiate the next dead counter to 3 seconds
            serverDeadCounter = 3;

            // temporarily disable the auto crash restart feature until the server is started
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

            ServerStatusLabel.Invoke((MethodInvoker)delegate
            {
                ServerStatusLabel.Text = "Attemping to shutdown RustDedicated (" + CONFIG.SERVER_IDENTITY + ")...";
                ServerStatusLabel.ForeColor = Color.FromArgb(255, 220, 180, 180);
            });

            statusTextAllowedToUpdate = false;

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


            ServerStatusLabel.Invoke((MethodInvoker)delegate
            {
                ServerStatusLabel.Text = "Attemping to restart RustDedicated (" + CONFIG.SERVER_IDENTITY + ")...";
                ServerStatusLabel.ForeColor = Color.FromArgb(255, 220, 170, 130);
            });

            SERVER_ALLOWED_TO_AUTO_CRASH_RESTART = false;
            statusTextAllowedToUpdate = false;

            // if the auto crash restart feature is enabled, use its logic to start the server again
            if (AutoRestartOnCrashCheckBox.Checked)
            {
                StopRustDedicated(false);
                InvokeAutoRestartBackup();
                SERVER_ALLOWED_TO_AUTO_CRASH_RESTART = true;
            }
            // if not, restart it normally
            else
            {
                StopRustDedicated(true);
                InvokeAutoRestartBackup();
                StartRustDedicated();
            }
        }

        private void InvokeAutoRestartBackup()
        {
            // this will activate asynchronously, so an invoke is needed to access BackupOnRestartCheckBox
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

            DialogResult bp_prompt = MessageBox.Show("Do you want to wipe blueprints?", "", MessageBoxButtons.YesNo);

            bool wipeBlueprints = bp_prompt == DialogResult.Yes;

            statusTextAllowedToUpdate = false;

            UpdateConfig();
            InitiateServerWipe(wipeBlueprints);
        }

        private void ResetWipeDateButton_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("Are you sure you want to reset the wipe date now?\nThis will calculate new wipe dates from the current settings.\nThe server will NOT shutdown.", "", MessageBoxButtons.YesNo);

            if (prompt == DialogResult.No)
            {
                return;
            }

            UpdateConfig();
            UpdateNextWipeDate();
        }

        private void BackupServerButton_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("Are you sure you want to backup the server now?\nIt will shutdown and you will need to restart it manually.", "", MessageBoxButtons.YesNo);

            if (prompt == DialogResult.No)
            {
                return;
            }

            Tools.LogTools.LogEvent("MAIN/INFO", "Initiating server backup...", false, false, ConsoleColor.Gray);

            statusTextAllowedToUpdate = false;

            UpdateConfig();
            StopRustDedicated(true);
            BackupServer();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tools.LogTools.LogEvent("MAIN/INFO", "Preparing for shutdown...", false, false, ConsoleColor.Gray);

            if (IsProcessRunning("RustDedicated") || IsProcessRunning("steamcmd"))
            {
                DialogResult prompt = MessageBox.Show("A Rust dedicated server is currently running.\nAuto wipes/restarts/backups/etc., will be unoperational while closed. They will resume normally the next time RustServerManager is opened.\n\nAre you sure you want to continue?", "", MessageBoxButtons.YesNo);

                if (prompt == DialogResult.No)
                {
                    Tools.LogTools.LogEvent("MAIN/WARN", "Aborting shutdown...", false, false, ConsoleColor.Yellow);
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
            // this function will refresh the config with updated values to be used

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
            string forceInstallDir = OpenFolderBrowserDialog();

            if (forceInstallDir == "")
                forceInstallDir = "rustserver";

            ForceInstallDirTextBox.Text = forceInstallDir;
        }

        private void ForceInstallDirResetButton_Click(object sender, EventArgs e)
        {
            // default value is "rustserver"
            ForceInstallDirTextBox.Text = "rustserver";
        }

        private void ForceInstallDirTextBox_TextChanged(object sender, EventArgs e)
        {
            // prevent the force_install_dir textbox from being blank
            if (ForceInstallDirTextBox.Text == "")
                ForceInstallDirTextBox.Text = "rustserver";
            else if (ForceInstallDirTextBox.Text.Any(char.IsUpper))
                ForceInstallDirTextBox.Text = ForceInstallDirTextBox.Text.ToLower();
        }

        private void ServerIdentityTextBox_TextChanged(object sender, EventArgs e)
        {
            // remove spaces from serverIdentityTextBox, spaces cause problems
            if (ServerIdentityTextBox.Text.Contains(" "))
                ServerIdentityTextBox.Text = ServerIdentityTextBox.Text.Replace(" ", "");
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