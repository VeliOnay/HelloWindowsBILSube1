using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class Helper : IDisposable
    {
        SqlConnection cn;
        SqlCommand cmd;
        public void Dispose() 
        {
            if (cn!=null)
            {
                cn.Close();
                cn.Dispose();
                cn = null;
            }
            if (cmd!=null)
            {
                cmd.Dispose();
                cmd = null;
            }
        }
       
        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        private static Helper instance;
        
        public static Helper GetInstance
        {
            get
            {
                if (instance==null)
                {
                    instance = new Helper();
                }
                return instance;
            }
        }
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            try
            {
                using (cn = new SqlConnection(cstr))
                {
                    using (cmd = new SqlCommand(cmdtext, cn))
                    {
                        if (p != null)
                        {
                            cmd.Parameters.AddRange(p);
                        }
                        cn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p = null)
        {
            try
            {
                cn = new SqlConnection(cstr);
                cmd = new SqlCommand(cmdtext, cn);
                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }
                cn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {

                throw;
            }
            finally { Dispose(); }
        }

    }
}
