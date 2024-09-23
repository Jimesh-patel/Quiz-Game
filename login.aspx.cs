using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace quizgame
{
    public partial class login : System.Web.UI.Page
    {
        model.dataconnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new model.dataconnection();
        }

        protected void btn_login_click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            //lblError.Text = email + " " + password;

            string query = $"SELECT * FROM users WHERE email = '{email}' AND password = '{password}'";

            DataTable dt = con.getData(query);

            if (dt.Rows.Count > 0)
            {
                string username = dt.Rows[0]["username"].ToString();

                HttpCookie userCookie = new HttpCookie("UserInfo");
                userCookie["Email"] = email;
                userCookie["Password"] = password;
                userCookie["Username"] = username;
                userCookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(userCookie);

                lblError.Text = "Login successful!";
                Response.Redirect("/quizgame/home.aspx");
            }
            else
            {
                lblError.Text = "Invalid email or password.";
            }
        }

        protected void btn_to_signup(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

    }
}