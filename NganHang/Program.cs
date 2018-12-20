using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace NganHang
{
    static class Program
    {
        public static FormMain formMain;
        public static FormTaiKhoan formTaiKhoan;
        public static SqlDataReader myreader;
        public static FormNhanVien formNhanVien;
        public static FromDangNhap formDangNhap;
        public static FormKhachHang formKhachHang;
        public static FormGiaoDich formGiaoDich;
        public static FormTTKH formTTKH;
        public static FormTKTK formTKTK;
        public static FormBaoCao formBaoCao;
        public static FormGD formGD;
        public static BindingSource bindingSourceChiNhanh;
        public static string database = "NGANHANG";
        public static string server = "";
        public static string loginName = "";
        public static string passWord = "";
        public static string connectionString = "";
        public static string connectionStringTTKH = "";

        public static SqlConnection sqlConnection;
        public static SqlConnection sqlConnectionTTKH;
        public static string loginHienTai = "";
        public static string passHienTai = "";

        public static string remoteLogin = "HTKN";
        public static string remotePassword = "123";
        public static string hoTen = "";
        public static string maNV="" ;
        public static string nhom = "";
        public static int mChinhanh;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            formDangNhap = new FromDangNhap();
            Application.Run(formDangNhap);
        }

        public static int KetNoi()
        {
            if (Program.sqlConnection != null && Program.sqlConnection.State == ConnectionState.Open)
                Program.sqlConnection.Close();
            try
            {

                Program.connectionString = "Data Source=" + Program.server + ";Initial Catalog=" + Program.database + ";User ID=" +
                      Program.loginHienTai + ";password=" + Program.passHienTai;
                Program.connectionStringTTKH = $"Data Source=PHUONG_HUE\\PH_SV3; Initial Catalog={Program.database};User ID={Program.loginHienTai}; password={Program.passHienTai};";
                sqlConnection = new SqlConnection(connectionString);
                sqlConnectionTTKH = new SqlConnection(connectionStringTTKH);
                Program.sqlConnection.ConnectionString = Program.connectionString;
                Program.sqlConnection.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("L?i k?t n?i co s? d? li?u.\nB?n xem l?i user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlDataReader myreader;

            SqlCommand sqlcmd = new SqlCommand(cmd, Program.sqlConnection);
            sqlcmd.CommandType = CommandType.Text;

            sqlcmd.CommandTimeout = 660;
            if (Program.sqlConnection.State == ConnectionState.Closed) Program.sqlConnection.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;

            }
            catch (SqlException ex)
            {
                Program.sqlConnection.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
