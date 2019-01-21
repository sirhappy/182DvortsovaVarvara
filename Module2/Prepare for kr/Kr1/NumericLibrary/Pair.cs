using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericLibrary
{
	public abstract class Pair
	{
		int  _x;
		public  int X => _x;
		public int Y { get; set; }
		
		public Pair(int x,int y)
		{
			_x = x;
			Y = y;
		}

		public abstract Pair Add(Pair b);
	    public abstract Pair Sub(Pair b);
		public abstract Pair Mult(Pair b);
		abstract public int PairEqual(Pair b);
			
		

		public override string ToString()
		{
			return $"x = {X} y = {Y}";
		}


	}
}
