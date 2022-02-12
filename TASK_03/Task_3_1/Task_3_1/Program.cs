using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_3_1 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
			int select = 0;
			ConsoleKeyInfo cki;
			IExecutable exec = null;
			do
			{
				if (exec != null)
				{
					exec = null;
					GC.Collect();
				}
				Console.Clear();
				DrawMenu(menu.Keys.ElementAt(select));
				cki = Console.ReadKey();
				if (cki.Key == ConsoleKey.DownArrow)
				{
					if (select == menu.Count - 1)
						select = 0;
					else
						select++;
				}
				if (cki.Key == ConsoleKey.UpArrow)
				{
					if (select == 0)
						select = menu.Count - 1;
					else
						select--;
				}

				if (cki.Key == ConsoleKey.Enter)
				{
					if (select == menu.Count - 1)
					{
						break;
					}
					else
					{
						exec = getProgramm(select);
						Console.Clear();
						exec.Execute();
					}
				}

			} while (true);

			Console.WriteLine("Case closed...");
			Console.ReadKey();
		}
		static Dictionary<string, IExecutable> menu = new Dictionary<string, IExecutable> {
			{ "3.1.1 WEAKEST LINK", new Task_3_1_1() },
			{ "3.1.2 TEXT ANALYSIS", new Task_3_1_2() },
			{ "выход", null }
		};

		static void DrawMenu(string select)
		{
			Console.WriteLine($"Выберите таск : \n");
			foreach (KeyValuePair<string, IExecutable> knn in menu)
			{
				Console.WriteLine(((select == knn.Key) ? $"[ {knn.Key} ]" : $"  {knn.Key}  "));
			}
		}
		static IExecutable getProgramm(int s) => menu[menu.Keys.ElementAt(s)];
	}
}