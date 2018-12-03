using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
	public partial class Form1 : Form
	{
		int old = 1, last = 0;
		string text = "Член ряда Пелла: ";
		int now;
		public Form1()
		{
			InitializeComponent();
			label1.Text = text;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (old > int.MaxValue - 2*last)
			{
				MessageBox.Show("MAnyMAny");
				
				last = 0;
				old = 1;
				return;
			}
			now = 2 * last + old;
			old = last;
			last = now;
			label1.Text = text + now.ToString();

		}
	}
}
