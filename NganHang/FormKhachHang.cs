using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.dS.KhachHang);

            this.cbxCN.DataSource = Program.bindingSourceChiNhanh;
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.khachHangTableAdapter.Fill(dS.KhachHang);
            cbxCN.DisplayMember = "description";
            cbxCN.ValueMember = "subscriber_server";
            if (cbxCN.ValueMember.Equals(Program.mChinhanh))
            {
                cbxCN.SelectedIndex = 0;
                cbxCN.SelectedIndex = 1;
            }
            else
            {
                cbxCN.SelectedIndex = 1;
                cbxCN.SelectedIndex = 0;
            }
            if (Program.nhom == ("ChiNhanh"))
            {
                cbxCN.Enabled = false;
            }

            ttxtk.Visible = false;
            groupBox1.Enabled = false;
            sodutkkh.Visible = true;
            sotkkh.Visible = true;
            sotktbx.Visible = false;
            sodutk.Visible = false;
            btnxoaa.Visible = false;
            btnsuaa.Visible = false;
            btnhuyy.Visible = false;
            btnokk.Visible = false;
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bdsKH.CancelEdit();
            groupBox1.Enabled = true;
            ttxtk.Visible = true;
            this.bdsKH.AddNew();

            this.taiKhoanBindingSource.AddNew();
            ttxoakh.Text = "1";
            ttxtk.Text = "1";
            ttxoakh.Enabled = false;
            macntk.Visible = false;
            cmndtk.Visible = false;
            sotkkh.Visible = false;
            sodutkkh.Visible = false;
            sotktbx.Visible = true;
            sodutk.Visible = true;
            macntbx.Text = cbxCN.Text;
            macntbx.Enabled = false;
            btnhuyy.Visible = false;
            btnsuaa.Visible = false;
            btnxoaa.Visible = false;
            btnokk.Visible = true;
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnxoaa.Visible = true;
            btnsuaa.Visible = false;
            btnokk.Visible = false;
            btnhuyy.Visible = false;
            groupBox1.Enabled = true;
        }

        private void cbxCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cbxCN.ValueMember != "")
                {
                    if (Program.server != this.cbxCN.SelectedValue.ToString())
                    {
                        Program.server = this.cbxCN.SelectedValue.ToString();

                    }
                    if (this.cbxCN.SelectedIndex != Program.mChinhanh)
                    {
                        Program.loginHienTai = Program.remoteLogin;
                        Program.passHienTai = Program.remotePassword;
                    }
                    else
                    {
                        Program.loginHienTai = Program.loginName;
                        Program.passHienTai = Program.passWord;
                    }
                    if (Program.KetNoi() == 0)
                    {
                        MessageBox.Show("Không thể kết nối", "Lỗi kết nối", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        this.khachHangTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.khachHangTableAdapter.Fill(this.dS.KhachHang);

                        //this.v_DSTKTableAdapter.Connection.ConnectionString = Program.connectionString;
                        //this.v_DSTKTableAdapter.Fill(this.dSLG.V_DSTK);

                    }
                }
            }
            catch (NullReferenceException nullex)
            {

            }


        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            sotkkh.Visible = true;
            sodutkkh.Visible = true;
            sotktbx.Visible = false;
            sodutk.Visible = false;
            macntbx.Enabled = false;
            cmndtbx.Enabled = false;
            btnxoaa.Visible = false;
            btnokk.Visible = false;
            btnhuyy.Visible = true;
            btnsuaa.Visible = true;
        }

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.khachHangTableAdapter.Update(this.dS.KhachHang);
            this.taiKhoanTableAdapter.Update(this.dS.TaiKhoan);

        }

        private void btnxoaa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban co chac xoa khach hang nay khong?", "Thong bao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else
            {
                ttxtk.Visible = true;
                ttxoakh.Text = "0";
                ttxtk.Text = "0";
                bdsKH.EndEdit();
                taiKhoanBindingSource.EndEdit();
                this.khachHangTableAdapter.Update(this.dS.KhachHang);
                this.taiKhoanTableAdapter.Update(this.dS.TaiKhoan);
                this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                ttxtk.Visible = false;


            }
        }

        private void btnsuaa_Click(object sender, EventArgs e)
        {
            this.bdsKH.EndEdit();
        }

        private void btnokk_Click(object sender, EventArgs e)
        {
            macntk.Visible = true;
            cmndtk.Visible = true;
            cmndtk.Text = cmndtbx.Text;
            macntk.Text = macntbx.Text;
            this.bdsKH.EndEdit();
            this.taiKhoanBindingSource.EndEdit();
            macntk.Visible = false;
            cmndtk.Visible = false;
        }

        private void btnhuyy_Click(object sender, EventArgs e)
        {
            this.bdsKH.CancelEdit();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.formMain.Close();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTaoTK formTaoTK = new FormTaoTK();
            formTaoTK.ShowDialog();
            formTaoTK.Chinhanh = macntk.Text;
        }

        private void cmndtk_TextChanged(object sender, EventArgs e)
        {

        }

        private void hotbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
