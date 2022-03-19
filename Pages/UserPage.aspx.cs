using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolProject1.Pages
{
    public partial class UserPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(bool)Session["signedIn"])
                Response.Redirect("Home.aspx");

            Session["activePage"] = "User Page";

            Dictionary<string, (string password, bool isAdmin)> Users = (Dictionary<string, (string password, bool isAdmin)>)Application["users"];

            Username.InnerText = (string)Session["username"];
            Password.InnerText = Users[(string)Session["username"]].password;
            IsAdmin.InnerText = Users[(string)Session["username"]].isAdmin ? "Yes" : "No";
        }
    }
}