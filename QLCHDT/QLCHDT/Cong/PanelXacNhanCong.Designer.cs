namespace QLCHDT.Cong
{
	partial class PanelXacNhanCong
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
			this.lbCong = new System.Windows.Forms.Label();
			this.btnXacNhan = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbCong
			// 
			this.lbCong.BackColor = System.Drawing.SystemColors.Control;
			this.lbCong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbCong.Location = new System.Drawing.Point(8, 12);
			this.lbCong.Name = "lbCong";
			this.lbCong.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.lbCong.Size = new System.Drawing.Size(137, 23);
			this.lbCong.TabIndex = 3;
			this.lbCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnXacNhan
			// 
			this.btnXacNhan.AutoSize = true;
			this.btnXacNhan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXacNhan.ForeColor = System.Drawing.Color.White;
			this.btnXacNhan.Location = new System.Drawing.Point(365, 7);
			this.btnXacNhan.Name = "btnXacNhan";
			this.btnXacNhan.Size = new System.Drawing.Size(135, 33);
			this.btnXacNhan.TabIndex = 2;
			this.btnXacNhan.Text = "Xác Nhận";
			this.btnXacNhan.UseVisualStyleBackColor = false;
			this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
			// 
			// PanelXacNhanCong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbCong);
			this.Controls.Add(this.btnXacNhan);
			this.Name = "PanelXacNhanCong";
			this.Size = new System.Drawing.Size(503, 44);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbCong;
		private System.Windows.Forms.Button btnXacNhan;
	}
}
