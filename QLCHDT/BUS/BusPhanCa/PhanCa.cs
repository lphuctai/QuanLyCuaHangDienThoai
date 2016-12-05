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

		public PhanCa(PHAN_CA pc)
		{
			Ca = pc.CA;
			MSNV = pc.MSNV;
			ChamCong = pc.CHAM_CONG;
			XacNhanCong = pc.XAC_NHAN_CONG;
			ThoiGian = pc.THOI_GIAN;
		}

		//	Add Shift
		public static bool ThemCaLamViec(PhanCa pc)
		{
			PHAN_CA.insert((PHAN_CA)Util.AdapterObjectToDB(pc));
			return true;
		}

		//	Timekeeping
		public static bool ChamCongHangNgay(PhanCa pc)
		{
			//Cham Cong
			PHAN_CA tmp = (PHAN_CA)Util.AdapterObjectToDB(pc);
			tmp.CHAM_CONG = true;
			Console.WriteLine(tmp.MSNV + " " + tmp.THOI_GIAN.Date + " " + tmp.CA + " " + tmp.CHAM_CONG + " " + tmp.XAC_NHAN_CONG);
			PHAN_CA.update(tmp);
            return true;
		}

		//	Confrim Shift
		public static bool XacNhanCaLamViec(PhanCa pc)
		{
			pc.XacNhanCong = true;
			PHAN_CA.update((PHAN_CA)Util.AdapterObjectToDB(pc));
			return true;
		}

		//	Delete Shift
		public static bool XoaCaLamViec(PhanCa pc)
		{
			PHAN_CA.delete(pc.MSNV, pc.ThoiGian, pc.Ca);
			return true;
		}

		//	Get Shift
		public static List<PhanCa> LayCaLamViec(NhanVien nv, DateTime thoiGianBatDau
			, DateTime thoiGianKetThuc, bool chamCong, bool xacNhanCong)
		{
			List<PHAN_CA> tmp = new List<PHAN_CA>(); ;
			try
			{
				tmp = PHAN_CA.select(" where MSNV = " + nv.MSNV + " and THOI_GIAN >= '" + thoiGianBatDau.ToShortDateString() +
										"' and THOI_GIAN <= '" + thoiGianKetThuc.ToShortDateString() + "' and CHAM_CONG = " + chamCong + " and XAC_NHAN_CONG = " + xacNhanCong + " ");
			}
			catch(Exception)
			{
				;
			}
			List<PhanCa> result = new List<PhanCa>();
			for (int i = 0; i < tmp.Count; i++)
				result.Add(new PhanCa(tmp[i]));
			return result;
		}

		//	Get Shift
		public static List<PhanCa> LayCaLamViec(NhanVien nv, DateTime thoiGianBatDau
			, DateTime thoiGianKetThuc)
		{
			List<PHAN_CA> tmp = new List<PHAN_CA>(); ;
				tmp = PHAN_CA.select(" where MSNV = " + nv.MSNV + " and THOI_GIAN >= '" + thoiGianBatDau.ToShortDateString() +
										"' and THOI_GIAN <= '" + thoiGianKetThuc.ToShortDateString()  + "' ");
			try
			{
				;
			}
			catch (Exception)
			{
				;
			}
			List<PhanCa> result = new List<PhanCa>();
			for (int i = 0; i < tmp.Count; i++)
				result.Add(new PhanCa(tmp[i]));
			return result;
		}




		//	Get/Set accessor
		public int MSNV
		{
			get; set;
		}

		public int Ca
		{
			get; set;
		}

		public bool ChamCong
		{
			get; set;
		}

		public bool XacNhanCong
		{
			get; set;
		}

		public DateTime ThoiGian
		{
			get; set;
		}
	}
}
