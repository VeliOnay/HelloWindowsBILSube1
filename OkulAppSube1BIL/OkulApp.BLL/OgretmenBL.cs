using System;
using OkulApp.MODEL;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DAL;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        private Helper hlp;
        public OgretmenBL()
        {
            hlp=Helper.GetInstance;
        }
        public bool OgretmenEkle(Ogretmen ogrt)
        {
            try
            {
                SqlParameter[] p =
            {
                    new SqlParameter("@Ad",ogrt.Ad),
                    new SqlParameter("@Soyad", ogrt.Soyad),
                    new SqlParameter("@Tc", ogrt.Tc)
                };
                Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblOgretmen values(@Ad,@Soyad,@Tc)", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public bool OgretmenSil(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ogrtid", id) };
                Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Delete from tblOgretmen where Ogrtid=@Ogrtid", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public bool OgrtGuncelle(Ogretmen ogr)
        {
            try
            {
                SqlParameter[] p = {
                new SqlParameter("@Ad",ogr.Ad),
                new SqlParameter("@Soyad",ogr.Soyad),
                new SqlParameter("@TCKimlik",ogr.Tc),
                new SqlParameter("@Ogrtid",ogr.Ogrtid)};

                // Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Update TblOgretmenler set Ad=@Ad,Soyad=@Soyad,TCKimlik=@TCKimlik where Ogrtidd=@Ogrtid", p) > 0;
            }

            catch (Exception)
            {

                throw;
            }
        }
            public Ogretmen OgretmenBul(string tc)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Tc", tc) };
                Helper hlp = new Helper();
                var dr = hlp.ExecuteReader("Select Ogrtid,Ad,Soyad,Tc from tblOgretmen where Tc=@Tc", p);
                Ogretmen ogrt = null;
                if (dr.Read())
                {
                    ogrt = new Ogretmen();
                    ogrt.Ogrtid = Convert.ToInt32(dr["Ogrtid"]);
                    ogrt.Ad = dr["Ad"].ToString();
                    ogrt.Soyad = dr["Soyad"].ToString();
                    ogrt.Tc = dr["Tc"].ToString();
                }
                dr.Close();
                return ogrt;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
