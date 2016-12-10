namespace QLCHDT.Cong
{
	partial class FormXacNhanCong
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
			this.cbbNhanVien = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpTu = new System.Windows.Forms.DateTimePicker();
			this.lbThoiGian = new System.Windows.Forms.Label();
			this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpDen = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// cbbNhanVien
			// 
			this.cbbNhanVien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.cbbNhanVien.FormattingEnabled = true;
			this.cbbNhanVien.Location = new System.Drawing.Point(110, 10);
			this.cbbNhanVien.Name = "cbbNhanVien";
			this.cbbNhanVien.Size = new System.Drawing.Size(340, 29);
			this.cbbNhanVien.TabIndex = 0;
			this.cbbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbbNhanVien_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nhân Viên:";
			// 
			// dtpTu
			// 
			this.dtpTu.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpTu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpTu.Location = new System.Drawing.Point(57, 50);
			this.dtpTu.Name = "dtpTu";
			this.dtpTu.Size = new System.Drawing.Size(233, 29);
			this.dtpTu.TabIndex = 2;
			this.dtpTu.ValueChanged += new System.EventHandler(this.dtpThoiGian_ValueChanged);
			// 
			// lbThoiGian
			// 
			this.lbThoiGian.AutoSize = true;
			this.lbThoiGian.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbThoiGian.ForeColor = System.Drawing.Color.White;
			this.lbThoiGian.Location = new System.Drawing.Point(15, 53);
			this.lbThoiGian.Name = "lbThoiGian";
			this.lbThoiGian.Size = new System.Drawing.Size(36, 21);
			this.lbThoiGian.TabIndex = 3;
			this.lbThoiGian.Text = "Từ:";
			// 
			// flowPanel
			// 
			this.flowPanel.AutoScroll = true;
			this.flowPanel.Location = new System.Drawing.Point(12, 85);
			this.flowPanel.Name = "flowPanel";
			this.flowPanel.Size = new System.Drawing.Size(578, 263);
			this.flowPanel.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(296, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 21);
			this.label2.TabIndex = 6;
			this.label2.Text = "Đến:";
			// 
			// dtpDen
			// 
			this.dtpDen.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpDen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.dtpDen.Location = new System.Drawing.Point(347, 50);
			this.dtpDen.Name = "dtpDen";
			this.dtpDen.Size = new System.Drawing.Size(233, 29);
			this.dtpDen.TabIndex = 5;
			// 
			// FormXacNhanCong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(602, 360);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpDen);
			this.Controls.Add(this.flowPanel);
			this.Controls.Add(this.lbThoiGian);
			this.Controls.Add(this.dtpTu);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbbNhanVien);
			this.Name = "FormXacNhanCong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormXacNhanCong";
			this.Load += new System.EventHandler(this.FormXacNhanCong_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbbNhanVien;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpTu;
		private System.Windows.Forms.Label lbThoiGian;
		private System.Windows.Forms.FlowLayoutPanel flowPanel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpDen;
	}
}