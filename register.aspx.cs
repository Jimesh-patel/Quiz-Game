using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quizgame
{
    public partial class register : System.Web.UI.Page
    {
        model.dataconnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new model.dataconnection();
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btn_submit_click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConformPassword.Text)
            {
                lblError.Text = "Passwords do not match";
            }
            else
            {
                string query = $"INSERT INTO users (username, email, password, isAdmin) VALUES ('{txtUsername.Text}', '{txtEmail.Text}', '{txtPassword.Text}', 0)";
                int count = con.SetData(query);

                if (count > 0)
                {
                    lblError.Text = "User registration successful !!";
                    Response.Redirect("login.aspx");
                }
                else
                {
                    lblError.Text = "User registration faild!!";
                }
            }

        }
    }
}