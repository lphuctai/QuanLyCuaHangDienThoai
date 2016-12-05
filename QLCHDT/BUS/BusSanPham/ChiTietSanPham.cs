using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusSanPham
{
	public class ChiTietSanPham
	{

		public ChiTietSanPham(CHI_TIET_SAN_PHAM ctsp)
		{
			MaChiTietSanPham = ctsp.MA_CHI_TIET_SAN_PHAM;
			ThoiGianBaoHanh = Convert.ToInt32(ctsp.THOI_GIAN_BAO_HANH);
			ConTon = Convert.ToInt32(ctsp.CON_TON);
			MaHang = ctsp.MA_HANG;
			DongSanPham = ctsp.DONG_SAN_PHAM;
			SoHieuSanPham = ctsp.SO_HIEU_SAN_PHAM;
			TenSanPham = ctsp.TEN_SAN_PHAM;
			ThongTinKyThuat = ctsp.THONG_TIN_KY_THUAT;
			ThongTinSanPham = ctsp.THONG_TIN_SAN_PHAM;
			GhiChu = ctsp.GHI_CHU;
			this.GiaMua = ctsp.GIA_MUA;
			this.GiaBan = ctsp.GIA_BAN;
		}

		public static bool ThemChiTietSanPham(ChiTietSanPham ctsp)
		{
			CHI_TIET_SAN_PHAM.insert((CHI_TIET_SAN_PHAM)Util.AdapterObjectToDB(ctsp));
			return true;
		}

		public static bool SuaChiTietSanPham(ChiTietSanPham ctsp)
		{
			CHI_TIET_SAN_PHAM.update((CHI_TIET_SAN_PHAM)Util.AdapterObjectToDB(ctsp));
			return true;
		}

		public static bool ThemSanPham(int mactsp)
		{
			ChiTietSanPham ctsp;
			try
			{
				ctsp = new ChiTietSanPham(CHI_TIET_SAN_PHAM.select(" where MA_CHI_TIET_SAN_PHAM = " + mactsp)[0]);
			}
			catch
			{
				return false;
			}
			ctsp.ConTon++;
			CHI_TIET_SAN_PHAM.update((CHI_TIET_SAN_PHAM)Util.AdapterObjectToDB(ctsp));
			return true;
		}

		public static bool ThanhToan(int mactsp)
		{
			ChiTietSanPham ctsp;
			try
			{
				ctsp = new ChiTietSanPham(CHI_TIET_SAN_PHAM.select(" where MA_CHI_TIET_SAN_PHAM = " + mactsp)[0]);
			}
			catch
			{
				return false;
			}
			if (ctsp.ConTon <= 0)
				return false;
			ctsp.ConTon--;
			CHI_TIET_SAN_PHAM.update((CHI_TIET_SAN_PHAM)Util.AdapterObjectToDB(ctsp));
			return true;
		}


		//	Get/Set accessor
		public int MaChiTietSanPham
		{
			get; set;
		}

		public int ThoiGianBaoHanh
		{
			get; set;
		}

		public int ConTon
		{
			get; set;
		}

		public int MaHang
		{
			get; set;
		}

		public string DongSanPham
		{
			get; set;
		}

		public string SoHieuSanPham
		{
			get; set;
		}

		public string TenSanPham
		{
			get; set;
		}

		public string ThongTinKyThuat
		{
			get; set;
		}

		public string ThongTinSanPham
		{
			get; set;
		}

		public string GhiChu
		{
			get; set;
		}

		public int GiaMua
		{
			get; set;
		}

		public int GiaBan
		{
			get; set;
		}
	}
}
