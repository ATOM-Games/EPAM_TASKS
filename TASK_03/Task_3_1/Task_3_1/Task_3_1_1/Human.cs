using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1
{
	public class Human
	{
		private int num;
		public Human(int n) {
			this.num=n;
		}
		~Human() {
			Console.WriteLine($"Человек под номером {num} был удален");
		}
	}
}
