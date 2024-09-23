using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quizgame.quizgame
{
    public partial class users : System.Web.UI.Page
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