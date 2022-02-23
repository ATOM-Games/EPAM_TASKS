using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
	internal class MainAction
	{
		static public string mainFoledr = @"C:\Users\1\Documents\РАБОТА\ЭПАМ\EPAM-TASKS\TASK_04\Task_4\Task_4\FolderMain\",
			logFile = @"C:\Users\1\Documents\РАБОТА\ЭПАМ\EPAM-TASKS\TASK_04\Task_4\Task_4\FolderMain\logges.log";
		public List<IActionable> logs = new List<IActionable>();

		public void loadLogs() {
			string[] slogs = File.ReadAllLines(MainAction.logFile);
			for(int i=0; i<slogs.Length; i++) {
				if(slogs[i].Split('	')[0] == "add")
				{
					logs.Add(new action_add(ref slogs, i));
				}
				if (slogs[i].Split('	')[0] == "del")
				{
					logs.Add(new action_delete(ref slogs, i));
				}
			}
		}
		public void saveLogs() {
			string[] slogs =new string[logs.Count];
			for (int i = 0; i < slogs.Length; i++) {
				slogs[i] = logs[i].saveString();
			}
			File.WriteAllLines(MainAction.logFile, slogs);
		}


		public void addString(string fileName) {
			Console.WriteLine($"[---------добавление записи в файл {fileName}---------]");
			string[] all_strs = File.ReadAllLines(MainAction.mainFoledr + fileName);
			string newstr = Console.ReadLine();
			logs.Add(new action_add(ref all_strs, newstr, fileName));
			File.WriteAllLines(MainAction.mainFoledr + fileName, all_strs);
			Console.WriteLine($"[---------запись добавлена в файл {fileName}---------]");
			stateFile(fileName);
		}
		public void deleteString(string fileName) {
			Console.WriteLine($"[---------удаление записи из файла {fileName}---------]");
			string[] all_strs = File.ReadAllLines(MainAction.mainFoledr + fileName);
			logs.Add(new action_delete(ref all_strs, fileName));
			File.WriteAllLines(MainAction.mainFoledr + fileName, all_strs);
			Console.WriteLine($"[---------запись удалена из файла {fileName}---------]");
			stateFile(fileName);
		}

		void stateFile(string fileName) {
			string[] all_strs = File.ReadAllLines(MainAction.mainFoledr + fileName);
			int maxLengt = 0;
			for (int i = 0; i < all_strs.Length; i++)
			{
				if (maxLengt < all_strs[i].Length) { maxLengt = all_strs[i].Length; }
			}
			if(maxLengt< fileName.Length) { maxLengt = fileName.Length; }
			Console.WriteLine("\n+-"+new string('-', maxLengt/2-fileName.Length/2)+fileName + new string('-', maxLengt / 2 - fileName.Length / 2)+"-+");
	
			for (int i = 0; i < all_strs.Length; i++) {
				Console.WriteLine("| "+all_strs[i]+new string(' ', maxLengt - all_strs[i].Length)+" |");
			}
			Console.WriteLine("+-" + new string('-', maxLengt) + "-+");
		}


		static public string inputFile()
		{

			string str;
			do
			{
				Console.Write("Введите имя файла : ");
				str = "";
				str = Console.ReadLine();
				str.Replace('/', '\\'); // в случае, если написали /
			} while (!File.Exists(MainAction.mainFoledr + str) && str!="break");
			return str;
		}

		public void Otkat(int d) {
			int size = logs.Count;
			for (int i = d; i < size; i++)
			{
				logs.Last().ctrlZ();
				logs.Remove(logs.Last());
			}
		}

	}
}
