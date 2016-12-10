namespace QLCHDT.FormSanPham
{
	partial class PanelSanPham
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
			this.lbIMEI = new System.Windows.Forms.Label();
			this.btnXoa = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbIMEI
			// 
			this.lbIMEI.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbIMEI.ForeColor = System.Drawing.Color.White;
			this.lbIMEI.Location = new System.Drawing.Point(3, 6);
			this.lbIMEI.Name = "lbIMEI";
			this.lbIMEI.Size = new System.Drawing.Size(335, 21);
			this.lbIMEI.TabIndex = 1;
			// 
			// btnXoa
			// 
			this.btnXoa.AutoSize = true;
			this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXoa.ForeColor = System.Drawing.Color.White;
			this.btnXoa.Location = new System.Drawing.Point(566, 0);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(115, 33);
			this.btnXoa.TabIndex = 2;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// PanelSanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.lbIMEI);
			this.Name = "PanelSanPham";
			this.Size = new System.Drawing.Size(684, 34);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbIMEI;
		private System.Windows.Forms.Button btnXoa;
	}
}
