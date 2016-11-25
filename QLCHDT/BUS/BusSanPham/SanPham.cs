using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusSanPham
{
	class SanPham
	{
		private string imei, ghiChu;
		private int maChiTietSanPham, trangThai, giaMua, giaBan;
		private DateTime ngayBatDauBaoHanh, ngayKetThucBaoHanh;

		public SanPham(SAN_PHAM dt)
		{
			imei = dt.IMEI;
			ghiChu = dt.GHI_CHU;
			maChiTietSanPham = Convert.ToInt32(dt.MA_CHI_TIET_SAN_PHAM);
			trangThai = dt.TRANG_THAI;
			giaMua = dt.GIA_MUA;
			giaBan = dt.GIA_BAN;
			ngayBatDauBaoHanh = Convert.ToDateTime(dt.NGAY_BAT_DAU_BAO_HANH);
			ngayKetThucBaoHanh = Convert.ToDateTime(dt.NGAY_KET_THUC_BAO_HANG);
		}
		//	Get/Set accessor
		public string GhiChu
		{
			get { return ghiChu; }

			set { ghiChu = value; }
		}

		public int GiaBan
		{
			get { return giaBan; }

			set { giaBan = value; }
		}

		public int GiaMua
		{
			get { return giaMua; }

			set { giaMua = value; }
		}

		public string IMEI
		{
			get { return imei; }

			set { imei = value; }
		}

		public int MaChiTietSanPham
		{
			get { return maChiTietSanPham; }

			set { maChiTietSanPham = value; }
		}

		public DateTime NgayBatDauBaoHanh1
		{
			get { return ngayBatDauBaoHanh; }

			set { ngayBatDauBaoHanh = value; }
		}

		public DateTime NgayKetThucBaoHanh
		{
			get { return ngayKetThucBaoHanh; }

			set { ngayKetThucBaoHanh = value; }
		}

		public int TrangThai
		{
			get { return trangThai; }

			set { trangThai = value; }
		}
	}
}
