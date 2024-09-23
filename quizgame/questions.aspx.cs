using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quizgame.quizgame
{
    public partial class questions : System.Web.UI.Page
    {
        model.dataconnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            string levelId = Request.QueryString["levelId"];
            if (levelId == null)
            {
                Response.Redirect("home.aspx");
            }
            con = new model.dataconnection();
            string query = $"SELECT * FROM Questions WHERE LevelId = {levelId}";
            DataTable dt = con.getData(query);
            RepeaterQuestions.DataSource = dt;
            RepeaterQuestions.DataBind();
        }
    }
}