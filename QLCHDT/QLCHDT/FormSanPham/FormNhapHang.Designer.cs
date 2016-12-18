namespace QLCHDT.FormSanPham
{
	partial class FormNhapHang
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
			this.lbDoiTac = new System.Windows.Forms.Label();
			this.lbDanhSachSanPham = new System.Windows.Forms.Label();
			this.btnThemSanPham = new System.Windows.Forms.Button();
			this.lbThemSanPham = new System.Windows.Forms.Label();
			this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.txtIMEI = new System.Windows.Forms.TextBox();
			this.cbbDoiTac = new System.Windows.Forms.ComboBox();
			this.btnLuu = new System.Windows.Forms.Button();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.lbSoLuong = new System.Windows.Forms.Label();
			this.lbGiaMua = new System.Windows.Forms.Label();
			this.txtGiaMua = new System.Windows.Forms.TextBox();
			this.cbbChiTietSanPham = new System.Windows.Forms.ComboBox();
			this.lbChiTietSanPham = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbDoiTac
			// 
			this.lbDoiTac.AutoSize = true;
			this.lbDoiTac.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbDoiTac.ForeColor = System.Drawing.Color.White;
			this.lbDoiTac.Location = new System.Drawing.Point(89, 29);
			this.lbDoiTac.Name = "lbDoiTac";
			this.lbDoiTac.Size = new System.Drawing.Size(76, 21);
			this.lbDoiTac.TabIndex = 0;
			this.lbDoiTac.Text = "Đối Tác:";
			// 
			// lbDanhSachSanPham
			// 
			this.lbDanhSachSanPham.AutoSize = true;
			this.lbDanhSachSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbDanhSachSanPham.ForeColor = System.Drawing.Color.White;
			this.lbDanhSachSanPham.Location = new System.Drawing.Point(12, 286);
			this.lbDanhSachSanPham.Name = "lbDanhSachSanPham";
			this.lbDanhSachSanPham.Size = new System.Drawing.Size(175, 21);
			this.lbDanhSachSanPham.TabIndex = 0;
			this.lbDanhSachSanPham.Text = "Danh Sách Sản Phẩm:";
			// 
			// btnThemSanPham
			// 
			this.btnThemSanPham.AutoSize = true;
			this.btnThemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThemSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThemSanPham.ForeColor = System.Drawing.Color.White;
			this.btnThemSanPham.Location = new System.Drawing.Point(423, 227);
			this.btnThemSanPham.Name = "btnThemSanPham";
			this.btnThemSanPham.Size = new System.Drawing.Size(145, 33);
			this.btnThemSanPham.TabIndex = 3;
			this.btnThemSanPham.Text = "Thêm Sản Phẩm";
			this.btnThemSanPham.UseVisualStyleBackColor = true;
			this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
			// 
			// lbThemSanPham
			// 
			this.lbThemSanPham.AutoSize = true;
			this.lbThemSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbThemSanPham.ForeColor = System.Drawing.Color.White;
			this.lbThemSanPham.Location = new System.Drawing.Point(28, 233);
			this.lbThemSanPham.Name = "lbThemSanPham";
			this.lbThemSanPham.Size = new System.Drawing.Size(137, 21);
			this.lbThemSanPham.TabIndex = 0;
			this.lbThemSanPham.Text = "Thêm Sản Phẩm:";
			// 
			// flowPanel
			// 
			this.flowPanel.BackColor = System.Drawing.SystemColors.ControlDark;
			this.flowPanel.Location = new System.Drawing.Point(32, 310);
			this.flowPanel.Name = "flowPanel";
			this.flowPanel.Size = new System.Drawing.Size(709, 274);
			this.flowPanel.TabIndex = 4;
			this.flowPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowPanel_ControlAdded);
			this.flowPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowPanel_ControlRemoved);
			// 
			// txtIMEI
			// 
			this.txtIMEI.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtIMEI.Location = new System.Drawing.Point(171, 230);
			this.txtIMEI.Name = "txtIMEI";
			this.txtIMEI.Size = new System.Drawing.Size(246, 29);
			this.txtIMEI.TabIndex = 2;
			// 
			// cbbDoiTac
			// 
			this.cbbDoiTac.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cbbDoiTac.FormattingEnabled = true;
			this.cbbDoiTac.Location = new System.Drawing.Point(171, 26);
			this.cbbDoiTac.Name = "cbbDoiTac";
			this.cbbDoiTac.Size = new System.Drawing.Size(406, 29);
			this.cbbDoiTac.TabIndex = 1;
			// 
			// btnLuu
			// 
			this.btnLuu.AutoSize = true;
			this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnLuu.ForeColor = System.Drawing.Color.White;
			this.btnLuu.Location = new System.Drawing.Point(682, 125);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(102, 33);
			this.btnLuu.TabIndex = 3;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtSoLuong.Location = new System.Drawing.Point(171, 179);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(246, 29);
			this.txtSoLuong.TabIndex = 2;
			this.txtSoLuong.Text = "0";
			this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
			// 
			// lbSoLuong
			// 
			this.lbSoLuong.AutoSize = true;
			this.lbSoLuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbSoLuong.ForeColor = System.Drawing.Color.White;
			this.lbSoLuong.Location = new System.Drawing.Point(76, 182);
			this.lbSoLuong.Name = "lbSoLuong";
			this.lbSoLuong.Size = new System.Drawing.Size(89, 21);
			this.lbSoLuong.TabIndex = 0;
			this.lbSoLuong.Text = "Số Lượng:";
			// 
			// lbGiaMua
			// 
			this.lbGiaMua.AutoSize = true;
			this.lbGiaMua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbGiaMua.ForeColor = System.Drawing.Color.White;
			this.lbGiaMua.Location = new System.Drawing.Point(87, 131);
			this.lbGiaMua.Name = "lbGiaMua";
			this.lbGiaMua.Size = new System.Drawing.Size(78, 21);
			this.lbGiaMua.TabIndex = 0;
			this.lbGiaMua.Text = "Giá Mua:";
			// 
			// txtGiaMua
			// 
			this.txtGiaMua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtGiaMua.Location = new System.Drawing.Point(171, 128);
			this.txtGiaMua.Name = "txtGiaMua";
			this.txtGiaMua.Size = new System.Drawing.Size(246, 29);
			this.txtGiaMua.TabIndex = 2;
			this.txtGiaMua.Text = "0";
			// 
			// cbbChiTietSanPham
			// 
			this.cbbChiTietSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cbbChiTietSanPham.FormattingEnabled = true;
			this.cbbChiTietSanPham.Location = new System.Drawing.Point(171, 77);
			this.cbbChiTietSanPham.Name = "cbbChiTietSanPham";
			this.cbbChiTietSanPham.Size = new System.Drawing.Size(613, 29);
			this.cbbChiTietSanPham.TabIndex = 1;
			// 
			// lbChiTietSanPham
			// 
			this.lbChiTietSanPham.AutoSize = true;
			this.lbChiTietSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbChiTietSanPham.ForeColor = System.Drawing.Color.White;
			this.lbChiTietSanPham.Location = new System.Drawing.Point(12, 80);
			this.lbChiTietSanPham.Name = "lbChiTietSanPham";
			this.lbChiTietSanPham.Size = new System.Drawing.Size(153, 21);
			this.lbChiTietSanPham.TabIndex = 0;
			this.lbChiTietSanPham.Text = "Chi Tiết Sản Phẩm:";
			// 
			// FormNhapHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(799, 596);
			this.Controls.Add(this.flowPanel);
			this.Controls.Add(this.btnThemSanPham);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.txtIMEI);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.lbDanhSachSanPham);
			this.Controls.Add(this.txtGiaMua);
			this.Controls.Add(this.lbThemSanPham);
			this.Controls.Add(this.lbSoLuong);
			this.Controls.Add(this.cbbChiTietSanPham);
			this.Controls.Add(this.lbGiaMua);
			this.Controls.Add(this.lbChiTietSanPham);
			this.Controls.Add(this.cbbDoiTac);
			this.Controls.Add(this.lbDoiTac);
			this.Name = "FormNhapHang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nhập Hàng";
			this.Load += new System.EventHandler(this.FormNhapHang_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbDoiTac;
		private System.Windows.Forms.Label lbDanhSachSanPham;
		private System.Windows.Forms.Button btnThemSanPham;
		private System.Windows.Forms.Label lbThemSanPham;
		private System.Windows.Forms.FlowLayoutPanel flowPanel;
		private System.Windows.Forms.TextBox txtIMEI;
		private System.Windows.Forms.ComboBox cbbDoiTac;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Label lbSoLuong;
		private System.Windows.Forms.Label lbGiaMua;
		private System.Windows.Forms.TextBox txtGiaMua;
		private System.Windows.Forms.ComboBox cbbChiTietSanPham;
		private System.Windows.Forms.Label lbChiTietSanPham;
	}
}