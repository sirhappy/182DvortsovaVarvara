﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
	public abstract class MatrixOperation
	{
		public int OperationComplexity { get; set; }
		public abstract Matrix PerformOperation(Matrix a,Matrix b);

	}
}
