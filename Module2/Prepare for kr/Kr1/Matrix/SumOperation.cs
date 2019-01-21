using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
	public class SumOperation:MatrixOperation
	{
		public override Matrix PerformOperation(Matrix a,Matrix b)
		{
			if(a.matrix.GetLength(0)!= b.matrix.GetLength(0)|| a.matrix.GetLength(1) != b.matrix.GetLength(1))
			{
				throw new ArgumentException();
			}
			Matrix arr = new Matrix(a.matrix.GetLength(0), a.matrix.GetLength(1));
			for (int i =0;i<a.matrix.GetLength(0); i++)
			{
				for(int j = 0; j < a.matrix.GetLength(1); j++)
				{
					arr.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
					OperationComplexity++;
				}
				
			}
			return arr;
		}


	}
}
