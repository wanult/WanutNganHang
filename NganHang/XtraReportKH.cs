using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NganHang
{
    public partial class XtraReportKH : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportKH(String maCN, Boolean global)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            sP_RP3TableAdapter1.Connection = Program.sqlConnection;
            sP_RP3TableAdapter1.Fill(ds1.SP_RP3, maCN, global);
        }

    }
}
