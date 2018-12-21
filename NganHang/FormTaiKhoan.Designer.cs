namespace NganHang
{
    partial class FormTaiKhoan
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
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label mACNLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxCNTK = new System.Windows.Forms.ComboBox();
            this.cnkh = new System.Windows.Forms.Label();
            this.dS = new NganHang.DS();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new NganHang.DSTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxTK = new System.Windows.Forms.GroupBox();
            this.cntk = new System.Windows.Forms.TextBox();
            this.sdtk = new System.Windows.Forms.TextBox();
            this.cmndtk = new System.Windows.Forms.TextBox();
            this.stk = new System.Windows.Forms.TextBox();
            sOTKLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBoxTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(32, 30);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(38, 14);
            sOTKLabel.TabIndex = 0;
            sOTKLabel.Text = "SOTK:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(32, 81);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(39, 14);
            cMNDLabel.TabIndex = 2;
            cMNDLabel.Text = "CMND:";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Location = new System.Drawing.Point(260, 30);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(39, 14);
            sODULabel.TabIndex = 4;
            sODULabel.Text = "SODU:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(260, 81);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(40, 14);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "MACN:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.cbxCNTK);
            this.panel1.Controls.Add(this.cnkh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            // 
            // cbxCNTK
            // 
            this.cbxCNTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCNTK.FormattingEnabled = true;
            this.cbxCNTK.Location = new System.Drawing.Point(74, 10);
            this.cbxCNTK.Name = "cbxCNTK";
            this.cbxCNTK.Size = new System.Drawing.Size(164, 22);
            this.cbxCNTK.TabIndex = 2;
            this.cbxCNTK.SelectedIndexChanged += new System.EventHandler(this.cbxCNTK_SelectedIndexChanged);
            // 
            // cnkh
            // 
            this.cnkh.AutoSize = true;
            this.cnkh.Location = new System.Drawing.Point(12, 13);
            this.cnkh.Name = "cnkh";
            this.cnkh.Size = new System.Drawing.Size(56, 14);
            this.cnkh.TabIndex = 0;
            this.cnkh.Text = "Chi Nhánh";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "TaiKhoan";
            this.bdsTK.DataSource = this.dS;
            this.bdsTK.Filter = "TrangThaiXoa = 1";
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taiKhoanGridControl.DataSource = this.bdsTK;
            this.taiKhoanGridControl.Location = new System.Drawing.Point(0, 39);
            this.taiKhoanGridControl.MainView = this.gridView1;
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(800, 290);
            this.taiKhoanGridControl.TabIndex = 2;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN});
            this.gridView1.GridControl = this.taiKhoanGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.OptionsColumn.AllowEdit = false;
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.OptionsColumn.AllowEdit = false;
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            // 
            // colSODU
            // 
            this.colSODU.FieldName = "SODU";
            this.colSODU.Name = "colSODU";
            this.colSODU.OptionsColumn.AllowEdit = false;
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            // 
            // groupBoxTK
            // 
            this.groupBoxTK.Controls.Add(mACNLabel);
            this.groupBoxTK.Controls.Add(this.cntk);
            this.groupBoxTK.Controls.Add(sODULabel);
            this.groupBoxTK.Controls.Add(this.sdtk);
            this.groupBoxTK.Controls.Add(cMNDLabel);
            this.groupBoxTK.Controls.Add(this.cmndtk);
            this.groupBoxTK.Controls.Add(sOTKLabel);
            this.groupBoxTK.Controls.Add(this.stk);
            this.groupBoxTK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxTK.Location = new System.Drawing.Point(0, 335);
            this.groupBoxTK.Name = "groupBoxTK";
            this.groupBoxTK.Size = new System.Drawing.Size(800, 115);
            this.groupBoxTK.TabIndex = 3;
            this.groupBoxTK.TabStop = false;
            // 
            // cntk
            // 
            this.cntk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "MACN", true));
            this.cntk.Location = new System.Drawing.Point(306, 78);
            this.cntk.Name = "cntk";
            this.cntk.Size = new System.Drawing.Size(141, 20);
            this.cntk.TabIndex = 7;
            // 
            // sdtk
            // 
            this.sdtk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "SODU", true));
            this.sdtk.Location = new System.Drawing.Point(305, 27);
            this.sdtk.Name = "sdtk";
            this.sdtk.Size = new System.Drawing.Size(142, 20);
            this.sdtk.TabIndex = 5;
            // 
            // cmndtk
            // 
            this.cmndtk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "CMND", true));
            this.cmndtk.Location = new System.Drawing.Point(77, 78);
            this.cmndtk.Name = "cmndtk";
            this.cmndtk.Size = new System.Drawing.Size(146, 20);
            this.cmndtk.TabIndex = 3;
            // 
            // stk
            // 
            this.stk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "SOTK", true));
            this.stk.Location = new System.Drawing.Point(76, 27);
            this.stk.Name = "stk";
            this.stk.Size = new System.Drawing.Size(147, 20);
            this.stk.TabIndex = 1;
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTK);
            this.Controls.Add(this.taiKhoanGridControl);
            this.Controls.Add(this.panel1);
            this.Name = "FormTaiKhoan";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBoxTK.ResumeLayout(false);
            this.groupBoxTK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cnkh;
        private System.Windows.Forms.ComboBox cbxCNTK;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsTK;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.GroupBox groupBoxTK;
        private System.Windows.Forms.TextBox cntk;
        private System.Windows.Forms.TextBox sdtk;
        private System.Windows.Forms.TextBox cmndtk;
        private System.Windows.Forms.TextBox stk;
    }
}