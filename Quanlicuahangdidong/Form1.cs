using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Quanlicuahangdidong
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        //function to active form if form exist
        private bool isFormActived(Form form)
        {
            bool isOpened = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        isOpened = true;
                    }
                    
                }
            }
            return isOpened;
        }

        //function to show child form
        private void showChildForm(Form form)
        {
            if (!isFormActived(form))
            {
                form.MdiParent = this;
                form.Show();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            //load icon

            banhangButton.EditValue = Quanlicuahangdidong.Properties.Resources.cart;
            nhaphangButton.EditValue = Quanlicuahangdidong.Properties.Resources.trolley;
            khachhangButton.EditValue = Quanlicuahangdidong.Properties.Resources.meeting;
            hdbanButton.EditValue = Quanlicuahangdidong.Properties.Resources.bill;
            nhanvienButton.EditValue = Quanlicuahangdidong.Properties.Resources.employee;
            taikhoanButton.EditValue = Quanlicuahangdidong.Properties.Resources.account;
            sptrongkhoButton.EditValue = Quanlicuahangdidong.Properties.Resources.product;
            hdnhapButton.EditValue = Quanlicuahangdidong.Properties.Resources.bill_1;
            dangnhapButton.EditValue = Quanlicuahangdidong.Properties.Resources.login;
            dangxuatButton.EditValue = Quanlicuahangdidong.Properties.Resources.logout;


            // disable popup menu when right click
            banhangButton.CanOpenEdit = false;
            nhanvienButton.CanOpenEdit = false;
            nhaphangButton.CanOpenEdit = false;
            hdbanButton.CanOpenEdit = false;
            khachhangButton.CanOpenEdit = false;
            sptrongkhoButton.CanOpenEdit = false;
            taikhoanButton.CanOpenEdit = false;
            hdnhapButton.CanOpenEdit = false;
            dangnhapButton.CanOpenEdit = false;
            dangxuatButton.CanOpenEdit = false;

            dangxuatButton.Enabled = false;
        }

        private void banhangButton_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBanHang frmBH = new frmBanHang();
            showChildForm(frmBH);
        }

        private void nhaphangButton_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhapHang frmNH = new frmNhapHang();
            showChildForm(frmNH);
        }

        private void nhanvienButton_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            showChildForm(frmNV);
        }

        private void hdnhaphangButton_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHoaDonNhap frmHDN = new frmHoaDonNhap();
            showChildForm(frmHDN);
        }

        private void hdbanButton_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHoaDonBan frmHDB = new frmHoaDonBan();
            showChildForm(frmHDB);
        }

        private void khachhangButton_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            showChildForm(frmKH);
        }

        private void sptrongkhoButton_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSanPhamTrongKho frmSPTK = new frmSanPhamTrongKho();
            showChildForm(frmSPTK);
        }

        private void taikhoanButton_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTaiKhoan frmTK = new frmTaiKhoan();
            showChildForm(frmTK);
        }
    }
}
