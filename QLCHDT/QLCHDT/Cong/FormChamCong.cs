using BUS;
using BUS.BusPhanCa;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHDT.Cong
{
	public partial class FormChamCong : Form
	{

		public FormChamCong()
		{
			InitializeComponent();
			List<PHAN_CA> pcs = PhanCa.LayCaLamViec(Init.nhanVien.MSNV, Convert.ToDateTime(DateTime.Now.ToShortDateString()));
			Console.WriteLine(pcs.Count);
			for (int i = 0; i < pcs.Count; i++)
				flowLayoutPanel1.Controls.Add(new PanelCong(pcs[i]));
		}

		public static Button getButton()
		{
			System.Windows.Forms.Button tmp = new System.Windows.Forms.Button();
			tmp.AutoSize = true;
			tmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			tmp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			tmp.ForeColor = System.Drawing.Color.White;
			tmp.Image = Properties.Resources.btnChamCong;
			tmp.Location = new System.Drawing.Point(23, 23);
			tmp.Size = new System.Drawing.Size(120, 120);
			tmp.Margin = new System.Windows.Forms.Padding(10);
			tmp.TabIndex = 0;
			tmp.Text = "Chấm Công";
			tmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			tmp.UseVisualStyleBackColor = false;
			tmp.Click += new System.EventHandler(btnSelected);
			return tmp;
		}

		private static void btnSelected(object sender, EventArgs e)
		{
			FormChamCong formChamCong = new FormChamCong();
			formChamCong.ShowDialog();
		}

		private void FormChamCong_Load(object sender, EventArgs e)
		{
		}
	}
}
