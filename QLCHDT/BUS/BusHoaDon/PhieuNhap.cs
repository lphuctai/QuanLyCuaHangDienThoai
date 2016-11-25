using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusHoaDon
{
	public class PhieuNhap : HoaDon
	{
		private int tongCong = 0, maDoiTac;

		public PhieuNhap(HOA_DON hd)
			:base(hd)
		{
			tongCong = Convert.ToInt32(hd.TONG_CONG);
			maDoiTac = Convert.ToInt32(hd.MA_DOI_TAC);
		}

		//	Get/Set accessor
		public int TongCong
		{
			get { return tongCong; }
			set { tongCong = value; }
		}

		public int MaDoiTac
		{
			get { return maDoiTac; }
			set { maDoiTac = value; }
		}

	}
}
