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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "CMND";
            // 
            // stk
            // 
            this.stk.AutoSize = true;
            this.stk.Location = new System.Drawing.Point(46, 75);
            this.stk.Name = "stk";
            this.stk.Size = new System.Drawing.Size(36, 14);
            this.stk.TabIndex = 1;
            this.stk.Text = "Số TK";
            // 
            // Sodu
            // 
            this.Sodu.AutoSize = true;
            this.Sodu.Location = new System.Drawing.Point(46, 124);
            this.Sodu.Name = "Sodu";
            this.Sodu.Size = new System.Drawing.Size(36, 14);
            this.Sodu.TabIndex = 2;
            this.Sodu.Text = "Số dư";
            // 
            // MaCN
            // 
            this.MaCN.AutoSize = true;
            this.MaCN.Location = new System.Drawing.Point(46, 185);
            this.MaCN.Name = "MaCN";
            this.MaCN.Size = new System.Drawing.Size(38, 14);
            this.MaCN.TabIndex = 3;
            this.MaCN.Text = "Mã CN";
            // 
            // CMND
            // 
            this.CMND.Location = new System.Drawing.Point(125, 13);
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(100, 20);
            this.CMND.TabIndex = 4;
            // 
            // sotk
            // 
            this.sotk.Location = new System.Drawing.Point(125, 75);
            this.sotk.Name = "sotk";
            this.sotk.Size = new System.Drawing.Size(100, 20);
            this.sotk.TabIndex = 5;
            // 
            // sdu
            // 
            this.sdu.Location = new System.Drawing.Point(125, 124);
            this.sdu.Name = "sdu";
            this.sdu.Size = new System.Drawing.Size(100, 20);
            this.sdu.TabIndex = 6;
            // 
            // CN
            // 
            this.CN.Location = new System.Drawing.Point(125, 178);
            this.CN.Name = "CN";
            this.CN.Size = new System.Drawing.Size(100, 20);
            this.CN.TabIndex = 7;
            // 
            // FormTaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CN);
            this.Controls.Add(this.sdu);
            this.Controls.Add(this.sotk);
            this.Controls.Add(this.CMND);
            this.Controls.Add(this.MaCN);
            this.Controls.Add(this.Sodu);
            this.Controls.Add(this.stk);
            this.Controls.Add(this.label1);
            this.Name = "FormTaoTK";
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
    }
}