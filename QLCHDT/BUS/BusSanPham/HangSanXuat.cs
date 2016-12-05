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

		public HangSanXuat(HANG_SAN_XUAT hsx)
		{
			this.MaHang = hsx.MA_HANG;
            this.Hang = hsx.HANG;
		}

		public HangSanXuat(string hang)
		{
			this.MaHang = 0;
			this.Hang = hang;
		}

		public static bool ThemHangSanXuat(HangSanXuat hsx)
		{
			HANG_SAN_XUAT.insert((HANG_SAN_XUAT)Util.AdapterObjectToDB(hsx));
            return true;
		}

		// Lay Tat Ca chua lam vi chưa tìm được cấu trúc dữ liệu thích hợp

		public string Hang
		{
			get; set;
		}

		public int MaHang
		{
			get; set;
		}
	}
}
