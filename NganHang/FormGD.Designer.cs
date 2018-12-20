namespace NganHang
{
    partial class FormGD
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
            this.lbstk = new System.Windows.Forms.Label();
            this.lbngayd = new System.Windows.Forms.Label();
            this.lbngayc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbstk
            // 
            this.lbstk.AutoSize = true;
            this.lbstk.Location = new System.Drawing.Point(44, 64);
            this.lbstk.Name = "lbstk";
            this.lbstk.Size = new System.Drawing.Size(36, 14);
            this.lbstk.TabIndex = 0;
            this.lbstk.Text = "Số TK";
            // 
            // lbngayd
            // 
            this.lbngayd.AutoSize = true;
            this.lbngayd.Location = new System.Drawing.Point(44, 113);
            this.lbngayd.Name = "lbngayd";
            this.lbngayd.Size = new System.Drawing.Size(47, 14);
            this.lbngayd.TabIndex = 1;
            this.lbngayd.Text = "Từ ngày";
            // 
            // lbngayc
            // 
            this.lbngayc.AutoSize = true;
            this.lbngayc.Location = new System.Drawing.Point(44, 152);
            this.lbngayc.Name = "lbngayc";
            this.lbngayc.Size = new System.Drawing.Size(54, 14);
            this.lbngayc.TabIndex = 2;
            this.lbngayc.Text = "Đến ngày";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(158, 145);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // FormGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbngayc);
            this.Controls.Add(this.lbngayd);
            this.Controls.Add(this.lbstk);
            this.Name = "FormGD";
            this.Text = "FormGD";
            this.Load += new System.EventHandler(this.FormGD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbstk;
        private System.Windows.Forms.Label lbngayd;
        private System.Windows.Forms.Label lbngayc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}