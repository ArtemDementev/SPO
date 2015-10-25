using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model2
{
	/// <summary>
	/// Исключение, возникающее при попытке ввода невозможного значения
	/// </summary>
	public class InvalidValueException:Exception
	{
		public InvalidValueException(string str):base(str)
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
