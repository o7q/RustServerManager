using System;
using System.Diagnostics;
using static RustServerManager.Tools.ShellTools;
using static RustServerManager.Tools.ProcessTools;
using static RustServerManager.Server.Wipe.WipeTimerManager;

using static RustServerManager.Global;

namespace RustServerManager.Server.RustDedicated
{
    public static class RustDedicatedProcess
    {
        public static void StartRustDedicated()
        {
            Tools.LogTools.LogEvent("SERVER/INFO", "Attempting to start RustDedicated...", false, false, ConsoleColor.Gray);

            if (IsProcessRunning("RustDedicated") || IsProcessRunning("steamcmd"))
                return;

            ProcessStartInfo command = new ProcessStartInfo();
            command.Arguments = "/c title RustServerManager - Server Identity: \"" + CONFIG.SERVER_IDENTITY + "\" - Server Seed: \"" + CONFIG.SERVER_SEED + "\" & " +
                            "steamcmd.exe +force_install_dir \"" + CONFIG.STEAMCMD_FORCE_INSTALL_DIR + "\" +login anonymous +app_update 258550 +quit & " +
                            " cd \"" + CONFIG.STEAMCMD_FORCE_INSTALL_DIR + "\" & " +
                            "RustDedicated.exe -batchmode +server.identity " + CONFIG.SERVER_IDENTITY + " " + CONFIG.SERVER_ARGUMENTS + " +server.seed " + CONFIG.SERVER_SEED;
            command.FileName = "cmd.exe";
            Process.Start(command);

            SERVER_ALLOWED_TO_AUTO_CRASH_RESTART = true;
            EnableWipeTimer();
        }

        public static void StopRustDedicated(bool waitForExit)
        {
            SERVER_ALLOWED_TO_AUTO_CRASH_RESTART = false;

            Tools.LogTools.LogEvent("SERVER/INFO", "Attempting to stop RustDedicated...", false, false, ConsoleColor.Gray);
            DisableWipeTimer();

            if (IsProcessRunning("RustDedicated"))
                RunCommand("taskkill /im RustDedicated.exe");

            if (IsProcessRunning("steamcmd"))
                RunCommand("taskkill /im steamcmd.exe");

            if (waitForExit)
            {
                // wait for RustDedicated to exit if specified
                WaitForProcess("RustDedicated");
                // wait for steamcmd to exit if specified
                WaitForProcess("steamcmd");
            }
        }
    }
}