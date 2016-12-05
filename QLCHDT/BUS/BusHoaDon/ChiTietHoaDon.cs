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
		private int maHoaDon, gia;
		private string imei, ghiChu;

		public ChiTietHoaDon(CHI_TIET_HOA_DON cthd)
		{
			this.maHoaDon = cthd.MA_HOA_DON;
			this.gia = Convert.ToInt32(cthd.GIA);
			this.imei = cthd.IMEI;
			this.ghiChu = cthd.GHI_CHU;
		}

		public static bool NhapHang(ChiTietHoaDon cthd)
		{
			CHI_TIET_HOA_DON.insert((CHI_TIET_HOA_DON)Util.AdapterObjectToDB(cthd));
			return true;
		}

		public static bool XuatHang(ChiTietHoaDon cthd)
		{
			CHI_TIET_HOA_DON.insert((CHI_TIET_HOA_DON)Util.AdapterObjectToDB(cthd));
			return true;
		}





		//	Get/Set accessor
		public int MaHoaDon
		{
			get; set;
		}

		public int Gia
		{
			get; set;
		}

		public string IMEI
		{
			get; set;
		}

		public string GhiChu
		{
			get; set;
		}
	}
}
