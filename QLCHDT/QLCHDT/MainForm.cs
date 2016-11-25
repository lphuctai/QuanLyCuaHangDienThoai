﻿using System;
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
		public MainForm()
		{
			InitializeComponent();
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
            }
		}
	}
}