using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
	class GeometricProgression
	{
		
		double _start;//начальное значение последовательности; 
		double _increment;//– знаменатель прогрессии; 
		
		public GeometricProgression():this(0,1) {}
		public GeometricProgression(double start,double increment)
		{
			_start = start;
			_increment = increment;
		}
		public double this[int index]
		{
			get {return _start * Math.Pow(_increment, index - 1); }
				
		}
		public double GetSum(int n)
		{
			
			
			return _start * (1 - Math.Pow(_increment, n)) / (1 - _increment);
		}
		public override string ToString()
		{
			return $"\tb1 = {_start}\tq = {_increment}";
		}

	}
}
