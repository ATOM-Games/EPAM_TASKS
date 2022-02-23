using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
	internal class Observer : IExecutable
	{
		int d = 0;
		MainAction ma;
		public Observer() {
			ma = new MainAction();
			ma.loadLogs();
		}

		public void exec()
		{
			Console.WriteLine("[---режим наблюдателя---]");
			string fileName = "";
			do {
				fileName = MainAction.inputFile();
				if (fileName != "break")
				{
					Console.Write("Введите 1 или 2 (1 - добавить запись 2  - удалить ) : ");
					inputInt();
					if (d == 1)
						ma.addString(fileName);
					if (d == 2)
						ma.deleteString(fileName);
				}
			} while (fileName!="break");


			saveLog();
		}

		public void saveLog()
		{
			ma.saveLogs();
		}

		void inputInt()
		{
			try
			{
				d = int.Parse(Console.ReadLine());
			}
			catch (Exception q)
			{
				Console.WriteLine("Введите число");
				inputInt();
			}
			if (d < 1 || d > 2)
			{
				Console.WriteLine($"Число должно быть в диапазоне от 1 до 2 ");
				inputInt();
			}
		}

	}
}
