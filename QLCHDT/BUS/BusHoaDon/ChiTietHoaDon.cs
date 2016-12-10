using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusHoaDon
{
	public class ChiTietHoaDon
	{
		public ChiTietHoaDon()
		{
		}

		public static bool NhapHang(int maHoaDon, string imei, int gia)
		{
			CHI_TIET_HOA_DON tmp = new CHI_TIET_HOA_DON();
			tmp.GIA = gia;
			tmp.MA_HOA_DON = maHoaDon;
			tmp.IMEI = imei;
			CHI_TIET_HOA_DON.insert(tmp);
			return true;
		}

		public static List<CHI_TIET_HOA_DON> LayChiTietHoaDon(int maHoaDon)
		{
			try
			{
				return CHI_TIET_HOA_DON.select(" where MA_HOA_DON = " + maHoaDon + " ");
			}
			catch(Exception)
			{
				return null;
			}
		}

		public static bool XuatHang(int maHoaDon, SAN_PHAM sp)
		{
			CHI_TIET_HOA_DON tmp = new CHI_TIET_HOA_DON();
			tmp.GIA = sp.GIA_BAN;
			tmp.MA_HOA_DON = maHoaDon;
			tmp.IMEI = sp.IMEI;
			CHI_TIET_HOA_DON.insert(tmp);
			return true;
		}
	}
}
