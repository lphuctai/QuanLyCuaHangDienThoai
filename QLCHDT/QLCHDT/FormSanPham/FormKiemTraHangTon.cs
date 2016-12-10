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
	public partial class FormKiemTraHangTon : Form
	{
		public FormKiemTraHangTon()
		{
			InitializeComponent();
			cbbChiTietSanPham.DataSource = ChiTietSanPham.LayChiTietSanPham();
			cbbChiTietSanPham.DisplayMember = "DINH_DANH";
			cbbChiTietSanPham.ValueMember = "MA_CHI_TIET_SAN_PHAM";
		}

		public static Bitmap getIcon()
		{
			return Properties.Resources.btnKiemTraHangTon;
		}

		private void FormKiemTraHangTon_Load(object sender, EventArgs e)
		{
			cbbChiTietSanPham_SelectedIndexChanged(sender, e);
		}

		private void cbbChiTietSanPham_SelectedIndexChanged(object sender, EventArgs e)
		{
			int maChiTietSanPham = (int)cbbChiTietSanPham.SelectedValue;
			CHI_TIET_SAN_PHAM ctsp = ChiTietSanPham.LayChiTietSanPham(maChiTietSanPham);
			int conTon = KhoHang.GetTonKho(maChiTietSanPham);
			Console.WriteLine(conTon);
			txtConLai.Text = conTon.ToString();
			txtGiaBan.Text = ctsp.GIA_BAN.ToString();
			txtThoiGianBaoHanh.Text = ctsp.THOI_GIAN_BAO_HANH.ToString();
			txtThongTinKyThuat.Text = ctsp.THONG_TIN_KY_THUAT;
			txtThongTinSanPham.Text = ctsp.THONG_TIN_SAN_PHAM;
		}
	}
}
