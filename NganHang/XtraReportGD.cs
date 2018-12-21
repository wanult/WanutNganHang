using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NganHang
{
    public partial class XtraReportGD : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportGD(string stk, string dateFrom, string dateTo)
        {
            InitializeComponent();
            ds2.EnforceConstraints = false;
            sP_RP1TableAdapter1.Connection = Program.sqlConnection;
            sP_RP1TableAdapter1.Fill(ds2.SP_RP1, stk, dateFrom, dateTo);
        }

    }
}
