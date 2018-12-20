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
using DevExpress.XtraReports.UI;

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
            this.bdsNV.CancelEdit();
            groupBox1.Enabled = true;
            this.bdsNV.AddNew();
            trangThaiXoaTextBox.Text = "1";
            trangThaiXoaTextBox.Enabled = false;
            mACNTextBox.Text = comboBoxCN.Text;
            mACNTextBox.Enabled = false;
            btnhuy.Visible = false;
            btnEdit.Visible = false;
            btnxoa.Visible = false;
            btnok.Visible = true;
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSLG.V_DSNHOM' table. You can move, or remove it, as needed.
            this.v_DSNHOMTableAdapter.Fill(this.dSLG.V_DSNHOM);
            // TODO: This line of code loads data into the 'dSLG.V_DSTK' table. You can move, or remove it, as needed.
            this.v_DSTKTableAdapter.Fill(this.dSLG.V_DSTK);
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.

            this.comboBoxCN.DataSource = Program.bindingSourceChiNhanh;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            comboBoxCN.DisplayMember = "description";
            comboBoxCN.ValueMember = "subscriber_server";
            if (comboBoxCN.ValueMember.Equals(Program.mChinhanh))
            {
                comboBoxCN.SelectedIndex = 0;
                comboBoxCN.SelectedIndex = 1;
            }
            else
            {
                comboBoxCN.SelectedIndex = 1;
                comboBoxCN.SelectedIndex = 0;
            }
            if (Program.nhom == ("ChiNhanh"))
            {
                comboBoxCN.Enabled = false;
            }
            groupBox1.Enabled = false;
            btnxoa.Visible = false;
            btnEdit.Visible = false;
            btnhuy.Visible = false;
            btnok.Visible = false;
        }

        private void hOLabel_Click(object sender, EventArgs e)
        {this.btnxoa.Visible = false;
            this.btnEdit.Visible = false;
            this.btnhuy.Visible = false;
            this.btnok.Visible = false;
            mANVTextBox.Enabled = false;
            groupBox1.Enabled = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (mACNTextBox.Text.Equals("") || hOTextBox.Text.Equals(""))
            {
                MessageBox.Show("Không hợp lệ! Vui lòng kiểm tra lại!");
                bdsNV.CancelEdit();
                mACNTextBox.ResetText();
                return;
            }
            else
            {

                string sqlCmd = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_CheckNV] @MANV = N'"
                    + mANVTextBox.Text + "' SELECT  'Return Value' = @return_value";
                Program.myreader = Program.ExecSqlDataReader(sqlCmd);
                Program.myreader.Read();
                int value = Program.myreader.GetInt32(0);

                Program.myreader.Close();
                if (value == 0)
                {
                    MessageBox.Show("MANV đã tồn tại! Vui lòng kiểm tra lại!");
                    bdsNV.CancelEdit();
                    return;
                }
                else
                {

                    bdsNV.EndEdit();
                    MessageBox.Show("Thành công!");
                    return;
                }

            }
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

            if (this.comboBoxCN.ValueMember != "")
            {
                if (Program.server != this.comboBoxCN.SelectedValue.ToString())
                {
                    Program.server = this.comboBoxCN.SelectedValue.ToString();

                }
                if (this.comboBoxCN.SelectedIndex != Program.mChinhanh)
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
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

                    this.v_DSTKTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.v_DSTKTableAdapter.Fill(this.dSLG.V_DSTK);

                }
            }
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.bdsNV.EndEdit();
            return;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnxoa.Visible = true;
            btnEdit.Visible = false;
            btnok.Visible = false;
            btnhuy.Visible = false;
            groupBox1.Enabled = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban co chac xoa nhan vien nay khong?", "Thong bao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else
            {
              
                trangThaiXoaTextBox.Text = "0";
                bdsNV.EndEdit();
                this.nhanVienTableAdapter.Update(this.dS.NhanVien);

                string sp = "EXEC SP_XOALOGIN '" + mANVTextBox.Text + "'";
                Program.myreader = Program.ExecSqlDataReader(sp);
                Program.myreader.Read();
                Program.myreader.Close();
                return;

            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox3.Visible = true;
            groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("tài khoản hoặc mật khẩu không hợp lệ!");
            }
            else
            {
                string sqlcmd1 = "DECLARE	@return_value int EXEC @return_value = " +
                "[dbo].[SP_CHECKLOGIN] @LGNAME = N'"+txtTen.Text.ToString().Trim()+"'SELECT  'Return Value' = @return_value";
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
                    groupBox2.Visible = false;

                }
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            mANVTextBox.Enabled = false;
            mACNTextBox.Enabled = false;
            btnxoa.Visible = false;
            btnok.Visible = false;
            btnhuy.Visible = true;
            btnEdit.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            btnxoa.Visible = false;
            btnEdit.Visible = false;
            btnhuy.Visible = false;
            btnok.Visible = false;
            groupBox1.Enabled = false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.bdsNV.EndEdit();
            
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.bdsNV.CancelEdit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.bdsNV.EndEdit();
            
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.formMain.Close();
            this.Close();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //LietKeKhachHang1CN lietke = new LietKeKhachHang1CN();
            //ReportPrintTool pr = new ReportPrintTool(lietke);
            //pr.ShowPreviewDialog();
        }
    }
}