using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
	internal class CUSTOM_PAINT_2_1_2 : Executable
	{
		public void Execute()
		{
			Console.WriteLine("[-------------->>>[ 2.1.2 Custom paint ]<<<--------------]");
			User us = new User();
			int select = 0;
			bool dowhile = true;
			do {
				if (us.UserName == "")
				{
					Console.WriteLine("Для начала работы Вам надо войти");
					us.login();
					Console.WriteLine("\n");
				}
				else
				{
					MenuUser(select);
					ConsoleKeyInfo cki;
					cki = Console.ReadKey();
					Console.Clear();
					if (cki.Key == ConsoleKey.DownArrow)
					{
						if (select == menu.Length - 1) select = 0;
						else select++;
					}
					if (cki.Key == ConsoleKey.UpArrow)
					{
						if (select == 0) select = menu.Length - 1;
						else select--;
					}

					if (cki.Key == ConsoleKey.Enter)
					{
						switch (select)
						{
							case 0: dowhile = false; break;
							case 1: us.logout(); break;
							case 2: us.Relog(); break;
							case 3: us.MyHolst.drawFigure(); break;
							case 4: us.MyHolst.drawAll(); Console.ReadKey(); break;
							case 5: us.MyHolst.addFigure(); break;
							case 6: us.MyHolst.deleteFigure(); break;
							case 7: us.MyHolst.clearHolst(); break;
						}
					}
				}

			} while (dowhile);
			Console.WriteLine("Работа таски завершена");
			Console.ReadLine();
		}

		string[] menu = new string[] { 
			"закончить работу",
			"выйти",
			"Сменить пользователя",
			"вывести фигуру",
			"все фигуры",
			"создать фигуру",
			"удалить фигуру",
			"очистить холтс"
		};

		void MenuUser(int select) {
			for (int i=0; i<menu.Length; i++)
			{
				Console.WriteLine(((select == i) ? $"[ {menu[i]} ]" : $"  {menu[i]}  "));
			}
		}
	}
}
