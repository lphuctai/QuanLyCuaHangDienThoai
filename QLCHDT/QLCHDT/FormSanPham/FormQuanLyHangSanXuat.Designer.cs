namespace QLCHDT.FormSanPham
{
	partial class FormQuanLyHangSanXuat
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
			this.lbHangSanXuat = new System.Windows.Forms.Label();
			this.txtHangSanXuat = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.dgvHangSanXuat = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvHangSanXuat)).BeginInit();
			this.SuspendLayout();
			// 
			// lbHangSanXuat
			// 
			this.lbHangSanXuat.AutoSize = true;
			this.lbHangSanXuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbHangSanXuat.ForeColor = System.Drawing.Color.White;
			this.lbHangSanXuat.Location = new System.Drawing.Point(10, 13);
			this.lbHangSanXuat.Name = "lbHangSanXuat";
			this.lbHangSanXuat.Size = new System.Drawing.Size(126, 21);
			this.lbHangSanXuat.TabIndex = 0;
			this.lbHangSanXuat.Text = "Hãng Sản Xuất:";
			// 
			// txtHangSanXuat
			// 
			this.txtHangSanXuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtHangSanXuat.Location = new System.Drawing.Point(14, 49);
			this.txtHangSanXuat.Name = "txtHangSanXuat";
			this.txtHangSanXuat.Size = new System.Drawing.Size(288, 29);
			this.txtHangSanXuat.TabIndex = 1;
			// 
			// btnThem
			// 
			this.btnThem.AutoSize = true;
			this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnThem.Location = new System.Drawing.Point(176, 96);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(126, 33);
			this.btnThem.TabIndex = 2;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// dgvHangSanXuat
			// 
			this.dgvHangSanXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvHangSanXuat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvHangSanXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHangSanXuat.Location = new System.Drawing.Point(308, 13);
			this.dgvHangSanXuat.Name = "dgvHangSanXuat";
			this.dgvHangSanXuat.ReadOnly = true;
			this.dgvHangSanXuat.Size = new System.Drawing.Size(214, 116);
			this.dgvHangSanXuat.TabIndex = 3;
			// 
			// FormQuanLyHangSanXuat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(534, 144);
			this.Controls.Add(this.dgvHangSanXuat);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.txtHangSanXuat);
			this.Controls.Add(this.lbHangSanXuat);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FormQuanLyHangSanXuat";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormQuanLyHangSanXuat";
			this.Load += new System.EventHandler(this.FormQuanLyHangSanXuat_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvHangSanXuat)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbHangSanXuat;
		private System.Windows.Forms.TextBox txtHangSanXuat;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.DataGridView dgvHangSanXuat;
	}
}