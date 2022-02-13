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
	public partial class User : Form
	{
		PapaJons pj;
		public User(string nameUser, PapaJons pf)
		{
			InitializeComponent();
			pj = pf;
			this.Text = nameUser;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			pj.addOrder().deadOr += new order.DeadOrder(createNotify);
		}

		public void createNotify(string message) {
			System.Windows.Forms.Label lbl = new Label();
			lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			lbl.Dock = System.Windows.Forms.DockStyle.Top;
			lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			lbl.ForeColor = System.Drawing.Color.Red;
			lbl.Location = new System.Drawing.Point(0, 0);
			lbl.Name = "label1";
			lbl.Size = new System.Drawing.Size(232, 23);
			lbl.TabIndex = 0;
			lbl.Text = message;



			this.panel1.Controls.Add(lbl);
		}
	}
}
