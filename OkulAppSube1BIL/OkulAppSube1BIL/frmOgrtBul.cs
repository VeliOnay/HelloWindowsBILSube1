using OkulApp.BLL;
using OkulApp.MODEL;
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
    public partial class frmOgrtBul : Form
    {
        frmOgrtKayit frm;
        public frmOgrtBul(frmOgrtKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        public frmOgrtBul()
        {
            InitializeComponent();
        }

        private void btnOgrtBul_Click(object sender, EventArgs e)
        {
            try
            {
                OgretmenBL obl = new OgretmenBL();
                Ogretmen ogrt = obl.OgretmenBul(txtOgrtTc.Text.Trim());
                if (ogrt != null)
                {
                    frm.txtad1.Text = ogrt.Ad;
                    frm.txtsoyad1.Text = ogrt.Soyad;
                    frm.txttc.Text = ogrt.Tc;
                    this.Close();
                    frm.btnOgrtSil.Enabled = true;
                    frm.btnOgrtGuncelle.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Öğretmen bulunamadı!!");
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
