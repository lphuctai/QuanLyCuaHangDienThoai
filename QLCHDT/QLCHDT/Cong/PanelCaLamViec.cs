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
		private int tongCa;
		private NHAN_VIEN nhanVien;
		private DateTime thoiGian;
		public PanelCaLamViec()
		{
			InitializeComponent();
		}
		public PanelCaLamViec(NHAN_VIEN nv, int tongCa, List<PHAN_CA>pc, DateTime thoiGian)
		{
			InitializeComponent();
			this.tongCa = tongCa;
			lbHoTen.Text = nv.MSNV + "-" + nv.HO_TEN.Substring(Math.Max(nv.HO_TEN.IndexOf(' '), 0));
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
				if (j < pc.Count && i == pc[j].CA)
				{
					tmp.Checked = true;
					if (pc[j].CHAM_CONG == 1)
						tmp.Enabled = false;
					j++;
				}
				cbb.Add(tmp);
				flowPanel.Controls.Add(cbb[i - 1]);
			}
			nhanVien = nv;
			this.thoiGian = thoiGian;
		}

		public List<PHAN_CA> PhanCa
		{
			get
			{
				List<PHAN_CA> pc = new List<PHAN_CA>();
				for(int i = 0; i < tongCa; i ++)
				{
					if(cbb[i].Checked)
					{
						PHAN_CA tmp = new PHAN_CA();
						tmp.MSNV = nhanVien.MSNV;
						tmp.THOI_GIAN = thoiGian;
						tmp.CA = Convert.ToInt32(cbb[i].Text);
						pc.Add(tmp);
					}					
				}
				return pc;
			}
		}
	}
}
