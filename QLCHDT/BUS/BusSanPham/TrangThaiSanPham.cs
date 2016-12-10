using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusSanPham
{
	public class TrangThaiSanPham
	{
		public static List<TRANG_THAI_SAN_PHAM> LayTrangThaiSanPham()
		{
			return TRANG_THAI_SAN_PHAM.select(" ");
		}
	}
}
