using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace quizgame.model
{
    public class dataconnection
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;

        public dataconnection()
        {
            Con = new SqlConnection();
            Con.ConnectionString = WebConfigurationManager.ConnectionStrings["conDB"].ConnectionString;
            cmd = new SqlCommand();
            cmd.Connection = Con;
        }

        public DataTable getData(String Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, Con); 
            sda.Fill(dt);
            return dt;
        }

        public int SetData(String Query)
        {
            try
            {
                int count;
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                cmd.CommandText = Query;
                count = cmd.ExecuteNonQuery();
                Con.Close();
                return count;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return -1;
            }
        }
    }
}
