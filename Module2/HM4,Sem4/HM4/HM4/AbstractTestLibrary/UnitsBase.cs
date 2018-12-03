using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTestLibrary
{
	// Абстрактный класс Units.
	// Определяет набор полей для классов наследников:

	abstract public class UnitsBase
	{
		public int unit_code{get;set;} // номер единицы
		public  double price { get; set; } // цена за единицу
		public string name { get; set; } // название
		public int skidka { get; set; }
		public virtual double Discount()
		{
			return price - (price * skidka)/100;
		}
	}

}
