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
    public partial class FormTaoLogin : Form
    {
        public FormTaoLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void FormTaoLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSLG.V_DSNHOM' table. You can move, or remove it, as needed.
            this.v_DSNHOMTableAdapter.Fill(this.dSLG.V_DSNHOM);
            // TODO: This line of code loads data into the 'dSLG.V_DSTK' table. You can move, or remove it, as needed.
            this.v_DSTKTableAdapter.Fill(this.dSLG.V_DSTK);

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("tài khoản hoặc mật khẩu không hợp lệ!");
            }
            else
            {
                string sqlcmd1 = "DECLARE	@return_value int EXEC @return_value = " +
                "[dbo].[SP_CHECKLOGIN] @LGNAME = N'" + txtTen.Text.ToString().Trim() + "'SELECT  'Return Value' = @return_value";
                Program.myreader = Program.ExecSqlDataReader(sqlcmd1);
                Program.myreader.Read();
                int value = Program.myreader.GetInt32(0);
                Program.myreader.Close();
                if (value == 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
                }
                else
                {

                    string sqlcmd = "exec SP_TAOTAIKHOAN '" + txtTen.Text.ToString().Trim() +
                    "','" + txtPass.Text.ToString().Trim() + "','" + cbxMa.Text.ToString() + "','" + cbxNh.Text.ToString() + "'";
                    Program.myreader = Program.ExecSqlDataReader(sqlcmd);
                    Program.myreader.Read();
                    Program.myreader.Close();
                    MessageBox.Show("Thành công!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
