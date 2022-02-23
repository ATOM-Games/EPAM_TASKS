using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
	internal class action_delete : IActionable
	{
		int index = 0; // index добавляемой строки (чтоб знать какую удалить)
		string del_str = "", file = ""; // значение лога
		DateTime datetime;// дата изменения

		public action_delete(ref string[] log, int index)
		{ // конструктор во время загрузки
			this.index = int.Parse(log[index].Split('	')[1]);
			this.datetime = DateTime.Parse(log[index].Split('	')[2]);
			this.file = log[index].Split('	')[3];
			this.del_str = log[index].Split('	')[4];
		}

		public action_delete(ref string[] str, string fileName)
		{
			this.index = str.Length;
			this.datetime = DateTime.Now;
			this.del_str = str[str.Length - 1];
			this.file = fileName;
			Array.Resize(ref str, str.Length - 1);
		}



		public void action(ref string[] str, ref string[] log)
		{
			
		}

		public void ctrlZ()
		{
			string[] strs = File.ReadAllLines(MainAction.mainFoledr + file);
			Array.Resize(ref strs, strs.Length + 1);
			strs[strs.Length - 1] = del_str;
			File.WriteAllLines(MainAction.mainFoledr + file, strs);
			Console.WriteLine($"Действие [ {this} ] откатан");
		}

		public override string ToString()
		{
			return $"{datetime.ToString("dd.MM.yyyy HH:mm: ss")} была удалена запись \"{del_str}\" в файл \"{file}\" ";
		}
		public string saveString()
		{
			return $"del	{index}	{datetime.ToString("dd.MM.yyyy HH:mm:ss")}	{file}	{del_str}";
		}
	}
}
