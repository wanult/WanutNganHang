namespace NganHang
{
    partial class FormBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btGD = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxSTK = new System.Windows.Forms.TextBox();
            this.lbngayc = new System.Windows.Forms.Label();
            this.lbngayd = new System.Windows.Forms.Label();
            this.lbstk = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnTKGlobal = new System.Windows.Forms.Button();
            this.btnTKLocal = new System.Windows.Forms.Button();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.btnKHGlobal = new System.Windows.Forms.Button();
            this.btnKHLocal = new System.Windows.Forms.Button();
            this.dS = new NganHang.DS();
            this.dataSetMaster1 = new NganHang.DataSetMaster();
            this.sP_RP1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_RP1TableAdapter = new NganHang.DSTableAdapters.SP_RP1TableAdapter();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_RP1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 10F);
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1039, 407);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.btGD);
            this.xtraTabPage1.Controls.Add(this.dateTimePicker2);
            this.xtraTabPage1.Controls.Add(this.dateTimePicker1);
            this.xtraTabPage1.Controls.Add(this.textBoxSTK);
            this.xtraTabPage1.Controls.Add(this.lbngayc);
            this.xtraTabPage1.Controls.Add(this.lbngayd);
            this.xtraTabPage1.Controls.Add(this.lbstk);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1033, 375);
            this.xtraTabPage1.Text = "GIAO DỊCH";
            // 
            // btGD
            // 
            this.btGD.Location = new System.Drawing.Point(545, 264);
            this.btGD.Name = "btGD";
            this.btGD.Size = new System.Drawing.Size(75, 23);
            this.btGD.TabIndex = 13;
            this.btGD.Text = "OK";
            this.btGD.UseVisualStyleBackColor = true;
            this.btGD.Click += new System.EventHandler(this.btGD_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(507, 194);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(238, 21);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(507, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 21);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // textBoxSTK
            // 
            this.textBoxSTK.Location = new System.Drawing.Point(507, 110);
            this.textBoxSTK.Name = "textBoxSTK";
            this.textBoxSTK.Size = new System.Drawing.Size(238, 21);
            this.textBoxSTK.TabIndex = 10;
            // 
            // lbngayc
            // 
            this.lbngayc.AutoSize = true;
            this.lbngayc.Location = new System.Drawing.Point(431, 201);
            this.lbngayc.Name = "lbngayc";
            this.lbngayc.Size = new System.Drawing.Size(54, 13);
            this.lbngayc.TabIndex = 9;
            this.lbngayc.Text = "Đến ngày";
            // 
            // lbngayd
            // 
            this.lbngayd.AutoSize = true;
            this.lbngayd.Location = new System.Drawing.Point(431, 162);
            this.lbngayd.Name = "lbngayd";
            this.lbngayd.Size = new System.Drawing.Size(47, 13);
            this.lbngayd.TabIndex = 8;
            this.lbngayd.Text = "Từ ngày";
            // 
            // lbstk
            // 
            this.lbstk.AutoSize = true;
            this.lbstk.Location = new System.Drawing.Point(431, 113);
            this.lbstk.Name = "lbstk";
            this.lbstk.Size = new System.Drawing.Size(34, 13);
            this.lbstk.TabIndex = 7;
            this.lbstk.Text = "Số TK";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btnTKGlobal);
            this.xtraTabPage2.Controls.Add(this.btnTKLocal);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1033, 375);
            this.xtraTabPage2.Text = "TÀI KHOẢN";
            // 
            // btnTKGlobal
            // 
            this.btnTKGlobal.BackColor = System.Drawing.Color.Transparent;
            this.btnTKGlobal.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnTKGlobal.Location = new System.Drawing.Point(604, 110);
            this.btnTKGlobal.Name = "btnTKGlobal";
            this.btnTKGlobal.Size = new System.Drawing.Size(354, 74);
            this.btnTKGlobal.TabIndex = 3;
            this.btnTKGlobal.Text = "Trên các Chi Nhánh";
            this.btnTKGlobal.UseVisualStyleBackColor = false;
            this.btnTKGlobal.Click += new System.EventHandler(this.btcacn_Click);
            // 
            // btnTKLocal
            // 
            this.btnTKLocal.BackColor = System.Drawing.Color.Transparent;
            this.btnTKLocal.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnTKLocal.Location = new System.Drawing.Point(220, 110);
            this.btnTKLocal.Name = "btnTKLocal";
            this.btnTKLocal.Size = new System.Drawing.Size(321, 73);
            this.btnTKLocal.TabIndex = 2;
            this.btnTKLocal.UseVisualStyleBackColor = false;
            this.btnTKLocal.Click += new System.EventHandler(this.bt1cn_Click);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.btnKHGlobal);
            this.xtraTabPage3.Controls.Add(this.btnKHLocal);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1033, 375);
            this.xtraTabPage3.Text = "KHÁCH HÀNG";
            // 
            // btnKHGlobal
            // 
            this.btnKHGlobal.BackColor = System.Drawing.Color.Transparent;
            this.btnKHGlobal.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnKHGlobal.Location = new System.Drawing.Point(604, 110);
            this.btnKHGlobal.Name = "btnKHGlobal";
            this.btnKHGlobal.Size = new System.Drawing.Size(354, 74);
            this.btnKHGlobal.TabIndex = 5;
            this.btnKHGlobal.Text = "Trên các Chi Nhánh";
            this.btnKHGlobal.UseVisualStyleBackColor = false;
            this.btnKHGlobal.Click += new System.EventHandler(this.btnGlobal_Click);
            // 
            // btnKHLocal
            // 
            this.btnKHLocal.BackColor = System.Drawing.Color.Transparent;
            this.btnKHLocal.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnKHLocal.Location = new System.Drawing.Point(220, 110);
            this.btnKHLocal.Name = "btnKHLocal";
            this.btnKHLocal.Size = new System.Drawing.Size(321, 73);
            this.btnKHLocal.TabIndex = 4;
            this.btnKHLocal.UseVisualStyleBackColor = false;
            this.btnKHLocal.Click += new System.EventHandler(this.btnKHLocal_Click);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetMaster1
            // 
            this.dataSetMaster1.DataSetName = "DataSetMaster";
            this.dataSetMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_RP1BindingSource
            // 
            this.sP_RP1BindingSource.DataMember = "SP_RP1";
            this.sP_RP1BindingSource.DataSource = this.dS;
            // 
            // sP_RP1TableAdapter
            // 
            this.sP_RP1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 407);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FormBaoCao";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_RP1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DataSetMaster dataSetMaster1;
        private System.Windows.Forms.Button btGD;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxSTK;
        private System.Windows.Forms.Label lbngayc;
        private System.Windows.Forms.Label lbngayd;
        private System.Windows.Forms.Label lbstk;
        private System.Windows.Forms.Button btnTKGlobal;
        private System.Windows.Forms.Button btnTKLocal;
        private DS dS;
        private System.Windows.Forms.BindingSource sP_RP1BindingSource;
        private DSTableAdapters.SP_RP1TableAdapter sP_RP1TableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnKHGlobal;
        private System.Windows.Forms.Button btnKHLocal;
    }
}