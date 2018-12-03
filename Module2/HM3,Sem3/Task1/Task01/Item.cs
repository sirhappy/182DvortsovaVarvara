using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
	/// <summary>
	/// Класс Item, моделирует одну покупку. 
	/// </summary>
	class Item
	{
		public string Name { get; }
		public double Price { get; }
		public int Quantity { get; }
		public Item(string itemName, double itemPrice, int numPurchased)
		{
			Name = itemName;
			Price = itemPrice;
			Quantity = numPurchased;
		}
		public override string ToString()
		{
			return $"{Name}\t\t{Price:C}\t\t{ Quantity}\t\t{Price* Quantity:C}";
		}
	}
}
