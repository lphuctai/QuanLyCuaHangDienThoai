namespace QLCHDT.FormSanPham
{
	partial class FormBanHang
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
			this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.btnThemSanPham = new System.Windows.Forms.Button();
			this.txtThongTinKhachHang = new System.Windows.Forms.TextBox();
			this.txtTongCong = new System.Windows.Forms.TextBox();
			this.txtIMEI = new System.Windows.Forms.TextBox();
			this.lbDanhSachSanPham = new System.Windows.Forms.Label();
			this.lbTongCong = new System.Windows.Forms.Label();
			this.lbThemSanPham = new System.Windows.Forms.Label();
			this.lbThongTinKhachHang = new System.Windows.Forms.Label();
			this.btnThanhToan = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// flowPanel
			// 
			this.flowPanel.BackColor = System.Drawing.SystemColors.ControlDark;
			this.flowPanel.Location = new System.Drawing.Point(50, 337);
			this.flowPanel.Name = "flowPanel";
			this.flowPanel.Size = new System.Drawing.Size(706, 232);
			this.flowPanel.TabIndex = 13;
			this.flowPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowPanel_ControlAdded);
			this.flowPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowPanel_ControlRemoved);
			// 
			// btnThemSanPham
			// 
			this.btnThemSanPham.AutoSize = true;
			this.btnThemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThemSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThemSanPham.ForeColor = System.Drawing.Color.White;
			this.btnThemSanPham.Location = new System.Drawing.Point(611, 36);
			this.btnThemSanPham.Name = "btnThemSanPham";
			this.btnThemSanPham.Size = new System.Drawing.Size(145, 33);
			this.btnThemSanPham.TabIndex = 12;
			this.btnThemSanPham.Text = "Thêm Sản Phẩm";
			this.btnThemSanPham.UseVisualStyleBackColor = true;
			this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
			// 
			// txtThongTinKhachHang
			// 
			this.txtThongTinKhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtThongTinKhachHang.Location = new System.Drawing.Point(50, 119);
			this.txtThongTinKhachHang.Multiline = true;
			this.txtThongTinKhachHang.Name = "txtThongTinKhachHang";
			this.txtThongTinKhachHang.Size = new System.Drawing.Size(706, 125);
			this.txtThongTinKhachHang.TabIndex = 9;
			// 
			// txtTongCong
			// 
			this.txtTongCong.Enabled = false;
			this.txtTongCong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtTongCong.Location = new System.Drawing.Point(149, 264);
			this.txtTongCong.Name = "txtTongCong";
			this.txtTongCong.Size = new System.Drawing.Size(212, 29);
			this.txtTongCong.TabIndex = 10;
			// 
			// txtIMEI
			// 
			this.txtIMEI.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtIMEI.Location = new System.Drawing.Point(186, 39);
			this.txtIMEI.Name = "txtIMEI";
			this.txtIMEI.Size = new System.Drawing.Size(403, 29);
			this.txtIMEI.TabIndex = 11;
			// 
			// lbDanhSachSanPham
			// 
			this.lbDanhSachSanPham.AutoSize = true;
			this.lbDanhSachSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbDanhSachSanPham.ForeColor = System.Drawing.Color.White;
			this.lbDanhSachSanPham.Location = new System.Drawing.Point(46, 313);
			this.lbDanhSachSanPham.Name = "lbDanhSachSanPham";
			this.lbDanhSachSanPham.Size = new System.Drawing.Size(175, 21);
			this.lbDanhSachSanPham.TabIndex = 5;
			this.lbDanhSachSanPham.Text = "Danh Sách Sản Phẩm:";
			// 
			// lbTongCong
			// 
			this.lbTongCong.AutoSize = true;
			this.lbTongCong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbTongCong.ForeColor = System.Drawing.Color.White;
			this.lbTongCong.Location = new System.Drawing.Point(43, 267);
			this.lbTongCong.Name = "lbTongCong";
			this.lbTongCong.Size = new System.Drawing.Size(100, 21);
			this.lbTongCong.TabIndex = 6;
			this.lbTongCong.Text = "Tổng Cộng:";
			// 
			// lbThemSanPham
			// 
			this.lbThemSanPham.AutoSize = true;
			this.lbThemSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbThemSanPham.ForeColor = System.Drawing.Color.White;
			this.lbThemSanPham.Location = new System.Drawing.Point(43, 42);
			this.lbThemSanPham.Name = "lbThemSanPham";
			this.lbThemSanPham.Size = new System.Drawing.Size(137, 21);
			this.lbThemSanPham.TabIndex = 7;
			this.lbThemSanPham.Text = "Thêm Sản Phẩm:";
			// 
			// lbThongTinKhachHang
			// 
			this.lbThongTinKhachHang.AutoSize = true;
			this.lbThongTinKhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbThongTinKhachHang.ForeColor = System.Drawing.Color.White;
			this.lbThongTinKhachHang.Location = new System.Drawing.Point(46, 95);
			this.lbThongTinKhachHang.Name = "lbThongTinKhachHang";
			this.lbThongTinKhachHang.Size = new System.Drawing.Size(185, 21);
			this.lbThongTinKhachHang.TabIndex = 8;
			this.lbThongTinKhachHang.Text = "Thông Tin Khách Hàng";
			// 
			// btnThanhToan
			// 
			this.btnThanhToan.AutoSize = true;
			this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThanhToan.ForeColor = System.Drawing.Color.White;
			this.btnThanhToan.Location = new System.Drawing.Point(611, 261);
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.Size = new System.Drawing.Size(145, 33);
			this.btnThanhToan.TabIndex = 12;
			this.btnThanhToan.Text = "Thanh Toán";
			this.btnThanhToan.UseVisualStyleBackColor = true;
			this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
			// 
			// FormBanHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(786, 587);
			this.Controls.Add(this.flowPanel);
			this.Controls.Add(this.btnThanhToan);
			this.Controls.Add(this.btnThemSanPham);
			this.Controls.Add(this.txtThongTinKhachHang);
			this.Controls.Add(this.txtTongCong);
			this.Controls.Add(this.txtIMEI);
			this.Controls.Add(this.lbDanhSachSanPham);
			this.Controls.Add(this.lbTongCong);
			this.Controls.Add(this.lbThemSanPham);
			this.Controls.Add(this.lbThongTinKhachHang);
			this.Name = "FormBanHang";
			this.Text = "FormBanHang";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowPanel;
		private System.Windows.Forms.Button btnThemSanPham;
		private System.Windows.Forms.TextBox txtThongTinKhachHang;
		private System.Windows.Forms.TextBox txtTongCong;
		private System.Windows.Forms.TextBox txtIMEI;
		private System.Windows.Forms.Label lbDanhSachSanPham;
		private System.Windows.Forms.Label lbTongCong;
		private System.Windows.Forms.Label lbThemSanPham;
		private System.Windows.Forms.Label lbThongTinKhachHang;
		private System.Windows.Forms.Button btnThanhToan;
	}
}