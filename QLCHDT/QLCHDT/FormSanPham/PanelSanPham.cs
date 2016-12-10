using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHDT.FormSanPham
{
	public partial class PanelSanPham : UserControl
	{
		public PanelSanPham(string s)
		{
			InitializeComponent();
			lbIMEI.Text = s;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		public string getString()
		{
			return lbIMEI.Text;
		}
	}
}
