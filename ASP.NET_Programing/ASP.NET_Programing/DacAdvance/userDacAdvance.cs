using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP.NET_Programing.DacAdvance
{
	public class userDacAdvance
	{
		private string connectionString;

		public userDacAdvance()
		{
			// 생성자에서 연결 문자열 초기화
			connectionString = ConfigurationManager.ConnectionStrings["webboardConnectionString"].ConnectionString;
		}

		/// <summary>
		/// 쿼리를 입력하면 해당 쿼리를 실행하여 결과를 반환
		/// </summary>
		/// <param name="query">조회할 쿼리</param>
		/// <returns></returns>
		public DataTable ReadQuery(string query)
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
	}
}