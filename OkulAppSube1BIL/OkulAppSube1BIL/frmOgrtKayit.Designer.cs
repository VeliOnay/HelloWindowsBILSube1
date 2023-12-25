namespace OkulAppSube1BIL
{
    partial class frmOgrtKayit
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
            this.grpOgretmen = new System.Windows.Forms.GroupBox();
            this.lblad1 = new System.Windows.Forms.Label();
            this.lblsoyad1 = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.txtad1 = new System.Windows.Forms.TextBox();
            this.txtsoyad1 = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.btnkaydet1 = new System.Windows.Forms.Button();
            this.grpOgretmen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgretmen
            // 
            this.grpOgretmen.Controls.Add(this.txttc);
            this.grpOgretmen.Controls.Add(this.txtsoyad1);
            this.grpOgretmen.Controls.Add(this.txtad1);
            this.grpOgretmen.Controls.Add(this.lbltc);
            this.grpOgretmen.Controls.Add(this.lblsoyad1);
            this.grpOgretmen.Controls.Add(this.lblad1);
            this.grpOgretmen.Location = new System.Drawing.Point(12, 12);
            this.grpOgretmen.Name = "grpOgretmen";
            this.grpOgretmen.Size = new System.Drawing.Size(336, 204);
            this.grpOgretmen.TabIndex = 0;
            this.grpOgretmen.TabStop = false;
            this.grpOgretmen.Text = "Öğretmen Bilgileri";
            // 
            // lblad1
            // 
            this.lblad1.AutoSize = true;
            this.lblad1.Location = new System.Drawing.Point(75, 77);
            this.lblad1.Name = "lblad1";
            this.lblad1.Size = new System.Drawing.Size(20, 13);
            this.lblad1.TabIndex = 0;
            this.lblad1.Text = "Ad";
            
            // 
            // lblsoyad1
            // 
            this.lblsoyad1.AutoSize = true;
            this.lblsoyad1.Location = new System.Drawing.Point(75, 114);
            this.lblsoyad1.Name = "lblsoyad1";
            this.lblsoyad1.Size = new System.Drawing.Size(37, 13);
            this.lblsoyad1.TabIndex = 1;
            this.lblsoyad1.Text = "Soyad";
            
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(75, 153);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(20, 13);
            this.lbltc.TabIndex = 2;
            this.lbltc.Text = "Tc";
            // 
            // txtad1
            // 
            this.txtad1.Location = new System.Drawing.Point(127, 74);
            this.txtad1.Name = "txtad1";
            this.txtad1.Size = new System.Drawing.Size(100, 20);
            this.txtad1.TabIndex = 3;
            // 
            // txtsoyad1
            // 
            this.txtsoyad1.Location = new System.Drawing.Point(127, 111);
            this.txtsoyad1.Name = "txtsoyad1";
            this.txtsoyad1.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad1.TabIndex = 4;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(127, 150);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(100, 20);
            this.txttc.TabIndex = 5;
            // 
            // btnkaydet1
            // 
            this.btnkaydet1.Location = new System.Drawing.Point(139, 222);
            this.btnkaydet1.Name = "btnkaydet1";
            this.btnkaydet1.Size = new System.Drawing.Size(100, 28);
            this.btnkaydet1.TabIndex = 1;
            this.btnkaydet1.Text = "Kaydet";
            this.btnkaydet1.UseVisualStyleBackColor = true;
            this.btnkaydet1.Click += new System.EventHandler(this.btnkaydet1_Click);
            // 
            // frmOgrtKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 270);
            this.Controls.Add(this.btnkaydet1);
            this.Controls.Add(this.grpOgretmen);
            this.Name = "frmOgrtKayit";
            this.Text = "frmOgrtKayit";
            this.grpOgretmen.ResumeLayout(false);
            this.grpOgretmen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgretmen;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblsoyad1;
        private System.Windows.Forms.Label lblad1;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtsoyad1;
        private System.Windows.Forms.TextBox txtad1;
        private System.Windows.Forms.Button btnkaydet1;
    }
}