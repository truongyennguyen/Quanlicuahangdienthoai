using System;
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
    public partial class frmNhapHang : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            // disable popup menu when right click
            luuButton.Properties.ContextMenuStrip = new ContextMenuStrip();
            xuathdButton.Properties.ContextMenuStrip = new ContextMenuStrip();
            suaButton.Properties.ContextMenuStrip = new ContextMenuStrip();
            xoaButton.Properties.ContextMenuStrip = new ContextMenuStrip();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}