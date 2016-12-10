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

		public static Bitmap getIcon()
		{
			return Properties.Resources.btnHangSanXuat;
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
