using BUS.BusNhanVien;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusPhanCa
{
	public class PhanCa
	{

		public PhanCa()
		{
		}

		//	Add Shift
		public static bool ThemCaLamViec(List<PHAN_CA> pc)
		{
			for(int i = 0; i < pc.Count; i++)
				PHAN_CA.insert(pc[i]);
			return true;
		}

		//	Add Shift
		public static bool ThemCaLamViec(PHAN_CA pc)
		{
			PHAN_CA.insert(pc);
			return true;
		}

		//	Timekeeping
		public static bool ChamCongHangNgay(PHAN_CA pc)
		{
			//Cham Cong
			pc.CHAM_CONG = 1;
			PHAN_CA.update(pc);
            return true;
		}

		//	Confrim Shift
		public static bool XacNhanCaLamViec(PHAN_CA pc)
		{
			pc.XAC_NHAN_CONG = 1;
			PHAN_CA.update(pc);
			return true;
		}

		//	Delete Shift
		public static bool XoaCaLamViec(PHAN_CA pc)
		{
			PHAN_CA.delete(pc.MSNV, pc.THOI_GIAN, pc.CA);
			return true;
		}

		//	Get Shift
		public static List<PHAN_CA> LayCaLamViec(int msnv, DateTime thoiGianBatDau
			, DateTime thoiGianKetThuc)
		{
			List<PHAN_CA> tmp = new List<PHAN_CA>(); ;
			try
			{
				tmp = PHAN_CA.select(" where MSNV = " + msnv + " and THOI_GIAN >= '" + thoiGianBatDau.ToShortDateString() +
										"' and THOI_GIAN <= '" + thoiGianKetThuc.ToShortDateString() + "' ");
			}
			catch(Exception)
			{
				;
			}
			List<PHAN_CA> result = new List<PHAN_CA>();
			for (int i = 0; i < tmp.Count; i++)
				result.Add(tmp[i]);
			return result;
		}

		//	Get Shift
		public static List<PHAN_CA> LayCaLamViec(int msnv, DateTime thoiGian)
		{
			return PHAN_CA.select(" where MSNV = " + msnv + " and THOI_GIAN = '" + thoiGian + "' order by MSNV, CA");
		}
	}
}
