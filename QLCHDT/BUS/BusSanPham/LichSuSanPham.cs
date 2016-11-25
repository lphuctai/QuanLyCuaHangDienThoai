using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusSanPham
{
	class LichSuSanPham
	{
		private string imei, ghiChu;
		private DateTime thoiGian;
		private int maLichSu, msnvThucHien;

		public LichSuSanPham(LICH_SU_SAN_PHAM lssp)
		{
			this.imei = lssp.IMEI;
			this.ghiChu = lssp.GHI_CHU;
			this.thoiGian = lssp.THOI_GIAN;
			this.maLichSu = lssp.MA_LICH_SU;
			this.msnvThucHien = Convert.ToInt32(lssp.MSNV_THUC_HIEN);
		}



		//	Get/Set accessor
		public string IMEI
		{
			get
			{
				return imei;
			}

			set
			{
				imei = value;
			}
		}

		public string GhiChu
		{
			get
			{
				return ghiChu;
			}

			set
			{
				ghiChu = value;
			}
		}

		public DateTime ThoiGian
		{
			get
			{
				return thoiGian;
			}

			set
			{
				thoiGian = value;
			}
		}

		public int MaLichSu
		{
			get
			{
				return maLichSu;
			}

			set
			{
				maLichSu = value;
			}
		}

		public int MsnvThucHien
		{
			get
			{
				return msnvThucHien;
			}

			set
			{
				msnvThucHien = value;
			}
		}
	}
}
