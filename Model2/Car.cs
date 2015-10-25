using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model2
{
	[Serializable]
	public class Car:VehicleBase
	{
		/// <summary>
		/// Вместимость топливного бака.
		/// </summary>
		public override int FuelCapacity
		{
			get { return 40; }
		}
				
		/// <summary>
		/// Наличие прицепа у автомобиля.
		/// </summary>
		public bool Trailer { get; set; }

		/// <summary>
		/// Проехать за один час.
		/// </summary>
		public override void Move()
		{
			if (Fuel - 5 < 0)
				throw new InsufficientFuelException("Недостаточно топлива");
			Fuel -= 5;
			TraversedPath += 4.7;
		}

		/// <summary>
		/// Возвращает тип элемента
		/// </summary>
		public override string ToString()
		{
			return "Машина";
		}
	}
}
