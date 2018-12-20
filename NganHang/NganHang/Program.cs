using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;

namespace NganHang
{
    static class Program
    {
        public static FormNhanVien formNhanVien;
        public static FromDangNhap formDangNhap;
        public static BindingSource bindingSourceChiNhanh;
        public static string database = "NGANHANG";
        public static string server = "";
        public static string loginName = "";
        public static string passWord = "";
        public static string connectionString = "";
        public static SqlConnection sqlConnection;
        public static string loginHienTai = "";
        public static string passHienTai = "";

        public static string remoteLogin = "HTKNNH";
        public static string remotePassword = "123";
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
    }
}
