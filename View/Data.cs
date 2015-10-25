using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model2;

namespace View
{
	/// <summary>
	/// Класс, для передачи объектов типа IVehicle между формами
	/// </summary>
	static class Data
	{
		public static VehicleBase VehicleItem { get; set; }
	}
}
