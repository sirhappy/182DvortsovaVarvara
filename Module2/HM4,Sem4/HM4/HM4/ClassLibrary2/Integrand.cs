using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
	// Абстрактная подынтегральная функция:
	public abstract class Integrand
	{

		// Пределы интегрирования (автореализуемые свойства):
		public double Xmin { get; set; }
		public double Xmax { get; set; }

		// Подынтегральная функция (абстрактный метод):
		public abstract double function(double x);
	}
}
