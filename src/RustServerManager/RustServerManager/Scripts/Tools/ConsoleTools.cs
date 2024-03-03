﻿using System;
using System.Runtime.InteropServices;

namespace RustServerManager.Tools
{
    public static class ConsoleTools
    {
        // console show/hide control
        // forked from: https://stackoverflow.com/a/3571628
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        //

        public static void ShowConsole()
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
        }

        public static void HideConsole()
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_SHOW);
        }
    }
}