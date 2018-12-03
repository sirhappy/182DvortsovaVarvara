using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEmploy
{
	public class PartTimeEmployee:Employee
	{
		int workingDays = 25;
		public int WorkingDays
		{
			get { return workingDays; }
		}
		public PartTimeEmployee(string name ,decimal basepay,int workingdays):base(name,basepay)
		{
			this.workingDays = workingdays;
		}
		public override decimal CalculatePay()
		{
			return basepay/25* workingDays;
		}
	}
}
