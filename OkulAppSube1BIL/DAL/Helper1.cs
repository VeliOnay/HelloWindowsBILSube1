using System;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class Helper1
    {
        SqlConnection cn1;
        SqlCommand cmd1;
        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] o = null)
        {
            using (cn1 = new SqlConnection(cstr))
            {
                using (cmd1 = new SqlCommand(cmdtext, cn1))
                {
                    if (o != null)
                    {
                        cmd1.Parameters.AddRange(o);
                    }
                    cn1.Open();
                    return cmd1.ExecuteNonQuery();
                }
            }
        }


    }
}
