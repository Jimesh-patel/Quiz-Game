using System;
using System.Web;
using System.Web.UI;

namespace quizgame.quizgame
{
    public partial class user : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["UserInfo"] != null)
                {
                    string username = Request.Cookies["UserInfo"]["Email"];

                    if (!string.IsNullOrEmpty(username))
                    {
                        lblUsername.Text = "Welcome, " + username;
                        btnLogout.Visible = true;
                    }
                }
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["UserInfo"] != null)
            {
                HttpCookie userCookie = new HttpCookie("UserInfo");
                userCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(userCookie);

                Response.Redirect("login.aspx");
            }
        }
    }
}
