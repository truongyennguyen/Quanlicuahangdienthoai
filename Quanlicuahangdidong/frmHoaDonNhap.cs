﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Quanlicuahangdidong
{
    public partial class frmHoaDonNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }

        private void chitietButton_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDonNhap CTHDN = new frmChiTietHoaDonNhap();
            CTHDN.ShowDialog();
        }
    }
}