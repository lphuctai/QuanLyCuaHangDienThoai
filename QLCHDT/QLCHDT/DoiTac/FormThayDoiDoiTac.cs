using BUS.BusDoiTac;
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

namespace QLCHDT.DoiTac
{
	public partial class FormThayDoiDoiTac : Form
	{
		public FormThayDoiDoiTac()
		{
			InitializeComponent();
		}

		public static Button getButton()
		{
			System.Windows.Forms.Button tmp = new System.Windows.Forms.Button();
			tmp.Text = "T.Đối Đ.Tác";
			tmp.Image = Properties.Resources.btnThayDoiDoiTac;
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
			FormThayDoiDoiTac formThayDoiDoiTac = new FormThayDoiDoiTac();
			formThayDoiDoiTac.ShowDialog();
		}

		private void ThayDoiDoiTac_Load(object sender, EventArgs e)
		{
			cbbMaDoiTac.DataSource = new BindingList<DOI_TAC_NHAP_HANG>(DOI_TAC_NHAP_HANG.select(""));
			cbbMaDoiTac.DisplayMember = "DINH_DANH";
			cbbMaDoiTac.ValueMember = "MA_DOI_TAC";
			LoadDoiTac();
        }

		private void LoadDoiTac()
		{
			if (cbbMaDoiTac.SelectedValue == null)
				return;
			try
			{
				DOI_TAC_NHAP_HANG dtnh = DoiTacNhapHang.LayDoiTac(Convert.ToInt32(cbbMaDoiTac.SelectedValue));
				txtDoiTac.Text = dtnh.THONG_TIN;
				txtSoDienThoai.Text = dtnh.SO_DIEN_THOAI;
			}
			catch(Exception)
			{
				return;
			}
			
		}

		private void cbbMaDoiTac_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadDoiTac();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				DOI_TAC_NHAP_HANG dtnh = DoiTacNhapHang.LayDoiTac(Convert.ToInt32(cbbMaDoiTac.SelectedValue));
				dtnh.THONG_TIN = txtDoiTac.Text;
                dtnh.SO_DIEN_THOAI = txtSoDienThoai.Text;
				if (DoiTacNhapHang.SuaDoiTac(dtnh))
					MessageBox.Show("Lưu Thành Công!");
				else
					MessageBox.Show("Lưu Thất Bại!");
				int tmp = cbbMaDoiTac.SelectedIndex;
				ThayDoiDoiTac_Load(sender, e);
				cbbMaDoiTac.SelectedIndex = tmp;
            }
			catch (Exception)
			{
				return;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				DOI_TAC_NHAP_HANG dtnh = DoiTacNhapHang.LayDoiTac(Convert.ToInt32(cbbMaDoiTac.SelectedValue));
				if (DoiTacNhapHang.XoaDoiTac(dtnh))
					MessageBox.Show("Xóa Thành Công!");
				else
					MessageBox.Show("Xóa Thất Bại!");
				txtSoDienThoai.Text = "";
				txtDoiTac.Text = "";
				cbbMaDoiTac.Text = "";
				ThayDoiDoiTac_Load(sender, e);
			}
			catch (Exception)
			{
				return;
			}
		}
	}
}
