using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_Programing.DataContext
{
	// 현재 프로젝트에서 db 연결되어 있는거와는 전혀 상관없음.. 해보려다가 못한것.
	// 현재 프로젝트는 Web.config 에서 연결되어 있음.
	public class AspNetCoreMVCStudyDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-L2B8S4V;Database=asp.net programing;Trusted_Connection=True;");
		}
	}
}