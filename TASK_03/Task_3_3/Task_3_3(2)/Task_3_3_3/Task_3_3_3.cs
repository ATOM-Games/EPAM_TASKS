using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3_3_2_
{
	internal class Task_3_3_3 : IExecutable
	{
		public void Exec()
		{
			Console.WriteLine("=======================[ 3.3.3 PIZZA TIME ]=========================");
			PapaJons pj = new PapaJons();
			Application.EnableVisualStyles();
			Application.Run(pj);



			Console.WriteLine("====================================================================");
			Console.ReadKey();
		}
	}
}
