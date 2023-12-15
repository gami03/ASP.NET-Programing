using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP.NET_Programing.mgr
{
	public class userMgr
	{
		private string connectionString;

		public userMgr()
		{
			// 생성자에서 연결 문자열 초기화
			connectionString = ConfigurationManager.ConnectionStrings["webboardConnectionString"].ConnectionString;
		}

		/// <summary>
		/// ㅅㅅㅅ
		/// </summary>
		/// <param name="query">조회할 쿼리</param>
		/// <returns></returns>
		public DataTable GetUsers(string query)
		{
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
				{
					adapter.Fill(table);
				}
			}

			return table;
		}

		/// <summary>
		/// test method
		/// </summary>
		/// <param name="a">test param1</param>
		/// <param name="b">test param2</param>
		/// <returns></returns>
		public DataTable GetUsers(string a, string b)
		{
			return GetUsers(a + b);
		}

		public DataTable GetUsers()
		{
			DataTable table = new DataTable();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT * FROM [user]";

				using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
				{
					adapter.Fill(table);
				}
			}

			return table;
		}
	}
}