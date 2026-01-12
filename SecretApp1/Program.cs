using System.Net.Http.Json;

namespace SecretApp1
{
    internal class Program
    {

        string[] userNames = { "Pelle", "Stina", "Ali" };
        string[] userPasswords = { "1234", "abcd", "qwerty" };
        static void AddUser()
        {
            Console.WriteLine("Hello from AddUser");
        }

        static void ChangePassword()
        {
            Console.WriteLine("Hello from ChangePassword");
        }

        static void ShowUsers()
        {
            Console.WriteLine("Hello from ShowUsers");
        }

        static void EndApplication()
        {
            Console.WriteLine("Hello from EndApplication");
        }

    }
}
