using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3_2_
{
	class Task_3_3_1 : IExecutable
	{
		public void Exec()
		{
			Console.WriteLine("=======================[ 3.3.1 SUPER ARRAY ]========================");
			SubArray sa = new SubArray(new int[] { 1, 5, 2, 5, 3, 6, 7, 4, 7, 4, 3, 5 });
			int summ = sa.summ();
			Console.WriteLine("summ : " + summ);
			int midd = sa.middle();
			Console.WriteLine("middle : " + midd);
			int vis = sa.maxVisArray();
			Console.WriteLine("vis : " + vis);
			Console.WriteLine("====================================================================");
			Console.ReadKey();
		}
	}
}
