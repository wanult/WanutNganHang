﻿namespace NganHang
{
    partial class FormNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.Windows.Forms.Label pHAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new NganHang.DS();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new NganHang.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pHAIComboBox = new System.Windows.Forms.ComboBox();
            this.trangThaiXoaTextBox = new System.Windows.Forms.TextBox();
            this.mACNTextBox = new System.Windows.Forms.TextBox();
            this.sODTTextBox = new System.Windows.Forms.TextBox();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.tENTextBox = new System.Windows.Forms.TextBox();
            this.hOTextBox = new System.Windows.Forms.TextBox();
            this.mANVTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.v_DSNHOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSLG = new NganHang.DSLG();
            this.v_DSTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSTKTableAdapter = new NganHang.DSLGTableAdapters.V_DSTKTableAdapter();
            this.tableAdapterManager1 = new NganHang.DSLGTableAdapters.TableAdapterManager();
            this.v_DSNHOMTableAdapter = new NganHang.DSLGTableAdapters.V_DSNHOMTableAdapter();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSNHOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSTKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(30, 34);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(42, 13);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "MANV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(210, 34);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            hOLabel.Click += new System.EventHandler(this.hOLabel_Click);
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(378, 34);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(22, 71);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(51, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "DIACHI:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODTLabel.Location = new System.Drawing.Point(29, 110);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(40, 13);
            sODTLabel.TabIndex = 10;
            sODTLabel.Text = "SODT:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(27, 147);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(42, 13);
            mACNLabel.TabIndex = 12;
            mACNLabel.Text = "MACN:";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trangThaiXoaLabel.Location = new System.Drawing.Point(317, 115);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(94, 13);
            trangThaiXoaLabel.TabIndex = 14;
            trangThaiXoaLabel.Text = "Trang Thai Xoa:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHAILabel.Location = new System.Drawing.Point(373, 74);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(38, 13);
            pHAILabel.TabIndex = 16;
            pHAILabel.Text = "PHAI:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            this.bar1.Visible = false;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem6, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem7, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem8, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ItemAppearance.Disabled.BackColor = System.Drawing.Color.LightGreen;
            this.barButtonItem1.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem1.ItemAppearance.Disabled.Options.UseBackColor = true;
            this.barButtonItem1.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xóa";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Sửa";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Lưu";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Làm mới";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Quay lại";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Tạo Đăng Nhập";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Đăng xuất";
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1090, 69);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 606);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1090, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 69);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 537);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1090, 69);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 537);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.comboBoxCN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 40);
            this.panel1.TabIndex = 4;
            // 
            // comboBoxCN
            // 
            this.comboBoxCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCN.FormattingEnabled = true;
            this.comboBoxCN.Location = new System.Drawing.Point(87, 9);
            this.comboBoxCN.Name = "comboBoxCN";
            this.comboBoxCN.Size = new System.Drawing.Size(215, 21);
            this.comboBoxCN.TabIndex = 1;
            this.comboBoxCN.SelectedIndexChanged += new System.EventHandler(this.comboBoxCN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.dS;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nhanVienGridControl.DataSource = this.bdsNV;
            this.nhanVienGridControl.Location = new System.Drawing.Point(0, 109);
            this.nhanVienGridControl.MainView = this.gridView1;
            this.nhanVienGridControl.MenuManager = this.barManager1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(1090, 251);
            this.nhanVienGridControl.TabIndex = 9;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colMACN});
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.AllowEdit = false;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            this.colSODT.OptionsColumn.AllowEdit = false;
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(pHAILabel);
            this.groupBox1.Controls.Add(this.pHAIComboBox);
            this.groupBox1.Controls.Add(trangThaiXoaLabel);
            this.groupBox1.Controls.Add(this.trangThaiXoaTextBox);
            this.groupBox1.Controls.Add(mACNLabel);
            this.groupBox1.Controls.Add(this.mACNTextBox);
            this.groupBox1.Controls.Add(sODTLabel);
            this.groupBox1.Controls.Add(this.sODTTextBox);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.dIACHITextBox);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.tENTextBox);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.hOTextBox);
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Controls.Add(this.mANVTextBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 194);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // pHAIComboBox
            // 
            this.pHAIComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "PHAI", true));
            this.pHAIComboBox.FormattingEnabled = true;
            this.pHAIComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.pHAIComboBox.Location = new System.Drawing.Point(414, 71);
            this.pHAIComboBox.Name = "pHAIComboBox";
            this.pHAIComboBox.Size = new System.Drawing.Size(158, 21);
            this.pHAIComboBox.TabIndex = 17;
            // 
            // trangThaiXoaTextBox
            // 
            this.trangThaiXoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "TrangThaiXoa", true));
            this.trangThaiXoaTextBox.Location = new System.Drawing.Point(414, 107);
            this.trangThaiXoaTextBox.Name = "trangThaiXoaTextBox";
            this.trangThaiXoaTextBox.Size = new System.Drawing.Size(158, 21);
            this.trangThaiXoaTextBox.TabIndex = 15;
            // 
            // mACNTextBox
            // 
            this.mACNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "MACN", true));
            this.mACNTextBox.Location = new System.Drawing.Point(75, 144);
            this.mACNTextBox.Name = "mACNTextBox";
            this.mACNTextBox.Size = new System.Drawing.Size(161, 21);
            this.mACNTextBox.TabIndex = 13;
            // 
            // sODTTextBox
            // 
            this.sODTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "SODT", true));
            this.sODTTextBox.Location = new System.Drawing.Point(75, 107);
            this.sODTTextBox.Name = "sODTTextBox";
            this.sODTTextBox.Size = new System.Drawing.Size(161, 21);
            this.sODTTextBox.TabIndex = 11;
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "DIACHI", true));
            this.dIACHITextBox.Location = new System.Drawing.Point(75, 71);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(288, 21);
            this.dIACHITextBox.TabIndex = 7;
            // 
            // tENTextBox
            // 
            this.tENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "TEN", true));
            this.tENTextBox.Location = new System.Drawing.Point(414, 31);
            this.tENTextBox.Name = "tENTextBox";
            this.tENTextBox.Size = new System.Drawing.Size(158, 21);
            this.tENTextBox.TabIndex = 5;
            // 
            // hOTextBox
            // 
            this.hOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "HO", true));
            this.hOTextBox.Location = new System.Drawing.Point(242, 31);
            this.hOTextBox.Name = "hOTextBox";
            this.hOTextBox.Size = new System.Drawing.Size(121, 21);
            this.hOTextBox.TabIndex = 3;
            // 
            // mANVTextBox
            // 
            this.mANVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "MANV", true));
            this.mANVTextBox.Location = new System.Drawing.Point(75, 31);
            this.mANVTextBox.Name = "mANVTextBox";
            this.mANVTextBox.Size = new System.Drawing.Size(100, 21);
            this.mANVTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnhuy);
            this.groupBox2.Controls.Add(this.btnok);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 546);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1090, 60);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(275, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 31);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, -11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nhom";
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnhuy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(402, 22);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(102, 29);
            this.btnhuy.TabIndex = 20;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnok.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(402, 8);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(102, 29);
            this.btnok.TabIndex = 19;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // v_DSNHOMBindingSource
            // 
            this.v_DSNHOMBindingSource.DataMember = "V_DSNHOM";
            this.v_DSNHOMBindingSource.DataSource = this.dSLG;
            // 
            // dSLG
            // 
            this.dSLG.DataSetName = "DSLG";
            this.dSLG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DSTKBindingSource
            // 
            this.v_DSTKBindingSource.DataMember = "V_DSTK";
            this.v_DSTKBindingSource.DataSource = this.dSLG;
            // 
            // v_DSTKTableAdapter
            // 
            this.v_DSTKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = NganHang.DSLGTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_DSNHOMTableAdapter
            // 
            this.v_DSNHOMTableAdapter.ClearBeforeFill = true;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nhanVienGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormNhanVien";
            this.Text = "Quản lý nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSNHOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSTKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCN;
        private System.Windows.Forms.BindingSource bdsNV;
        private DS dS;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private System.Windows.Forms.TextBox tENTextBox;
        private System.Windows.Forms.TextBox hOTextBox;
        private System.Windows.Forms.TextBox mANVTextBox;
        private System.Windows.Forms.TextBox mACNTextBox;
        private System.Windows.Forms.TextBox sODTTextBox;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private System.Windows.Forms.TextBox trangThaiXoaTextBox;
        private System.Windows.Forms.ComboBox pHAIComboBox;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private System.Windows.Forms.Label label5;
        private DSLG dSLG;
        private System.Windows.Forms.BindingSource v_DSTKBindingSource;
        private DSLGTableAdapters.V_DSTKTableAdapter v_DSTKTableAdapter;
        private DSLGTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource v_DSNHOMBindingSource;
        private DSLGTableAdapters.V_DSNHOMTableAdapter v_DSNHOMTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
    }
}