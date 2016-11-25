using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusSanPham
{
	class HangSanXuat
	{
		private string hang;

		public HangSanXuat(HANG_SAN_XUAT hsx)
		{
			this.hang = hsx.HANG;
		}

		public string Hang
		{
			get
			{
				return hang;
			}

			set
			{
				hang = value;
			}
		}
	}
}
