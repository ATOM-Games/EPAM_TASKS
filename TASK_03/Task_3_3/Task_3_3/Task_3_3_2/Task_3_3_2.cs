using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3
{
	class Task_3_3_2 : IExecutable
	{
		public void Exec()
		{
			Console.WriteLine("=======================[ 3.3.2 SUPER STRING ]=======================");
			SubString ss1 = new SubString("World");
			SubString ss2 = new SubString("Иволга");
			SubString ss3 = new SubString("1466");
			SubString ss4 = new SubString("Cokneys vs zombies");
			SubString ss5 = new SubString("яяSsss");
			Console.WriteLine(ss1.getTypeWord());
			Console.WriteLine(ss2.getTypeWord());
			Console.WriteLine(ss3.getTypeWord());
			Console.WriteLine(ss4.getTypeWord());
			Console.WriteLine(ss5.getTypeWord());
			Console.WriteLine("====================================================================");
			Console.ReadKey();
		}
	}
}
