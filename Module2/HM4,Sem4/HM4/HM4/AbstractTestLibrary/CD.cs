using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTestLibrary
{
	// CD - класс определяет лазерный диск. 
	// Наследует абстрактный класс UnitsBase
	public class CD : UnitsBase
	{
		public int playing_time { get; set; } // время звучания диска
		public CD(string name, double price, int skidka, int unit_code, int playing_time)
		{
			this.name = name;
			this.skidka = skidka;
			this.unit_code = unit_code;
			this.price = price;
			this.playing_time = playing_time;
			
		}
		/*public override double Discount()
		{
			return price;
		}
		*/
	}

}
