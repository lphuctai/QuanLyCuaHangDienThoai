using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusDoiTac
{
	public class DoiTacNhapHang
	{
		protected int maDoiTac, msnvQuanLy;
		protected string thongTin, soDienThoai;

		public static bool ThemDoiTac(DoiTacNhapHang dt)
		{
			EntityConnect.getConnection().DOI_TAC_NHAP_HANG.Add((DOI_TAC_NHAP_HANG)Util.AdapterObjectToDB(dt));
			return EntityConnect.SaveChange() == 1;
		}

		public static bool SuaDoiTac(DoiTacNhapHang dt)
		{
			EntityConnect.Update((DOI_TAC_NHAP_HANG)Util.AdapterObjectToDB(dt));
			return EntityConnect.SaveChange() == 1;
		}
		
		public static bool XoaDoiTac(DoiTacNhapHang dt)
		{
			EntityConnect.Delete((DOI_TAC_NHAP_HANG)Util.AdapterObjectToDB(dt));
			return EntityConnect.SaveChange() == 1;
		}

		public int MaDoiTac
		{
			get { return maDoiTac; }
			set { maDoiTac = value; }
		}

		public int MSNVQuanLy
		{
			get { return msnvQuanLy; }
			set { msnvQuanLy = value; }
		}

		public string SoDienThoai
		{
			get { return soDienThoai; }
			set { soDienThoai = value; }
		}

		public string ThongTin
		{
			get { return thongTin; }
			set { thongTin = value; }
		}
	}
}
