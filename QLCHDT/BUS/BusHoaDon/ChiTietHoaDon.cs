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

		public static bool NhapHang(CHI_TIET_HOA_DON cthd)
		{
			CHI_TIET_HOA_DON.insert(cthd);
			return true;
		}

		public static bool XuatHang(CHI_TIET_HOA_DON cthd)
		{
			CHI_TIET_HOA_DON.insert(cthd);
			return true;
		}
	}
}
