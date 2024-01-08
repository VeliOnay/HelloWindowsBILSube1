using OkulApp.BLL;
using OkulApp.MODEL;
using OkulAppSube1BIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{ 
    public partial class FrmOgrBul : Form
    {
        frmOgrKayit frm;
        public FrmOgrBul(frmOgrKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            try
            {
                OgrenciBL obl = new OgrenciBL();
                Ogrenci ogr = obl.OgrenciBul(txtNumara.Text.Trim());
                if (ogr != null)
                {
                    frm.txtAd.Text = ogr.Ad;
                    frm.txtSoyad.Text = ogr.Soyad;
                    frm.txtNumara.Text = ogr.Numara;
                    frm.Ogrenciid = ogr.Ogrenciid;
                    this.Close();
                    frm.btnSil.Enabled = true;
                    frm.btnGuncelle.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı!!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

