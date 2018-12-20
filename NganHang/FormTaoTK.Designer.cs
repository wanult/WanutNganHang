namespace NganHang
{
    partial class FormTaoTK
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
            this.label1 = new System.Windows.Forms.Label();
            this.stk = new System.Windows.Forms.Label();
            this.Sodu = new System.Windows.Forms.Label();
            this.MaCN = new System.Windows.Forms.Label();
            this.CMND = new System.Windows.Forms.TextBox();
            this.sotk = new System.Windows.Forms.TextBox();
            this.sdu = new System.Windows.Forms.TextBox();
            this.CN = new System.Windows.Forms.TextBox();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CMND";
            // 
            // stk
            // 
            this.stk.AutoSize = true;
            this.stk.Location = new System.Drawing.Point(54, 117);
            this.stk.Name = "stk";
            this.stk.Size = new System.Drawing.Size(37, 13);
            this.stk.TabIndex = 1;
            this.stk.Text = "Số TK";
            // 
            // Sodu
            // 
            this.Sodu.AutoSize = true;
            this.Sodu.Location = new System.Drawing.Point(54, 160);
            this.Sodu.Name = "Sodu";
            this.Sodu.Size = new System.Drawing.Size(35, 13);
            this.Sodu.TabIndex = 2;
            this.Sodu.Text = "Số dư";
            // 
            // MaCN
            // 
            this.MaCN.AutoSize = true;
            this.MaCN.Location = new System.Drawing.Point(54, 203);
            this.MaCN.Name = "MaCN";
            this.MaCN.Size = new System.Drawing.Size(40, 13);
            this.MaCN.TabIndex = 3;
            this.MaCN.Text = "Mã CN";
            // 
            // CMND
            // 
            this.CMND.Location = new System.Drawing.Point(122, 71);
            this.CMND.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(195, 20);
            this.CMND.TabIndex = 4;
            // 
            // sotk
            // 
            this.sotk.Location = new System.Drawing.Point(122, 114);
            this.sotk.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.sotk.Name = "sotk";
            this.sotk.Size = new System.Drawing.Size(195, 20);
            this.sotk.TabIndex = 5;
            // 
            // sdu
            // 
            this.sdu.Location = new System.Drawing.Point(122, 157);
            this.sdu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.sdu.Name = "sdu";
            this.sdu.Size = new System.Drawing.Size(195, 20);
            this.sdu.TabIndex = 6;
            // 
            // CN
            // 
            this.CN.Location = new System.Drawing.Point(122, 200);
            this.CN.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.CN.Name = "CN";
            this.CN.Size = new System.Drawing.Size(195, 20);
            this.CN.TabIndex = 7;
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTK.Location = new System.Drawing.Point(144, 235);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(75, 31);
            this.btnTaoTK.TabIndex = 8;
            this.btnTaoTK.Text = "Tạo";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tạo tài khoản";
            // 
            // FormTaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTaoTK);
            this.Controls.Add(this.CN);
            this.Controls.Add(this.sdu);
            this.Controls.Add(this.sotk);
            this.Controls.Add(this.CMND);
            this.Controls.Add(this.MaCN);
            this.Controls.Add(this.Sodu);
            this.Controls.Add(this.stk);
            this.Controls.Add(this.label1);
            this.Name = "FormTaoTK";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Text = "FormTaoTK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stk;
        private System.Windows.Forms.Label Sodu;
        private System.Windows.Forms.Label MaCN;
        private System.Windows.Forms.TextBox CMND;
        private System.Windows.Forms.TextBox sotk;
        private System.Windows.Forms.TextBox sdu;
        private System.Windows.Forms.TextBox CN;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.Label label2;
    }
}