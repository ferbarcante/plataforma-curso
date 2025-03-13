using Microsoft.Data.SqlClient;

// Dapper
namespace BaltaDataAcess
{
    class Program 
    {

        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,5432;Database=balta;User ID=postgres;Password=123";

            using (var connection = new SqlConnection())
            {
                
            }
        }
    }
}