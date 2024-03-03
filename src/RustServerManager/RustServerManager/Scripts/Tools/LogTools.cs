using System;
using System.IO;

using static RustServerManager.Global;

namespace RustServerManager.Tools
{
    public static class LogTools
    {
        public static void LogEvent(string prefix, string message, bool prependNewLine, bool appendNewLine, ConsoleColor consoleColor)
        {
            string log = (prependNewLine ? "\n" : "") + "[" + DateTime.Now.ToString("M/d/yyyy h:mm:ss tt") + "] [" + prefix + "] " + message + (appendNewLine ? "\n" : "");

            Console.ForegroundColor = consoleColor;
            Console.WriteLine(log);
            Console.ResetColor();

            File.AppendAllText("RustServerManager\\logs\\RSM_" + LOG_DATETIME.ToString("yyyy.MM.dd-HH.mm.ss") + ".log", log + "\n");
        }
    }
}