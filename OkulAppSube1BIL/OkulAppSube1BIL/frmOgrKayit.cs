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
using OkulApp.BLL;

namespace OkulAppSube1BIL
{
    public partial class frmOgrKayit : Form
    {
        public int Ogrenciid { get; set; }
        public frmOgrKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            {
                var obl = new OgrenciBL();
                try
                {
                    bool sonuc = obl.OgrenciEkle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim() });
                    MessageBox.Show(sonuc ? "Ekleme Başarılı" : "Ekleme Başarısız");

                    txtAd.Clear();
                    txtSoyad.Clear();
                    txtNumara.Clear();

                }

                catch (SqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 2627:
                            MessageBox.Show("Bu Numara daha önce kaydedilmiş!! ");
                            break;
                        default:
                            MessageBox.Show("Veritabanı Hatası!");
                            break;
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Bir Hata Oluştu!");
                }
            }

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                MessageBox.Show(obl.OgrenciEkle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim(), Ogrenciid = Ogrenciid }) ? "Güncelleme Başarılı" : "Güncelleme Başarısız!");
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

        private void btnBul_Click(object sender, EventArgs e)
        {
          try
            {
                var frm = new FrmOgrBul(this);
                frm.Show();
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                MessageBox.Show(obl.OgrenciGuncelle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim(), Ogrenciid = Ogrenciid }) ? "Güncelleme Başarılı" : "Güncelleme Başarısız!");
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


    


//Garbage Collector
