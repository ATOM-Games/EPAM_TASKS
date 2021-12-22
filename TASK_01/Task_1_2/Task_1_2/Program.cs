using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_1_2
{
	class Program
	{
		static void Main(string[] args)
		{
			int select = 0;
			ConsoleKeyInfo cki;
			Executable exec = null;
			do {
				if (exec != null) {
					exec = null;
					GC.Collect();
				}
				Console.Clear();
				DrawMenu(menu.Keys.ElementAt(select));
				cki = Console.ReadKey();
				if (cki.Key == ConsoleKey.DownArrow) {
					if (select == menu.Count - 1)
						select = 0;
					else
						select++;
				}
				if (cki.Key == ConsoleKey.UpArrow) {
					if (select == 0)
						select = menu.Count - 1;
					else
						select--;
				}
				if (cki.Key == ConsoleKey.Enter) {
					if (select == menu.Count - 1) {
						break;
					} else {
						exec = getProgramm(select);
						Console.Clear();
						exec.Execute();
					}
				}

			} while (true);
			Console.WriteLine("Case closed...");
			Console.ReadKey();
		}

		static Dictionary<string, Type> menu = new Dictionary<string, Type> {
			{"1.2.1 Averages", typeof(AVERAGES_1_2_1)},
			{"1.2.2 Doubler", typeof(DOUBLER_1_2_2)},
			{"1.2.3 Lowercase", typeof(LOWERCASE_1_2_3)},
			{"1.2.4 Validator", typeof(VALIDATOR_1_2_4)},
			{"выход", null}
		};

		static void DrawMenu(string select)
		{
			Console.WriteLine($"Выберите таск : \n");
			foreach (KeyValuePair<string, Type> knn in menu)
			{
				Console.WriteLine(((select == knn.Key) ? $"[ {knn.Key} ]" : $"  {knn.Key}  "));
			}
		}

		static Executable getProgramm(int str)
		{
			return (Executable)Activator.CreateInstance(menu[menu.Keys.ElementAt(str)]);
		}
	}
}
