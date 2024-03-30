using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace WebApplication2.Models
{
    public class userTBL
    {
        public static string conString = "Server=tcp:clvd-sql-server.database.windows.net,1433;Initial Catalog=clvd-db;Persist Security Info=False;User ID=Jose;Password=2004Fr@ney;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public static SqlConnection con = new SqlConnection(conString);

        public string Name { get; set; }
        public string Surname { get; set; }   
        public string Email { get; set; }  
        
 
        public int insert_User(userTBL u)
        {
            try
            {
                string sql = "INSERT INTO userTBL (name, surname, email) VALUES(@Name, @Surname, @Email)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", u.Name);
                cmd.Parameters.AddWithValue("@Surname", u.Surname);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected;

            }catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
