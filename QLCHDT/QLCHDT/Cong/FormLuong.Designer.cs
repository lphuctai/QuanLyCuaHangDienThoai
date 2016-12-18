namespace QLCHDT.Cong
{
	partial class FormLuong
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
			this.lbThoiGian = new System.Windows.Forms.Label();
			this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
			this.dgvBangLuong = new System.Windows.Forms.DataGridView();
			this.lbBangLuong = new System.Windows.Forms.Label();
			this.lbHoTen = new System.Windows.Forms.Label();
			this.lbMSNV = new System.Windows.Forms.Label();
			this.lbTongLuongThuong = new System.Windows.Forms.Label();
			this.txtMSNV = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.txtTongLuongThuong = new System.Windows.Forms.TextBox();
			this.btnXacNhanNhanLuong = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
			this.SuspendLayout();
			// 
			// lbThoiGian
			// 
			this.lbThoiGian.AutoSize = true;
			this.lbThoiGian.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbThoiGian.ForeColor = System.Drawing.Color.White;
			this.lbThoiGian.Location = new System.Drawing.Point(103, 26);
			this.lbThoiGian.Name = "lbThoiGian";
			this.lbThoiGian.Size = new System.Drawing.Size(89, 21);
			this.lbThoiGian.TabIndex = 5;
			this.lbThoiGian.Text = "Thời Gian:";
			// 
			// dtpThoiGian
			// 
			this.dtpThoiGian.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpThoiGian.CustomFormat = "\' \'MMMM \'năm\' yyyy";
			this.dtpThoiGian.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpThoiGian.Location = new System.Drawing.Point(198, 20);
			this.dtpThoiGian.Name = "dtpThoiGian";
			this.dtpThoiGian.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dtpThoiGian.Size = new System.Drawing.Size(258, 29);
			this.dtpThoiGian.TabIndex = 33;
			this.dtpThoiGian.Value = new System.DateTime(2016, 11, 16, 20, 14, 0, 0);
			this.dtpThoiGian.ValueChanged += new System.EventHandler(this.dtpThoiGian_ValueChanged);
			// 
			// dgvBangLuong
			// 
			this.dgvBangLuong.AllowUserToAddRows = false;
			this.dgvBangLuong.AllowUserToDeleteRows = false;
			this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBangLuong.Location = new System.Drawing.Point(12, 216);
			this.dgvBangLuong.MultiSelect = false;
			this.dgvBangLuong.Name = "dgvBangLuong";
			this.dgvBangLuong.ReadOnly = true;
			this.dgvBangLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBangLuong.Size = new System.Drawing.Size(749, 319);
			this.dgvBangLuong.TabIndex = 35;
			this.dgvBangLuong.SelectionChanged += new System.EventHandler(this.dgvBangLuong_SelectionChanged);
			// 
			// lbBangLuong
			// 
			this.lbBangLuong.AutoSize = true;
			this.lbBangLuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbBangLuong.ForeColor = System.Drawing.Color.White;
			this.lbBangLuong.Location = new System.Drawing.Point(12, 192);
			this.lbBangLuong.Name = "lbBangLuong";
			this.lbBangLuong.Size = new System.Drawing.Size(106, 21);
			this.lbBangLuong.TabIndex = 36;
			this.lbBangLuong.Text = "Bảng Lương:";
			// 
			// lbHoTen
			// 
			this.lbHoTen.AutoSize = true;
			this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbHoTen.ForeColor = System.Drawing.Color.White;
			this.lbHoTen.Location = new System.Drawing.Point(113, 117);
			this.lbHoTen.Name = "lbHoTen";
			this.lbHoTen.Size = new System.Drawing.Size(71, 21);
			this.lbHoTen.TabIndex = 5;
			this.lbHoTen.Text = "Họ Tên:";
			// 
			// lbMSNV
			// 
			this.lbMSNV.AutoSize = true;
			this.lbMSNV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbMSNV.ForeColor = System.Drawing.Color.White;
			this.lbMSNV.Location = new System.Drawing.Point(118, 77);
			this.lbMSNV.Name = "lbMSNV";
			this.lbMSNV.Size = new System.Drawing.Size(66, 21);
			this.lbMSNV.TabIndex = 5;
			this.lbMSNV.Text = "MSNV:";
			// 
			// lbTongLuongThuong
			// 
			this.lbTongLuongThuong.AutoSize = true;
			this.lbTongLuongThuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbTongLuongThuong.ForeColor = System.Drawing.Color.White;
			this.lbTongLuongThuong.Location = new System.Drawing.Point(12, 157);
			this.lbTongLuongThuong.Name = "lbTongLuongThuong";
			this.lbTongLuongThuong.Size = new System.Drawing.Size(172, 21);
			this.lbTongLuongThuong.TabIndex = 5;
			this.lbTongLuongThuong.Text = "Tổng Lương Thưởng:";
			// 
			// txtMSNV
			// 
			this.txtMSNV.Enabled = false;
			this.txtMSNV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtMSNV.Location = new System.Drawing.Point(198, 74);
			this.txtMSNV.Name = "txtMSNV";
			this.txtMSNV.Size = new System.Drawing.Size(246, 29);
			this.txtMSNV.TabIndex = 37;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Enabled = false;
			this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtHoTen.Location = new System.Drawing.Point(198, 114);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(465, 29);
			this.txtHoTen.TabIndex = 37;
			// 
			// txtTongLuongThuong
			// 
			this.txtTongLuongThuong.Enabled = false;
			this.txtTongLuongThuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtTongLuongThuong.Location = new System.Drawing.Point(198, 154);
			this.txtTongLuongThuong.Name = "txtTongLuongThuong";
			this.txtTongLuongThuong.Size = new System.Drawing.Size(304, 29);
			this.txtTongLuongThuong.TabIndex = 37;
			// 
			// btnXacNhanNhanLuong
			// 
			this.btnXacNhanNhanLuong.AutoSize = true;
			this.btnXacNhanNhanLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXacNhanNhanLuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnXacNhanNhanLuong.ForeColor = System.Drawing.Color.White;
			this.btnXacNhanNhanLuong.Location = new System.Drawing.Point(508, 154);
			this.btnXacNhanNhanLuong.Name = "btnXacNhanNhanLuong";
			this.btnXacNhanNhanLuong.Size = new System.Drawing.Size(194, 33);
			this.btnXacNhanNhanLuong.TabIndex = 38;
			this.btnXacNhanNhanLuong.Text = "Xác Nhận Nhận Lương";
			this.btnXacNhanNhanLuong.UseVisualStyleBackColor = true;
			this.btnXacNhanNhanLuong.Click += new System.EventHandler(this.btnXacNhanNhanLuong_Click);
			// 
			// FormLuong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(773, 547);
			this.Controls.Add(this.btnXacNhanNhanLuong);
			this.Controls.Add(this.txtTongLuongThuong);
			this.Controls.Add(this.txtHoTen);
			this.Controls.Add(this.txtMSNV);
			this.Controls.Add(this.lbBangLuong);
			this.Controls.Add(this.dgvBangLuong);
			this.Controls.Add(this.dtpThoiGian);
			this.Controls.Add(this.lbMSNV);
			this.Controls.Add(this.lbTongLuongThuong);
			this.Controls.Add(this.lbHoTen);
			this.Controls.Add(this.lbThoiGian);
			this.Name = "FormLuong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tính Lương";
			this.Load += new System.EventHandler(this.FormLuong_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbThoiGian;
		private System.Windows.Forms.DateTimePicker dtpThoiGian;
		private System.Windows.Forms.DataGridView dgvBangLuong;
		private System.Windows.Forms.Label lbBangLuong;
		private System.Windows.Forms.Label lbHoTen;
		private System.Windows.Forms.Label lbMSNV;
		private System.Windows.Forms.Label lbTongLuongThuong;
		private System.Windows.Forms.TextBox txtMSNV;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.TextBox txtTongLuongThuong;
		private System.Windows.Forms.Button btnXacNhanNhanLuong;
	}
}