using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolProject1.Pages
{
    public partial class Stats : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(bool)Session["isAdmin"])
                Response.Redirect("Home.aspx");

            Session["activePage"] = "Statistics";

            TotalVisitorsCount.InnerText = Application["visitorsCount"].ToString();
            CurrentVisitorsCount.InnerText = (string)Application["currentVisitorsCount"].ToString();
            TotalGuestsCount.InnerText = (string)Application["guestsCount"].ToString();
            CurrentGuestsCount.InnerText = (string)Application["currentGuestsCount"].ToString();
            TotalLoggedInCount.InnerText = (string)Application["loggedInCount"].ToString();
            CurrentLoggedInCount.InnerText = (string)Application["currentLoggedInCount"].ToString();
        }
    }
}