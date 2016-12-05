namespace QLCHDT
{
	partial class FormLogin
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
			this.lbTenDangNhap = new System.Windows.Forms.Label();
			this.txtTenDangNhap = new System.Windows.Forms.TextBox();
			this.lbMatKhau = new System.Windows.Forms.Label();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbTenDangNhap
			// 
			this.lbTenDangNhap.AutoSize = true;
			this.lbTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbTenDangNhap.ForeColor = System.Drawing.Color.White;
			this.lbTenDangNhap.Location = new System.Drawing.Point(43, 46);
			this.lbTenDangNhap.Name = "lbTenDangNhap";
			this.lbTenDangNhap.Size = new System.Drawing.Size(129, 21);
			this.lbTenDangNhap.TabIndex = 1;
			this.lbTenDangNhap.Text = "Tên Đăng Nhập";
			// 
			// txtTenDangNhap
			// 
			this.txtTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtTenDangNhap.Location = new System.Drawing.Point(178, 43);
			this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
			this.txtTenDangNhap.Name = "txtTenDangNhap";
			this.txtTenDangNhap.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTenDangNhap.Size = new System.Drawing.Size(235, 29);
			this.txtTenDangNhap.TabIndex = 5;
			// 
			// lbMatKhau
			// 
			this.lbMatKhau.AutoSize = true;
			this.lbMatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbMatKhau.ForeColor = System.Drawing.Color.White;
			this.lbMatKhau.Location = new System.Drawing.Point(89, 88);
			this.lbMatKhau.Name = "lbMatKhau";
			this.lbMatKhau.Size = new System.Drawing.Size(83, 21);
			this.lbMatKhau.TabIndex = 1;
			this.lbMatKhau.Text = "Mật Khẩu";
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtMatKhau.Location = new System.Drawing.Point(178, 85);
			this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.PasswordChar = '●';
			this.txtMatKhau.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtMatKhau.Size = new System.Drawing.Size(235, 29);
			this.txtMatKhau.TabIndex = 10;
			// 
			// btnExit
			// 
			this.btnExit.AutoSize = true;
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.Location = new System.Drawing.Point(67, 139);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(105, 34);
			this.btnExit.TabIndex = 20;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.AutoSize = true;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(308, 139);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(105, 34);
			this.btnLogin.TabIndex = 15;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// FormLogin
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(472, 185);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.txtTenDangNhap);
			this.Controls.Add(this.lbMatKhau);
			this.Controls.Add(this.lbTenDangNhap);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.FormLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbTenDangNhap;
		private System.Windows.Forms.TextBox txtTenDangNhap;
		private System.Windows.Forms.Label lbMatKhau;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnLogin;
	}
}