namespace QLCHDT.FormSanPham
{
	partial class FormNhanBaoHanh
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
			this.lbIMEI = new System.Windows.Forms.Label();
			this.txtIMEI = new System.Windows.Forms.TextBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.lbMaKho = new System.Windows.Forms.Label();
			this.txtMaKho = new System.Windows.Forms.TextBox();
			this.lbMaChiTietSanPham = new System.Windows.Forms.Label();
			this.txtChiTietSanPham = new System.Windows.Forms.TextBox();
			this.txtNgayBatDauBaoHanh = new System.Windows.Forms.Label();
			this.lbNgayKetThucBaoHanh = new System.Windows.Forms.Label();
			this.dtpNgayBatDauBaoHanh = new System.Windows.Forms.DateTimePicker();
			this.dtpNgayKetThucBaoHanh = new System.Windows.Forms.DateTimePicker();
			this.cbbTrangThai = new System.Windows.Forms.ComboBox();
			this.lbTrangThai = new System.Windows.Forms.Label();
			this.lbGiaMua = new System.Windows.Forms.Label();
			this.txtGiaMua = new System.Windows.Forms.TextBox();
			this.lbGiaBan = new System.Windows.Forms.Label();
			this.txtGiaBan = new System.Windows.Forms.TextBox();
			this.lbThongBao = new System.Windows.Forms.Label();
			this.btnNhanBaoHanh = new System.Windows.Forms.Button();
			this.lbThongTin = new System.Windows.Forms.Label();
			this.txtThongTinKhachHang = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbIMEI
			// 
			this.lbIMEI.AutoSize = true;
			this.lbIMEI.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbIMEI.ForeColor = System.Drawing.Color.White;
			this.lbIMEI.Location = new System.Drawing.Point(140, 35);
			this.lbIMEI.Name = "lbIMEI";
			this.lbIMEI.Size = new System.Drawing.Size(53, 21);
			this.lbIMEI.TabIndex = 0;
			this.lbIMEI.Text = "IMEI:";
			// 
			// txtIMEI
			// 
			this.txtIMEI.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtIMEI.Location = new System.Drawing.Point(199, 32);
			this.txtIMEI.Name = "txtIMEI";
			this.txtIMEI.Size = new System.Drawing.Size(334, 29);
			this.txtIMEI.TabIndex = 1;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.AutoSize = true;
			this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnTimKiem.ForeColor = System.Drawing.Color.White;
			this.btnTimKiem.Location = new System.Drawing.Point(539, 29);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(113, 33);
			this.btnTimKiem.TabIndex = 2;
			this.btnTimKiem.Text = "Tìm Kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// lbMaKho
			// 
			this.lbMaKho.AutoSize = true;
			this.lbMaKho.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbMaKho.ForeColor = System.Drawing.Color.White;
			this.lbMaKho.Location = new System.Drawing.Point(45, 137);
			this.lbMaKho.Name = "lbMaKho";
			this.lbMaKho.Size = new System.Drawing.Size(75, 21);
			this.lbMaKho.TabIndex = 0;
			this.lbMaKho.Text = "Mã Kho:";
			// 
			// txtMaKho
			// 
			this.txtMaKho.Enabled = false;
			this.txtMaKho.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtMaKho.Location = new System.Drawing.Point(126, 134);
			this.txtMaKho.Name = "txtMaKho";
			this.txtMaKho.Size = new System.Drawing.Size(174, 29);
			this.txtMaKho.TabIndex = 1;
			// 
			// lbMaChiTietSanPham
			// 
			this.lbMaChiTietSanPham.AutoSize = true;
			this.lbMaChiTietSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbMaChiTietSanPham.ForeColor = System.Drawing.Color.White;
			this.lbMaChiTietSanPham.Location = new System.Drawing.Point(306, 137);
			this.lbMaChiTietSanPham.Name = "lbMaChiTietSanPham";
			this.lbMaChiTietSanPham.Size = new System.Drawing.Size(153, 21);
			this.lbMaChiTietSanPham.TabIndex = 0;
			this.lbMaChiTietSanPham.Text = "Chi Tiết Sản Phẩm:";
			// 
			// txtChiTietSanPham
			// 
			this.txtChiTietSanPham.Enabled = false;
			this.txtChiTietSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtChiTietSanPham.Location = new System.Drawing.Point(465, 134);
			this.txtChiTietSanPham.Name = "txtChiTietSanPham";
			this.txtChiTietSanPham.Size = new System.Drawing.Size(412, 29);
			this.txtChiTietSanPham.TabIndex = 1;
			// 
			// txtNgayBatDauBaoHanh
			// 
			this.txtNgayBatDauBaoHanh.AutoSize = true;
			this.txtNgayBatDauBaoHanh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtNgayBatDauBaoHanh.ForeColor = System.Drawing.Color.White;
			this.txtNgayBatDauBaoHanh.Location = new System.Drawing.Point(39, 194);
			this.txtNgayBatDauBaoHanh.Name = "txtNgayBatDauBaoHanh";
			this.txtNgayBatDauBaoHanh.Size = new System.Drawing.Size(198, 21);
			this.txtNgayBatDauBaoHanh.TabIndex = 0;
			this.txtNgayBatDauBaoHanh.Text = "Ngày Bắt Đầu Bảo Hành:";
			// 
			// lbNgayKetThucBaoHanh
			// 
			this.lbNgayKetThucBaoHanh.AutoSize = true;
			this.lbNgayKetThucBaoHanh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbNgayKetThucBaoHanh.ForeColor = System.Drawing.Color.White;
			this.lbNgayKetThucBaoHanh.Location = new System.Drawing.Point(30, 248);
			this.lbNgayKetThucBaoHanh.Name = "lbNgayKetThucBaoHanh";
			this.lbNgayKetThucBaoHanh.Size = new System.Drawing.Size(207, 21);
			this.lbNgayKetThucBaoHanh.TabIndex = 0;
			this.lbNgayKetThucBaoHanh.Text = "Ngày Kết Thúc Bảo Hành:";
			// 
			// dtpNgayBatDauBaoHanh
			// 
			this.dtpNgayBatDauBaoHanh.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpNgayBatDauBaoHanh.Enabled = false;
			this.dtpNgayBatDauBaoHanh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpNgayBatDauBaoHanh.Location = new System.Drawing.Point(243, 188);
			this.dtpNgayBatDauBaoHanh.Name = "dtpNgayBatDauBaoHanh";
			this.dtpNgayBatDauBaoHanh.Size = new System.Drawing.Size(216, 29);
			this.dtpNgayBatDauBaoHanh.TabIndex = 3;
			this.dtpNgayBatDauBaoHanh.Value = new System.DateTime(2016, 12, 10, 12, 57, 9, 0);
			// 
			// dtpNgayKetThucBaoHanh
			// 
			this.dtpNgayKetThucBaoHanh.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpNgayKetThucBaoHanh.Enabled = false;
			this.dtpNgayKetThucBaoHanh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpNgayKetThucBaoHanh.Location = new System.Drawing.Point(243, 242);
			this.dtpNgayKetThucBaoHanh.Name = "dtpNgayKetThucBaoHanh";
			this.dtpNgayKetThucBaoHanh.Size = new System.Drawing.Size(216, 29);
			this.dtpNgayKetThucBaoHanh.TabIndex = 3;
			this.dtpNgayKetThucBaoHanh.Value = new System.DateTime(2016, 12, 10, 12, 57, 9, 0);
			// 
			// cbbTrangThai
			// 
			this.cbbTrangThai.Enabled = false;
			this.cbbTrangThai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cbbTrangThai.FormattingEnabled = true;
			this.cbbTrangThai.Location = new System.Drawing.Point(243, 297);
			this.cbbTrangThai.Name = "cbbTrangThai";
			this.cbbTrangThai.Size = new System.Drawing.Size(216, 29);
			this.cbbTrangThai.TabIndex = 4;
			// 
			// lbTrangThai
			// 
			this.lbTrangThai.AutoSize = true;
			this.lbTrangThai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbTrangThai.ForeColor = System.Drawing.Color.White;
			this.lbTrangThai.Location = new System.Drawing.Point(142, 300);
			this.lbTrangThai.Name = "lbTrangThai";
			this.lbTrangThai.Size = new System.Drawing.Size(95, 21);
			this.lbTrangThai.TabIndex = 0;
			this.lbTrangThai.Text = "Trạng Thái:";
			// 
			// lbGiaMua
			// 
			this.lbGiaMua.AutoSize = true;
			this.lbGiaMua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbGiaMua.ForeColor = System.Drawing.Color.White;
			this.lbGiaMua.Location = new System.Drawing.Point(622, 194);
			this.lbGiaMua.Name = "lbGiaMua";
			this.lbGiaMua.Size = new System.Drawing.Size(78, 21);
			this.lbGiaMua.TabIndex = 0;
			this.lbGiaMua.Text = "Giá Mua:";
			// 
			// txtGiaMua
			// 
			this.txtGiaMua.Enabled = false;
			this.txtGiaMua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtGiaMua.Location = new System.Drawing.Point(703, 191);
			this.txtGiaMua.Name = "txtGiaMua";
			this.txtGiaMua.Size = new System.Drawing.Size(174, 29);
			this.txtGiaMua.TabIndex = 1;
			this.txtGiaMua.Text = "0";
			// 
			// lbGiaBan
			// 
			this.lbGiaBan.AutoSize = true;
			this.lbGiaBan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbGiaBan.ForeColor = System.Drawing.Color.White;
			this.lbGiaBan.Location = new System.Drawing.Point(622, 245);
			this.lbGiaBan.Name = "lbGiaBan";
			this.lbGiaBan.Size = new System.Drawing.Size(74, 21);
			this.lbGiaBan.TabIndex = 0;
			this.lbGiaBan.Text = "Giá Bán:";
			// 
			// txtGiaBan
			// 
			this.txtGiaBan.Enabled = false;
			this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtGiaBan.Location = new System.Drawing.Point(703, 242);
			this.txtGiaBan.Name = "txtGiaBan";
			this.txtGiaBan.Size = new System.Drawing.Size(174, 29);
			this.txtGiaBan.TabIndex = 1;
			this.txtGiaBan.Text = "0";
			// 
			// lbThongBao
			// 
			this.lbThongBao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbThongBao.ForeColor = System.Drawing.Color.White;
			this.lbThongBao.Location = new System.Drawing.Point(112, 85);
			this.lbThongBao.Name = "lbThongBao";
			this.lbThongBao.Size = new System.Drawing.Size(673, 21);
			this.lbThongBao.TabIndex = 0;
			this.lbThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnNhanBaoHanh
			// 
			this.btnNhanBaoHanh.AutoSize = true;
			this.btnNhanBaoHanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNhanBaoHanh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnNhanBaoHanh.ForeColor = System.Drawing.Color.White;
			this.btnNhanBaoHanh.Location = new System.Drawing.Point(737, 382);
			this.btnNhanBaoHanh.Name = "btnNhanBaoHanh";
			this.btnNhanBaoHanh.Size = new System.Drawing.Size(140, 33);
			this.btnNhanBaoHanh.TabIndex = 2;
			this.btnNhanBaoHanh.Text = "Nhận Bảo Hành";
			this.btnNhanBaoHanh.UseVisualStyleBackColor = true;
			this.btnNhanBaoHanh.Click += new System.EventHandler(this.txtNhanBaoHanh_Click);
			// 
			// lbThongTin
			// 
			this.lbThongTin.AutoSize = true;
			this.lbThongTin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbThongTin.ForeColor = System.Drawing.Color.White;
			this.lbThongTin.Location = new System.Drawing.Point(45, 354);
			this.lbThongTin.Name = "lbThongTin";
			this.lbThongTin.Size = new System.Drawing.Size(189, 21);
			this.lbThongTin.TabIndex = 0;
			this.lbThongTin.Text = "Thông Tin Khách Hàng:";
			// 
			// txtThongTinKhachHang
			// 
			this.txtThongTinKhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtThongTinKhachHang.Location = new System.Drawing.Point(49, 382);
			this.txtThongTinKhachHang.Multiline = true;
			this.txtThongTinKhachHang.Name = "txtThongTinKhachHang";
			this.txtThongTinKhachHang.Size = new System.Drawing.Size(682, 97);
			this.txtThongTinKhachHang.TabIndex = 1;
			// 
			// FormNhanBaoHanh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(920, 491);
			this.Controls.Add(this.cbbTrangThai);
			this.Controls.Add(this.dtpNgayKetThucBaoHanh);
			this.Controls.Add(this.dtpNgayBatDauBaoHanh);
			this.Controls.Add(this.btnNhanBaoHanh);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.lbTrangThai);
			this.Controls.Add(this.lbNgayKetThucBaoHanh);
			this.Controls.Add(this.txtNgayBatDauBaoHanh);
			this.Controls.Add(this.txtChiTietSanPham);
			this.Controls.Add(this.lbMaChiTietSanPham);
			this.Controls.Add(this.txtGiaBan);
			this.Controls.Add(this.lbGiaBan);
			this.Controls.Add(this.txtGiaMua);
			this.Controls.Add(this.lbGiaMua);
			this.Controls.Add(this.txtThongTinKhachHang);
			this.Controls.Add(this.txtMaKho);
			this.Controls.Add(this.lbThongTin);
			this.Controls.Add(this.lbThongBao);
			this.Controls.Add(this.lbMaKho);
			this.Controls.Add(this.txtIMEI);
			this.Controls.Add(this.lbIMEI);
			this.Name = "FormNhanBaoHanh";
			this.Text = "FormNhanBaoHanh";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbIMEI;
		private System.Windows.Forms.TextBox txtIMEI;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.Label lbMaKho;
		private System.Windows.Forms.TextBox txtMaKho;
		private System.Windows.Forms.Label lbMaChiTietSanPham;
		private System.Windows.Forms.TextBox txtChiTietSanPham;
		private System.Windows.Forms.Label txtNgayBatDauBaoHanh;
		private System.Windows.Forms.Label lbNgayKetThucBaoHanh;
		private System.Windows.Forms.DateTimePicker dtpNgayBatDauBaoHanh;
		private System.Windows.Forms.DateTimePicker dtpNgayKetThucBaoHanh;
		private System.Windows.Forms.ComboBox cbbTrangThai;
		private System.Windows.Forms.Label lbTrangThai;
		private System.Windows.Forms.Label lbGiaMua;
		private System.Windows.Forms.TextBox txtGiaMua;
		private System.Windows.Forms.Label lbGiaBan;
		private System.Windows.Forms.TextBox txtGiaBan;
		private System.Windows.Forms.Label lbThongBao;
		private System.Windows.Forms.Button btnNhanBaoHanh;
		private System.Windows.Forms.Label lbThongTin;
		private System.Windows.Forms.TextBox txtThongTinKhachHang;
	}
}