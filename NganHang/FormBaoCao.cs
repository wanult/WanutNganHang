using DevExpress.XtraReports.UI;
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
    public partial class FormBaoCao : Form
    {
        String maCN;
        public FormBaoCao()
        {
            InitializeComponent();
            maCN = ((DataRowView)Program.bindingSourceChiNhanh.Current)["subscriber_server"].ToString();
            this.btnTKLocal.Text = $"Trên chi nhánh " + (((DataRowView)Program.bindingSourceChiNhanh.Current)["description"].ToString().Equals("BENTHANH") ? "Bến Thành" : "Tân Định");
            this.btnKHLocal.Text = $"Trên chi nhánh " + (((DataRowView)Program.bindingSourceChiNhanh.Current)["description"].ToString().Equals("BENTHANH") ? "Bến Thành" : "Tân Định");

        }

        private void btGD_Click(object sender, EventArgs e)
        {
            String s1 = dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Year;
            String s2 = dateTimePicker2.Value.Month + "/" + dateTimePicker2.Value.Day + "/" + dateTimePicker2.Value.Year;
            XtraReportGD xtraReportGD = new XtraReportGD(textBoxSTK.Text, s1, s2);
            xtraReportGD.ShowPreview();
        }

        private void bt1cn_Click(object sender, EventArgs e)
        {
            XtraReportLKTK xtraReportLKTK = new XtraReportLKTK(maCN, false);
            xtraReportLKTK.ShowPreview();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.ChiNhanh' table. You can move, or remove it, as needed.

        }

        private void btcacn_Click(object sender, EventArgs e)
        {
            XtraReportLKTK xtraReportLKTK = new XtraReportLKTK(maCN, true);
            xtraReportLKTK.ShowPreview();
        }

      
        private void btnGlobal_Click(object sender, EventArgs e)
        {
            XtraReportKH xtraReportKH = new XtraReportKH(maCN, true);
            xtraReportKH.ShowPreview();

        }

        private void btnKHLocal_Click(object sender, EventArgs e)
        {
            XtraReportKH xtraReportKH = new XtraReportKH(maCN, false);
            xtraReportKH.ShowPreview();
        }
    }
}
