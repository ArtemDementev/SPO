namespace View
{
	partial class ControlObjectForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlObjectForm));
			this.vehiclePropertyControl = new View.VehiclePropertyControl();
			this.CancellButton = new System.Windows.Forms.Button();
			this.OkButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// vehiclePropertyControl
			// 
			this.vehiclePropertyControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vehiclePropertyControl.Location = new System.Drawing.Point(1, 2);
			this.vehiclePropertyControl.Name = "vehiclePropertyControl";
//			this.vehiclePropertyControl.Object = ((Model2.VehicleBase)(resources.GetObject("vehiclePropertyControl.Object")));
			this.vehiclePropertyControl.ReadOnly = false;
			this.vehiclePropertyControl.Size = new System.Drawing.Size(478, 151);
			this.vehiclePropertyControl.TabIndex = 0;
			// 
			// CancellButton
			// 
			this.CancellButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancellButton.Location = new System.Drawing.Point(276, 166);
			this.CancellButton.Name = "CancellButton";
			this.CancellButton.Size = new System.Drawing.Size(203, 23);
			this.CancellButton.TabIndex = 4;
			this.CancellButton.Text = "Отмена";
			this.CancellButton.UseVisualStyleBackColor = true;
			this.CancellButton.Click += new System.EventHandler(this.CancellButton_Click);
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(1, 166);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(203, 23);
			this.OkButton.TabIndex = 3;
			this.OkButton.Text = "Добавить";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// ControlObjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 201);
			this.Controls.Add(this.CancellButton);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.vehiclePropertyControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ControlObjectForm";
			this.ResumeLayout(false);

		}

		#endregion

		private VehiclePropertyControl vehiclePropertyControl;
		private System.Windows.Forms.Button CancellButton;
		private System.Windows.Forms.Button OkButton;
	}
}