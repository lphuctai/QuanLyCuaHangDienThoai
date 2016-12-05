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

		public static bool ThemDoiTac(DoiTacNhapHang dt)
		{
			DOI_TAC_NHAP_HANG.insert((DOI_TAC_NHAP_HANG)Util.AdapterObjectToDB(dt));
			return true;
		}

		public static bool SuaDoiTac(DoiTacNhapHang dt)
		{
			DOI_TAC_NHAP_HANG.update((DOI_TAC_NHAP_HANG)Util.AdapterObjectToDB(dt));
			return true;
		}
		
		public static bool XoaDoiTac(DoiTacNhapHang dt)
		{
			DOI_TAC_NHAP_HANG.delete(dt.MaDoiTac);
			return true;
		}

		public int MaDoiTac
		{
			get; set;
		}

		public int MSNVQuanLy
		{
			get; set;
		}

		public string SoDienThoai
		{
			get; set;
		}

		public string ThongTin
		{
			get; set;
		}
	}
}
