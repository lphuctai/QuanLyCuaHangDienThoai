using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusSanPham
{
	public class HangSanXuat
	{

		public HangSanXuat()
		{
		}

		public static bool ThemHangSanXuat(HANG_SAN_XUAT hsx)
		{
			HANG_SAN_XUAT.insert(hsx);
            return true;
		}

		public static List<HANG_SAN_XUAT> LayHangSanXuat()
		{
			return HANG_SAN_XUAT.select(" ");
		}

		public static HANG_SAN_XUAT LayHangSanXuat(string hang)
		{
			try
			{
				return HANG_SAN_XUAT.select(" where HANG = '" + hang + "' ")[0];
			}
			catch(Exception)
			{
				return null;
			}
		}
		
		public static HANG_SAN_XUAT LayHangSanXuat(int maHang)
		{
			try
			{
				return HANG_SAN_XUAT.select(" where MA_HANG = '" + maHang + "' ")[0];
			}
			catch (Exception)
			{
				return null;
			}
		}

	}
}
