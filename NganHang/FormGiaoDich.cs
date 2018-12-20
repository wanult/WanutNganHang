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
    public partial class FormGiaoDich : Form
    {
        int chucnang;
        public FormGiaoDich()
        {
            InitializeComponent();
        }

        private void FormGiaoDich_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chucnang = 1;
            groupBox1.Visible = true;
            pictien.Visible = false;
            lbtien.Visible = false;
            tbtien.Visible = false;
            picrut.Visible = true;
            lbgui1.Visible = true;
            btOK.Visible = false;
            picnhan.Visible = false;
            ktrut.Visible = true;
            ktnhan.Visible = false;
            lbgui.Visible = false;
            tbrut.Visible = true;
            lbnhan.Visible = false;
            tbnhan.Visible = false;
            bthuy.Visible = false;
            tbtien.ResetText();
            tbrut.ResetText();
        }

        private void ruttien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chucnang = 2;
            groupBox1.Visible = true;
            picrut.Visible = true;
            picnhan.Visible = false;
            pictien.Visible = false;
            ktrut.Visible = true;
            ktnhan.Visible = false;
            lbgui.Visible = true;
            tbrut.Visible = true;
            lbnhan.Visible = false;
            tbnhan.Visible = false;
            lbgui1.Visible = false;
            tbtien.Visible = false;
            lbtien.Visible = false;
            btOK.Visible = false;
            bthuy.Visible = false;
            tbtien.ResetText();
            tbrut.ResetText();
        }

        private void chuyentien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chucnang = 3;
            groupBox1.Visible = true;
            lbtien.Visible = true;
            tbtien.Visible = true;
            pictien.Visible = true;
            picrut.Visible = true;
            btOK.Visible = false;
            picnhan.Visible = true;
            ktrut.Visible = true;
            ktnhan.Visible = true;
            lbgui1.Visible = true;
            lbgui.Visible = false;
            tbrut.Visible = true;
            lbnhan.Visible = true;
            tbnhan.Visible = true;
            btOK.Visible = false;
            bthuy.Visible = false;
            tbtien.ResetText();
            tbnhan.ResetText();
            tbrut.ResetText();
        }

        
        private void ktrut_Click(object sender, EventArgs e)
        {
            try
            {  
                string sp = "EXEC KIEMTRATK '" + tbrut.Text + "'";
                Program.myreader = Program.ExecSqlDataReader(sp);
                Program.myreader.Read();
                MessageBox.Show("CMND: " + Program.myreader.GetString(0) + "Ho ten: " +
                    Program.myreader.GetString(1));
                lbtien.Visible = true;
                tbtien.Visible = true;
                pictien.Visible = true;
                btOK.Visible = true;
                bthuy.Visible = true;
                Program.myreader.Close();
            }
            catch
            {
                MessageBox.Show("Tai khoan khong ton tai!");
                Program.myreader.Close();
                return;
            }

        }

        private void ktnhan_Click(object sender, EventArgs e)
        {
            try
            {
                string sp = "EXEC KIEMTRATK '" + tbnhan.Text + "'";
                Program.myreader = Program.ExecSqlDataReader(sp);
                Program.myreader.Read();
                MessageBox.Show("CMND: " + Program.myreader.GetString(0) + "Ho ten: " +
                    Program.myreader.GetString(1));
                
                btOK.Visible = true;
                bthuy.Visible = true;
                Program.myreader.Close();
            }
            catch
            {
                MessageBox.Show("Tai khoan khong ton tai!");
                Program.myreader.Close();
                return;
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (chucnang == 1)
            {
               
                string sp1 = "EXEC SP_MAGD";
                Program.myreader = Program.ExecSqlDataReader(sp1);
                Program.myreader.Read();
                string magd= Program.myreader.GetString(0);
                int MAGD = int.Parse(magd);
                Program.myreader.Close();
                string sp = "EXEC SP_GUITIEN '" + tbrut.Text.ToString() + 
                    "','"+ tbtien.Text + "','" + Program.maNV + "','" + (MAGD + 1) + "'";

                Program.myreader = Program.ExecSqlDataReader(sp);
                Program.myreader.Read();
                Program.myreader.Close();
                MessageBox.Show("Thành công");
                groupBox1.Visible = false;
            }
            else if (chucnang == 2)
            {
                string sp1 = "EXEC SP_MAGD";
                Program.myreader = Program.ExecSqlDataReader(sp1);
                Program.myreader.Read();
                string magd = Program.myreader.GetString(0);
                int MAGD = int.Parse(magd);
                Program.myreader.Close();
                string sp = "EXEC SP_RUTTIEN '" + tbrut.Text.ToString() +
                    "','" + tbtien.Text + "','" + Program.maNV + "','" + (MAGD + 1) + "'";

                Program.myreader = Program.ExecSqlDataReader(sp);
                Program.myreader.Read();
                MessageBox.Show("Thanh cong");
                groupBox1.Visible = false;
            }
            else if (chucnang == 3)
            {
                string sp2 = "EXEC SP_MAGD_CT";
                Program.myreader = Program.ExecSqlDataReader(sp2);
                Program.myreader.Read();
                string magd = Program.myreader.GetString(0);
                int MAGD = int.Parse(magd);
                Program.myreader.Close();
                string sp3 = "EXEC SP_CHUYENTIEN '" + tbrut.Text.ToString() + "','" + (MAGD + 1) +
                    "','" + tbtien.Text + "','" + tbnhan.Text.ToString() + "','" + Program.maNV +  "'";

                Program.myreader = Program.ExecSqlDataReader(sp3);
                Program.myreader.Read();
                MessageBox.Show("Thanh cong");
                groupBox1.Visible = false;
            }
            
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}
