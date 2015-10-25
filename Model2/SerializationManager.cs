using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Model2
{
	/// <summary>
	/// Класс для сериализции списка IVehicle
	/// </summary>
	public static class SerializationManager
	{
		

		public static List<VehicleBase> LoadConfigData(string OutputFilename)
		{
			Stream stream = File.Open(OutputFilename, FileMode.Open);
			var formatter = new BinaryFormatter();
			var data = (List<VehicleBase>)formatter.Deserialize(stream);
			stream.Close();
			return data;
		}

		public static void SaveConfigData(List<VehicleBase> data, string OutputFilename)
		{
			Stream stream = File.Open(OutputFilename, FileMode.Create);
			var formatter = new BinaryFormatter();
			formatter.Serialize(stream, data);
			stream.Close();
		} 

	}
}
