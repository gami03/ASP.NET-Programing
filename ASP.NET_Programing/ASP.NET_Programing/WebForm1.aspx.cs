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

		protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
		{
			if (e.CommandName == "Add")
			{
				// 새로운 빈 행을 추가하기 위해 데이터를 가져옴
				DataTable dt = GetDummyData(); // 이 함수는 빈 행을 포함한 DataTable을 반환하는 가정입니다.

				// GridView의 데이터 소스에 새로운 행을 추가
				GridView1.DataSource = dt;
				GridView1.DataBind();

				// GridView를 편집 모드로 설정
				GridView1.EditIndex = 0;
			}
		}

		// 빈 행을 포함한 더미 데이터를 반환하는 함수
		private DataTable GetDummyData()
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("userNo", typeof(int));
			dt.Columns.Add("userName", typeof(string));
			dt.Columns.Add("userAge", typeof(int));

			// 새로운 빈 행을 추가
			DataRow newRow = dt.NewRow();
			dt.Rows.Add(newRow);

			return dt;
		}


		/// <summary>
		/// GridView의 RowDeleting 이벤트 핸들러
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
		{
			// 삭제하려는 행의 인덱스를 가져옴
			int rowIndex = e.RowIndex;

			// GridView의 DataKeys 컬렉션을 사용하여 userNo와 userName 값을 가져옴
			int userNo = Convert.ToInt32(GridView1.DataKeys[rowIndex].Values["userNo"]);
			string userName = GridView1.DataKeys[rowIndex].Values["userName"].ToString();

			userMgr userManager = new userMgr();

			userManager.DeleteUser(userNo, userName);

			BindUser();
		}

		/// <summary>
		/// gridView의 RowEditing 이벤트 핸들러
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
		{
			GridView1.EditIndex = e.NewEditIndex;

			BindUser();

			GridViewRow row = GridView1.Rows[e.NewEditIndex];

			TextBox txtUserName = (TextBox)row.FindControl("txtUserName");
			TextBox txtUserAge = (TextBox)row.FindControl("txtUserAge");

			if (txtUserName != null && txtUserAge != null)
			{
				txtUserName.Enabled = true;
				txtUserAge.Enabled = true;
			}
		}

		/// <summary>
		/// GridView의 RowCancelingEdit 이벤트 핸들러
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
		{
			GridView1.EditIndex = -1;
			BindUser();
		}

		/// <summary>
		/// GridView의 RowUpdating 이벤트 핸들러
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
		{
			int rowIndex = e.RowIndex;

			int userNo = Convert.ToInt32(GridView1.DataKeys[rowIndex].Values["userNo"]);

			TextBox txtUserName = (TextBox)GridView1.Rows[rowIndex].FindControl("txtUserName");
			TextBox txtUserAge = (TextBox)GridView1.Rows[rowIndex].FindControl("txtUserAge");

			string newUserName = txtUserName.Text;
			int newUserAge = Convert.ToInt32(txtUserAge.Text);

			userMgr userManager = new userMgr();

			userManager.UpdateUser(userNo, newUserName, newUserAge);

			// GridView를 일반 모드로 전환하고 데이터를 다시 바인딩
			GridView1.EditIndex = -1;
			BindUser();
		}

		/// <summary>
		/// user 정보를 불러와 GridView에 바인딩
		/// </summary>
		protected void BindUser()
		{
			userMgr userManager = new userMgr();

			Console.WriteLine("BindUser");

			string whereQuery = "";

			DataTable userData = userManager.GetUsers(whereQuery);

			GridView1.DataSource = userData;
			GridView1.DataBind();
		}
	}
}