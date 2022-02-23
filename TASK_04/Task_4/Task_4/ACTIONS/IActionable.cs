using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
	internal interface IActionable
	{
		public void action(ref string[] str, ref string[] log);
		public void ctrlZ();
		public string saveString();
	}
}
