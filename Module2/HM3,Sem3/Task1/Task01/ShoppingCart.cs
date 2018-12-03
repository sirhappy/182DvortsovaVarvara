using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
	class ShoppingCart
	{
		private int _itemCount; // количество предметов в корзине
		private double _totalPrice; // цена всех предметов в корзине
		int _capacity; // текущая вместимость корзины
		public int Capacity{get{return _capacity;} }

		/// <summary>
		/// массив покупок
		/// </summary>
		Item[] _cart;

		/// <summary>
		/// Создаёт новый экземпляр корзины с вместимостью в 5 элементов
		/// </summary>
		public ShoppingCart() {
			_capacity = 5;
			_itemCount = 0;
			_totalPrice = 0.0;
			_cart = new Item[_capacity];
		}
		/// <summary>
		/// Свойства для вывода общей стоимости покупок
		/// </summary>
		public double TotalPrice { get { return _totalPrice; } }
		/// <summary>
		/// Добавляет предмет в корзину
		/// </summary>
		/// <param name="itemName">Название предмета</param>
		/// <param name="price">Цена предмета</param>
		/// <param name="quantity">Количество предметов</param>
		public void AddToCart(string itemName, double price, int quantity)
		{
			if (_itemCount >= _cart.Length) IncreaseSize();

			_cart[_itemCount++] = new Item(itemName, price, quantity);
			_totalPrice += price * quantity;
		}
		private void IncreaseSize() {
			Array.Resize(ref _cart, _cart.Length + 3);

		}
		public override string ToString()
		{
			string contents = "\nShopping Cart\n";
			contents +="\nItem\t\tUnit Price\tQuantity\tTotal\n";
			for
			(int i = 0; i < _itemCount; i++) contents += _cart[i] + "\n";
			contents += $"\nTotal Price: {_totalPrice:C}\n";
			return contents;
		} 
	}
}
