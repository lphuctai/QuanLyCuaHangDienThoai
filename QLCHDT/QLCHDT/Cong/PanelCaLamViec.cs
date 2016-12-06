using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace QLCHDT.Cong
{
	public partial class PanelCaLamViec : UserControl
	{
		private List<CheckBox> cbb = new List<CheckBox>(); 
		public PanelCaLamViec()
		{
			InitializeComponent();
		}
		public PanelCaLamViec(NHAN_VIEN nv, int tongCa, List<PHAN_CA>pc)
		{
			InitializeComponent();
			lbHoTen.Text = nv.MSNV + "-" + nv.HO_TEN.Substring(nv.HO_TEN.IndexOf(' '));
			int j = 0;
			for(int i = 1; i <= tongCa; i ++)
			{
				CheckBox tmp = new CheckBox();
				tmp.AutoSize = true;
				tmp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
				tmp.Location = new System.Drawing.Point(3, 3);
				tmp.Name = i.ToString();
				tmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				tmp.Size = new System.Drawing.Size(113, 25);
				tmp.TabIndex = 5;
				tmp.Text = i.ToString();
				tmp.UseVisualStyleBackColor = true;
				if(i == pc[j].CA)
				{
					tmp.Checked = true;
					j++;
				}
				cbb.Add(tmp);
				flowPanel.Controls.Add(cbb[i - 1]);
			}
		}

		private void AddCa(int tongCa)
		{

			
		}
	}
}
