using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using quizgame.model;

namespace quizgame.quizgame
{
    public partial class home : System.Web.UI.Page
    {
        model.dataconnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new model.dataconnection();
            string query = "SELECT * FROM Levels";
            DataTable dt = con.getData(query);
            RepeaterLevels.DataSource = dt;
            RepeaterLevels.DataBind();
        }
    }
}