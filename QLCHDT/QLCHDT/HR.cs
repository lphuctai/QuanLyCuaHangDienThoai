using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHDT
{
	public partial class HR : UserControl
	{
		public HR()
		{
			InitializeComponent();
		}
		public HR(string text)
		{
			InitializeComponent();
			lbText.Text = text;
		}
	}
}
