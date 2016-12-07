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
	}
}
