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
        public bool ogretmenekle(Ogretmen ogrt)
        {
            SqlParameter[] o =
            {
                    new SqlParameter("@Ad",ogrt.Ad),
                    new SqlParameter("@Soyad", ogrt.Soyad),
                    new SqlParameter("@Tc", ogrt.Tc)
                };
            Helper1 hlp1 = new Helper1();
            return hlp1.ExecuteNonQuery("Insert into tblogretmen values(@Ad,@Soyad,@Tc)", o) > 0;
        }
    }
}
