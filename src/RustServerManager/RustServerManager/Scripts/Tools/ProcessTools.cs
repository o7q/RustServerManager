using System;
using System.Linq;
using System.Diagnostics;

namespace RustServerManager.Tools
{
    public static class ProcessTools
    {
        public static bool IsProcessRunning(string processName)
        {
            if (Process.GetProcessesByName(processName).Any())
                return true;
            else
                return false;
        }

        public static void WaitForProcess(string processName)
        {
            Tools.LogTools.LogEvent("PROCESS/INFO", "Waiting for " + processName + "...", false, false, ConsoleColor.DarkGray);
            Process[] processes = Process.GetProcessesByName(processName);
            foreach (Process process in processes)
            {
                process.WaitForExit();
            }
        }
    }
}