using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NganHang
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            toolten.Text = "Họ tên: " + Program.hoTen;
            toolmanv.Text = "Mã NV: " + Program.maNV;
            toolnhom.Text = "Nhóm: " + Program.nhom;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormNhanVien));
            if(form != null)
            {
                form.Activate();
            }
            else
            {
                Program.formNhanVien = new FormNhanVien();
                Program.formNhanVien.MdiParent = this;
                Program.formNhanVien.Activate();
                Program.formNhanVien.Show();
            }
            
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formDangNhap.Visible = true;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormKhachHang));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                Program.formKhachHang = new FormKhachHang();
                Program.formKhachHang.MdiParent = this;
                Program.formKhachHang.Activate();
                Program.formKhachHang.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormGiaoDich));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                Program.formGiaoDich = new FormGiaoDich();
                Program.formGiaoDich.MdiParent = this;
                Program.formGiaoDich.Activate();
                Program.formGiaoDich.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormTaiKhoan));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                Program.formTaiKhoan = new FormTaiKhoan();
                Program.formTaiKhoan.MdiParent = this;
                Program.formTaiKhoan.Activate();
                Program.formTaiKhoan.Show();
            }
        }

        private void btnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FormBaoCao));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                Program.formBaoCao = new FormBaoCao();
                Program.formBaoCao.MdiParent = this;
                Program.formBaoCao.Activate();
                Program.formBaoCao.Show();
            }
        }
    }
}
