using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusHoaDon
{
	public abstract class HoaDon
	{
		protected int maHoaDon, msnvThucHien;
		protected DateTime thoiGian;
		protected string ghiChu;

		protected HoaDon(HOA_DON hd)
		{
			maHoaDon = hd.MA_HOA_DON;
			msnvThucHien = Convert.ToInt32(hd.MSNV_THUC_HIEN);
			thoiGian = Convert.ToDateTime(hd.THOI_GIAN);
			ghiChu = hd.GHI_CHU;
		}
		
		public int getLoaiHoaDon()
		{
			Type loai = this.GetType();
			if (loai == typeof(PhieuNhap))
				return 1;
			if (loai == typeof(PhieuXuat))
				return 2;
			if (loai == typeof(BienNhan))
				return 3;
			return 0;
		}



		//	Get/Set accessor
		public int MaHoaDon
		{
			get { return maHoaDon; }
			set { maHoaDon = value; }
		}

		public int MSNVThucHien
		{
			get { return msnvThucHien; }
			set { msnvThucHien = value; }
		}

		public DateTime ThoiGian
		{
			get { return thoiGian; }
			set { thoiGian = value; }
		}

		public string GhiChu
		{
			get { return ghiChu; }
			set { ghiChu = value; }
		}
	}
}
