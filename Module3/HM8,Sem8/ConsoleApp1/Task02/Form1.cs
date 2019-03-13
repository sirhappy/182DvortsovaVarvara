using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task02
{
	public partial class Form1 : Form
	{
		ElectronicQueue eq;
		public Form1()
		{
			InitializeComponent();
			eq = new ElectronicQueue(); // очередь пуста
										// загрузка элементов в очередь для примера
			eq.AddToQueue(new Person("Jabba", "Hutt", 604));
			eq.AddToQueue(new Person("Wedge", "Antille", 25));
			eq.AddToQueue(new Person("Han", "Solo", 33));
			eq.AddToQueue(new Person("Leia", "Organa", 23));
			eq.AddToQueue(new Person("Lando", "Calrissian", 35));
			eq.AddToQueue(new Person("Anakin", "Skywalker", 46));
			//
			timer1.Enabled = true; // запускаем очередь
		}

		private void button1_Click(object sender, EventArgs e)
		{
			eq.AddToQueue(new Person(textBox1.Text,
							textBox2.Text, int.Parse(textBox3.Text)));
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Interval=1000;
			// отображаем вызываемого по очереди
			label4.Text = eq.CallFromElectronicQueue();
			System.Media.SystemSounds.Exclamation.Play();
			// обновляем очередь
			try
			{
				eq.DeleteFromQueue();
			}
			catch (Exception ex )
			{
				timer1.Stop();
				MessageBox.Show(ex.Message);
				
			}
			
		}	
	}
}
