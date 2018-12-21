using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang
{
    public partial class FormTaoTK : Form
    {
        public FormTaoTK()
        {
            InitializeComponent();
        }

        public string Chinhanh
        {
            set
            {
                CN.Text = value;
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            SqlDataReader checkKH = Program.ExecSqlDataReader($"EXEC [dbo].[SP_CheckKH] @CMND = '{CMND.Text}'");
            checkKH.Read();
            string errorKH = String.Format("{0}",((IDataRecord)checkKH)[0]);
            if (errorKH.Equals("1"))
            {
                MessageBox.Show("Khách hàng chưa tồn tại.");
                return;
            }

            SqlDataReader checkTK = Program.ExecSqlDataReader($"EXCEC [SP_CheckTK] '{sotk.Text}'");
            checkTK.NextResult();
            string error = checkTK.GetString(1);
            if (error.Equals("1"))
            {
                MessageBox.Show("Tài khoản đã tồn tại.");
                return;
            }

            SqlDataReader x = Program.ExecSqlDataReader($"INSERT INTO dbo.TaiKhoan VALUE('{sotk.Text}','{CMND.Text}',{Convert.ToDouble(sdu.Text)},'{CN.Text}',1)");

        }
    }
}
