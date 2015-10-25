using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting;
using Model2;

namespace ConsoleLoader
{
	class Program
	{
		
		static void Main(string[] args)
		{
			var moto = new Motorcycle();
			var car = new Car();
			var yacht = new Yacht();
			VehicleBase item=moto;
			int key=0;
			var success = false;

			//Вводим данные мотоцикла
			Console.WriteLine("Мотоцикл");
			Console.Write("Введите модель: ");
			while (!success)
			{
				try
				{
					moto.Model = Console.ReadLine();
					if (moto.Model.Any(t => t<0 || t>200))
					{
                        throw new InvalidValueException("Строка не может быть пустой");
					}
					success = true;
				}
                catch (InvalidValueException e)
				{
					Console.WriteLine(e.Message);
				}
			}
			Console.Write("Введите количество топлива: ");
			success = false;
			while (!success)
			{
				try
				{
					moto.Fuel = Convert.ToDouble(Console.ReadLine());
					success = true;
				}
				catch
				{
					Console.WriteLine("Значение не может быть пустым, отрицательным или большем 24. Так же ввод символов не допускается");
				}
			}

			Console.Write("Введите Пройденный путь: ");
			success = false;
			while (!success)
			{
				try
				{
					moto.TraversedPath = Convert.ToDouble(Console.ReadLine());
					success = true;
				}
				catch
				{
					Console.WriteLine("Значение не может быть пустым или отрицательным. Так же ввод символов не допускается");
				}
			}
			Console.Write("Приреплена коляска? Y/N: ");
			var temp = Console.ReadLine();
			if (temp == "Y" || temp == "y" || temp == "Yes")
				moto.Stroller = true;
            Console.Clear();

			//Вводим данные машины
			Console.WriteLine("");
			success = false;
			Console.WriteLine("Автомобиль");
			Console.Write("Введите модель: ");
			while (!success)
			{
				try
				{
					car.Model = Console.ReadLine();
					success = true;
				}
				catch
				{
					Console.WriteLine("Строка не может быть пустой");
				}
			}
			Console.Write("Введите количество топлива: ");
			success = false;
			while (!success)
			{
				try
				{
					car.Fuel = Convert.ToDouble(Console.ReadLine());
					success = true;
				}
				catch
				{
					Console.WriteLine("Значение не может быть пустым, отрицательным или большем 40. Так же ввод символов не допускается");
				}
			}

			Console.Write("Введите Пройденный путь: ");
			success = false;
			while (!success)
			{
				try
				{
					car.TraversedPath = Convert.ToDouble(Console.ReadLine());
					success = true;
				}
				catch
				{
					Console.WriteLine("Значение не может быть пустым,отрицательным или вещественным. Так же ввод символов не допускается");
				}
			}
			Console.Write("Приреплен прицеп? Y/N: ");
			temp = Console.ReadLine();
			if (temp == "Y" || temp == "y" || temp == "Yes")
				car.Trailer = true;

            Console.Clear();
			//Вводим данные яхты
			Console.WriteLine("");
			success = false;
			Console.WriteLine("Яхта");
			Console.Write("Введите модель: ");
			while (!success)
			{
				try
				{
					yacht.Model = Console.ReadLine();
					success = true;
				}
				catch
				{
					Console.WriteLine("Строка не может быть пустой");
				}
			}
			Console.Write("Введите количество топлива: ");
			success = false;
			while (!success)
			{
				try
				{
					yacht.Fuel = Convert.ToDouble(Console.ReadLine());
					success = true;
				}
				catch
				{
					Console.WriteLine("Значение не может быть пустым, отрицательным или большем 100. Так же ввод символов не допускается");
				}
			}

			Console.Write("Введите Пройденный путь: ");
			success = false;
			while (!success)
			{
				try
				{
					yacht.TraversedPath = Convert.ToDouble(Console.ReadLine());
					success = true;
				}
				catch
				{
					Console.WriteLine("Значение не может быть пустым или отрицательным. Так же ввод символов не допускается");
				}
			}
			Console.Write("Введите количество палуб: ");
			success = false;
			while (!success)
			{
				try
				{
					yacht.DecksCount = Convert.ToInt32(Console.ReadLine());
					success = true;
				}
				catch
				{
					Console.WriteLine("Значение не может быть пустым или отрицательным. Так же ввод символов не допускается");
				}
			}

			

			Console.Clear();
			while (key != 6)
			{
				Console.WriteLine("-------");
				Console.WriteLine(item.ToString());
				Console.WriteLine("-------");

				Console.WriteLine("-------");
				Console.WriteLine("1.Выбрать мотоцикл");
				Console.WriteLine("2.Выбрать машину");
				Console.WriteLine("3.Выбрать яхту");
				Console.WriteLine("4.Проехать");
				Console.WriteLine("5.Заправиться");
				Console.WriteLine("6.Выход");
				Console.WriteLine("-------");
                Console.WriteLine("");
                Console.WriteLine("");
				try
				{
					key = Convert.ToInt32(Console.ReadLine());
					if (key < 1 || key > 6)
                        throw new InvalidValueException("Неверное значение!");
				}
                catch (InvalidValueException e)
				{
					Console.WriteLine(e.Message);
				}
				
				switch ((Menu)key)
				{
					case Menu.ChooseMoto:
						item = moto;
						break;
					case Menu.ChooseCar:
						item = car;
						break;
					case Menu.ChooseYacht:
						item = yacht;
						break;
					case Menu.MoveVehicle:
						item.Move();
						break;
					case Menu.FillVehicle:
						item.Fill(1);
						break;
				}
			}
		}
	}
}
