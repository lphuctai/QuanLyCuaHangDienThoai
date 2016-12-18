using BUS.BusSanPham;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHDT.FormSanPham
{
	public partial class FormQuanLyHangSanXuat : Form
	{
		public FormQuanLyHangSanXuat()
		{
			InitializeComponent();
		}

		public static Button getButton()
		{
			System.Windows.Forms.Button tmp = new System.Windows.Forms.Button();
			tmp.Text = "Hãng S.Xuất";
			tmp.Image = Properties.Resources.btnHangSanXuat;
			tmp.AutoSize = true;
			tmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			tmp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			tmp.ForeColor = System.Drawing.Color.White;
			tmp.Location = new System.Drawing.Point(23, 23);
			tmp.Size = new System.Drawing.Size(120, 120);
			tmp.Margin = new System.Windows.Forms.Padding(10);
			tmp.TabIndex = 0;
			tmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			tmp.UseVisualStyleBackColor = false;
			tmp.Click += new System.EventHandler(btnSelected);
			return tmp;
		}

		private static void btnSelected(object sender, EventArgs e)
		{
			FormQuanLyHangSanXuat formQuanLyHangSanXuat = new FormQuanLyHangSanXuat();
			formQuanLyHangSanXuat.ShowDialog();
		}

		private void FormQuanLyHangSanXuat_Load(object sender, EventArgs e)
		{
			LoadThongTin();
		}

		private void LoadThongTin()
		{
			dgvHangSanXuat.DataSource = HangSanXuat.LayHangSanXuat();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if(txtHangSanXuat.Text.Length == 0)
			{
				MessageBox.Show("Chưa Nhập Dữ Liệu!");
				return;
			}
			HANG_SAN_XUAT hsx = HangSanXuat.LayHangSanXuat(txtHangSanXuat.Text) ;
			if (hsx != null)
			{
				MessageBox.Show("Dữ Liệu Tồn Tại!");
				return;
			}
			hsx = new HANG_SAN_XUAT();
			hsx.HANG = txtHangSanXuat.Text;
			if (HangSanXuat.ThemHangSanXuat(hsx))
			{
				MessageBox.Show("Thêm Thành Công!");
				LoadThongTin();
				txtHangSanXuat.Text = "";
			}
			else
				MessageBox.Show("Thêm Thất Bại!");
		}
	}
}
