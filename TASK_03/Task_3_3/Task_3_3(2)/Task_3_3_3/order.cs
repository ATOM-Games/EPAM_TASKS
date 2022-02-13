using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3_3_2_
{
	public partial class order : UserControl
	{
		public delegate void DeadOrder(string message);
		public event DeadOrder deadOr;
		PapaJons pj;
		int stepWait=1, maxStepWait=1;
		public order(string str, PapaJons p)
		{
			InitializeComponent();
			this.groupBox1.Text = str;
			pj = p;
			Random r = new Random(str.GetHashCode()+(int)(System.DateTime.Now.Ticks));
			maxStepWait = r.Next(1, 10);
		}

		public void update() {
			if (this.progressBar1.Value < 100)
				if (stepWait < maxStepWait)
				{
					stepWait++;
				}
				else
				{
					this.progressBar1.Value++;
					stepWait = 1;
				}
			else
			{
				deadOr("Ваш заказ " + groupBox1.Text + " готов");
				pj.removeOrder(this);
			}
		}
	}
}
