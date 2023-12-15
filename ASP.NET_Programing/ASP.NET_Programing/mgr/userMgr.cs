using ASP.NET_Programing.DacAdvance;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ASP.NET_Programing.mgr
{
	public class userMgr
	{
		private readonly userDacAdvance userDadvance;

		public userMgr()
		{
			// DaAdvance 인스턴스를 생성
			userDadvance = new userDacAdvance();
		}

		/// <summary>
		/// user table의 전체값을 where 절을 받아서 조회하여 반환 
		/// </summary>
		/// <param name="whereQuery">select user 의 where절</param>
		/// <returns></returns>
		public DataTable GetUsers(string whereQuery)
		{
			string query = "SELECT * FROM [user]";

			System.Diagnostics.Debug.WriteLine("출력할 문자열");

			if (!string.IsNullOrEmpty(whereQuery))
			{
				query += " where " + whereQuery;
			}

			System.Diagnostics.Debug.WriteLine("query" + query);

			// DaAdvance를 사용하여 쿼리 실행
			return userDadvance.ReadQuery(query);
		}

		///// <summary>
		///// test method
		///// </summary>
		///// <param name="a">test param1</param>
		///// <param name="b">test param2</param>
		///// <returns></returns>
		//public DataTable GetUsers(string a, string b)
		//{
		//	return GetUsers(a + b);
		//}

		//public DataTable GetUsers()
		//{
		//	DataTable table = new DataTable();

		//	using (SqlConnection connection = new SqlConnection(connectionString))
		//	{
		//		connection.Open();

		//		string query = "SELECT * FROM [user]";

		//		using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
		//		{
		//			adapter.Fill(table);
		//		}
		//	}

		//	return table;
		//}
	}
}