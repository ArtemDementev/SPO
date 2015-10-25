namespace View
{
	partial class MainForm
	{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ListGroup = new System.Windows.Forms.GroupBox();
            this.ListItemsGrid = new System.Windows.Forms.DataGridView();
            this.TypeCoulumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraversedPathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FilePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainSaveAsFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.ModifyObjectButton = new System.Windows.Forms.Button();
            this.RemoveObjectButton = new System.Windows.Forms.Button();
            this.AddObjectButton = new System.Windows.Forms.Button();
            this.vehiclePropertyControl = new View.VehiclePropertyControl();
            this.ListGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListItemsGrid)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListGroup
            // 
            this.ListGroup.Controls.Add(this.ListItemsGrid);
            this.ListGroup.Location = new System.Drawing.Point(3, 27);
            this.ListGroup.Name = "ListGroup";
            this.ListGroup.Size = new System.Drawing.Size(481, 275);
            this.ListGroup.TabIndex = 0;
            this.ListGroup.TabStop = false;
            this.ListGroup.Text = "Список транспортных средств";
            // 
            // ListItemsGrid
            // 
            this.ListItemsGrid.AllowUserToAddRows = false;
            this.ListItemsGrid.AllowUserToDeleteRows = false;
            this.ListItemsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListItemsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ListItemsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListItemsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeCoulumn,
            this.ModelColumn,
            this.TraversedPathColumn,
            this.FuelColumn});
            this.ListItemsGrid.Location = new System.Drawing.Point(9, 24);
            this.ListItemsGrid.MultiSelect = false;
            this.ListItemsGrid.Name = "ListItemsGrid";
            this.ListItemsGrid.ReadOnly = true;
            this.ListItemsGrid.RowHeadersVisible = false;
            this.ListItemsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListItemsGrid.Size = new System.Drawing.Size(466, 245);
            this.ListItemsGrid.TabIndex = 0;
            this.ListItemsGrid.Click += new System.EventHandler(this.ListItemsGrid_Click);
            // 
            // TypeCoulumn
            // 
            this.TypeCoulumn.HeaderText = "Тип транспорта";
            this.TypeCoulumn.Name = "TypeCoulumn";
            this.TypeCoulumn.ReadOnly = true;
            this.TypeCoulumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TypeCoulumn.Width = 120;
            // 
            // ModelColumn
            // 
            this.ModelColumn.HeaderText = "Модель";
            this.ModelColumn.Name = "ModelColumn";
            this.ModelColumn.ReadOnly = true;
            this.ModelColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ModelColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ModelColumn.Width = 130;
            // 
            // TraversedPathColumn
            // 
            this.TraversedPathColumn.HeaderText = "Пройденный путь";
            this.TraversedPathColumn.Name = "TraversedPathColumn";
            this.TraversedPathColumn.ReadOnly = true;
            this.TraversedPathColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TraversedPathColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TraversedPathColumn.Width = 90;
            // 
            // FuelColumn
            // 
            this.FuelColumn.HeaderText = "Топливо";
            this.FuelColumn.Name = "FuelColumn";
            this.FuelColumn.ReadOnly = true;
            this.FuelColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FuelColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FuelColumn.Width = 70;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilePageToolStripMenuItem,
            this.helpPageToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(488, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // FilePageToolStripMenuItem
            // 
            this.FilePageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FilePageToolStripMenuItem.Name = "FilePageToolStripMenuItem";
            this.FilePageToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FilePageToolStripMenuItem.Text = "Файл";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newFileToolStripMenuItem.Text = "Новый";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.openFileToolStripMenuItem.Text = "Открыть";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveAsToolStripMenuItem.Text = "Сохранить как...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpPageToolStripMenuItem
            // 
            this.helpPageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGidToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpPageToolStripMenuItem.Name = "helpPageToolStripMenuItem";
            this.helpPageToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpPageToolStripMenuItem.Text = "Помощь";
            // 
            // userGidToolStripMenuItem
            // 
            this.userGidToolStripMenuItem.Name = "userGidToolStripMenuItem";
            this.userGidToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.userGidToolStripMenuItem.Text = "Справка";
            this.userGidToolStripMenuItem.Click += new System.EventHandler(this.userGidToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainOpenFileDialog
            // 
            this.mainOpenFileDialog.DefaultExt = "vlf";
            this.mainOpenFileDialog.Filter = " VehicleList Files|*.vlf";
            this.mainOpenFileDialog.Tag = "";
            this.mainOpenFileDialog.Title = "Открыть файл";
            // 
            // mainSaveFileDialog
            // 
            this.mainSaveFileDialog.DefaultExt = "vlf";
            this.mainSaveFileDialog.FileName = "project1";
            this.mainSaveFileDialog.Filter = " VehicleList Files|*.vlf";
            this.mainSaveFileDialog.Title = "Сохранить";
            // 
            // mainSaveAsFileDialog
            // 
            this.mainSaveAsFileDialog.DefaultExt = "vlf";
            this.mainSaveAsFileDialog.Filter = " VehicleList Files|*.vlf";
            this.mainSaveAsFileDialog.Title = "Сохранить как...";
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlPanel.Controls.Add(this.ModifyObjectButton);
            this.ControlPanel.Controls.Add(this.RemoveObjectButton);
            this.ControlPanel.Controls.Add(this.AddObjectButton);
            this.ControlPanel.Location = new System.Drawing.Point(3, 459);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(479, 33);
            this.ControlPanel.TabIndex = 6;
            // 
            // ModifyObjectButton
            // 
            this.ModifyObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ModifyObjectButton.Location = new System.Drawing.Point(144, 7);
            this.ModifyObjectButton.Name = "ModifyObjectButton";
            this.ModifyObjectButton.Size = new System.Drawing.Size(120, 23);
            this.ModifyObjectButton.TabIndex = 3;
            this.ModifyObjectButton.Text = "Редактировать";
            this.ModifyObjectButton.UseVisualStyleBackColor = true;
            this.ModifyObjectButton.Click += new System.EventHandler(this.ModifyObjectButton_Click);
            // 
            // RemoveObjectButton
            // 
            this.RemoveObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveObjectButton.Location = new System.Drawing.Point(351, 7);
            this.RemoveObjectButton.Name = "RemoveObjectButton";
            this.RemoveObjectButton.Size = new System.Drawing.Size(120, 23);
            this.RemoveObjectButton.TabIndex = 2;
            this.RemoveObjectButton.Text = "Удалить объект";
            this.RemoveObjectButton.UseVisualStyleBackColor = true;
            this.RemoveObjectButton.Click += new System.EventHandler(this.RemoveObjectButton_Click);
            // 
            // AddObjectButton
            // 
            this.AddObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddObjectButton.Location = new System.Drawing.Point(9, 7);
            this.AddObjectButton.Name = "AddObjectButton";
            this.AddObjectButton.Size = new System.Drawing.Size(120, 23);
            this.AddObjectButton.TabIndex = 1;
            this.AddObjectButton.Text = "Добавить объект";
            this.AddObjectButton.UseVisualStyleBackColor = true;
            this.AddObjectButton.Click += new System.EventHandler(this.AddObjectButton_Click);
            // 
            // vehiclePropertyControl
            // 
            this.vehiclePropertyControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehiclePropertyControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehiclePropertyControl.Location = new System.Drawing.Point(12, 302);
            this.vehiclePropertyControl.Name = "vehiclePropertyControl";
            this.vehiclePropertyControl.Object = ((Model2.VehicleBase)(resources.GetObject("vehiclePropertyControl.Object")));
            this.vehiclePropertyControl.ReadOnly = true;
            this.vehiclePropertyControl.Size = new System.Drawing.Size(466, 151);
            this.vehiclePropertyControl.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 492);
            this.Controls.Add(this.vehiclePropertyControl);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.ListGroup);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Транспортные средства";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ListGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListItemsGrid)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox ListGroup;
		private System.Windows.Forms.DataGridView ListItemsGrid;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem FilePageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpPageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem userGidToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog mainOpenFileDialog;
		private System.Windows.Forms.SaveFileDialog mainSaveFileDialog;
		private System.Windows.Forms.SaveFileDialog mainSaveAsFileDialog;
		private System.Windows.Forms.DataGridViewTextBoxColumn TypeCoulumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ModelColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TraversedPathColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn FuelColumn;
		private System.Windows.Forms.Panel ControlPanel;
		private System.Windows.Forms.Button ModifyObjectButton;
		private System.Windows.Forms.Button RemoveObjectButton;
		private System.Windows.Forms.Button AddObjectButton;
		private VehiclePropertyControl vehiclePropertyControl;
	}
}

