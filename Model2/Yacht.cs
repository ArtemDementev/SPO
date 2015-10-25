using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model2
{
	[Serializable]
	public class Yacht:VehicleBase
	{
		/// <summary>
		/// Вместимость топливного бака.
		/// </summary>
		public override int FuelCapacity
		{
			get { return 100; }
		}
			
		/// <summary>
		/// Количество палуб яхты.
		/// </summary>
		private int _decksCount;

		/// <summary>
		/// Возвращает количество палуб. Если вводится отрицательно значение - вызывается исключение.
		/// </summary>
		public int DecksCount
		{
			get { return _decksCount; }
			set
			{
				if (value<0 || value>10)
					throw new InvalidValueException("Количество палуб не может быть отрицательным или больше 10");
				_decksCount = value;
			}
		}

		/// <summary>
		/// Проехать за один час.
		/// </summary>
		public override void Move()
		{
			if (Fuel - 10 < 0)
				throw new InsufficientFuelException("Недостаточно топлива");
			Fuel -= 10;
			TraversedPath += 13.2;
		}

		/// <summary>
		/// Вывод описания текущего состояния т.с.
		/// </summary>
		public override string ToString()
		{
			return "Яхта";
		}
	}
}
