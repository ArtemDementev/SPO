using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model2;

namespace View
{

	public partial class VehiclePropertyControl : UserControl
	{
		public VehiclePropertyControl()
		{
			InitializeComponent();
			ItemTypeComboBox.SelectedIndex = 0;
			Clear();
		}

		/// <summary>
		/// Объект, хранимый данным элементом управления.
		/// </summary>
		public VehicleBase Object
		{
			get
			{
				if (ModelTextBox.Text == "")
					throw new InvalidValueException("Поле Модель не может быть пустым!");
				if (ItemTypeComboBox.SelectedIndex==-1)
					throw new InvalidValueException("Не выбран тип объекта!");
				switch ((ItemsName)ItemTypeComboBox.SelectedIndex)
				{
					default:
						var itemMoto = new Motorcycle();
						itemMoto.Model = ModelTextBox.Text;
						itemMoto.TraversedPath = Convert.ToDouble(TraversedPathNumUpDown.Value);
						itemMoto.Fuel = Convert.ToDouble(FuelNumUpDown.Value);
						itemMoto.Stroller = HitchedItemCheckBox.Checked;
						return itemMoto;
					case ItemsName.Car:
						var itemCar = new Car();
						itemCar.Model = ModelTextBox.Text;
						itemCar.TraversedPath = Convert.ToDouble(TraversedPathNumUpDown.Value);
						itemCar.Fuel = Convert.ToDouble(FuelNumUpDown.Value);
						itemCar.Trailer = HitchedItemCheckBox.Checked;
						return itemCar;
					case ItemsName.Yacht:
						var itemYacht = new Yacht();
						itemYacht.Model = ModelTextBox.Text;
						itemYacht.TraversedPath = Convert.ToDouble(TraversedPathNumUpDown.Value);
						itemYacht.Fuel = Convert.ToDouble(FuelNumUpDown.Value);
						itemYacht.DecksCount = Convert.ToInt32(DecksNumUpDown.Value);
						return itemYacht;
				}
			}
			set
			{
				ItemTypeComboBox.Enabled = false;
				switch (value.ToString())
				{
					case "Мотоцикл":
						ItemTypeComboBox.SelectedIndex = 0;
						var motorcycleItem = (Motorcycle)value;
						ModelTextBox.Text = motorcycleItem.Model;
						TraversedPathNumUpDown.Value = Convert.ToDecimal(motorcycleItem.TraversedPath);
						FuelNumUpDown.Value = (decimal)motorcycleItem.Fuel;
						if (motorcycleItem.Stroller)
							HitchedItemCheckBox.Checked = true;
						break;
					case "Машина":
						ItemTypeComboBox.SelectedIndex = 1;
						var carItem = (Car)value;
						ModelTextBox.Text = carItem.Model;
						TraversedPathNumUpDown.Value = Convert.ToDecimal(carItem.TraversedPath);
						FuelNumUpDown.Value = (decimal)carItem.Fuel;
						HitchedItemCheckBox.Text = "Прицеп";
						if (carItem.Trailer)
							HitchedItemCheckBox.Checked = true;
						break;
					case "Яхта":
						ItemTypeComboBox.SelectedIndex = 2;
						var yachtItem = (Yacht)value;
						ModelTextBox.Text = yachtItem.Model;
						TraversedPathNumUpDown.Value = Convert.ToDecimal(yachtItem.TraversedPath);
						FuelNumUpDown.Value = (decimal)yachtItem.Fuel;
						HitchedItemCheckBox.Visible = false;
						DecksNumLabel.Visible = true;
						DecksNumUpDown.Visible = true;
						DecksNumUpDown.Value = yachtItem.DecksCount;
						break;
				}

			}
		}

		/// <summary>
		/// Поле, показывающее, может ли пользователь изменять данные элемента управления.
		/// </summary>
		private bool _readOnly = false;

