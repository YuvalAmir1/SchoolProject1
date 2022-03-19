using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace SchoolProject1
{
    public partial class NavigationBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AddTab("Home", "Home.aspx", Home);
            AddTab("Sign In", "SignIn.aspx", SignIn);
            AddTab("User Page", "UserPage.aspx", UserPage);
            AddTab("Users", "Users.aspx", Users);
            AddTab("Statistics", "Stats.aspx", Stats);

            string isAdmin = (bool)Session["isAdmin"] ? "Admin" : "NotAdmin";
            if ((bool)Session["signedIn"]) UserName.InnerHtml = $"<a class='{isAdmin}' href='UserPage.aspx'> {Session["userName"]} </a>";
            else UserName.InnerHtml = $"<a class='{isAdmin}'> Guest </a>";

            if ((bool)Session["signedIn"])
            {
                SignIn.Visible = false;
                SignOut.Visible = true;
                UserPage.Visible = true;
            }
            else
            {
                SignIn.Visible = true;
                SignOut.Visible = false;
                UserPage.Visible = false;
            }

            if ((bool)Session["isAdmin"])
            {
                Users.Visible = true;
                Stats.Visible = true;
            }
            else
            {
                Users.Visible = false;
                Stats.Visible = false;
            }

            void AddTab(string pageName, string pageLink, HtmlContainerControl htmlContainer)
            {
                if ((string)Session["activePage"] == pageName) htmlContainer.InnerHtml = $"<a class='Active'> {pageName} </a>";
                else htmlContainer.InnerHtml = $"<a class='NotActive' href='{pageLink}'> {pageName} </a>";
            }
        }

        public void SignOutFunction(Object sender, EventArgs e)
        {
            Session["signedIn"] = false;
            Session["isAdmin"] = false;
            Application["currentLoggedInCount"] = (int)Application["currentLoggedInCount"] - 1;
            Application["guestsCount"] = (int)Application["guestsCount"] + 1;
            Application["currentGuestsCount"] = (int)Application["currentGuestsCount"] + 1;
            Response.Redirect("SignIn.aspx");
        }
    }
}