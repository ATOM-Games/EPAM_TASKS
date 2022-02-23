using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Task_4 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        internal delegate void SignalHandler(ConsoleSignal consoleSignal);
        internal enum ConsoleSignal
        {
            CtrlC = 0,
            CtrlBreak = 1,
            Close = 2,
            LogOff = 5,
            Shutdown = 6
        }
        internal static class ConsoleHelper
        {
            [DllImport("Kernel32", EntryPoint = "SetConsoleCtrlHandler")]
            public static extern bool SetSignalHandler(SignalHandler handler, bool add);
        }
        private static SignalHandler signalHandler;

        static int k = 0;
        static IExecutable ex;
        public static void Main(string[] args)
        {
            signalHandler += HandleConsoleSignal;
            ConsoleHelper.SetSignalHandler(signalHandler, true);
            input();
            ex = (k == 1) ? new Observer() : new ctr_Z_ver();
            ex.exec();
        }
        static void input() {
            Console.WriteLine("Выберете режим (1 - наблюдатель 2 - исправлятор)");
            try
            {
                k = int.Parse(Console.ReadLine());
            }
            catch (Exception s) {
                Console.WriteLine("Введите число");
                input();
            }
            if (k < 1 || k > 2) {
                Console.WriteLine("Число должно быть либо 1 или 2");
                input();
            }
        }
        private static void HandleConsoleSignal(ConsoleSignal consoleSignal)
        {
            if (consoleSignal == ConsoleSignal.Close) {
                ex.saveLog();
            }
        }
    }
}