		/// <summary>
		/// Задает, может ли пользователь изенять содержимое элемента управления.
		/// </summary>
		public bool ReadOnly
		{
			get { return _readOnly; }
			set
			{
				if (value)
				{
					ItemTypeComboBox.Enabled = false;
					ModelTextBox.Enabled = false;
					TraversedPathNumUpDown.Enabled = false;
					FuelNumUpDown.Enabled = false;
					HitchedItemCheckBox.Enabled = false;
					DecksNumUpDown.Enabled = false;
				}
				else
				{
					ItemTypeComboBox.Enabled = true;
					ModelTextBox.Enabled = true;
					TraversedPathNumUpDown.Enabled = true;
					FuelNumUpDown.Enabled = true;
					HitchedItemCheckBox.Enabled = true;
					DecksNumUpDown.Enabled = true;
				}
				_readOnly = value;
			}
		}
		/// <summary>
		/// Изменение полей под выбранный тип объекта.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ItemTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			HitchedItemCheckBox.Checked = false;
			HitchedItemCheckBox.Visible = false;
			DecksNumLabel.Visible = false;
			DecksNumUpDown.Visible = false;
			switch ((ItemsName)ItemTypeComboBox.SelectedIndex)
			{
				case ItemsName.Motorcycle:
					HitchedItemCheckBox.Text = "Боковой прицеп";
					HitchedItemCheckBox.Visible = true;
					break;
				case ItemsName.Car:
					HitchedItemCheckBox.Text = "Прицеп";
					HitchedItemCheckBox.Visible = true;
					break;
				case ItemsName.Yacht:
					DecksNumLabel.Visible = true;
					DecksNumUpDown.Visible = true;
					break;
			}
		}

		/// <summary>
		/// Запрет на ввод некоректных символов.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ModelTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != Convert.ToChar(8) && e.KeyChar != ' ')
				e.Handled = true;
		}

		/// <summary>
		/// Проверка значения после потери фокуса.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ModelTextBox_Leave(object sender, EventArgs e)
		{
			ModelTextBox.BackColor = Color.White;
			if (ModelTextBox.Text == "")
				return;

			if (ModelTextBox.Text.Any(t => !Char.IsLetterOrDigit(t) && t != '-' && t != ' '))
			{
				ModelTextBox.BackColor = Color.Red;
				
			}
			//Проверка на некорректные дефисы
			if (ModelTextBox.Text.First() == '-' || ModelTextBox.Text.Last() == '-')
			{
				ModelTextBox.BackColor = Color.Red;
			}
			int count = 0;
			for (int i = 0; i < ModelTextBox.Text.Length; i++)
			{
				if (ModelTextBox.Text[i] == '-')
				{
					count++;
					if (count > 1)
					{
						ModelTextBox.BackColor = Color.Red;
					}
				}

				else
					count = 0;
			}
			//Проверка на некорректные пробелы
			if (ModelTextBox.Text.First() == ' ' || ModelTextBox.Text.Last() == ' ')
			{
				ModelTextBox.BackColor = Color.Red;
			}
			for (int i = 0; i < ModelTextBox.Text.Length; i++)
			{
				if (ModelTextBox.Text[i] == ' ')
				{
					count++;
					if (count > 1)
					{
						ModelTextBox.BackColor = Color.Red;
					}
				}

				else
					count = 0;
			}
		}

		

		/// <summary>
		/// Запрет на ввод неправильного значения топлива.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FuelNumUpDown_ValueChanged(object sender, EventArgs e)
		{
			switch ((ItemsName)ItemTypeComboBox.SelectedIndex)
			{
				case ItemsName.Motorcycle:
					if (FuelNumUpDown.Value > 24)
					{
						MessageBox.Show("Вместимость бака - 24 единицы", "Неккоректные данные!");
						FuelNumUpDown.Value = 24;
					}
					break;
				case ItemsName.Car:
					if (FuelNumUpDown.Value > 40)
					{
						MessageBox.Show("Вместимость бака - 40 единиц", "Неккоректные данные!");
						FuelNumUpDown.Value = 40;
					}
					break;
				case ItemsName.Yacht:
					if (FuelNumUpDown.Value > 100)
					{
						MessageBox.Show("Вместимость бака - 100 единиц", "Неккоректные данные!");
						FuelNumUpDown.Value = 100;
					}
					break;
			}
		}

		/// <summary>
		/// Запрет на ввод неправильного количества палуб.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DecksNumUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (DecksNumUpDown.Value > 10)
			{
				MessageBox.Show("Не может быть больше 10 палуб!", "Неккоректные данные!");
				DecksNumUpDown.Value = 10;
			}
		}

		/// <summary>
		/// Очищение контрола.
		/// </summary>
		public void Clear()
		{
			ModelTextBox.Text = "";
			TraversedPathNumUpDown.Value = 0;
			FuelNumUpDown.Value = 0;
			HitchedItemCheckBox.Checked = false;
			DecksNumUpDown.Value = 0;
			ItemTypeComboBox.SelectedIndex = -1;
		}
	}
}
