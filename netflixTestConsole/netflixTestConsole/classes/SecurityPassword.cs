using System.Security.Cryptography;
using System.Text;

namespace NetflixServer.Classes
{
    public static class SecurityPassword
    {
        public static string Hash(string content)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(content);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                return BitConverter.ToString(hashBytes).Replace("-", String.Empty);
            }
        }
    }
}