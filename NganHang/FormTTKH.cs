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
    public partial class FormTTKH : Form
    {
        public FormTTKH()
        {
            InitializeComponent();
        }

        private void chiNhanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chiNhanhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSTTKH);

        }

        private void FormTTKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSTTKH.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.dSTTKH.KhachHang);
            // TODO: This line of code loads data into the 'dSTTKH.ChiNhanh' table. You can move, or remove it, as needed.
            this.chiNhanhTableAdapter.Fill(this.dSTTKH.ChiNhanh);
            this.chiNhanhBindingSource.Sort = "MACN asc";
            this.fKKhachHangChiNhanhBindingSource.Sort = "TEN asc, HO asc";


        }

        private void chiNhanhComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
