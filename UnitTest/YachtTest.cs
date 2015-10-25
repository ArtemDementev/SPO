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
	/// Набор тестов для тестирования класса Car
	/// </summary>
	[TestFixture]
	class YachtTest
	{
		/// <summary>
		/// Тестирование свойства Fuel 
		/// </summary>
		[Test]
		[TestCase(100, TestName = "Тест: Присваивание в Fuel положительного числа")]
		[TestCase(0, TestName = "Тест: Присваивание в Fuel 0 ")]
		[TestCase(83.4, TestName = "Тест: Присваивание в Fuel 83,4")]
		[TestCase(-1, ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание в Fuel отрицательного значения -1")]
		[TestCase(100.4, ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание в Fuel числа, выходящего за интервал - 100.4 ")]
		public void FuelTest(double fuel)
		{
			var item = new Yacht();
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
			var item = new Yacht();
			item.TraversedPath = path;
		}

		/// <summary>
		/// Тестирование свойства Model
		/// </summary>
		[Test]
		[TestCase("Mazda RX-8", TestName = "Тест: Присваивание корректной строки")]
		[TestCase("", ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание пустой строки")]
		[TestCase(null, ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание null")]
		[TestCase("-Mazda RX-8", ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание строки с дефисом в начале")]
		[TestCase("ВАЗ RX-8-", ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание строки с дефисом в конце")]
		[TestCase("Mazda RX--8", ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание строки с двумя дефисами подряд")]
		[TestCase(" Mazda RX-8", ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание строки с пробелом в начале")]
		[TestCase("Mazda RX-8 ", ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание строки с пробелом в конце")]
		[TestCase("Mazda  RX-8", ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание строки с двумя пробелами подряд")]
		[TestCase("Mazda RX-8,?", ExpectedException = typeof(InvalidValueException), TestName = "Тест: Присваивание строки с некорректными символами")]
		public void ModelTest(string model)
		{
			var item = new Yacht();
			item.Model = model;
		}

		/// <summary>
		/// Тестирование метода Move()
		/// </summary>
		[Test]
		[TestCase(15, TestName = "Тест: Достаточное количество топлива - 20")]
		[TestCase(10, TestName = "Тест: Достаточное количество топлива граничное - 1")]
		[TestCase(3, ExpectedException = typeof(InsufficientFuelException), TestName = "Тест: Недостаточное количество топлива - 3")]
		public void MoveTest(double fuel)
		{
			var item = new Yacht();
			item.Fuel = fuel;
			item.Move();
		}

		/// <summary>
		/// Тестирование метода Fill()
		/// </summary>
		[Test]
		[TestCase(0, 12.5, TestName = "Тест заправка на 12.5 единиц")]
		[TestCase(0, 100, TestName = "Тест заправка на 100 единицы")]
		[TestCase(35, 120.5, ExpectedException = typeof(InvalidValueException), TestName = "Тест на переполнение бака")]
		[TestCase(20, -15, ExpectedException = typeof(InvalidValueException), TestName = "Тест на заправку отрицательного кол-ва топлива")]
		public void Filltest(double fuel, double fuelCount)
		{
			var item = new Yacht();
			item.Fuel = fuel;
			item.Fill(fuelCount);
		}

		/// <summary>
		/// Тестирование свойства DecsCount
		/// </summary>
		[Test]
		[TestCase(6, TestName = "Тест: Присваивание положительного числа палуб")]
		[TestCase(0, TestName = "Тест: Присваивание нулевого количества палуб")]
		[TestCase(-1,ExpectedException = typeof(InvalidValueException),TestName = "Тест: Присваивание отрицательного числа палуб")]
		[TestCase(11, ExpectedException = typeof(InvalidValueException),TestName = "Тест: Присваивание невозможного количества палуб - 11")]
		public void DecsCountTest(int count)
		{
			var item = new Yacht();
			item.DecksCount = count;
		}
	}
}
