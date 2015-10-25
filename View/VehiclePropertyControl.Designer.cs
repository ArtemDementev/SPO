namespace View
{
	partial class VehiclePropertyControl
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

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Обязательный метод для поддержки конструктора - не изменяйте 
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.ObjectPropertyBox = new System.Windows.Forms.GroupBox();
            this.TraversedPathNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.FuelErrorLabel = new System.Windows.Forms.Label();
            this.ItemTypeLabel = new System.Windows.Forms.Label();
            this.DecksNumLabel = new System.Windows.Forms.Label();
            this.ItemTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DecksNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.TraversedPathLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.FuelNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.HitchedItemCheckBox = new System.Windows.Forms.CheckBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.FuelLabel = new System.Windows.Forms.Label();
            this.ObjectPropertyBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TraversedPathNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecksNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjectPropertyBox
            // 
            this.ObjectPropertyBox.Controls.Add(this.TraversedPathNumUpDown);
            this.ObjectPropertyBox.Controls.Add(this.FuelErrorLabel);
            this.ObjectPropertyBox.Controls.Add(this.ItemTypeLabel);
            this.ObjectPropertyBox.Controls.Add(this.DecksNumLabel);
            this.ObjectPropertyBox.Controls.Add(this.ItemTypeComboBox);
            this.ObjectPropertyBox.Controls.Add(this.DecksNumUpDown);
            this.ObjectPropertyBox.Controls.Add(this.TraversedPathLabel);
            this.ObjectPropertyBox.Controls.Add(this.ModelLabel);
            this.ObjectPropertyBox.Controls.Add(this.FuelNumUpDown);
            this.ObjectPropertyBox.Controls.Add(this.HitchedItemCheckBox);
            this.ObjectPropertyBox.Controls.Add(this.ModelTextBox);
            this.ObjectPropertyBox.Controls.Add(this.FuelLabel);
            this.ObjectPropertyBox.Location = new System.Drawing.Point(4, 5);
            this.ObjectPropertyBox.Name = "ObjectPropertyBox";
            this.ObjectPropertyBox.Size = new System.Drawing.Size(471, 136);
            this.ObjectPropertyBox.TabIndex = 1;
            this.ObjectPropertyBox.TabStop = false;
            this.ObjectPropertyBox.Text = "Свойства объекта";
            // 
            // TraversedPathNumUpDown
            // 
            this.TraversedPathNumUpDown.DecimalPlaces = 1;
            this.TraversedPathNumUpDown.Location = new System.Drawing.Point(24, 103);
            this.TraversedPathNumUpDown.Name = "TraversedPathNumUpDown";
            this.TraversedPathNumUpDown.Size = new System.Drawing.Size(120, 20);
            this.TraversedPathNumUpDown.TabIndex = 13;
            // 
            // FuelErrorLabel
            // 
            this.FuelErrorLabel.AutoSize = true;
            this.FuelErrorLabel.Location = new System.Drawing.Point(315, 105);
            this.FuelErrorLabel.Name = "FuelErrorLabel";
            this.FuelErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.FuelErrorLabel.TabIndex = 12;
            // 
            // ItemTypeLabel
            // 
            this.ItemTypeLabel.AutoSize = true;
            this.ItemTypeLabel.Location = new System.Drawing.Point(21, 34);
            this.ItemTypeLabel.Name = "ItemTypeLabel";
            this.ItemTypeLabel.Size = new System.Drawing.Size(157, 13);
            this.ItemTypeLabel.TabIndex = 9;
            this.ItemTypeLabel.Text = "Тип транспортного средства:";
            // 
            // DecksNumLabel
            // 
            this.DecksNumLabel.AutoSize = true;
            this.DecksNumLabel.Location = new System.Drawing.Point(348, 87);
            this.DecksNumLabel.Name = "DecksNumLabel";
            this.DecksNumLabel.Size = new System.Drawing.Size(101, 13);
            this.DecksNumLabel.TabIndex = 8;
            this.DecksNumLabel.Text = "Количество палуб:";
            this.DecksNumLabel.Visible = false;
            // 
            // ItemTypeComboBox
            // 
            this.ItemTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemTypeComboBox.FormattingEnabled = true;
            this.ItemTypeComboBox.Items.AddRange(new object[] {
            "Мотоцикл",
            "Машина",
            "Яхта"});
            this.ItemTypeComboBox.Location = new System.Drawing.Point(24, 50);
            this.ItemTypeComboBox.Name = "ItemTypeComboBox";
            this.ItemTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ItemTypeComboBox.TabIndex = 0;
            this.ItemTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemTypeComboBox_SelectedIndexChanged);
            // 
            // DecksNumUpDown
            // 
            this.DecksNumUpDown.Location = new System.Drawing.Point(351, 103);
            this.DecksNumUpDown.Name = "DecksNumUpDown";
            this.DecksNumUpDown.Size = new System.Drawing.Size(50, 20);
            this.DecksNumUpDown.TabIndex = 7;
            this.DecksNumUpDown.Visible = false;
            this.DecksNumUpDown.ValueChanged += new System.EventHandler(this.DecksNumUpDown_ValueChanged);
            // 
            // TraversedPathLabel
            // 
            this.TraversedPathLabel.AutoSize = true;
            this.TraversedPathLabel.Location = new System.Drawing.Point(22, 85);
            this.TraversedPathLabel.Name = "TraversedPathLabel";
            this.TraversedPathLabel.Size = new System.Drawing.Size(99, 13);
            this.TraversedPathLabel.TabIndex = 3;
            this.TraversedPathLabel.Text = "Пройденный путь:";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(186, 35);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(49, 13);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Модель:";
            // 
            // FuelNumUpDown
            // 
            this.FuelNumUpDown.DecimalPlaces = 1;
            this.FuelNumUpDown.Location = new System.Drawing.Point(189, 103);
            this.FuelNumUpDown.Name = "FuelNumUpDown";
            this.FuelNumUpDown.Size = new System.Drawing.Size(120, 20);
            this.FuelNumUpDown.TabIndex = 4;
            this.FuelNumUpDown.ValueChanged += new System.EventHandler(this.FuelNumUpDown_ValueChanged);
            // 
            // HitchedItemCheckBox
            // 
            this.HitchedItemCheckBox.AutoSize = true;
            this.HitchedItemCheckBox.Location = new System.Drawing.Point(351, 101);
            this.HitchedItemCheckBox.Name = "HitchedItemCheckBox";
            this.HitchedItemCheckBox.Size = new System.Drawing.Size(108, 17);
            this.HitchedItemCheckBox.TabIndex = 6;
            this.HitchedItemCheckBox.Text = "Боковой прицеп";
            this.HitchedItemCheckBox.UseVisualStyleBackColor = true;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(189, 51);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(153, 20);
            this.ModelTextBox.TabIndex = 0;
            this.ModelTextBox.Text = "Введите модель";
            this.ModelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModelTextBox_KeyPress);
            this.ModelTextBox.Leave += new System.EventHandler(this.ModelTextBox_Leave);
            // 
            // FuelLabel
            // 
            this.FuelLabel.AutoSize = true;
            this.FuelLabel.Location = new System.Drawing.Point(186, 87);
            this.FuelLabel.Name = "FuelLabel";
            this.FuelLabel.Size = new System.Drawing.Size(53, 13);
            this.FuelLabel.TabIndex = 5;
            this.FuelLabel.Text = "Топливо:";
            // 
            // VehiclePropertyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ObjectPropertyBox);
            this.Name = "VehiclePropertyControl";
            this.Size = new System.Drawing.Size(478, 151);
            this.ObjectPropertyBox.ResumeLayout(false);
            this.ObjectPropertyBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TraversedPathNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecksNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelNumUpDown)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox ObjectPropertyBox;
		private System.Windows.Forms.Label FuelErrorLabel;
		private System.Windows.Forms.Label ItemTypeLabel;
		private System.Windows.Forms.Label DecksNumLabel;
		private System.Windows.Forms.ComboBox ItemTypeComboBox;
		private System.Windows.Forms.NumericUpDown DecksNumUpDown;
		private System.Windows.Forms.Label TraversedPathLabel;
		private System.Windows.Forms.Label ModelLabel;
		private System.Windows.Forms.NumericUpDown FuelNumUpDown;
		private System.Windows.Forms.CheckBox HitchedItemCheckBox;
		private System.Windows.Forms.TextBox ModelTextBox;
		private System.Windows.Forms.Label FuelLabel;
		private System.Windows.Forms.NumericUpDown TraversedPathNumUpDown;

	}
}
