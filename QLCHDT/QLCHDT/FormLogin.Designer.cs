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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(43, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tên Đăng Nhập";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.textBox1.Location = new System.Drawing.Point(178, 43);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBox1.Size = new System.Drawing.Size(235, 29);
			this.textBox1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(89, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mật Khẩu";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.textBox2.Location = new System.Drawing.Point(178, 85);
			this.textBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '●';
			this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBox2.Size = new System.Drawing.Size(235, 29);
			this.textBox2.TabIndex = 2;
			// 
			// btnExit
			// 
			this.btnExit.AutoSize = true;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.Location = new System.Drawing.Point(93, 130);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(105, 34);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(308, 130);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(472, 185);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button button1;
	}
}