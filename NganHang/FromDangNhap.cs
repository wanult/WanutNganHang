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
    public partial class FromDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FromDangNhap()
        {
            InitializeComponent();
        }

        private void FromDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMaster.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.dataSetMaster.V_DSPM);
            Program.bindingSourceChiNhanh = this.bdsDSPM;
            if (this.ComboBoxCN.ValueMember != "")
            {
                ComboBoxCN.SelectedIndex = 1;
                ComboBoxCN.SelectedIndex = 0;
            }
            else
            {
                ComboBoxCN.SelectedIndex = 0;
                ComboBoxCN.SelectedIndex = 1;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginname.Text.Equals("") || Password.Text.Equals(""))
            {
                MessageBox.Show("Ban chua nhap tai khoan hoac password!");
                return;
            }
            
            Program.loginHienTai = loginname.Text;
            Program.passHienTai = Password.Text;
            if (Program.KetNoi() == 0)
            {
                return;
            }
            Program.loginName = Program.loginHienTai;
            Program.passWord = Program.passHienTai;
            Program.mChinhanh = ComboBoxCN.SelectedIndex;
            String sp = "EXEC SP_LOGIN '"+Program.loginHienTai+"'";
            Program.myreader = Program.ExecSqlDataReader(sp);
            Program.myreader.Read();
            Program.maNV= Program.myreader.GetString(0) + "";
            if (Convert.IsDBNull(Program.maNV))
            {
                return;
            }
            Program.hoTen = Program.myreader.GetString(1) + "";
            Program.nhom = Program.myreader.GetString(2);
            Program.myreader.Close();
            Program.sqlConnection.Close();
            Program.formMain = new FormMain();
            Program.formMain.Activate();
            Program.formMain.Show();
            this.Visible = false;
        }

        private void ComboBoxCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.server = ComboBoxCN.SelectedValue.ToString();
            }catch(Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}