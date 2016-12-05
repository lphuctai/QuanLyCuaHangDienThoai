namespace QLCHDT.Cong
{
	partial class PanelCong
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
			this.btnCong = new System.Windows.Forms.Button();
			this.lbCong = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCong
			// 
			this.btnCong.AutoSize = true;
			this.btnCong.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnCong.ForeColor = System.Drawing.Color.White;
			this.btnCong.Location = new System.Drawing.Point(227, 4);
			this.btnCong.Name = "btnCong";
			this.btnCong.Size = new System.Drawing.Size(112, 33);
			this.btnCong.TabIndex = 0;
			this.btnCong.Text = "Chấm Công";
			this.btnCong.UseVisualStyleBackColor = false;
			this.btnCong.Click += new System.EventHandler(this.button1_Click);
			// 
			// lbCong
			// 
			this.lbCong.BackColor = System.Drawing.SystemColors.Control;
			this.lbCong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbCong.Location = new System.Drawing.Point(8, 9);
			this.lbCong.Name = "lbCong";
			this.lbCong.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.lbCong.Size = new System.Drawing.Size(213, 23);
			this.lbCong.TabIndex = 1;
			// 
			// PanelCong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.lbCong);
			this.Controls.Add(this.btnCong);
			this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
			this.Name = "PanelCong";
			this.Size = new System.Drawing.Size(347, 40);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnCong;
		private System.Windows.Forms.Label lbCong;
	}
}
