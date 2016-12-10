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

		public ChiTietSanPham()
		{
		}

		public static bool ThemChiTietSanPham(CHI_TIET_SAN_PHAM ctsp)
		{
			CHI_TIET_SAN_PHAM.insert(ctsp);
			return true;
		}

		public static bool SuaChiTietSanPham(CHI_TIET_SAN_PHAM ctsp)
		{
			CHI_TIET_SAN_PHAM.update(ctsp);
			return true;
		}

		public static bool ThemSanPham(int mactsp)
		{
			return false;
		}

		public static List<CHI_TIET_SAN_PHAM> LayChiTietSanPham()
		{
			return CHI_TIET_SAN_PHAM.select(" ");
		}

		public static CHI_TIET_SAN_PHAM LayChiTietSanPham(int maChiTietSanPham)
		{
			try
			{
				return CHI_TIET_SAN_PHAM.select(" where MA_CHI_TIET_SAN_PHAM = " + maChiTietSanPham + " ")[0];
			}
			catch(Exception)
			{
				return null;
			}
		}

		public static CHI_TIET_SAN_PHAM LayChiTietSanPham(int maHang, string dongSanPham, string soHieu, string tenSanPham)
		{
			try
			{
				return CHI_TIET_SAN_PHAM.select(" where MA_HANG = " + maHang + " and DONG_SAN_PHAM = '" + dongSanPham + "' and SO_HIEU_SAN_PHAM = '" 
					+ soHieu + "' and TEN_SAN_PHAM = '" + tenSanPham + "' ")[0];
			}
			catch (Exception)
			{
				return null;
			}
		}

		public static bool XoaChiTietSanPham(int ma)
		{
			CHI_TIET_SAN_PHAM.delete(ma);
			return true;
		}

		public static bool ThanhToan(int mactsp)
		{
			return false;
		}
	}
}
