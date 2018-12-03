using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTestLibrary
{
	// Books - класс определяет книгу. 
	// Наследует  абстрактный класс UnitsBase

	public class Books:UnitsBase
	{
		public int no_of_pages { get; set; } // количество страниц в книге
		public bool _isBestSeller { get; set; } // является ли бестселлером
		public Books(string name,double price,int skidka,int unit_code,int no_of_pages,bool _isBestSeller)
		{
			this.name = name;
			this.skidka = skidka;
			this.unit_code = unit_code;
			this.price = price;
			this.no_of_pages = no_of_pages;
			this._isBestSeller = _isBestSeller;
		}
		/*public override double Discount()
		{
			return price;
		}
		*/
	}
}
