namespace OkulAppSube1BIL
{
    partial class frmOgrtBul
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOgrtBul = new System.Windows.Forms.Button();
            this.txtOgrtTc = new System.Windows.Forms.TextBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.txtOgrtTc);
            this.groupBox1.Controls.Add(this.btnOgrtBul);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Bul";
            // 
            // btnOgrtBul
            // 
            this.btnOgrtBul.Location = new System.Drawing.Point(141, 148);
            this.btnOgrtBul.Name = "btnOgrtBul";
            this.btnOgrtBul.Size = new System.Drawing.Size(75, 23);
            this.btnOgrtBul.TabIndex = 0;
            this.btnOgrtBul.Text = "Bul";
            this.btnOgrtBul.UseVisualStyleBackColor = true;
            this.btnOgrtBul.Click += new System.EventHandler(this.btnOgrtBul_Click);
            // 
            // txtOgrtTc
            // 
            this.txtOgrtTc.Location = new System.Drawing.Point(131, 90);
            this.txtOgrtTc.Name = "txtOgrtTc";
            this.txtOgrtTc.Size = new System.Drawing.Size(100, 20);
            this.txtOgrtTc.TabIndex = 1;
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(154, 55);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(20, 13);
            this.lblTc.TabIndex = 2;
            this.lblTc.Text = "Tc";
            // 
            // frmOgrtBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 213);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgrtBul";
            this.Text = "frmOgrtBul";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.TextBox txtOgrtTc;
        private System.Windows.Forms.Button btnOgrtBul;
    }
}