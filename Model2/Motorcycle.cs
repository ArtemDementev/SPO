using System;
using System.Linq;

namespace Model2
{
	[Serializable]
    public class Motorcycle:VehicleBase
	{
		/// <summary>
		/// Вместимость топливного бака.
		/// </summary>
		public override int FuelCapacity
		{
			get { return 24; }
		}
	
		/// <summary>
		/// Наличие коляски у мотоцикла.
		/// </summary>
	    public bool Stroller { get; set; }

	    /// <summary>
	    /// Проехать за один час.
	    /// </summary>
		public override void Move()
	    {
			if (Fuel - 1 < 0)
				throw new InsufficientFuelException("Недостаточно топлива");
		    Fuel -= 1;
		    TraversedPath += 5.5;
	    }

		/// <summary>
		/// Возвращает тип объекта
		/// </summary>
	    public override string ToString()
	    {
		    return "Мотоцикл";
	    }
    }
}
