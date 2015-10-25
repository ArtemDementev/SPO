using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Model2
{
	[Serializable]
	public abstract class VehicleBase
	{
		/// <summary>
		/// Вместимость топливного бака.
		/// </summary>
		public abstract int FuelCapacity { get; }
		
		/// <summary>
		/// Уровень топлива.
		/// </summary>
		private double _fuel;

		/// <summary>
		/// Количество топлива у транспортного средства
		/// </summary>
		public double Fuel
		{
			get { return _fuel; }
			set
			{
				if (value < 0 || value > FuelCapacity)
					throw new InvalidValueException("Значения поля Топливо не должно быть отрицательным или больше "+Convert.ToString(FuelCapacity));
				_fuel = value;
			}
		}

		/// <summary>
		/// Путь, пройденным транспортом.
		/// </summary>
		private double _traversedPath;

		/// <summary>
		/// Путь, пройденным транспортом
		/// </summary>
		public  double TraversedPath
		{
			get { return _traversedPath; }
			set
			{
				if (value < 0)
					throw new InvalidValueException("Поле Пройденный Путь не может быть отрицательным");
				_traversedPath = value;
			}
			
		}

		/// <summary>
		/// Модель транспортного средства.
		/// </summary>
		private string _model;

		/// <summary>
		/// Модель транспортного средства
		/// </summary>
		public string Model
		{
			get { return _model; }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new InvalidValueException("Поле Модель не может быть пустым!");
				if (value.Any(t => !Char.IsLetterOrDigit(t) && t != '-' && t != ' '))
				{
					throw new InvalidValueException("В поле Модель введен неккоректный символ!");
				}
				if (value.First() == '-' || value.Last() == '-')
				{
					throw new InvalidValueException("В поле Модель введен неккоректный символ!");
				}
				int count = 0;
				for (int i = 0; i < value.Length; i++)
				{
					if (value[i] == '-')
					{
						count++;
						if (count > 1)
							throw new InvalidValueException("В поле Модель введен неккоректный символ!");
					}

					else
						count = 0;
				}

				//Проверка на некорректные пробелы
				if (value.First() == ' ' || value.Last() == ' ')
				{
					throw new InvalidValueException("В поле Модель введен неккоректный символ!");
				}
				for (int i = 0; i < value.Length; i++)
				{
					if (value[i] == ' ')
					{
						count++;
						if (count > 1)
							throw new InvalidValueException("В поле Модель введен неккоректный символ!");
					}

					else
						count = 0;
				}

				if (Char.IsLower(value[0]))
					Char.ToUpper(value[0]);
				_model = value;
			}
		}

		/// <summary>
		/// Проехать за один час
		/// </summary>
		/// 
		public abstract void Move();

		/// <summary>
		/// Заправить т.с.
		/// </summary>
		public void Fill(double fuelCount)
		{
			if (fuelCount < 0)
				throw new InvalidValueException("Невозможно заправиться на отрицательное число едениц топлива");
			if (Fuel + fuelCount > FuelCapacity)
				throw new InvalidValueException("Бак будет переполнен");
			Fuel += fuelCount;
		}

	}
}
