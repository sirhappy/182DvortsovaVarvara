using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
	public delegate double delegateConvertTemperature(double temp);

	public class TemperatureConverterImp
	{
		public double F_C(double tempF)
		{
			double res = 9.0 / 5.0*(tempF-32);
			return res;
		}
		public double C_F(double tempC)
		{
			double res = 9.0 / 5.0 * (tempC + 32);
			return res;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			TemperatureConverterImp tm = new TemperatureConverterImp();
			delegateConvertTemperature delF = new delegateConvertTemperature(tm.C_F);
			delegateConvertTemperature delC = new delegateConvertTemperature(tm.F_C);
			delegateConvertTemperature[] Maindel = { delF, delC };
			//Через массив
			Console.WriteLine("100F = {0}C", Maindel[1](100));
			Console.WriteLine("100C = {0}F", Maindel[0](100));

			Console.WriteLine("100F = {0}C", delC(100));
			Console.WriteLine("100C = {0}F", delF(100));
			Console.ReadLine();
			//создаем оъект.когда вызываем метод из класса вызываем через инвоук
		}
	}
}
