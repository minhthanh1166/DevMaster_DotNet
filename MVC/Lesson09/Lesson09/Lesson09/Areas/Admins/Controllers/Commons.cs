using System.Text;
using System.Security.Cryptography;

namespace Lesson09.Areas.Admins.Controllers
{
    public class Commons
    {
        public static string GetSHA256Hash(string password)
        {
            // Create a SHA256 
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array 
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string 
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
