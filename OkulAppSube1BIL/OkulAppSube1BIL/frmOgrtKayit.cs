using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulApp.BLL;
using System.Data.SqlClient;

namespace OkulAppSube1BIL
{
    public partial class frmOgrtKayit : Form
    {
        public frmOgrtKayit()
        {
            InitializeComponent();
        }

        

        private void btnkaydet1_Click(object sender, EventArgs e)
        {
            try
            {
                var ogbl = new OgretmenBL();
                bool sonuc1=ogbl.ogretmenekle(new Ogretmen { Ad = txtad1.Text.Trim(),Soyad=txtsoyad1.Text.Trim(),Tc=txttc.Text.Trim() });
                MessageBox.Show(sonuc1 ? "Ekleme başarılı" : "Ekleme başarısız");
            }
            catch (SqlException ex1)
            {
                switch (ex1.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numaralı öğrenci daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı hatası");
                        MessageBox.Show(ex1.ToString());
                        break;
                }
                throw;
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }
        }
    }
}
