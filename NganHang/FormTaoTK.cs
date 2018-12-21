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
            SqlDataReader checkCMND = Program.ExecSqlDataReader($"DECLARE @return_value int EXEC @return_value = [dbo].[SP_CHECKCMND] @CMND = '{CMND.Text}' SELECT 'Return Value' = @return_value");
            checkCMND.Read();
            int errorKH = checkCMND.GetInt32(0);
            checkCMND.Close();
            if (errorKH == 0)
            {
                MessageBox.Show("Khách hàng đã tồn tại.");
                return;
            }
            SqlDataReader x = Program.ExecSqlDataReader($"INSERT INTO dbo.TaiKhoan SELECT '{sotk.Text}','{CMND.Text}',{Convert.ToDouble(sdu.Text)},'{CN.Text}',1 , newid()");
            this.Close();
        }
    }
}
