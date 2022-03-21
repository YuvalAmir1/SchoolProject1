using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace SchoolProject1.Pages
{
    public class Global : System.Web.HttpApplication
    {
		protected void Application_Start(object sender, EventArgs e)
		{
			Dictionary<string, (string password, bool isAdmin)> Users = new Dictionary<string, (string password, bool isAdmin)>();
			Users.Add("Yuval", ("StrongPassword123", true));
			Users.Add("Gamer", ("42069", true));
			Users.Add("Bob", ("123456", false));
			Users.Add("Bobby", ("102030405060", false));
			Users.Add("Hami", ("BadPassword321", false));
			Application["users"] = Users;

			Application["visitorsCount"] = 0;
			Application["loggedInCount"] = 0;
			Application["guestsCount"] = 0;
			Application["currentVisitorsCount"] = 0;
			Application["currentLoggedInCount"] = 0;
			Application["currentGuestsCount"] = 0;
		}

		protected void Session_Start(object sender, EventArgs e)
		{
			Session["isAdmin"] = false;
			Session["signedIn"] = false;
			Session["userName"] = null;
			Application["visitorsCount"] = (int)Application["visitorsCount"] + 1;
			Application["guestsCount"] = (int)Application["guestsCount"] + 1;
			Application["currentVisitorsCount"] = (int)Application["currentVisitorsCount"] + 1;
			Application["currentGuestsCount"] = (int)Application["currentGuestsCount"] + 1;
		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{

		}

		protected void Application_Error(object sender, EventArgs e)
		{

		}

		protected void Session_End(object sender, EventArgs e)
		{
			if ((bool)Session["signedIn"]) Application["currentLoggedInCount"] = (int)Application["currentLoggedInCount"] - 1;
			else Application["currentGuestsCount"] = (int)Application["currentGuestsCount"] - 1;
			Application["currentVisitorsCount"] = (int)Application["currentVisitorsCount"] - 1;
		}

		protected void Application_End(object sender, EventArgs e)
		{
			Session.Clear();
			Session.Abandon();
		}
	}
}