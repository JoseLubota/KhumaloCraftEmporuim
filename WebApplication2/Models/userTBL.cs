using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace WebApplication2.Models
{
    public class userTBL : Controller
    {
        public static string conString = "Server=tcp:clvd-sql-server5.database.windows.net,1433;Initial Catalog=clvd-db;Persist Security Info=False;User ID=Jose;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public static SqlConnection con = new SqlConnection(conString);

        public IActionResult Index()
        {
            return View();
        }
    }
}
