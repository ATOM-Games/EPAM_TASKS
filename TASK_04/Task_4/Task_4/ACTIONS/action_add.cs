using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
	internal class action_add : IActionable
	{
		int index = 0; // index добавляемой строки (чтоб знать какую удалить)
		string add_str = "", file=""; // значение лога
		DateTime datetime;// дата изменения

		public action_add(ref string[] log, int index) { // конструктор во время загрузки
			this.index = int.Parse(log[index].Split('	')[1]);
			this.datetime = DateTime.Parse(log[index].Split('	')[2]);
			this.file = log[index].Split('	')[3];
			this.add_str = log[index].Split('	')[4];
		}

		public action_add(ref string[] str, string value, string fileName) {
			this.index = str.Length;
			this.datetime = DateTime.Now;
			this.add_str = value;
			this.file = fileName;
			Array.Resize(ref str, str.Length+1);
			str[str.Length - 1] = value;
		}





		public void action(ref string[] str, ref string[] log)
		{

		}

		public void ctrlZ()
		{
			string[] strs = File.ReadAllLines(MainAction.mainFoledr+ file);
			Array.Resize(ref strs, strs.Length - 1);
			File.WriteAllLines(MainAction.mainFoledr + file, strs);
			Console.WriteLine($"Действие [ {this} ] откатан");
		}
		public override string ToString()
		{
			return $"{datetime.ToString("dd.MM.yyyy HH:mm: ss")} была добавлена запись \"{add_str}\" в файл \"{file}\" ";
		}
		public string saveString(){
			return $"add	{index}	{datetime.ToString("dd.MM.yyyy HH:mm:ss")}	{file}	{add_str}";
		}
	}
}
