using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
	internal class Holst
	{
		public List<Figure> allFig = new List<Figure>();

		public void addFigure() {
			int select = 0;
			bool dowhile = true;
			Console.WriteLine("Создание фигуры фигуру");
			do
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
						case 1: {
								Circleference cf = new Circleference();
								cf.create();
								this.allFig.Add(cf);
								break; }
						case 2: {
								Circle cr = new Circle();
								cr.create();
								this.allFig.Add(cr);
								break; }
						case 3: {
								Ring rg = new Ring();
								rg.create();
								this.allFig.Add(rg);
								break; }
						case 4: {
								Line ln = new Line();
								ln.create();
								this.allFig.Add(ln);
								break; }
						case 5: {
								Square sq = new Square();
								sq.create();
								this.allFig.Add(sq);
								break; }
						case 6: {
								Rectangle rc = new Rectangle();
								rc.create();
								this.allFig.Add(rc);
								break; }
					}
				}
			} while (dowhile);
		}
		public void drawAll() {
			Console.WriteLine("==============================================================================");
			for (int i = 0; i < allFig.Count(); i++) {
				Console.Write("\t"+i+"\t - ");
				allFig[i].draw();
			}
		}
		public void drawFigure() {
			int i = int.Parse(Console.ReadLine());
			allFig[i].draw();
		}
		public void clearHolst() { allFig.Clear(); }
		public void deleteFigure() {
			drawAll();
			int i = int.Parse(Console.ReadLine());
			allFig.RemoveAt(i);
		}


		void MenuUser(int select)
		{
			for (int i = 0; i < menu.Length; i++)
			{
				Console.WriteLine(((select == i) ? $"[ {menu[i]} ]" : $"  {menu[i]}  "));
			}
		}
		string[] menu = new string[] {
			"отменить",
			"окружность",
			"круг",
			"кольцо",
			"линия",
			"квадрат",
			"прямоугольник"
		};
	}
}
