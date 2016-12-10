using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusSanPham
{
	public class KhoHang
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

		public static SAN_PHAM XuatKho(SAN_PHAM imei) // Return Gia Mua Vao
		{
			KHO_HANG kh = KhoHang.LayKhoHang(imei.MA_KHO);
			kh.CON_LAI--;
			KHO_HANG.update(kh);
			imei.GIA_MUA = kh.GIA_MUA;
			return SanPham.ThanhToan(imei);
		}

		public static KHO_HANG LayKhoHang(int maKho)
		{
			try
			{
				return KHO_HANG.select(" where MA_KHO = " + maKho + " ")[0];
			}
			catch(Exception)
			{
				return null;
			}
		}

		public static int GetTonKho(int maChiTietSanPham)
		{
			List<KHO_HANG> khs = KHO_HANG.select(" where MA_CHI_TIET_SAN_PHAM = " + maChiTietSanPham + " ");
			int tongCong = 0;
			for (int i = 0; i < khs.Count; i++)
				tongCong += khs[i].CON_LAI;
			return tongCong;
		}
	}
}
