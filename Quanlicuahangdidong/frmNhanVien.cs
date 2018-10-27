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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // disable popup menu when right click
            luuButton.Properties.ContextMenuStrip = new ContextMenuStrip();
            themButton.Properties.ContextMenuStrip = new ContextMenuStrip();
            suaButton.Properties.ContextMenuStrip = new ContextMenuStrip();
            xoaButton.Properties.ContextMenuStrip = new ContextMenuStrip();
        }


    }
}