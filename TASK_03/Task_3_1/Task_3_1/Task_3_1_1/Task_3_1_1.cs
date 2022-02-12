using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1
{
	internal class Task_3_1_1 : IExecutable
	{
		public void Execute()
		{
			Console.WriteLine("------------[ task 3.1.1 WEAKEST LINK ]-------------");
			int count_hum=Inputs.int_input_with_while(true, "Введите количество человек : ");
			int step_hum = Inputs.int_input_with_while(true, "Введите шаг : ");
			List<Human> hum = init_hum(count_hum);
			int round = 1;
			while (hum.Count > 1) {
				for (int i = 1; i < hum.Count; i += step_hum) {
					hum.RemoveAt(i);
				}
				GC.Collect();
				Console.WriteLine($"Раунд {round++} осталось {hum.Count} человек");
			}


			//Console.WriteLine(count_hum);

			Console.WriteLine("----------------------------------------------------");
			Console.ReadKey();
		}

		List<Human> init_hum(int count) {
			List<Human> hum = new List<Human>();
			for (int i = 0; i < count; i++) {
				hum.Add(new Human(i + 1));
			}
			return hum;
		}

	}
}
