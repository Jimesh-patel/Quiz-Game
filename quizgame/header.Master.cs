using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quizgame.quizgame
{
    public partial class header : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetAllowResponseInBrowserHistory(false);

            if (Request.Cookies["UserInfo"] != null)
            {
                string username = Request.Cookies["UserInfo"]["Username"];
                lblUsername.Text = username;
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }
        }

        protected void GoToHomePage(object sender, EventArgs e)
        {
            Response.Redirect("~/home.aspx");
        }

        protected void GoToProfilePage(object sender, EventArgs e)
        {
            Response.Redirect("~/home.aspx");
        }

        protected void Logout(object sender, EventArgs e)
        {
            HttpCookie userCookie = new HttpCookie("UserInfo");
            userCookie.Expires = DateTime.Now.AddDays(-1); 
            Response.Cookies.Add(userCookie);
          
            Session.Clear();
            Response.Redirect("~/login.aspx");
        }
    }
}