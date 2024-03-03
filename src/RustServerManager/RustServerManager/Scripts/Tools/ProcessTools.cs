using System.Linq;
using System.Diagnostics;

namespace RustServerManager.Tools
{
    public static class ProcessTools
    {
        public static bool IsProcessRunning(string process)
        {
            if (Process.GetProcessesByName(process).Any())
                return true;
            else
                return false;
        }

        public static void WaitForProcess(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            foreach (Process process in processes)
            {
                process.WaitForExit();
            }
        }
    }
}