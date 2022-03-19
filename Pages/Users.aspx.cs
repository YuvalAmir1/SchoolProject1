using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolProject1.Pages
{
    public partial class Users : System.Web.UI.Page
    {
		protected void Page_Load(object sender, EventArgs e)
		{
			Session["activePage"] = "Users";

			if (!(bool)Session["isAdmin"])
				Response.Redirect("Home.aspx");

			string tableData = "<table> <tr> <th> Username </th> <th> Password </th> <th> Admin? </th> </tr>";
			Dictionary<string, (string password, bool isAdmin)> Users = (Dictionary<string, (string password, bool isAdmin)>)Application["users"];

			foreach (KeyValuePair<string, (string password, bool isAdmin)> user in Users)
				tableData += $"<tr> <td> {user.Key} </td> <td> {user.Value.password} </td> <td> {(user.Value.isAdmin ? "Yes" : "No")} </td> </tr>";

			tableData += "</table";

			TableData.InnerHtml = tableData;
		}
	}
}