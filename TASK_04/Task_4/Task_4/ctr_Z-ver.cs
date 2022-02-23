using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
	internal class ctr_Z_ver : IExecutable
	{
		int d = -1;
		MainAction ma;
		public ctr_Z_ver() {
			ma = new MainAction();
			ma.loadLogs();
		}

		public void exec()
		{
			Console.WriteLine("[---режим исправления---]");
			for (int i = 0; i < ma.logs.Count; i++) {
				Console.WriteLine((i+1)+" )	"+ma.logs[i]);
			}
			Console.WriteLine("Откатить до :");
			inputInt();
			ma.Otkat(d-1);
			saveLog();
		}

		public void saveLog()
		{
			ma.saveLogs();
		}

		void inputInt() {
			try
			{
				d = int.Parse(Console.ReadLine());
			}
			catch (Exception q) {
				Console.WriteLine("Введите число");
				inputInt();
			}
			if (d < 1 || d > ma.logs.Count) {
				Console.WriteLine($"Число должно быть в диапазоне от {1} до {ma.logs.Count} ");
				inputInt();
			}
		}
	}

}
