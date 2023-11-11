using System.Security.Cryptography;
using System.Text;

namespace KarimHash
{
    public class SHA2
    {
        static string HashIt(string text)
        {
            byte[] input = Encoding.Unicode.GetBytes(text);
            var service = new SHA256Managed();
            byte[] output = service.ComputeHash(input);
            return Convert.ToBase64String(output);
        }
    }
}