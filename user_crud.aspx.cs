using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace quizgame
{
    public partial class user_crud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\vadod\\OneDrive\\Desktop\\ASP.NET\\quizgame\\quizgame\\App_Data\\quiz_game_database.mdf;Integrated Security=True";

            //try
            //{
            //    using(con)
            //    {
            //        string command = "select * from users";
            //        SqlCommand cmd = new SqlCommand(command, con);
            //        con.Open();
            //        SqlDataReader reader = cmd.ExecuteReader();
            //        GridView1.DataSource = reader;
            //        GridView1.DataBind();
            //        reader.Close();

            //    }
            //} catch(Exception ex) {
           
            //    Response.Write(ex.Message);
            //}

        }
    }
}