namespace QLCHDT.DoiTac
{
	partial class FormThayDoiDoiTac
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
			this.cbbMaDoiTac = new System.Windows.Forms.ComboBox();
			this.lbDoiTac = new System.Windows.Forms.Label();
			this.txtDoiTac = new System.Windows.Forms.TextBox();
			this.lbMaDoiTac = new System.Windows.Forms.Label();
			this.lbSoDienThoai = new System.Windows.Forms.Label();
			this.txtSoDienThoai = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbbMaDoiTac
			// 
			this.cbbMaDoiTac.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cbbMaDoiTac.FormattingEnabled = true;
			this.cbbMaDoiTac.Location = new System.Drawing.Point(141, 15);
			this.cbbMaDoiTac.Name = "cbbMaDoiTac";
			this.cbbMaDoiTac.Size = new System.Drawing.Size(381, 29);
			this.cbbMaDoiTac.TabIndex = 0;
			this.cbbMaDoiTac.SelectedIndexChanged += new System.EventHandler(this.cbbMaDoiTac_SelectedIndexChanged);
			// 
			// lbDoiTac
			// 
			this.lbDoiTac.AutoSize = true;
			this.lbDoiTac.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbDoiTac.ForeColor = System.Drawing.Color.White;
			this.lbDoiTac.Location = new System.Drawing.Point(59, 68);
			this.lbDoiTac.Name = "lbDoiTac";
			this.lbDoiTac.Size = new System.Drawing.Size(76, 21);
			this.lbDoiTac.TabIndex = 1;
			this.lbDoiTac.Text = "Đối Tác:";
			// 
			// txtDoiTac
			// 
			this.txtDoiTac.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtDoiTac.Location = new System.Drawing.Point(141, 65);
			this.txtDoiTac.Name = "txtDoiTac";
			this.txtDoiTac.Size = new System.Drawing.Size(381, 29);
			this.txtDoiTac.TabIndex = 2;
			// 
			// lbMaDoiTac
			// 
			this.lbMaDoiTac.AutoSize = true;
			this.lbMaDoiTac.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbMaDoiTac.ForeColor = System.Drawing.Color.White;
			this.lbMaDoiTac.Location = new System.Drawing.Point(30, 18);
			this.lbMaDoiTac.Name = "lbMaDoiTac";
			this.lbMaDoiTac.Size = new System.Drawing.Size(105, 21);
			this.lbMaDoiTac.TabIndex = 1;
			this.lbMaDoiTac.Text = "Mã Đối Tác:";
			// 
			// lbSoDienThoai
			// 
			this.lbSoDienThoai.AutoSize = true;
			this.lbSoDienThoai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbSoDienThoai.ForeColor = System.Drawing.Color.White;
			this.lbSoDienThoai.Location = new System.Drawing.Point(12, 118);
			this.lbSoDienThoai.Name = "lbSoDienThoai";
			this.lbSoDienThoai.Size = new System.Drawing.Size(123, 21);
			this.lbSoDienThoai.TabIndex = 1;
			this.lbSoDienThoai.Text = "Số Điện Thoại:";
			// 
			// txtSoDienThoai
			// 
			this.txtSoDienThoai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtSoDienThoai.Location = new System.Drawing.Point(141, 115);
			this.txtSoDienThoai.Name = "txtSoDienThoai";
			this.txtSoDienThoai.Size = new System.Drawing.Size(381, 29);
			this.txtSoDienThoai.TabIndex = 2;
			// 
			// btnSave
			// 
			this.btnSave.AutoSize = true;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(397, 176);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(125, 33);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.AutoSize = true;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(16, 176);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(125, 33);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// FormThayDoiDoiTac
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(542, 225);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtSoDienThoai);
			this.Controls.Add(this.lbSoDienThoai);
			this.Controls.Add(this.txtDoiTac);
			this.Controls.Add(this.lbMaDoiTac);
			this.Controls.Add(this.lbDoiTac);
			this.Controls.Add(this.cbbMaDoiTac);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FormThayDoiDoiTac";
			this.Text = "ThayDoiDoiTac";
			this.Load += new System.EventHandler(this.ThayDoiDoiTac_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbbMaDoiTac;
		private System.Windows.Forms.Label lbDoiTac;
		private System.Windows.Forms.TextBox txtDoiTac;
		private System.Windows.Forms.Label lbMaDoiTac;
		private System.Windows.Forms.Label lbSoDienThoai;
		private System.Windows.Forms.TextBox txtSoDienThoai;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
	}
}