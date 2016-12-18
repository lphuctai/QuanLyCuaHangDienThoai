using BUS;
using BUS.BusNhanVien;
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

namespace QLCHDT.User
{
	public partial class FormSaThai : Form
	{
		public FormSaThai()
		{
			InitializeComponent();
		}
		
		public static Button getButton()
		{
			System.Windows.Forms.Button tmp = new System.Windows.Forms.Button();
			tmp.Text = "Sa Thải";
			tmp.Image = Properties.Resources.btnRemoveAccount;
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
			FormSaThai formSaThai = new FormSaThai();
			formSaThai.ShowDialog();
		}

		private void FormSaThai_Load(object sender, EventArgs e)
		{
			BindingList<NHAN_VIEN> nv = new BindingList<NHAN_VIEN>(NhanVien.LayNhanVien());
			dgvNhanVien.DataSource = nv;
		}

		private void button1_Click(object sender, EventArgs e)
		{
            int msnv = ((NHAN_VIEN)dgvNhanVien.SelectedRows[0].DataBoundItem).MSNV;
			if(QuanLy.SaThaiNhanVien(msnv, ""))
			{
				MessageBox.Show("Xoá Nhân Viên Thành Công!");
				dgvNhanVien.Rows.RemoveAt(dgvNhanVien.CurrentRow.Index);
			}
			else
			{
				MessageBox.Show("Xoá Nhân Viên Thất Bại!");
			}
		}
	}
}
