using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
	public class TramsposeOperation:MatrixOperation
	{
		public Matrix PerformOperation(Matrix a)
		{
			Matrix arr = new Matrix(a.matrix.GetLength(1), a.matrix.GetLength(0));
			for(int i = 0; i < a.matrix.GetLength(0); i++)
			{
				for(int j = 0; j < a.matrix.GetLength(1); j++)
				{
					arr.matrix[j, i] = a.matrix[i, j];
					if(arr.matrix[j, i] > 0)
					{
						arr.matrix[i, j] = arr.matrix[i, j] * 0.08 + arr.matrix[i, j];
					}
				}
			}
			return arr;
		}
		public override Matrix PerformOperation(Matrix a, Matrix b)
		{
			Matrix arr = new Matrix(a.matrix.GetLength(1), a.matrix.GetLength(0));
			for (int i = 0; i < a.matrix.GetLength(0); i++)
			{
				for (int j = 0; j < a.matrix.GetLength(1); j++)
				{
					arr.matrix[j, i] = a.matrix[i, j];
					OperationComplexity += 3;
				}
				
			}
			return arr;
		}
	}
}
