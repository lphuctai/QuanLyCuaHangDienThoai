using BUS.BusSanPham;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusHoaDon
{
	public class PhieuNhap : HoaDon
	{

		public PhieuNhap(HOA_DON hd)
			:base(hd)
		{
			TongCong = Convert.ToInt32(hd.TONG_CONG);
			MaDoiTac = Convert.ToInt32(hd.MA_DOI_TAC);
		}

		public static int TaoPhieuNhap(int maDoiTac)
		{
			HOA_DON tmp = new HOA_DON();
			tmp.MA_HOA_DON = 0;
			tmp.TONG_CONG = 0;
			tmp.LOAI_HOA_DON = 1;
			tmp.TONG_CONG = 0;
			tmp.THOI_GIAN = DateTime.Now;
			tmp.MSNV_THUC_HIEN = Init.nhanVien.MSNV;
			tmp.MA_DOI_TAC = maDoiTac;
			return HOA_DON.insert(tmp);
        }

		public static bool NhapHang(int maHoaDon, List<SanPham> sps, List<ChiTietHoaDon>cthds)
		{
			HOA_DON tmp;
			try
			{
				tmp = HOA_DON.select(" where MA_HOA_DON = " + maHoaDon)[0];
			}
			catch(Exception)
			{
				return false;
			}
			int tongCong = 0;
			for(int i = 0; i < sps.Count; i ++)
			{
				SanPham.ThemSanPham(sps[i]);
				cthds[i].MaHoaDon = tmp.MA_HOA_DON;
				ChiTietHoaDon.NhapHang(cthds[i]);
				ChiTietSanPham.ThemSanPham(sps[i].MaChiTietSanPham);
				tongCong += cthds[i].Gia;
			}
			HOA_DON.update(tmp);
			return true;
		}

		//	Get/Set accessor
		public int TongCong
		{
			get; set;
		}

		public int MaDoiTac
		{
			get; set;
		}

	}
}
