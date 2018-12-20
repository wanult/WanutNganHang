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
            this.GD = new System.Windows.Forms.Button();
            this.TK = new System.Windows.Forms.Button();
            this.KH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GD
            // 
            this.GD.Location = new System.Drawing.Point(52, 25);
            this.GD.Name = "GD";
            this.GD.Size = new System.Drawing.Size(132, 37);
            this.GD.TabIndex = 0;
            this.GD.Text = "GIAO DỊCH";
            this.GD.UseVisualStyleBackColor = true;
            this.GD.Click += new System.EventHandler(this.GD_Click);
            // 
            // TK
            // 
            this.TK.Location = new System.Drawing.Point(217, 25);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(147, 37);
            this.TK.TabIndex = 1;
            this.TK.Text = "TÀI KHOẢN";
            this.TK.UseVisualStyleBackColor = true;
            this.TK.Click += new System.EventHandler(this.TK_Click);
            // 
            // KH
            // 
            this.KH.Location = new System.Drawing.Point(405, 25);
            this.KH.Name = "KH";
            this.KH.Size = new System.Drawing.Size(133, 37);
            this.KH.TabIndex = 2;
            this.KH.Text = "KHÁCH HÀNG";
            this.KH.UseVisualStyleBackColor = true;
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 327);
            this.Controls.Add(this.KH);
            this.Controls.Add(this.TK);
            this.Controls.Add(this.GD);
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GD;
        private System.Windows.Forms.Button TK;
        private System.Windows.Forms.Button KH;
    }
}