namespace QLCHDT.FormSanPham
{
	partial class FormThayDoiChiTietSanPham
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
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtThongTinSanPham = new System.Windows.Forms.TextBox();
			this.txtThongTinKyThuat = new System.Windows.Forms.TextBox();
			this.nudThoiGianBaoHanh = new System.Windows.Forms.NumericUpDown();
			this.cbbHangSanXuat = new System.Windows.Forms.ComboBox();
			this.lbThongTinSanPham = new System.Windows.Forms.Label();
			this.lbThongTinKyThuat = new System.Windows.Forms.Label();
			this.lbTenSanPham = new System.Windows.Forms.Label();
			this.lbDongSanPham = new System.Windows.Forms.Label();
			this.lbGiaBan = new System.Windows.Forms.Label();
			this.lbThoiGianBaoHanh = new System.Windows.Forms.Label();
			this.lbSoHieuSanPham = new System.Windows.Forms.Label();
			this.lbHangSanXuat = new System.Windows.Forms.Label();
			this.txtTenSanPham = new System.Windows.Forms.TextBox();
			this.txtDongSanPham = new System.Windows.Forms.TextBox();
			this.txtGiaBan = new System.Windows.Forms.TextBox();
			this.txtSoHieuSanPham = new System.Windows.Forms.TextBox();
			this.dgvChiTietSanPham = new System.Windows.Forms.DataGridView();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudThoiGianBaoHanh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTietSanPham)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDelete
			// 
			this.btnDelete.AutoSize = true;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(753, 161);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(104, 33);
			this.btnDelete.TabIndex = 27;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// txtThongTinSanPham
			// 
			this.txtThongTinSanPham.AcceptsTab = true;
			this.txtThongTinSanPham.Location = new System.Drawing.Point(455, 243);
			this.txtThongTinSanPham.Multiline = true;
			this.txtThongTinSanPham.Name = "txtThongTinSanPham";
			this.txtThongTinSanPham.Size = new System.Drawing.Size(402, 182);
			this.txtThongTinSanPham.TabIndex = 26;
			// 
			// txtThongTinKyThuat
			// 
			this.txtThongTinKyThuat.AcceptsTab = true;
			this.txtThongTinKyThuat.Location = new System.Drawing.Point(21, 243);
			this.txtThongTinKyThuat.Multiline = true;
			this.txtThongTinKyThuat.Name = "txtThongTinKyThuat";
			this.txtThongTinKyThuat.Size = new System.Drawing.Size(402, 182);
			this.txtThongTinKyThuat.TabIndex = 25;
			// 
			// nudThoiGianBaoHanh
			// 
			this.nudThoiGianBaoHanh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.nudThoiGianBaoHanh.Location = new System.Drawing.Point(625, 27);
			this.nudThoiGianBaoHanh.Name = "nudThoiGianBaoHanh";
			this.nudThoiGianBaoHanh.Size = new System.Drawing.Size(120, 29);
			this.nudThoiGianBaoHanh.TabIndex = 24;
			this.nudThoiGianBaoHanh.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// cbbHangSanXuat
			// 
			this.cbbHangSanXuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cbbHangSanXuat.FormattingEnabled = true;
			this.cbbHangSanXuat.Location = new System.Drawing.Point(177, 26);
			this.cbbHangSanXuat.Name = "cbbHangSanXuat";
			this.cbbHangSanXuat.Size = new System.Drawing.Size(246, 29);
			this.cbbHangSanXuat.TabIndex = 23;
			// 
			// lbThongTinSanPham
			// 
			this.lbThongTinSanPham.AutoSize = true;
			this.lbThongTinSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbThongTinSanPham.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbThongTinSanPham.Location = new System.Drawing.Point(451, 219);
			this.lbThongTinSanPham.Name = "lbThongTinSanPham";
			this.lbThongTinSanPham.Size = new System.Drawing.Size(172, 21);
			this.lbThongTinSanPham.TabIndex = 21;
			this.lbThongTinSanPham.Text = "Thông Tin Sản Phẩm:";
			// 
			// lbThongTinKyThuat
			// 
			this.lbThongTinKyThuat.AutoSize = true;
			this.lbThongTinKyThuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbThongTinKyThuat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbThongTinKyThuat.Location = new System.Drawing.Point(17, 219);
			this.lbThongTinKyThuat.Name = "lbThongTinKyThuat";
			this.lbThongTinKyThuat.Size = new System.Drawing.Size(167, 21);
			this.lbThongTinKyThuat.TabIndex = 20;
			this.lbThongTinKyThuat.Text = "Thông Tin Kỹ Thuật:";
			// 
			// lbTenSanPham
			// 
			this.lbTenSanPham.AutoSize = true;
			this.lbTenSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbTenSanPham.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbTenSanPham.Location = new System.Drawing.Point(48, 167);
			this.lbTenSanPham.Name = "lbTenSanPham";
			this.lbTenSanPham.Size = new System.Drawing.Size(123, 21);
			this.lbTenSanPham.TabIndex = 19;
			this.lbTenSanPham.Text = "Tên Sản Phẩm:";
			// 
			// lbDongSanPham
			// 
			this.lbDongSanPham.AutoSize = true;
			this.lbDongSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbDongSanPham.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbDongSanPham.Location = new System.Drawing.Point(36, 75);
			this.lbDongSanPham.Name = "lbDongSanPham";
			this.lbDongSanPham.Size = new System.Drawing.Size(135, 21);
			this.lbDongSanPham.TabIndex = 18;
			this.lbDongSanPham.Text = "Dòng Sản Phẩm:";
			// 
			// lbGiaBan
			// 
			this.lbGiaBan.AutoSize = true;
			this.lbGiaBan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbGiaBan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbGiaBan.Location = new System.Drawing.Point(545, 75);
			this.lbGiaBan.Name = "lbGiaBan";
			this.lbGiaBan.Size = new System.Drawing.Size(74, 21);
			this.lbGiaBan.TabIndex = 17;
			this.lbGiaBan.Text = "Giá Bán:";
			// 
			// lbThoiGianBaoHanh
			// 
			this.lbThoiGianBaoHanh.AutoSize = true;
			this.lbThoiGianBaoHanh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbThoiGianBaoHanh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbThoiGianBaoHanh.Location = new System.Drawing.Point(451, 29);
			this.lbThoiGianBaoHanh.Name = "lbThoiGianBaoHanh";
			this.lbThoiGianBaoHanh.Size = new System.Drawing.Size(168, 21);
			this.lbThoiGianBaoHanh.TabIndex = 15;
			this.lbThoiGianBaoHanh.Text = "Thời Gian Bảo Hành:";
			// 
			// lbSoHieuSanPham
			// 
			this.lbSoHieuSanPham.AutoSize = true;
			this.lbSoHieuSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbSoHieuSanPham.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbSoHieuSanPham.Location = new System.Drawing.Point(17, 121);
			this.lbSoHieuSanPham.Name = "lbSoHieuSanPham";
			this.lbSoHieuSanPham.Size = new System.Drawing.Size(154, 21);
			this.lbSoHieuSanPham.TabIndex = 14;
			this.lbSoHieuSanPham.Text = "Số Hiệu Sản Phẩm:";
			// 
			// lbHangSanXuat
			// 
			this.lbHangSanXuat.AutoSize = true;
			this.lbHangSanXuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbHangSanXuat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbHangSanXuat.Location = new System.Drawing.Point(45, 29);
			this.lbHangSanXuat.Name = "lbHangSanXuat";
			this.lbHangSanXuat.Size = new System.Drawing.Size(126, 21);
			this.lbHangSanXuat.TabIndex = 13;
			this.lbHangSanXuat.Text = "Hãng Sản Xuất:";
			// 
			// txtTenSanPham
			// 
			this.txtTenSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtTenSanPham.Location = new System.Drawing.Point(177, 164);
			this.txtTenSanPham.Name = "txtTenSanPham";
			this.txtTenSanPham.Size = new System.Drawing.Size(246, 29);
			this.txtTenSanPham.TabIndex = 11;
			// 
			// txtDongSanPham
			// 
			this.txtDongSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtDongSanPham.Location = new System.Drawing.Point(177, 72);
			this.txtDongSanPham.Name = "txtDongSanPham";
			this.txtDongSanPham.Size = new System.Drawing.Size(246, 29);
			this.txtDongSanPham.TabIndex = 10;
			// 
			// txtGiaBan
			// 
			this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtGiaBan.Location = new System.Drawing.Point(625, 72);
			this.txtGiaBan.Name = "txtGiaBan";
			this.txtGiaBan.Size = new System.Drawing.Size(100, 29);
			this.txtGiaBan.TabIndex = 9;
			this.txtGiaBan.Text = "0";
			// 
			// txtSoHieuSanPham
			// 
			this.txtSoHieuSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtSoHieuSanPham.Location = new System.Drawing.Point(177, 118);
			this.txtSoHieuSanPham.Name = "txtSoHieuSanPham";
			this.txtSoHieuSanPham.Size = new System.Drawing.Size(246, 29);
			this.txtSoHieuSanPham.TabIndex = 7;
			// 
			// dgvChiTietSanPham
			// 
			this.dgvChiTietSanPham.AllowUserToAddRows = false;
			this.dgvChiTietSanPham.AllowUserToDeleteRows = false;
			this.dgvChiTietSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvChiTietSanPham.EnableHeadersVisualStyles = false;
			this.dgvChiTietSanPham.Location = new System.Drawing.Point(21, 436);
			this.dgvChiTietSanPham.MultiSelect = false;
			this.dgvChiTietSanPham.Name = "dgvChiTietSanPham";
			this.dgvChiTietSanPham.ReadOnly = true;
			this.dgvChiTietSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvChiTietSanPham.Size = new System.Drawing.Size(836, 150);
			this.dgvChiTietSanPham.TabIndex = 28;
			this.dgvChiTietSanPham.SelectionChanged += new System.EventHandler(this.dgvChiTietSanPham_SelectionChanged);
			// 
			// btnSave
			// 
			this.btnSave.AutoSize = true;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(753, 115);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(104, 33);
			this.btnSave.TabIndex = 27;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// FormThayDoiChiTietSanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(869, 598);
			this.Controls.Add(this.dgvChiTietSanPham);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.txtThongTinSanPham);
			this.Controls.Add(this.txtThongTinKyThuat);
			this.Controls.Add(this.nudThoiGianBaoHanh);
			this.Controls.Add(this.cbbHangSanXuat);
			this.Controls.Add(this.lbThongTinSanPham);
			this.Controls.Add(this.lbThongTinKyThuat);
			this.Controls.Add(this.lbTenSanPham);
			this.Controls.Add(this.lbDongSanPham);
			this.Controls.Add(this.lbGiaBan);
			this.Controls.Add(this.lbThoiGianBaoHanh);
			this.Controls.Add(this.lbSoHieuSanPham);
			this.Controls.Add(this.lbHangSanXuat);
			this.Controls.Add(this.txtTenSanPham);
			this.Controls.Add(this.txtDongSanPham);
			this.Controls.Add(this.txtGiaBan);
			this.Controls.Add(this.txtSoHieuSanPham);
			this.Name = "FormThayDoiChiTietSanPham";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormThayDoiChiTietSanPham";
			this.Load += new System.EventHandler(this.FormThayDoiChiTietSanPham_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudThoiGianBaoHanh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvChiTietSanPham)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox txtThongTinSanPham;
		private System.Windows.Forms.TextBox txtThongTinKyThuat;
		private System.Windows.Forms.NumericUpDown nudThoiGianBaoHanh;
		private System.Windows.Forms.ComboBox cbbHangSanXuat;
		private System.Windows.Forms.Label lbThongTinSanPham;
		private System.Windows.Forms.Label lbThongTinKyThuat;
		private System.Windows.Forms.Label lbTenSanPham;
		private System.Windows.Forms.Label lbDongSanPham;
		private System.Windows.Forms.Label lbGiaBan;
		private System.Windows.Forms.Label lbThoiGianBaoHanh;
		private System.Windows.Forms.Label lbSoHieuSanPham;
		private System.Windows.Forms.Label lbHangSanXuat;
		private System.Windows.Forms.TextBox txtTenSanPham;
		private System.Windows.Forms.TextBox txtDongSanPham;
		private System.Windows.Forms.TextBox txtGiaBan;
		private System.Windows.Forms.TextBox txtSoHieuSanPham;
		private System.Windows.Forms.DataGridView dgvChiTietSanPham;
		private System.Windows.Forms.Button btnSave;
	}
}