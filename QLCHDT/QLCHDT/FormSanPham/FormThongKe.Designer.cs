namespace QLCHDT.FormSanPham
{
	partial class FormThongKe
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
			this.lbNgayBatDau = new System.Windows.Forms.Label();
			this.btnLoc = new System.Windows.Forms.Button();
			this.lbNgayKetThuc = new System.Windows.Forms.Label();
			this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
			this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
			this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
			this.lbTongDoanhThu = new System.Windows.Forms.Label();
			this.lbTongGioCong = new System.Windows.Forms.Label();
			this.txtTongGioCong = new System.Windows.Forms.TextBox();
			this.dgvPhieuXuat = new System.Windows.Forms.DataGridView();
			this.lbPhieuXuat = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).BeginInit();
			this.SuspendLayout();
			// 
			// lbNgayBatDau
			// 
			this.lbNgayBatDau.AutoSize = true;
			this.lbNgayBatDau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbNgayBatDau.ForeColor = System.Drawing.Color.White;
			this.lbNgayBatDau.Location = new System.Drawing.Point(33, 18);
			this.lbNgayBatDau.Name = "lbNgayBatDau";
			this.lbNgayBatDau.Size = new System.Drawing.Size(119, 21);
			this.lbNgayBatDau.TabIndex = 39;
			this.lbNgayBatDau.Text = "Ngày Bắt Đầu:";
			// 
			// btnLoc
			// 
			this.btnLoc.AutoSize = true;
			this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnLoc.ForeColor = System.Drawing.Color.White;
			this.btnLoc.Location = new System.Drawing.Point(772, 12);
			this.btnLoc.Name = "btnLoc";
			this.btnLoc.Size = new System.Drawing.Size(112, 33);
			this.btnLoc.TabIndex = 41;
			this.btnLoc.Text = "Lọc";
			this.btnLoc.UseVisualStyleBackColor = true;
			this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
			// 
			// lbNgayKetThuc
			// 
			this.lbNgayKetThuc.AutoSize = true;
			this.lbNgayKetThuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbNgayKetThuc.ForeColor = System.Drawing.Color.White;
			this.lbNgayKetThuc.Location = new System.Drawing.Point(398, 18);
			this.lbNgayKetThuc.Name = "lbNgayKetThuc";
			this.lbNgayKetThuc.Size = new System.Drawing.Size(128, 21);
			this.lbNgayKetThuc.TabIndex = 42;
			this.lbNgayKetThuc.Text = "Ngày Kết Thúc:";
			// 
			// dtpBatDau
			// 
			this.dtpBatDau.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpBatDau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpBatDau.Location = new System.Drawing.Point(158, 12);
			this.dtpBatDau.Name = "dtpBatDau";
			this.dtpBatDau.Size = new System.Drawing.Size(234, 29);
			this.dtpBatDau.TabIndex = 43;
			this.dtpBatDau.Value = new System.DateTime(2016, 12, 18, 16, 31, 56, 0);
			// 
			// dtpKetThuc
			// 
			this.dtpKetThuc.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpKetThuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpKetThuc.Location = new System.Drawing.Point(532, 12);
			this.dtpKetThuc.Name = "dtpKetThuc";
			this.dtpKetThuc.Size = new System.Drawing.Size(234, 29);
			this.dtpKetThuc.TabIndex = 44;
			this.dtpKetThuc.Value = new System.DateTime(2016, 12, 18, 16, 31, 56, 0);
			// 
			// txtTongDoanhThu
			// 
			this.txtTongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtTongDoanhThu.Location = new System.Drawing.Point(201, 85);
			this.txtTongDoanhThu.Name = "txtTongDoanhThu";
			this.txtTongDoanhThu.ReadOnly = true;
			this.txtTongDoanhThu.Size = new System.Drawing.Size(304, 29);
			this.txtTongDoanhThu.TabIndex = 40;
			// 
			// lbTongDoanhThu
			// 
			this.lbTongDoanhThu.AutoSize = true;
			this.lbTongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbTongDoanhThu.ForeColor = System.Drawing.Color.White;
			this.lbTongDoanhThu.Location = new System.Drawing.Point(52, 88);
			this.lbTongDoanhThu.Name = "lbTongDoanhThu";
			this.lbTongDoanhThu.Size = new System.Drawing.Size(143, 21);
			this.lbTongDoanhThu.TabIndex = 45;
			this.lbTongDoanhThu.Text = "Tổng Doanh Thu:";
			// 
			// lbTongGioCong
			// 
			this.lbTongGioCong.AutoSize = true;
			this.lbTongGioCong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbTongGioCong.ForeColor = System.Drawing.Color.White;
			this.lbTongGioCong.Location = new System.Drawing.Point(62, 136);
			this.lbTongGioCong.Name = "lbTongGioCong";
			this.lbTongGioCong.Size = new System.Drawing.Size(133, 21);
			this.lbTongGioCong.TabIndex = 47;
			this.lbTongGioCong.Text = "Tổng Giờ Công:";
			// 
			// txtTongGioCong
			// 
			this.txtTongGioCong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtTongGioCong.Location = new System.Drawing.Point(201, 133);
			this.txtTongGioCong.Name = "txtTongGioCong";
			this.txtTongGioCong.ReadOnly = true;
			this.txtTongGioCong.Size = new System.Drawing.Size(304, 29);
			this.txtTongGioCong.TabIndex = 46;
			// 
			// dgvPhieuXuat
			// 
			this.dgvPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPhieuXuat.Location = new System.Drawing.Point(12, 228);
			this.dgvPhieuXuat.Name = "dgvPhieuXuat";
			this.dgvPhieuXuat.ReadOnly = true;
			this.dgvPhieuXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPhieuXuat.Size = new System.Drawing.Size(891, 227);
			this.dgvPhieuXuat.TabIndex = 49;
			// 
			// lbPhieuXuat
			// 
			this.lbPhieuXuat.AutoSize = true;
			this.lbPhieuXuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbPhieuXuat.ForeColor = System.Drawing.Color.White;
			this.lbPhieuXuat.Location = new System.Drawing.Point(12, 204);
			this.lbPhieuXuat.Name = "lbPhieuXuat";
			this.lbPhieuXuat.Size = new System.Drawing.Size(95, 21);
			this.lbPhieuXuat.TabIndex = 50;
			this.lbPhieuXuat.Text = "Phiếu Xuất:";
			// 
			// FormThongKe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(915, 467);
			this.Controls.Add(this.lbPhieuXuat);
			this.Controls.Add(this.dgvPhieuXuat);
			this.Controls.Add(this.lbTongGioCong);
			this.Controls.Add(this.txtTongGioCong);
			this.Controls.Add(this.lbTongDoanhThu);
			this.Controls.Add(this.dtpKetThuc);
			this.Controls.Add(this.dtpBatDau);
			this.Controls.Add(this.lbNgayKetThuc);
			this.Controls.Add(this.btnLoc);
			this.Controls.Add(this.txtTongDoanhThu);
			this.Controls.Add(this.lbNgayBatDau);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FormThongKe";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thống Kê";
			((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbNgayBatDau;
		private System.Windows.Forms.Button btnLoc;
		private System.Windows.Forms.Label lbNgayKetThuc;
		private System.Windows.Forms.DateTimePicker dtpBatDau;
		private System.Windows.Forms.DateTimePicker dtpKetThuc;
		private System.Windows.Forms.TextBox txtTongDoanhThu;
		private System.Windows.Forms.Label lbTongDoanhThu;
		private System.Windows.Forms.Label lbTongGioCong;
		private System.Windows.Forms.TextBox txtTongGioCong;
		private System.Windows.Forms.DataGridView dgvPhieuXuat;
		private System.Windows.Forms.Label lbPhieuXuat;
	}
}