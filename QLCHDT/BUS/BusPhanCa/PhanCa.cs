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
		protected int msnv, ca;
		protected bool chamCong, xacNhanCong;
		protected DateTime thoiGian;

		public PhanCa(PHAN_CA pc)
		{
			this.ca = pc.CA;
			this.msnv = pc.MSNV;
			this.chamCong = pc.CHAM_CONG;
			this.xacNhanCong = pc.XAC_NHAN_CONG;
			this.thoiGian = pc.THOI_GIAN;
		}

		//	Add Shift
		public static bool ThemCaLamViec(PhanCa pc)
		{
			EntityConnect.getConnection().PHAN_CA.Add((PHAN_CA)Util.AdapterObjectToDB(pc));
			return EntityConnect.SaveChange() == 1;
		}

		//	Timekeeping
		public static bool ChamCongHangNgay(PhanCa pc)
		{
			//Cham Cong
			pc.ChamCong = true;
			EntityConnect.Update((PHAN_CA)Util.AdapterObjectToDB(pc));
			return EntityConnect.SaveChange() == 1;
		}

		//	Confrim Shift
		public static bool XacNhanCaLamViec(PhanCa pc)
		{
			pc.XacNhanCong = true;
			EntityConnect.Update((PHAN_CA)Util.AdapterObjectToDB(pc));
			return EntityConnect.SaveChange() == 1;
		}

		//	Delete Shift
		public static bool XoaCaLamViec(PhanCa pc)
		{
			EntityConnect.Delete((PHAN_CA)Util.AdapterObjectToDB(pc));
			return EntityConnect.SaveChange() == 1;
		}

		//	Get Shift
		public static List<PhanCa> LayCaLamViec(NhanVien nv, DateTime thoiGianBatDau
			, DateTime thoiGianKetThuc, bool chamCong, bool xacNhanCong)
		{
			List<PHAN_CA> tmp = (from i in EntityConnect.getConnection().PHAN_CA
								 where i.MSNV == nv.MSNV && i.THOI_GIAN >= thoiGianBatDau
										&& i.THOI_GIAN <= thoiGianKetThuc && i.CHAM_CONG == chamCong && i.XAC_NHAN_CONG == xacNhanCong
								 select i).ToList<PHAN_CA>();
			List<PhanCa> result = new List<PhanCa>();
			for (int i = 0; i < tmp.Count; i++)
				result.Add(new PhanCa(tmp[i]));
			return result;
		}




		//	Get/Set accessor
		public int MSNV
		{
			get { return msnv; }
			set { msnv = value; }
		}

		public int Ca
		{
			get { return ca; }
			set { ca = value; }
		}

		public bool ChamCong
		{
			get { return chamCong; }
			set { chamCong = value; }
		}

		public bool XacNhanCong
		{
			get { return xacNhanCong; }
			set { xacNhanCong = value; }
		}

		public DateTime ThoiGian
		{
			get { return thoiGian; }
			set { thoiGian = value; }
		}
	}
}
