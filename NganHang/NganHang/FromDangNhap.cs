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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.server = ComboBoxCN.SelectedValue.ToString();
            
            //string userid = "";
            //string password = "";
            //userid = loginname.Text;
            Program.loginName = loginname.Text;
            Program.passWord = Password.Text; ;
            //password = Password.Text;
            Program.connectionString = "Server=" + Program.server
                + ";" + "Database=" + Program.database + ";" + "User id=" + Program.loginName + ";" + "Password=" + Program.passWord;
            Program.sqlConnection = new SqlConnection(Program.connectionString);
            try
            {
                Program.sqlConnection.Open();
                Program.loginHienTai = Program.loginName;
                Program.passHienTai = Program.passWord;
                FormMain formmain = new FormMain();
                formmain.Activate();
                formmain.Show();
                this.Visible = false;
            }
            catch(Exception a)
            {
                MessageBox.Show("Ket noi that bai, sai id hoac password " + a.Message);
            }
            
        }

        private void ComboBoxCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}