using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model2;
using NUnit.Framework;

namespace UnitTest
{
	/// <summary>
	/// Набор тестов для класса Motorcycle
	/// </summary>
	[TestFixture]
    public class MotorcycleTest
    {
		/// <summary>
		/// Тестирование свойства Fuel 
		/// </summary>
		[Test]
		[TestCase(24,TestName = "Тест: Присваивание в Fuel положительного числа")]
		[TestCase(0, TestName = "Тест: Присваивание в Fuel 0 ")]
		[TestCase(23.4, TestName = "Тест: Присваивание в Fuel 23,4")]
		[TestCase(-1, ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание в Fuel отрицательного значения -1")]
		[TestCase(25, ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание в Fuel числа, выходящего за интервал - 25 ")]
		public void FuelTest(double fuel)
		{
			var item = new Motorcycle();
			item.Fuel = fuel;
		}

		/// <summary>
		/// Тестирование свойства Traversed Path
		/// </summary>
		[Test]
		[TestCase(41, TestName = "Тест: Присваивание в TPath положительного числа - 41")]
		[TestCase(0, TestName = "Тест: Присваивание в TPath 0")]
		[TestCase(23.4, TestName = "Тест: Присваивание в TPath дробного числа - 23,4")]
		[TestCase(double.MaxValue, TestName = "Тест: Присваивание в TPath double.MaxValue")]
		[TestCase(-1, ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание в TPath -1")]
		public void TraversedPathTest(double path)
		{
			var item = new Motorcycle();
			item.TraversedPath = path;
		}

		/// <summary>
		/// Тестирование свойства Model
		/// </summary>
		[Test]
		[TestCase("Mazda RX-8", TestName="Тест: Присваивание корректной строки")]
		[TestCase("", ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание пустой строки")]
		[TestCase(null, ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание null")]
		[TestCase("-Mazda RX-8",ExpectedException = typeof(InvalidValueException),TestName="Тест: Присваивание строки с дефисом в начале")]
		[TestCase("Mazda RX-8-",ExpectedException = typeof(InvalidValueException),TestName="Тест: Присваивание строки с дефисом в конце")]
		[TestCase("Mazda RX--8",ExpectedException = typeof(InvalidValueException),TestName="Тест: Присваивание строки с двумя дефисами подряд")]
		[TestCase(" Mazda RX-8", ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание строки с пробелом в начале")]
		[TestCase("Mazda RX-8 ", ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание строки с пробелом в конце")]
		[TestCase("Mazda  RX-8", ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание строки с двумя пробелами подряд")]
		[TestCase("Mazda RX-8,?", ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание строки с некорректными символами")]
		public void ModelTest(string model)
		{
			var item = new Motorcycle();
			item.Model = model;
		}

		/// <summary>
		/// Тестирование метода Move()
		/// </summary>
		[Test]
		[TestCase(10,TestName = "Тест: Достаточное количество топлива - 20")]
		[TestCase(1, TestName = "Тест: Достаточное количество топлива граничное - 1")]
		[TestCase(0, ExpectedException = typeof(InsufficientFuelException), TestName = "Тест: Недостаточное количество топлива - 0")]
		public void MoveTest(double fuel)
		{
			var item = new Motorcycle();
			item.Fuel = fuel;
			item.Move();
		}

		/// <summary>
		/// Тестирование метода Fill()
		/// </summary>
		[Test]
		[TestCase(0,12.5,TestName = "Тест заправка на 12.5 единиц")]
		[TestCase(0, 24, TestName = "Тест заправка на 24 единицы")]
		[TestCase(20, 12.5,ExpectedException = typeof(InvalidValueException), TestName = "Тест на переполнение бака")]
		[TestCase(20, -15, ExpectedException = typeof(InvalidValueException), TestName = "Тест на заправку отрицательного кол-ва топлива")]
		public void Filltest(double fuel,double fuelCount)
		{
			var item = new Motorcycle();
			item.Fuel = fuel;
			item.Fill(fuelCount);
		}
    }
}
