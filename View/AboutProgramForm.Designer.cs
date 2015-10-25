namespace View
{
	partial class AboutProgramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutProgramForm));
            this.NameProjectLabel = new System.Windows.Forms.Label();
            this.NameAutorLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameProjectLabel
            // 
            this.NameProjectLabel.AutoSize = true;
            this.NameProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameProjectLabel.Location = new System.Drawing.Point(93, 29);
            this.NameProjectLabel.Name = "NameProjectLabel";
            this.NameProjectLabel.Size = new System.Drawing.Size(169, 17);
            this.NameProjectLabel.TabIndex = 1;
            this.NameProjectLabel.Text = "Транспортные средства";
            // 
            // NameAutorLabel
            // 
            this.NameAutorLabel.AutoSize = true;
            this.NameAutorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameAutorLabel.Location = new System.Drawing.Point(93, 56);
            this.NameAutorLabel.Name = "NameAutorLabel";
            this.NameAutorLabel.Size = new System.Drawing.Size(171, 17);
            this.NameAutorLabel.TabIndex = 2;
            this.NameAutorLabel.Text = "Дементьев Артем гр.513";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearLabel.Location = new System.Drawing.Point(151, 85);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(40, 17);
            this.YearLabel.TabIndex = 3;
            this.YearLabel.Text = "2015";
            // 
            // AboutProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 142);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.NameAutorLabel);
            this.Controls.Add(this.NameProjectLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutProgramForm";
            this.Text = "О  программе";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Label NameProjectLabel;
		private System.Windows.Forms.Label NameAutorLabel;
		private System.Windows.Forms.Label YearLabel;

	}
}