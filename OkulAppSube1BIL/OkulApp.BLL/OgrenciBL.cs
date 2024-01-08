using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using DAL;

namespace OkulApp.BLL
{
    public class OgrenciBL
    {
        public bool OgrenciEkle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = {
                             new SqlParameter("@Ad",ogr.Ad),
                             new SqlParameter("@Soyad",ogr.Soyad),
                             new SqlParameter("@Numara",ogr.Numara)
                         };

                Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblOgrenciler values(@Ad,@Soyad,@Numara)", p) > 0;

            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public bool OgrenciSil(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ogrenciid", id) };
                Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Delete from tblOgrenciler where OgrenciId=@OgrenciId", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public bool OgrenciGuncelle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = 
                    { 
            new SqlParameter("@Ad",ogr.Ad),
            new SqlParameter("@Soyad",ogr.Soyad),
            new SqlParameter("@Numara",ogr.Numara),
            new SqlParameter("@Ogrenciid",ogr.Ogrenciid)};

                Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Update tblOgrenciler set Ad=@Ad,Soyad=@Soyad,Numara=@Numara where Ogrenciid=@Ogrenciid", p) > 0;
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
        public Ogrenci OgrenciBul(string numara)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Numara", numara) };
                Helper hlp = new Helper();
                var dr = hlp.ExecuteReader("Select OgrenciId,Ad,Soyad,Numara from tbl Ogrenciler where Numara=@Numara", p);
                Ogrenci ogr = null;
                if (dr.Read())
                {
                    ogr = new Ogrenci();
                    ogr.Ogrenciid = Convert.ToInt32(dr["Ogrenciid"]);
                    ogr.Ad = dr["Ad"].ToString();
                    ogr.Soyad = dr["Soyad"].ToString();
                    ogr.Numara = dr["Numara"].ToString();
                }
                dr.Close();
                return ogr;
            }
            catch (Exception)
            {

                throw;
            } 

        }
    }
}
//n Katmanlı Mimari