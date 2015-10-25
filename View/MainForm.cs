using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model2;

namespace View
{ 
	public partial class MainForm : Form
	{
		/// <summary>
		/// Имя и путь текущего файла.
		/// </summary>
		public string OutputFilename = "";

		/// <summary>
		/// Список сущностей.
		/// </summary>
		private List<VehicleBase> _vehicleList = new List<VehicleBase>();

		/// <summary>
		/// Событие на статус измененности проекта
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public delegate void ProjectChangeHandler(object sender, ProjectChangeArgs e);
		public event ProjectChangeHandler ProjectChanged;

		private bool _isProjectChanged = false;
		
		public class ProjectChangeArgs
		{
			public bool IsProjectChanged;
		}

		public  bool IsProjectChanged
		{
			get { return _isProjectChanged; }
			set
			{
				if (_isProjectChanged == value)
					return;
				_isProjectChanged = value;
				if (ProjectChanged != null)
					ProjectChanged(this, new ProjectChangeArgs(){IsProjectChanged = value});
			}
		}

		/// <summary>
		/// Конструктор, принимающий на вход путь к открываемому файлу.
		/// </summary>
		/// <param name="file"></param>
		public MainForm(string[] file)
		{
			InitializeComponent();
			ProjectChanged += MainForm_ProjectChanged;
			if (file.Length == 1)
			{
				OutputFilename = file[0];
			}
		}

		/// <summary>
		/// Формирование заголовка и свойств кнопки сохранить в зависимости от наличия изменений в проекте.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void MainForm_ProjectChanged(object sender, MainForm.ProjectChangeArgs e)
		{
			if (e.IsProjectChanged)
			{
				if (OutputFilename == "")
					Text = "Новый проект* - Транспортные средства";
				else
					Text = OutputFilename.Substring(OutputFilename.LastIndexOf('\\') + 1)+"* - Транспортные средства";
				saveToolStripMenuItem.Enabled = true;
			}
			else
			{
				if (OutputFilename == "")
					Text = "Новый проект - Транспортные средства";
				else
					Text = OutputFilename.Substring(OutputFilename.LastIndexOf('\\') + 1) + " - Транспортные средства";
				saveToolStripMenuItem.Enabled = false;
			}
		}

		/// <summary>
		/// Открытие формы добавления объекта. В случае успеха - добавляет новый объект в список.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddObjectButton_Click(object sender, EventArgs e)
		{
			var newObjectForm=new ControlObjectForm(true);
			DialogResult dialogResult = newObjectForm.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				_vehicleList.Add(Data.VehicleItem);
				IsProjectChanged = true;
				RefreshTable();
			}
		}

		/// <summary>
		/// Обновление данных таблицы ListItemGrid.
		/// </summary>
		private void RefreshTable()
		{
			ListItemsGrid.Rows.Clear();
			foreach (VehicleBase vehicle in _vehicleList)
			{
				ListItemsGrid.Rows.Add(vehicle.ToString(),vehicle.Model, vehicle.TraversedPath, vehicle.Fuel);
			}
				showDetailInformation();
		}

		/// <summary>
		/// Кнопка удаления выбранного объекта из списка.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemoveObjectButton_Click(object sender, EventArgs e)
		{
			try
			{
				_vehicleList.RemoveAt(ListItemsGrid.CurrentRow.Index);
				IsProjectChanged = true;
			}
			catch (Exception)
			{
					MessageBox.Show("Список пуст или не выбрана строка!","Ошибка!",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
			}
			RefreshTable();
		}

		/// <summary>
		/// Изменение размера формы.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (Width < 510) 
				Width = 510;	
			if (Height < 531)
				Height = 531;
			ListGroup.Width = Width - 24;
			ListGroup.Height = Height - 263;
			ListItemsGrid.Width = Width - 46;
			ListItemsGrid.Height = Height -293;
		}

