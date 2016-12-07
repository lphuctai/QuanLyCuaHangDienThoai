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
			CHI_TIET_SAN_PHAM ctsp;
			try
			{
				ctsp = CHI_TIET_SAN_PHAM.select(" where MA_CHI_TIET_SAN_PHAM = " + mactsp)[0];
			}
			catch
			{
				return false;
			}
			ctsp.CON_TON++;
			CHI_TIET_SAN_PHAM.update(ctsp);
			return true;
		}

		public static bool ThanhToan(int mactsp)
		{
			CHI_TIET_SAN_PHAM ctsp;
			try
			{
				ctsp = CHI_TIET_SAN_PHAM.select(" where MA_CHI_TIET_SAN_PHAM = " + mactsp)[0];
			}
			catch
			{
				return false;
			}
			if (ctsp.CON_TON <= 0)
				return false;
			ctsp.CON_TON--;
			CHI_TIET_SAN_PHAM.update(ctsp);
			return true;
		}
	}
}
