using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1
{
	internal class Task_3_1_2 : IExecutable
	{
		Dictionary<string, int> slova = new Dictionary<string, int>();
		char[] sep = { ' ', '.', ',', '!', '?' };

		public void Execute()
		{
			Console.WriteLine("------------[ task 3.1.1 WEAKEST LINK ]-------------");
			Console.WriteLine("+--------------------------------------------------+");
			string str = Console.ReadLine();
			str = str.ToLower();
			string[] all = str.Split(sep);
			Array.Sort(all);
			foreach (string s in all) {
				if (slova.ContainsKey(s)) {
					slova[s]++;
				} else {
					slova.Add(s, 1);
				}
			}
			Console.WriteLine("+--------------------------------------------------+");
			foreach (KeyValuePair<string, int> knn in slova)
			{
				if(knn.Key.Count()>0)
					Console.WriteLine(knn.Key + " : "+knn.Value);
			}

			Console.WriteLine("----------------------------------------------------");
			Console.ReadKey();
		}
	}
}
