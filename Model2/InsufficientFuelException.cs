using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model2
{
	/// <summary>
	/// Исключение, возникающее при недостатке топлива на действие
	/// </summary>
	public class InsufficientFuelException:Exception
	{
		public InsufficientFuelException(string str) : base(str)
		{
			ExceptionMessage = str;
		}
		public string ExceptionMessage;
		public override string ToString()
		{
			return ExceptionMessage;
		}
	}
}
