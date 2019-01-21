using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
	public class Matrix
	{
		int _n;
		int _m;
		public static Random rnd = new Random();
		public int N {
			get { return _n; }
			set { _n = value; }

		}
		public int M { get { return _m; } }
		double[,] _matrix;
		public double[,] matrix { get { return _matrix; } }
		public Matrix(int n,int m)
		{
			_matrix = new double[n, m];
			N = n;
			_m = m;
			for(int i = 0; i < _matrix.GetLength(0); i++)
			{
				for(int j = 0; j < _matrix.GetLength(1); j++)
				{
					_matrix[i, j] = rnd.Next(-10, 11);
				}
			}
		}
		public double this[int x ,int y]
		{
			get { return matrix[x, y]; }
		}
		public override string ToString()
		{
			string mstr = "";
			for(int i = 0; i < matrix.GetLength(0); i++,mstr+="\n")
			{
				for(int j = 0;j<matrix.GetLength(1); j++)
				    mstr += matrix[i,j].ToString("f3")+" ";
			}
			return mstr;
		}

	}
}
