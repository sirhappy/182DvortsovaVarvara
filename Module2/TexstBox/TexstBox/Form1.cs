using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexstBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}
		string[] lines = new string[]
			   { "один", "два", "три", "четыре", "пять", "шесть", "семь" };

		private void button2_Click(object sender, EventArgs e)
		{
			string res = string.Join("  ", textBox1.Lines);
			MessageBox.Show("Результат изменений:\n" + res);


		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
    // показать вторую кнопку
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Lines = lines;
		}
	}
}
