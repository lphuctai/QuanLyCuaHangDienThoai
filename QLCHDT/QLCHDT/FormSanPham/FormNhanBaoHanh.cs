using BUS.BusHoaDon;
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
	public partial class FormNhanBaoHanh : Form
	{
		public FormNhanBaoHanh()
		{
			InitializeComponent();
			cbbTrangThai.DataSource = new BindingList<TRANG_THAI_SAN_PHAM>(TrangThaiSanPham.LayTrangThaiSanPham());
			cbbTrangThai.DisplayMember = "TRANG_THAI";
			cbbTrangThai.ValueMember = "MA_TRANG_THAI";
			btnNhanBaoHanh.Enabled = false;
		}

		public static Bitmap getIcon()
		{
			return Properties.Resources.btnNhanBaoHanh;
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			string s = txtIMEI.Text;
			SAN_PHAM sp = SanPham.TimSanPham(s);
			if(sp == null)
			{
				//InitializeComponent();
				lbThongBao.Text = "!!!Không Tìm Thấy!!!";
				txtMaKho.Text = "";
				txtChiTietSanPham.Text = "";
				dtpNgayBatDauBaoHanh.Value = DateTime.Now;
				dtpNgayKetThucBaoHanh.Value = DateTime.Now;
				txtGiaBan.Text = "0";
				txtGiaMua.Text = "0";
				btnNhanBaoHanh.Enabled = false;
				return;
			}
			else
			{
				lbThongBao.Text = "!!!Đã Tìm Thấy!!!";
				txtMaKho.Text = sp.MA_KHO.ToString();
				txtChiTietSanPham.Text = ChiTietSanPham.LayChiTietSanPham(sp.MA_CHI_TIET_SAN_PHAM).DINH_DANH;
				dtpNgayBatDauBaoHanh.Value = Convert.ToDateTime(sp.NGAY_BAT_DAU_BAO_HANH);
				dtpNgayKetThucBaoHanh.Value = Convert.ToDateTime(sp.NGAY_KET_THUC_BAO_HANH);
				txtGiaBan.Text = sp.GIA_BAN.ToString();
				txtGiaMua.Text = sp.GIA_MUA.ToString();
				cbbTrangThai.SelectedValue = sp.TRANG_THAI;
				if((int)cbbTrangThai.SelectedValue == 1)
				{
					btnNhanBaoHanh.Enabled = true;
				}
			}
		}

		private void txtNhanBaoHanh_Click(object sender, EventArgs e)
		{
			string imei = txtIMEI.Text;
			string thongTinKhachHang = txtThongTinKhachHang.Text;
			int maHoaDon = BienNhan.GuiBaoHanh(imei, thongTinKhachHang);

			if (maHoaDon != 0)
			{
				MessageBox.Show("Nhận Bảo Hành Thành Công!\nMã Hóa Đơn Là: " + maHoaDon);
				btnNhanBaoHanh.Enabled = false;
			}
			else
				MessageBox.Show("Nhận Bảo Hành Thất Bại!");
		}
	}
}
