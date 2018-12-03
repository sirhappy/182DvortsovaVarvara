using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{

	// Конкретная подынтегральная функция 1:
	public class Fun_1 : Integrand
	{

		public Fun_1(double xmi, double xma)
		{  // Конструктор
			Xmin = xmi;
			Xmax = xma;
		}

		// Подынтегральная функция: 
		public override double function(double x)
		{
			double denominator = (x * x + 1) * (x * x + 1);
			return x / denominator;
		}
	}
}
