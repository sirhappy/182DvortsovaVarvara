using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTestLibrary
{
	// Cards - класс определяет карточки.
	// Наследует абстрактный класс UnitsBase
	public class Cards : UnitsBase
	{
		public string message { get; set; } // сообщение
		public Cards(string name, double price, int skidka, int unit_code, string message)
		{
			this.name = name;
			this.skidka = skidka;
			this.unit_code = unit_code;
			this.price = price;
			this.message = message;
		}
		/*public  override double Discount()
		{
			return price;
		}
		*/
	}

}
