using System;
using System.IO;

namespace RustServerManager.Tools
{
    public static class LogTools
    {
        public static void LogEvent(string prefix, string message, bool prependNewLine)
        {
            string log = (prependNewLine ? "\n" : "") + "[" + DateTime.Now.ToString("M/d/yyyy h:mm:ss tt") + "] [" + prefix + "] " + message;

            Console.WriteLine(log);
            File.AppendAllText("RustServerManager.log", log + "\n");
        }
    }
}