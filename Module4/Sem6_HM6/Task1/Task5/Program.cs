using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	public class Guest
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}
	public class Party
	{
		public IEnumerator GetEnumerator()
		{
			return new PartyEnumarator(_guestList);
		}
		private List<Guest> _guestList;
		public Party()
		{
			_guestList = new List<Guest>();
		}
		public void AddGuest(Guest guest)
		{
			_guestList.Add(guest);
		}
	}
	class PartyEnumarator : IEnumerator
	{
		private List<Guest> _guestList;

		public PartyEnumarator(List<Guest> guestList)
		{
			_guestList = guestList;
		}
		int Position = -1;

		public object Current => _guestList[Position];

		public bool MoveNext() => ++Position < _guestList.Count;


		public void Reset() => Position = -1;
		
	}
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				Party party = new Party();
				party.AddGuest(new Guest() { Age = 25, Name = "John" });
				party.AddGuest(new Guest() { Age = 24, Name = "Barbara" });
				party.AddGuest(new Guest() { Age = 24, Name = "Phil" });
				party.AddGuest(new Guest() { Age = 23, Name = "Fred" });
				party.AddGuest(new Guest() { Age = 26, Name = "Hannah" });
				party.AddGuest(new Guest() { Age = 27, Name = "Cindy" });
				foreach (Guest guest in party)
				{
					Console.WriteLine(guest.Name);
				}
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
			

		}
	}
}
