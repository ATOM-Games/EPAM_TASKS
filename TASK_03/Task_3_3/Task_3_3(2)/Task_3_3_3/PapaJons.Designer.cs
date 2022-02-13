using System;
using System.Collections.Generic;

namespace Task_3_3_2_
{
	partial class PapaJons
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.orders = new List<order>();
			this.timer = new System.Windows.Forms.Timer();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(228, 450);
			this.panel1.TabIndex = 0;
			//
			//this.orders.Dock = System.Windows.Forms.DockStyle.Top;
			this.timer.Interval = 10;
			this.timer.Tick += new System.EventHandler(update);
			// 
			// PapaJons
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			//this.panel1.Controls.Add(orders);
			this.Name = "PapaJons";
			this.Text = "Папа Джонс";
			this.ResumeLayout(false);

		}

		

		#endregion

		private System.Windows.Forms.Panel panel1;
		private List<order> orders;
		private System.Windows.Forms.Timer timer;
	}
}

