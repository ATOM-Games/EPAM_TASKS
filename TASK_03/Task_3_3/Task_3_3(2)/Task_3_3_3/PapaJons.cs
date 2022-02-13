using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task_3_3_2_
{
	public partial class PapaJons : Form
	{
		int num_order = 0;
		public PapaJons()
		{
			InitializeComponent();
			timer.Start();
			//---
			User us1 = new User("James Raynor", this);
			User us2 = new User("Kyle Crane", this);
			User us3 = new User("Drake MacMannis", this);
			us1.Show();
			us2.Show();
			us3.Show();
		}

		public order addOrder() {
			order newOr = new order( "[ заказ № "+(num_order++)+" ]", this );
			newOr.Dock = System.Windows.Forms.DockStyle.Top;
			this.orders.Add(newOr);
			this.panel1.Controls.Add(newOr);
			return newOr;
		}
		private void update(object sender, EventArgs e)
		{
			try
			{
				foreach (order o in this.orders)
				{
					if (o != null) o.update();
				}
			}
			catch (Exception ew) { }
		}

		public void removeOrder(order r) {
			this.orders.Remove(r);
			this.panel1.Controls.Remove(r);
		}
	}
}
