using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusPhanCa
{
	public class CaLamViec
	{
		private int ca, gio;

		public CaLamViec(CA_LAM_VIEC clv)
		{
			this.ca = clv.CA;
			this.gio = Convert.ToInt32(clv.GIO);
		}

		public int Ca
		{
			get
			{
				return ca;
			}

			set
			{
				ca = value;
			}
		}

		public int Gio
		{
			get
			{
				return gio;
			}

			set
			{
				gio = value;
			}
		}
	}
}
