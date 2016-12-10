namespace QLCHDT
{
	partial class HR
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbText
			// 
			this.lbText.AutoSize = true;
			this.lbText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbText.ForeColor = System.Drawing.Color.White;
			this.lbText.Location = new System.Drawing.Point(3, 0);
			this.lbText.Name = "lbText";
			this.lbText.Size = new System.Drawing.Size(0, 21);
			this.lbText.TabIndex = 0;
			// 
			// HR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Controls.Add(this.lbText);
			this.Name = "HR";
			this.Size = new System.Drawing.Size(1285, 21);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbText;
	}
}