		/// <summary>
		/// Кнопка выхода.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			Close();
		}

		/// <summary>
		/// Сохранение файла.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (OutputFilename == "")
			{
				if (mainSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					OutputFilename = mainSaveFileDialog.FileName;
					SerializationManager.SaveConfigData(_vehicleList, OutputFilename);
					string safeName = mainSaveFileDialog.FileName;
					safeName = safeName.Substring(safeName.LastIndexOf('\\')+1);
					Text = safeName+" - Транспортные средства";
					IsProjectChanged = false;
				}
			}
			else
			{
				SerializationManager.SaveConfigData(_vehicleList, OutputFilename);
				IsProjectChanged = false;
			}
			
		}

		/// <summary>
		/// Открытие файла.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (IsProjectChanged)
			{
				var saveDialogResult = MessageBox.Show("Сохранить изменения перед открытием нового файла?", "Внимание",
					MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				switch (saveDialogResult)
				{
					case DialogResult.Yes:
						if (OutputFilename == "")
						{
							if (mainSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
							{
								OutputFilename = mainSaveFileDialog.FileName;
								SerializationManager.SaveConfigData(_vehicleList, OutputFilename);
								IsProjectChanged = false;
							}
							else
							{
								return;
							}
						}
						else
						{
							SerializationManager.SaveConfigData(_vehicleList, OutputFilename);
							IsProjectChanged = false;
						}
						break;
					case DialogResult.No:
						break;
					case DialogResult.Cancel:
						return;
				}
			}
			if (mainOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				OutputFilename = mainOpenFileDialog.FileName;
				try
				{
					_vehicleList = SerializationManager.LoadConfigData(OutputFilename);
					this.Text =  mainOpenFileDialog.SafeFileName + " - Транспортные средства";
					IsProjectChanged = false;
				}
				catch 
				{
					MessageBox.Show("Файл поврежден или имеет неверный формат!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					_vehicleList.Clear();
					this.Text = "Новый проект"+" - Транспортные средства";
					OutputFilename = "";
					IsProjectChanged = true;
				}
				
				RefreshTable();
				
			}
			
		}

		/// <summary>
		/// Кнопка меню сохранить как.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			if (mainSaveAsFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				string oldOutputFileName = OutputFilename;
				OutputFilename = mainSaveAsFileDialog.FileName;
				SerializationManager.SaveConfigData(_vehicleList, OutputFilename);
				OutputFilename = oldOutputFileName;

			}
		}

		/// <summary>
		/// Создание нового файла.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (IsProjectChanged)
			{
				var saveDialogResult = MessageBox.Show("Сохранить изменения перед созданием нового файла?", "Внимание",
					MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				switch (saveDialogResult)
				{
					case DialogResult.Yes:
						if (OutputFilename == "")
						{
							if (mainSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
							{
								OutputFilename = mainSaveFileDialog.FileName;
								SerializationManager.SaveConfigData(_vehicleList, OutputFilename);
								IsProjectChanged = false;
							}
							else
							{
								return;
							}
						}
						else
						{
							SerializationManager.SaveConfigData(_vehicleList, OutputFilename);
							IsProjectChanged = false;
						}
						break;
					case DialogResult.No:
						IsProjectChanged = false;
						break;
					case DialogResult.Cancel:
						return;
				}
			}
			_vehicleList.Clear();
			RefreshTable();
			this.Text = "Новый проект"+" - Транспортные средства";
			OutputFilename = "";
			IsProjectChanged = true;
		}

		/// <summary>
		/// Редкатирование выбранного объекта.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ModifyObjectButton_Click(object sender, EventArgs e)
		{
			try
			{
				Data.VehicleItem = _vehicleList[ListItemsGrid.CurrentRow.Index];
			}
			catch 
			{
				MessageBox.Show("Список пуст или не выбрана строка!", "Ошибка!",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			var modifyObjectForm=new ControlObjectForm(false);
			DialogResult dialogResult = modifyObjectForm.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				_vehicleList[ListItemsGrid.CurrentRow.Index] = Data.VehicleItem;
				IsProjectChanged = true;
				RefreshTable();
			}
		}

		/// <summary>
		/// О программе.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var aboutForm = new AboutProgramForm();
			aboutForm.ShowDialog();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{  
				if (IsProjectChanged)
				{
					var saveDialogResult = MessageBox.Show("Сохранить изменения перед выходом?", "Внимание",
						MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
					switch (saveDialogResult)
					{
						case DialogResult.Yes:
							if (OutputFilename == "")
							{
								if (mainSaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
								{
									OutputFilename = mainSaveFileDialog.FileName;
									SerializationManager.SaveConfigData(_vehicleList, OutputFilename);
									IsProjectChanged = false;
								}
								else
								{
									e.Cancel = true;
								}
							}
							else
							{
								SerializationManager.SaveConfigData(_vehicleList, OutputFilename);
								IsProjectChanged = false;
							}
							break;
						case DialogResult.No:
							break;
						case DialogResult.Cancel:
							e.Cancel = true;
							break;
					}
				}
			}
			
		}

		/// <summary>
		/// Файл справки.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void userGidToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("help.chm");
		}

		private void showDetailInformation()
		{
			if (_vehicleList.Count > 0)
				vehiclePropertyControl.Object = _vehicleList[ListItemsGrid.CurrentRow.Index];
			else
				vehiclePropertyControl.Clear();
		}

		/// <summary>
		/// Изменение детальной информации при клике строки.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ListItemsGrid_Click(object sender, EventArgs e)
		{
			showDetailInformation();
		}

		/// <summary>
		/// Загрузка начального файла или создание нового при старте.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Load(object sender, EventArgs e)
		{
			if (OutputFilename!="")
			{
				_vehicleList = SerializationManager.LoadConfigData(OutputFilename);
				Text = OutputFilename.Substring(OutputFilename.LastIndexOf('\\') + 1) + " - Транспортные средства";
				IsProjectChanged = false;
				RefreshTable();
			}
			else
			{
				IsProjectChanged = true;
			}
		}
	}
}
