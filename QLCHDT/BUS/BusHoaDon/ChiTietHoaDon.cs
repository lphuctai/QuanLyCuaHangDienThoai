using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusHoaDon
{
	class ChiTietHoaDon
	{
		private int maHoaDon, gia;
		private string imei, ghiChu;

		public ChiTietHoaDon(CHI_TIET_HOA_DON cthd)
		{
			this.maHoaDon = cthd.MA_HOA_DON;
			this.gia = Convert.ToInt32(cthd.GIA);
			this.imei = cthd.IMEI;
			this.ghiChu = cthd.GHI_CHU;
		}








		//	Get/Set accessor
		public int MaHoaDon
		{
			get
			{
				return maHoaDon;
			}

			set
			{
				maHoaDon = value;
			}
		}

		public int Gia
		{
			get
			{
				return gia;
			}

			set
			{
				gia = value;
			}
		}

		public string Imei
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
	}
}
