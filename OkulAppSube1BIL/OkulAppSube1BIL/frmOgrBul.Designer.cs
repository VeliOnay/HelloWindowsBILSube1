namespace OkulAppSube1BIL
{
    partial class FrmOgrBul
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
            this.ogrgrp = new System.Windows.Forms.GroupBox();
            this.lblnumara = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnBul = new System.Windows.Forms.Button();
            this.ogrgrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogrgrp
            // 
            this.ogrgrp.Controls.Add(this.lblnumara);
            this.ogrgrp.Controls.Add(this.txtNumara);
            this.ogrgrp.Location = new System.Drawing.Point(68, 50);
            this.ogrgrp.Name = "ogrgrp";
            this.ogrgrp.Size = new System.Drawing.Size(200, 100);
            this.ogrgrp.TabIndex = 0;
            this.ogrgrp.TabStop = false;
            this.ogrgrp.Text = "Öğrenci bul";
            // 
            // lblnumara
            // 
            this.lblnumara.AutoSize = true;
            this.lblnumara.Location = new System.Drawing.Point(80, 27);
            this.lblnumara.Name = "lblnumara";
            this.lblnumara.Size = new System.Drawing.Size(44, 13);
            this.lblnumara.TabIndex = 1;
            this.lblnumara.Text = "Numara";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(50, 52);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(129, 156);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // FrmOgrBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 239);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.ogrgrp);
            this.Name = "FrmOgrBul";
            this.Text = "frmOgrBul";
            this.ogrgrp.ResumeLayout(false);
            this.ogrgrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ogrgrp;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblnumara;
        private System.Windows.Forms.Button btnBul;
    }
}