using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusSanPham
{
	class ChiTietSanPham
	{
		private int maChiTietSanPham, thoiGianBaoHanh, conTon;
		private string hangSanXuat, dongSanPham, soHieuSanPham, tenSanPham, thongTinKyThuat, thongTinSanPham, ghiChu;

		public ChiTietSanPham(CHI_TIET_SAN_PHAM ctsp)
		{
			this.maChiTietSanPham = ctsp.MA_CHI_TIET_SAN_PHAM;
			this.thoiGianBaoHanh = Convert.ToInt32(ctsp.THOI_GIAN_BAO_HANH);
			this.conTon = Convert.ToInt32(ctsp.CON_TON);
			this.hangSanXuat = ctsp.HANG_SAN_XUAT;
			this.dongSanPham = ctsp.DONG_SAN_PHAM;
			this.soHieuSanPham = ctsp.SO_HIEU_SAN_PHAM;
			this.tenSanPham = ctsp.TEN_SAN_PHAM;
			this.thongTinKyThuat = ctsp.THONG_TIN_KY_THUAT;
			this.thongTinSanPham = ctsp.THONG_TIN_SAN_PHAM;
			this.ghiChu = ctsp.GHI_CHU;
		}






		//	Get/Set accessor
		public int MaChiTietSanPham
		{
			get
			{
				return maChiTietSanPham;
			}

			set
			{
				maChiTietSanPham = value;
			}
		}

		public int ThoiGianBaoHanh
		{
			get
			{
				return thoiGianBaoHanh;
			}

			set
			{
				thoiGianBaoHanh = value;
			}
		}

		public int ConTon
		{
			get
			{
				return conTon;
			}

			set
			{
				conTon = value;
			}
		}

		public string HangSanXuat
		{
			get
			{
				return hangSanXuat;
			}

			set
			{
				hangSanXuat = value;
			}
		}

		public string DongSanPham
		{
			get
			{
				return dongSanPham;
			}

			set
			{
				dongSanPham = value;
			}
		}

		public string SoHieuSanPham
		{
			get
			{
				return soHieuSanPham;
			}

			set
			{
				soHieuSanPham = value;
			}
		}

		public string TenSanPham
		{
			get
			{
				return tenSanPham;
			}

			set
			{
				tenSanPham = value;
			}
		}

		public string ThongTinKyThuat
		{
			get
			{
				return thongTinKyThuat;
			}

			set
			{
				thongTinKyThuat = value;
			}
		}

		public string ThongTinSanPham
		{
			get
			{
				return thongTinSanPham;
			}

			set
			{
				thongTinSanPham = value;
			}
		}

		public string GhiChu
		{
			get
			{
				return ghiChu;
			}

			set
			{
				ghiChu = value;
			}
		}
	}
}
