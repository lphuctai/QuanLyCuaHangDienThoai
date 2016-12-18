using BUS.BusNhanVien;
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
	public partial class FormXacNhanCong : Form
	{
		public FormXacNhanCong()
		{
			InitializeComponent();
		}

		public static Button getButton()
		{
			System.Windows.Forms.Button tmp = new System.Windows.Forms.Button();
			tmp.Text = "X.Nhận Công";
			tmp.Image = Properties.Resources.btnXacNhanCa;
			tmp.AutoSize = true;
			tmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			tmp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			tmp.ForeColor = System.Drawing.Color.White;
			tmp.Location = new System.Drawing.Point(23, 23);
			tmp.Size = new System.Drawing.Size(120, 120);
			tmp.Margin = new System.Windows.Forms.Padding(10);
			tmp.TabIndex = 0;
			tmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			tmp.UseVisualStyleBackColor = false;
			tmp.Click += new System.EventHandler(btnSelected);
			return tmp;
		}

		private static void btnSelected(object sender, EventArgs e)
		{
			FormXacNhanCong formXacNhanCong = new FormXacNhanCong();
			formXacNhanCong.ShowDialog();
		}

		private void FormXacNhanCong_Load(object sender, EventArgs e)
		{
			BindingList<NHAN_VIEN> nv = new BindingList<NHAN_VIEN>(NhanVien.LayNhanVien());
			cbbNhanVien.DataSource = nv;
			cbbNhanVien.DisplayMember = "DINH_DANH";
			cbbNhanVien.ValueMember = "MSNV";
			Console.WriteLine(cbbNhanVien.SelectedValue);
			TimCa((int)cbbNhanVien.SelectedValue, dtpTu.Value, dtpDen.Value);
		}

		public void TimCa(int msnv, DateTime tu, DateTime den)
		{
			flowPanel.Controls.Clear();
			List<PHAN_CA> pc = PhanCa.LayCaLamViec(msnv, tu, den);
			for (int i = 0; i < pc.Count; i++)
			{
				if(pc[i].CHAM_CONG == 1)
					flowPanel.Controls.Add(new PanelXacNhanCong(pc[i]));
			}
		}

		private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
		{
			TimCa((int)cbbNhanVien.SelectedValue, dtpTu.Value, dtpDen.Value);
		}

		private void cbbNhanVien_ValueMemberChanged(object sender, EventArgs e)
		{
			TimCa((int)cbbNhanVien.SelectedValue, dtpTu.Value, dtpDen.Value);
		}

		private void cbbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				TimCa((int)cbbNhanVien.SelectedValue, dtpTu.Value, dtpDen.Value);
			}
			catch(Exception)
			{ }
		}
	}
}
