using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
	// Абстрактная подынтегральная функция:
	// Конкретная подынтегральная функция 2:
	public class Fun_2 : Integrand
	{
		public Fun_2(double xmi, double xma)
		{  // Конструктор
			Xmin = xmi;
			Xmax = xma;
		}

		// Подынтегральная функция: 
		public override double function(double x)
		{
			return 4 * Math.Cos(x) * Math.Cos(x);
		}
	}
}
