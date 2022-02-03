using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_1_1
{
	class Program
	{
		static void Main(string[] args) 
		{
			int select = 0;
			ConsoleKeyInfo cki;
			Executable exec = null;
			do
			{
				if (exec != null) {
					exec = null;
					GC.Collect();
				}
				Console.Clear();
				DrawMenu(menu.Keys.ElementAt(select));
				cki = Console.ReadKey();
				if (cki.Key == ConsoleKey.DownArrow) {
					if (select == menu.Count-1)
						select = 0;
					else
						select ++;
				}
				if (cki.Key == ConsoleKey.UpArrow)
				{
					if (select == 0)
						select = menu.Count-1;
					else
						select--;
				}

				if (cki.Key == ConsoleKey.Enter) {
					if (select == menu.Count-1)
					{
						break;
					}
					else {
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
			{"1.1.1 Rectangle", typeof(RECTANGLE_1_1_1)},
			{"1.1.2 Triangle", typeof(TRIANGLE_1_1_2)},
			{"1.1.3 Another Triangle", typeof(ANOTHER_TRIANGLE_1_1_3)},
			{"1.1.4 X-Mas_tree", typeof(X_MAS_TREE_1_1_4)},
			{"1.1.5 Sum of numbers", typeof(SUM_OF_NUMBERS_1_1_5)},
			{"1.1.6 Font Adjustment", typeof(FONT_ADJUSTMENT_1_1_6)},
			{"1.1.7 Array processing", typeof(ARRAY_PROCESSING_1_1_7)},
			{"1.1.8 No posible", typeof(NO_POSITIVE_1_1_8)},
			{"1.1.9 Non positive sum", typeof(NON_NEGATIVE_SUM_1_1_9)},
			{"1.1.10 2D Array", typeof(ARRAY_2D_1_1_10) },
			{"выход", null} 
		};

		static void DrawMenu(string select) {
			Console.WriteLine($"Выберите таск : \n");
			foreach (KeyValuePair<string, Type> knn in menu) {
				Console.WriteLine(  ((select == knn.Key) ? $"[ {knn.Key} ]" : $"  {knn.Key}  ")  );
			}
		}

		static Executable getProgramm(int str) {
			return (Executable)Activator.CreateInstance(menu[menu.Keys.ElementAt(str)]);
		}
	}
}
