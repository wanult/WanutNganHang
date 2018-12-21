namespace NganHang
{
    partial class FormGiaoDich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiaoDich));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.guitien = new DevExpress.XtraBars.BarButtonItem();
            this.ruttien = new DevExpress.XtraBars.BarButtonItem();
            this.chuyentien = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbgui1 = new System.Windows.Forms.Label();
            this.bthuy = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.ktnhan = new System.Windows.Forms.Button();
            this.ktrut = new System.Windows.Forms.Button();
            this.picnhan = new System.Windows.Forms.PictureBox();
            this.pictien = new System.Windows.Forms.PictureBox();
            this.picrut = new System.Windows.Forms.PictureBox();
            this.tbtien = new System.Windows.Forms.TextBox();
            this.tbrut = new System.Windows.Forms.TextBox();
            this.tbnhan = new System.Windows.Forms.TextBox();
            this.lbtien = new System.Windows.Forms.Label();
            this.lbgui = new System.Windows.Forms.Label();
            this.lbnhan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picnhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrut)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.guitien,
            this.ruttien,
            this.chuyentien,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.guitien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.ruttien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.chuyentien, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // guitien
            // 
            this.guitien.Caption = "Gửi tiền";
            this.guitien.Id = 0;
            this.guitien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("guitien.ImageOptions.Image")));
            this.guitien.ImageOptions.LargeImage = global::NganHang.Properties.Resources.pigpng;
            this.guitien.Name = "guitien";
            this.guitien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ruttien
            // 
            this.ruttien.Caption = "Rút tiền";
            this.ruttien.Id = 1;
            this.ruttien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ruttien.ImageOptions.Image")));
            this.ruttien.Name = "ruttien";
            this.ruttien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ruttien_ItemClick);
            // 
            // chuyentien
            // 
            this.chuyentien.Caption = "Chuyển tiền";
            this.chuyentien.Id = 2;
            this.chuyentien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chuyentien.ImageOptions.Image")));
            this.chuyentien.Name = "chuyentien";
            this.chuyentien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.chuyentien_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(683, 63);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 411);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(683, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 63);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 348);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(683, 63);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 348);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbgui1);
            this.groupBox1.Controls.Add(this.bthuy);
            this.groupBox1.Controls.Add(this.btOK);
            this.groupBox1.Controls.Add(this.ktnhan);
            this.groupBox1.Controls.Add(this.ktrut);
            this.groupBox1.Controls.Add(this.picnhan);
            this.groupBox1.Controls.Add(this.pictien);
            this.groupBox1.Controls.Add(this.picrut);
            this.groupBox1.Controls.Add(this.tbtien);
            this.groupBox1.Controls.Add(this.tbrut);
            this.groupBox1.Controls.Add(this.tbnhan);
            this.groupBox1.Controls.Add(this.lbtien);
            this.groupBox1.Controls.Add(this.lbgui);
            this.groupBox1.Controls.Add(this.lbnhan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 330);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lbgui1
            // 
            this.lbgui1.AutoSize = true;
            this.lbgui1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgui1.Location = new System.Drawing.Point(222, 58);
            this.lbgui1.Name = "lbgui1";
            this.lbgui1.Size = new System.Drawing.Size(52, 16);
            this.lbgui1.TabIndex = 13;
            this.lbgui1.Text = "TK Gửi";
            // 
            // bthuy
            // 
            this.bthuy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.Location = new System.Drawing.Point(384, 245);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(75, 23);
            this.bthuy.TabIndex = 12;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(283, 245);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 11;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // ktnhan
            // 
            this.ktnhan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktnhan.Location = new System.Drawing.Point(475, 186);
            this.ktnhan.Name = "ktnhan";
            this.ktnhan.Size = new System.Drawing.Size(75, 22);
            this.ktnhan.TabIndex = 10;
            this.ktnhan.Text = "Kiểm tra";
            this.ktnhan.UseVisualStyleBackColor = true;
            this.ktnhan.Click += new System.EventHandler(this.ktnhan_Click);
            // 
            // ktrut
            // 
            this.ktrut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktrut.Location = new System.Drawing.Point(475, 55);
            this.ktrut.Name = "ktrut";
            this.ktrut.Size = new System.Drawing.Size(75, 23);
            this.ktrut.TabIndex = 9;
            this.ktrut.Text = "Kiểm tra";
            this.ktrut.UseVisualStyleBackColor = true;
            this.ktrut.Click += new System.EventHandler(this.ktrut_Click);
            // 
            // picnhan
            // 
            this.picnhan.Image = ((System.Drawing.Image)(resources.GetObject("picnhan.Image")));
            this.picnhan.Location = new System.Drawing.Point(107, 182);
            this.picnhan.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.picnhan.Name = "picnhan";
            this.picnhan.Size = new System.Drawing.Size(100, 50);
            this.picnhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picnhan.TabIndex = 8;
            this.picnhan.TabStop = false;
            // 
            // pictien
            // 
            this.pictien.Image = ((System.Drawing.Image)(resources.GetObject("pictien.Image")));
            this.pictien.Location = new System.Drawing.Point(107, 109);
            this.pictien.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.pictien.Name = "pictien";
            this.pictien.Size = new System.Drawing.Size(100, 50);
            this.pictien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictien.TabIndex = 7;
            this.pictien.TabStop = false;
            // 
            // picrut
            // 
            this.picrut.Image = ((System.Drawing.Image)(resources.GetObject("picrut.Image")));
            this.picrut.Location = new System.Drawing.Point(107, 35);
            this.picrut.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.picrut.Name = "picrut";
            this.picrut.Size = new System.Drawing.Size(100, 51);
            this.picrut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picrut.TabIndex = 6;
            this.picrut.TabStop = false;
            // 
            // tbtien
            // 
            this.tbtien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtien.Location = new System.Drawing.Point(283, 118);
            this.tbtien.Name = "tbtien";
            this.tbtien.Size = new System.Drawing.Size(186, 22);
            this.tbtien.TabIndex = 5;
            // 
            // tbrut
            // 
            this.tbrut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbrut.Location = new System.Drawing.Point(283, 55);
            this.tbrut.Name = "tbrut";
            this.tbrut.Size = new System.Drawing.Size(186, 22);
            this.tbrut.TabIndex = 4;
            // 
            // tbnhan
            // 
            this.tbnhan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnhan.Location = new System.Drawing.Point(283, 186);
            this.tbnhan.Name = "tbnhan";
            this.tbnhan.Size = new System.Drawing.Size(186, 22);
            this.tbnhan.TabIndex = 3;
            // 
            // lbtien
            // 
            this.lbtien.AutoSize = true;
            this.lbtien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtien.Location = new System.Drawing.Point(221, 121);
            this.lbtien.Name = "lbtien";
            this.lbtien.Size = new System.Drawing.Size(53, 16);
            this.lbtien.TabIndex = 2;
            this.lbtien.Text = "Số tiền";
            // 
            // lbgui
            // 
            this.lbgui.AutoSize = true;
            this.lbgui.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgui.Location = new System.Drawing.Point(224, 58);
            this.lbgui.Name = "lbgui";
            this.lbgui.Size = new System.Drawing.Size(50, 16);
            this.lbgui.TabIndex = 1;
            this.lbgui.Text = "TK Rút";
            // 
            // lbnhan
            // 
            this.lbnhan.AutoSize = true;
            this.lbnhan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnhan.Location = new System.Drawing.Point(212, 189);
            this.lbnhan.Name = "lbnhan";
            this.lbnhan.Size = new System.Drawing.Size(62, 16);
            this.lbnhan.TabIndex = 0;
            this.lbnhan.Text = "TK Nhận";
            // 
            // FormGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 434);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormGiaoDich";
            this.Text = "Quản lý giao dịch";
            this.Load += new System.EventHandler(this.FormGiaoDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picnhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem guitien;
        private DevExpress.XtraBars.BarButtonItem ruttien;
        private DevExpress.XtraBars.BarButtonItem chuyentien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbnhan;
        private System.Windows.Forms.Label lbgui;
        private System.Windows.Forms.TextBox tbtien;
        private System.Windows.Forms.TextBox tbrut;
        private System.Windows.Forms.TextBox tbnhan;
        private System.Windows.Forms.Label lbtien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button ktnhan;
        private System.Windows.Forms.Button ktrut;
        private System.Windows.Forms.PictureBox picnhan;
        private System.Windows.Forms.PictureBox pictien;
        private System.Windows.Forms.PictureBox picrut;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Label lbgui1;
    }
}