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
	public partial class FormThayDoiChiTietSanPham : Form
	{
		public FormThayDoiChiTietSanPham()
		{
			InitializeComponent();
			cbbHangSanXuat.DataSource = new BindingList<HANG_SAN_XUAT>(HangSanXuat.LayHangSanXuat());
			cbbHangSanXuat.DisplayMember = "HANG";
			cbbHangSanXuat.ValueMember = "MA_HANG";
			LoadThongTin();
		}

		private void FormThayDoiChiTietSanPham_Load(object sender, EventArgs e)
		{
			dgvChiTietSanPham.DataSource = new BindingList<CHI_TIET_SAN_PHAM>(ChiTietSanPham.LayChiTietSanPham());
		}

		private void LoadThongTin()
		{
			CHI_TIET_SAN_PHAM tmp;
			try
			{
				tmp = (CHI_TIET_SAN_PHAM)dgvChiTietSanPham.SelectedRows[0].DataBoundItem;
			}
			catch(Exception)
			{
				tmp = null;
				return;
			}
			if (tmp == null || cbbHangSanXuat == null || cbbHangSanXuat.SelectedValue == null)
				return;
			cbbHangSanXuat.SelectedValue = tmp.MA_HANG;
			txtDongSanPham.Text = tmp.DONG_SAN_PHAM;
			txtSoHieuSanPham.Text = tmp.SO_HIEU_SAN_PHAM;
			txtTenSanPham.Text = tmp.TEN_SAN_PHAM;
			nudThoiGianBaoHanh.Value = Convert.ToInt32(tmp.THOI_GIAN_BAO_HANH);
			txtGiaBan.Text = tmp.GIA_BAN.ToString();
			txtThongTinKyThuat.Text = tmp.THONG_TIN_KY_THUAT;
			txtThongTinSanPham.Text = tmp.THONG_TIN_SAN_PHAM;
		}

		private void dgvChiTietSanPham_SelectionChanged(object sender, EventArgs e)
		{
			LoadThongTin();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			CHI_TIET_SAN_PHAM tmp;
			try
			{
				tmp = (CHI_TIET_SAN_PHAM)dgvChiTietSanPham.SelectedRows[0].DataBoundItem;
			}
			catch (Exception)
			{
				tmp = null;
				return;
			}
			if (tmp == null)
				return;
			ChiTietSanPham.XoaChiTietSanPham(tmp.MA_CHI_TIET_SAN_PHAM);
			CHI_TIET_SAN_PHAM ctsp = ChiTietSanPham.LayChiTietSanPham((int)cbbHangSanXuat.SelectedValue,
				txtDongSanPham.Text, txtSoHieuSanPham.Text, txtTenSanPham.Text);
			if (ctsp != null)
			{
				MessageBox.Show("Thông tin thay đổi bị trùng!");
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
				MessageBox.Show("Thay Đổi Thành Công!");
			else
				MessageBox.Show("Thay Đổi Thất Bại!");
			FormThayDoiChiTietSanPham_Load(sender, e);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			CHI_TIET_SAN_PHAM tmp;
			try
			{
				tmp = (CHI_TIET_SAN_PHAM)dgvChiTietSanPham.SelectedRows[0].DataBoundItem;
			}
			catch (Exception)
			{
				tmp = null;
				return;
			}
			if (tmp == null)
				return;
			if (ChiTietSanPham.XoaChiTietSanPham(tmp.MA_CHI_TIET_SAN_PHAM))
				MessageBox.Show("Xóa Thành Công!");
			else
				MessageBox.Show("Xóa Thất Bại!");
			FormThayDoiChiTietSanPham_Load(sender, e);
		}
	}
}
