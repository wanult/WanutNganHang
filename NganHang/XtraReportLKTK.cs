using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NganHang
{
    public partial class XtraReportLKTK : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportLKTK(String maCN, Boolean global)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            sP_RP2TableAdapter1.Connection = Program.sqlConnection;
            sP_RP2TableAdapter1.Fill(ds1.SP_RP2,maCN,global);
        }

    }
}
