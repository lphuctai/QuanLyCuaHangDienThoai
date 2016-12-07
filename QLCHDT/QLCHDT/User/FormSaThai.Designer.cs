namespace QLCHDT.User
{
	partial class FormSaThai
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
			this.dgvNhanVien = new System.Windows.Forms.DataGridView();
			this.btNghiViec = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvNhanVien
			// 
			this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNhanVien.Location = new System.Drawing.Point(12, 12);
			this.dgvNhanVien.MultiSelect = false;
			this.dgvNhanVien.Name = "dgvNhanVien";
			this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvNhanVien.Size = new System.Drawing.Size(945, 444);
			this.dgvNhanVien.TabIndex = 0;
			// 
			// btNghiViec
			// 
			this.btNghiViec.AutoSize = true;
			this.btNghiViec.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btNghiViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btNghiViec.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btNghiViec.ForeColor = System.Drawing.Color.White;
			this.btNghiViec.Location = new System.Drawing.Point(823, 462);
			this.btNghiViec.Name = "btNghiViec";
			this.btNghiViec.Size = new System.Drawing.Size(134, 33);
			this.btNghiViec.TabIndex = 1;
			this.btNghiViec.Text = "Cho Nghĩ Việc";
			this.btNghiViec.UseVisualStyleBackColor = false;
			this.btNghiViec.Click += new System.EventHandler(this.button1_Click);
			// 
			// FormSaThai
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(969, 507);
			this.Controls.Add(this.btNghiViec);
			this.Controls.Add(this.dgvNhanVien);
			this.Name = "FormSaThai";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormSaThai";
			this.Load += new System.EventHandler(this.FormSaThai_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvNhanVien;
		private System.Windows.Forms.Button btNghiViec;
	}
}