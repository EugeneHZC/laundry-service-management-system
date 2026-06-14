using System.Data.SqlClient;

namespace Laundry_Service_Management
{
    public class Helper
    {
        public static decimal UserId { get; set; } = 1;
        public static string UserRole { get; set; } = "Customer";

        public static SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\UTeM\\Sem 4\\Event-Driven Programming\\Project\\Laundry Service Management\\Laundry Service Management\\LaundryServiceManagementDb.mdf\";Integrated Security=True");
    }
}
