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

		public static bool ThemDoiTac(DOI_TAC_NHAP_HANG dt)
		{
			DOI_TAC_NHAP_HANG.insert(dt);
			return true;
		}

		public static bool SuaDoiTac(DOI_TAC_NHAP_HANG dt)
		{
			DOI_TAC_NHAP_HANG.update(dt);
			return true;
		}
		
		public static bool XoaDoiTac(DOI_TAC_NHAP_HANG dt)
		{
			DOI_TAC_NHAP_HANG.delete(dt.MA_DOI_TAC);
			return true;
		}

		public static List<DOI_TAC_NHAP_HANG> LayDoiTac()
		{
			return DOI_TAC_NHAP_HANG.select(" ");
		}

		public static DOI_TAC_NHAP_HANG LayDoiTac(int maDoiTac)
		{
			try
			{
				return DOI_TAC_NHAP_HANG.select(" where MA_DOI_TAC = " + maDoiTac + " ")[0];
			}
			catch(Exception)
			{
				return null; 
			}
		}
	}
}
