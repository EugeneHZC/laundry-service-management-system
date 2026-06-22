using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Laundry_Service_Management
{
    public class Helper
    {
        public static decimal UserId { get; set; }
        public static string UserRole { get; set; }

        public static SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\USER\\Desktop\\laundry_service_management_system\\laundry-service-management-system\\Laundry Service Management\\LaundryServiceManagementDb.mdf\";Integrated Security=True");

        public static string hash(string text)
        {
            SHA256 sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
            return string.Concat(bytes.Select(x => x.ToString("x2")));
        }
    }
}
