namespace QLCHDT.Cong
{
	partial class FormYeuCauTinhLuong
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
			this.lbThongBao = new System.Windows.Forms.Label();
			this.txtHeSoLuong = new System.Windows.Forms.TextBox();
			this.lbHeSoLuong = new System.Windows.Forms.Label();
			this.btnTinhLuong = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbThongBao
			// 
			this.lbThongBao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbThongBao.ForeColor = System.Drawing.Color.White;
			this.lbThongBao.Location = new System.Drawing.Point(12, 9);
			this.lbThongBao.Name = "lbThongBao";
			this.lbThongBao.Size = new System.Drawing.Size(546, 155);
			this.lbThongBao.TabIndex = 6;
			this.lbThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtHeSoLuong
			// 
			this.txtHeSoLuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtHeSoLuong.Location = new System.Drawing.Point(133, 170);
			this.txtHeSoLuong.Name = "txtHeSoLuong";
			this.txtHeSoLuong.Size = new System.Drawing.Size(304, 29);
			this.txtHeSoLuong.TabIndex = 39;
			// 
			// lbHeSoLuong
			// 
			this.lbHeSoLuong.AutoSize = true;
			this.lbHeSoLuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbHeSoLuong.ForeColor = System.Drawing.Color.White;
			this.lbHeSoLuong.Location = new System.Drawing.Point(12, 173);
			this.lbHeSoLuong.Name = "lbHeSoLuong";
			this.lbHeSoLuong.Size = new System.Drawing.Size(115, 21);
			this.lbHeSoLuong.TabIndex = 38;
			this.lbHeSoLuong.Text = "Hệ Số Lương:";
			// 
			// btnTinhLuong
			// 
			this.btnTinhLuong.AutoSize = true;
			this.btnTinhLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTinhLuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnTinhLuong.ForeColor = System.Drawing.Color.White;
			this.btnTinhLuong.Location = new System.Drawing.Point(446, 167);
			this.btnTinhLuong.Name = "btnTinhLuong";
			this.btnTinhLuong.Size = new System.Drawing.Size(112, 33);
			this.btnTinhLuong.TabIndex = 40;
			this.btnTinhLuong.Text = "Tính Lương";
			this.btnTinhLuong.UseVisualStyleBackColor = true;
			this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
			// 
			// FormYeuCauTinhLuong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(570, 220);
			this.Controls.Add(this.btnTinhLuong);
			this.Controls.Add(this.txtHeSoLuong);
			this.Controls.Add(this.lbHeSoLuong);
			this.Controls.Add(this.lbThongBao);
			this.Name = "FormYeuCauTinhLuong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormYeuCauTinhLuong";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbThongBao;
		private System.Windows.Forms.TextBox txtHeSoLuong;
		private System.Windows.Forms.Label lbHeSoLuong;
		private System.Windows.Forms.Button btnTinhLuong;
	}
}