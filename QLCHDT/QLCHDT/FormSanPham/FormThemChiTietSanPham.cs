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
	public partial class FormThemChiTietSanPham : Form
	{
		public FormThemChiTietSanPham()
		{
			InitializeComponent();
		}

		private void FormThemChiTietSanPham_Load(object sender, EventArgs e)
		{
			cbbHangSanXuat.DataSource = new BindingList<HANG_SAN_XUAT>(HangSanXuat.LayHangSanXuat());
			cbbHangSanXuat.DisplayMember = "HANG";
			cbbHangSanXuat.ValueMember = "MA_HANG";
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			CHI_TIET_SAN_PHAM ctsp = ChiTietSanPham.LayChiTietSanPham((int)cbbHangSanXuat.SelectedValue, 
				txtDongSanPham.Text, txtSoHieuSanPham.Text, txtTenSanPham.Text);
			if(ctsp != null)
			{
				MessageBox.Show("Thông tin thêm bị trùng!");
				return;
			}
			ctsp = new CHI_TIET_SAN_PHAM();
			ctsp.MA_HANG = (int)cbbHangSanXuat.SelectedValue;
			ctsp.DONG_SAN_PHAM = txtDongSanPham.Text;
			ctsp.SO_HIEU_SAN_PHAM = txtSoHieuSanPham.Text;
			ctsp.TEN_SAN_PHAM = txtTenSanPham.Text;
			ctsp.THONG_TIN_KY_THUAT = txtThongTinKyThuat.Text;
			ctsp.THONG_TIN_SAN_PHAM = txtThongTinSanPham.Text;
			ctsp.THOI_GIAN_BAO_HANH = Convert.ToInt32(nudThoiGianBaoHanh.Value);
			ctsp.GIA_BAN = Convert.ToInt32(txtGiaBan.Text);
			if (ChiTietSanPham.ThemChiTietSanPham(ctsp))
				MessageBox.Show("Thêm Thành Công!");
			else
				MessageBox.Show("Thêm Thất Bại!");
		}
	}
}
