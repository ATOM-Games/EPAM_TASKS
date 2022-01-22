using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2_2 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static Windowable win;
        public static void Main(string[] args)
        {
            bool canKey = true;
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            win = new MainMenu();
            do
            {
                if (win != null) win.update(cki);
                if (win != null) win.draw();
                canKey = true;
                cki = Console.ReadKey();
                canKey = false;
                Console.Clear();
            } while (win!=null);
        }
    }
}