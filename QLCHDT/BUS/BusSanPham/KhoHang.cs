using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusSanPham
{
	class KhoHang
	{
		public static bool LuuKho(KHO_HANG kh, List<string> imei)
		{
			int maKho = KHO_HANG.insert(kh);
			for(int i = 0; i < imei.Count; i ++)
			{
				SAN_PHAM sp = new SAN_PHAM();
				sp.IMEI = imei[i];
				sp.MA_CHI_TIET_SAN_PHAM = kh.MA_CHI_TIET_SAN_PHAM;
				sp.MA_KHO = maKho;
				sp.TRANG_THAI = 0;
				sp.GIA_MUA = kh.GIA_MUA;
				SanPham.ThemSanPham(sp);
			}
			return true;
		}
	}
}
