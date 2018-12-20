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
using System.Data.SqlClient;

namespace NganHang
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bdsNV.AddNew();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            
            this.comboBoxCN.DataSource = Program.bindingSourceChiNhanh;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            comboBoxCN.DisplayMember = "description";
            comboBoxCN.ValueMember = "subscriber_server";
        }

        private void hOLabel_Click(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
        }

        private void trangThaiXoaLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bdsNV.EndEdit();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nhanVienTableAdapter.Update(this.dS.NhanVien);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
        }

        private void comboBoxCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxCN.ValueMember == "System.Data.DataRowView")
            {
                if (Program.server != this.comboBoxCN.SelectedValue.ToString())
                {
                    Program.server = this.comboBoxCN.SelectedValue.ToString();
                    if (Program.loginHienTai != Program.remoteLogin)
                    {
                        Program.loginHienTai = Program.remoteLogin;
                        Program.passHienTai = Program.remotePassword;

                    }
                    else
                    {
                        Program.loginHienTai = Program.loginName;
                        Program.passHienTai = Program.passWord;
                    }
                    Program.connectionString = "Server=" + Program.server
                    + ";" + "Database=" + Program.database + ";" + "User id=" + Program.loginHienTai + ";"
                    + "Password=" + Program.passHienTai;
                    Program.sqlConnection = new SqlConnection(Program.connectionString);
                    Program.sqlConnection.Open();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                }
                
            }
        }
    }
}