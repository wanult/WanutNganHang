namespace NganHang
{
    partial class UserControlGD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btGD = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbngayc = new System.Windows.Forms.Label();
            this.lbngayd = new System.Windows.Forms.Label();
            this.lbstk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btGD
            // 
            this.btGD.Location = new System.Drawing.Point(173, 215);
            this.btGD.Name = "btGD";
            this.btGD.Size = new System.Drawing.Size(75, 23);
            this.btGD.TabIndex = 13;
            this.btGD.Text = "OK";
            this.btGD.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(173, 145);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lbngayc
            // 
            this.lbngayc.AutoSize = true;
            this.lbngayc.Location = new System.Drawing.Point(59, 152);
            this.lbngayc.Name = "lbngayc";
            this.lbngayc.Size = new System.Drawing.Size(54, 14);
            this.lbngayc.TabIndex = 9;
            this.lbngayc.Text = "Đến ngày";
            // 
            // lbngayd
            // 
            this.lbngayd.AutoSize = true;
            this.lbngayd.Location = new System.Drawing.Point(59, 113);
            this.lbngayd.Name = "lbngayd";
            this.lbngayd.Size = new System.Drawing.Size(47, 14);
            this.lbngayd.TabIndex = 8;
            this.lbngayd.Text = "Từ ngày";
            // 
            // lbstk
            // 
            this.lbstk.AutoSize = true;
            this.lbstk.Location = new System.Drawing.Point(59, 64);
            this.lbstk.Name = "lbstk";
            this.lbstk.Size = new System.Drawing.Size(36, 14);
            this.lbstk.TabIndex = 7;
            this.lbstk.Text = "Số TK";
            // 
            // UserControlGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btGD);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbngayc);
            this.Controls.Add(this.lbngayd);
            this.Controls.Add(this.lbstk);
            this.Name = "UserControlGD";
            this.Size = new System.Drawing.Size(453, 304);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGD;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbngayc;
        private System.Windows.Forms.Label lbngayd;
        private System.Windows.Forms.Label lbstk;
    }
}
