namespace NganHang
{
    partial class FormTKTK
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
            this.bt1cn = new System.Windows.Forms.Button();
            this.btcacn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt1cn
            // 
            this.bt1cn.Location = new System.Drawing.Point(49, 27);
            this.bt1cn.Name = "bt1cn";
            this.bt1cn.Size = new System.Drawing.Size(124, 41);
            this.bt1cn.TabIndex = 0;
            this.bt1cn.Text = "Trên 1 Chi Nhánh";
            this.bt1cn.UseVisualStyleBackColor = true;
            // 
            // btcacn
            // 
            this.btcacn.Location = new System.Drawing.Point(205, 26);
            this.btcacn.Name = "btcacn";
            this.btcacn.Size = new System.Drawing.Size(125, 42);
            this.btcacn.TabIndex = 1;
            this.btcacn.Text = "Trên các Chi Nhánh";
            this.btcacn.UseVisualStyleBackColor = true;
            // 
            // FormTKTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 341);
            this.Controls.Add(this.btcacn);
            this.Controls.Add(this.bt1cn);
            this.Name = "FormTKTK";
            this.Text = "FormTKTK";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt1cn;
        private System.Windows.Forms.Button btcacn;
    }
}