using System.Security.Cryptography;
using System.Text;

namespace hash_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = "Hello World!";

            var soursebyte = Encoding.UTF8.GetBytes(input);


            var hashBytes = SHA256.Create().ComputeHash(soursebyte);
            // Console.WriteLine(hashBytes);

            var hash = BitConverter.ToString(hashBytes).Replace("-", "");
            Console.WriteLine("The MD5 hash of " + input + " is: " + hash);


            //06B611E628BEE9DB677D50FC350DAFEDDD54E3C5

            // F8DABC56C1BB77D82C77787AC2A7863E

        }
    }
}
