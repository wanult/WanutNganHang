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
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        private void cbxCNTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cbxCNTK.ValueMember != "")
                {
                    if (Program.server != this.cbxCNTK.SelectedValue.ToString())
                    {
                        Program.server = this.cbxCNTK.SelectedValue.ToString();

                    }
                    if (this.cbxCNTK.SelectedIndex != Program.mChinhanh)
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
                        this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
                    }
                }
            }
            catch (NullReferenceException nrex)
            {

            }

        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.dS.TaiKhoan);
            this.cbxCNTK.DataSource = Program.bindingSourceChiNhanh;
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.taiKhoanTableAdapter.Fill(dS.TaiKhoan);
            cbxCNTK.DisplayMember = "description";
            cbxCNTK.ValueMember = "subscriber_server";
            if (cbxCNTK.ValueMember.Equals(Program.mChinhanh))
            {
                cbxCNTK.SelectedIndex = 0;
                cbxCNTK.SelectedIndex = 1;
            }
            else
            {
                cbxCNTK.SelectedIndex = 1;
                cbxCNTK.SelectedIndex = 0;
            }
            if (Program.nhom == ("ChiNhanh"))
            {
                cbxCNTK.Enabled = false;
            }
        }


    }
}
