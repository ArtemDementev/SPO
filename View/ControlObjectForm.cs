using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model2;

namespace View
{
	public partial class ControlObjectForm : Form
	{
		public ControlObjectForm(bool newObject)
		{
			InitializeComponent();
			if (!newObject)
			{
				Text = "Редактирование объекта";
				OkButton.Text = "Сохранить";
				vehiclePropertyControl.Object = Data.VehicleItem;
			}
			else
			{
				Text = "Добавление объекта";
				OkButton.Text = "Добавить";
				vehiclePropertyControl.Clear();
			}
		}

		/// <summary>
		/// Кнопка выхода.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CancellButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Кнопка добавления/сохранения.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OkButton_Click(object sender, EventArgs e)
		{
			try
			{
				Data.VehicleItem = vehiclePropertyControl.Object;
			}
			catch (InvalidValueException ee)
			{
				MessageBox.Show(ee.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			catch (InsufficientFuelException ee)
			{
				MessageBox.Show(ee.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DialogResult = DialogResult.OK;
		}
	}
}
