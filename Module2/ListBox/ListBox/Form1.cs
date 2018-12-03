using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if(listBox1.SelectedIndex>=0)
				listBox1.Items.RemoveAt(listBox1.SelectedIndex);
			else MessageBox.Show("No elements");
		}
		string[] lines = { "as", "ad" };
		private void button1_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			listBox1.Items.AddRange(lines);
		}

		private void listBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
