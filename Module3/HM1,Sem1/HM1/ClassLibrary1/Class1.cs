using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public delegate int MyDel(int a, int b);
    public static  class TestClassstat
    {
		static public int TestMethod(int a,int b)
		{
			return Math.Max(a, b);
		}
    }
}
