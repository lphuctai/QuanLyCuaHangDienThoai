using QLCHDT.Cong;
using QLCHDT.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHDT
{
	public partial class MainForm : Form
	{
		public MainForm(int chucVu)
		{
			InitializeComponent();
			if(chucVu == 1) //QL
			{
				AddButton("Chấm Công", FormChamCong.getIcon());
				AddButton("Thêm NV", FormAddUser.getIcon());
			}
		}

		public void AddButton(string text, System.Drawing.Bitmap icon)
		{
			System.Windows.Forms.Button tmp = new System.Windows.Forms.Button();
			tmp.AutoSize = true;
			tmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			tmp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			tmp.ForeColor = System.Drawing.Color.White;
			tmp.Image = icon;
			tmp.Location = new System.Drawing.Point(23, 23);
			tmp.Size = new System.Drawing.Size(120, 120);
			tmp.Margin = new System.Windows.Forms.Padding(10);
			tmp.TabIndex = 0;
			tmp.Text = text;
			tmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			tmp.UseVisualStyleBackColor = false;
			tmp.Click += new System.EventHandler(this.btnSelected);
			this.FlowPanel.Controls.Add(tmp);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnSelected(object sender, EventArgs e)
		{
			Button tmp = (Button)sender;
			switch(tmp.Text)
			{
				case "Chấm Công":
                    new FormChamCong().ShowDialog();
					break;
				case "Thêm NV":
					new FormAddUser().ShowDialog();
					break;
			}
		}
	}
}
