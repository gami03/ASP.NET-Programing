using ASP.NET_Programing.mgr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Programing
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				BindUser();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		protected void BindUser()
		{
			userMgr userManager = new userMgr();

			string query = "SELECT * FROM [user]";

			DataTable userData = userManager.GetUsers(query);

			GridView1.DataSource = userData;
			GridView1.DataBind();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
		{

		}
	}
}