namespace NganHang
{
    partial class FormTaoLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaoLogin));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.cbxNh = new System.Windows.Forms.ComboBox();
            this.cbxMa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dSLG = new NganHang.DSLG();
            this.vDSTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSTKTableAdapter = new NganHang.DSLGTableAdapters.V_DSTKTableAdapter();
            this.NhomQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSNHOMTableAdapter = new NganHang.DSLGTableAdapters.V_DSNHOMTableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSTKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhomQuyenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.login);
            this.groupBox3.Controls.Add(this.cbxNh);
            this.groupBox3.Controls.Add(this.cbxMa);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.txtPass);
            this.groupBox3.Controls.Add(this.txtTen);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(35);
            this.groupBox3.Size = new System.Drawing.Size(508, 377);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(267, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 36);
            this.button4.TabIndex = 13;
            this.button4.Text = "Hủy";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Silver;
            this.login.Location = new System.Drawing.Point(137, 296);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(87, 36);
            this.login.TabIndex = 12;
            this.login.Text = "Tạo";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // cbxNh
            // 
            this.cbxNh.DataSource = this.NhomQuyenBindingSource;
            this.cbxNh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNh.FormattingEnabled = true;
            this.cbxNh.Location = new System.Drawing.Point(209, 241);
            this.cbxNh.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.cbxNh.Name = "cbxNh";
            this.cbxNh.Size = new System.Drawing.Size(214, 22);
            this.cbxNh.TabIndex = 11;
            this.cbxNh.ValueMember = "name";
            // 
            // cbxMa
            // 
            this.cbxMa.DataSource = this.vDSTKBindingSource;
            this.cbxMa.DisplayMember = "MANV";
            this.cbxMa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMa.FormattingEnabled = true;
            this.cbxMa.Location = new System.Drawing.Point(209, 186);
            this.cbxMa.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.cbxMa.Name = "cbxMa";
            this.cbxMa.Size = new System.Drawing.Size(214, 22);
            this.cbxMa.TabIndex = 10;
            this.cbxMa.ValueMember = "MANV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nhóm Quyền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật Khẩu";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(209, 133);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(214, 20);
            this.txtPass.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(209, 80);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(214, 20);
            this.txtTen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(65, 231);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(65, 176);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(65, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "TẠO LOGIN";
            // 
            // dSLG
            // 
            this.dSLG.DataSetName = "DSLG";
            this.dSLG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vDSTKBindingSource
            // 
            this.vDSTKBindingSource.DataMember = "V_DSTK";
            this.vDSTKBindingSource.DataSource = this.dSLG;
            // 
            // v_DSTKTableAdapter
            // 
            this.v_DSTKTableAdapter.ClearBeforeFill = true;
            // 
            // NhomQuyenBindingSource
            // 
            this.NhomQuyenBindingSource.DataMember = "V_DSNHOM";
            this.NhomQuyenBindingSource.DataSource = this.dSLG;
            // 
            // v_DSNHOMTableAdapter
            // 
            this.v_DSNHOMTableAdapter.ClearBeforeFill = true;
            // 
            // FormTaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 377);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormTaoLogin";
            this.Text = "FormTaoLogin";
            this.Load += new System.EventHandler(this.FormTaoLogin_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSTKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhomQuyenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.ComboBox cbxNh;
        private System.Windows.Forms.ComboBox cbxMa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private DSLG dSLG;
        private System.Windows.Forms.BindingSource vDSTKBindingSource;
        private DSLGTableAdapters.V_DSTKTableAdapter v_DSTKTableAdapter;
        private System.Windows.Forms.BindingSource NhomQuyenBindingSource;
        private DSLGTableAdapters.V_DSNHOMTableAdapter v_DSNHOMTableAdapter;
    }
}