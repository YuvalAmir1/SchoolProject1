using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolProject1.Pages
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["activePage"] = "Sign In";

            if (IsPostBack)
            {
                Dictionary<string, (string password, bool isAdmin)> Users = (Dictionary<string, (string password, bool isAdmin)>)Application["users"];
                if (Users.ContainsKey(Request.Form["userName"]) && Users[Request.Form["userName"]].password == Request.Form["password"])
                {
                    Session["signedIn"] = true;
                    Session["userName"] = Request.Form["userName"];
                    Session["isAdmin"] = Users[(string)Session["userName"]].isAdmin;
                    Application["loggedInCount"] = (int)Application["loggedInCount"] + 1;
                    Application["currentLoggedInCount"] = (int)Application["currentLoggedInCount"] + 1;
                    Application["guestsCount"] = (int)Application["guestsCount"] - 1;
                    Application["currentGuestsCount"] = (int)Application["currentGuestsCount"] - 1;
                    message.InnerHtml = "";
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    message.InnerHtml = "<p style='color:Red;'> User does not exist. </p>";
                    Session["signedIn"] = false;
                }
            }
        }
    }
}