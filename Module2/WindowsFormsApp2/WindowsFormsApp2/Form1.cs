using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		double step = 0.05;
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (label1.Text.Length>0&&step>0)
				label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
			else
			{
				this.Opacity -= step;//прозрачность формы
				if (Opacity <= 0)
				{
					label1.Text = "Кот уже ушел";
					step = -step;
				}
			}
			
		}
	}
}
