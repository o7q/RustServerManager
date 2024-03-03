using System.Diagnostics;

namespace RustServerManager.Tools
{
    public static class ShellTools
    {
        public static void RunCommand(string command)
        {
            ProcessStartInfo process = new ProcessStartInfo();
            process.Arguments = "/c " + command;
            process.FileName = "cmd.exe";
            process.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(process);
        }
    }
}