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
            string sql = "EXEC SP_LOGIN " + Program.loginName;
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();
            toolmanv.Text = "Mã NV: "+ dataReader.GetValue(0).ToString();
            toolten.Text = "Họ tên: "+ dataReader.GetValue(1).ToString();
            toolnhom.Text = "Nhóm: "+ dataReader.GetValue(2).ToString();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.formNhanVien = new FormNhanVien();
            Program.formNhanVien.MdiParent = this;
            Program.formNhanVien.Activate();
            Program.formNhanVien.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formDangNhap.Visible = true;
        }
    }
}
