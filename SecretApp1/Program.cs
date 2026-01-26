using System.Net.Http.Json;

namespace SecretApp1
{
    internal class Program
    {
        static string[] userNames = { "Pelle", "Stina", "Ali" };
        static string[] userPasswords = { "1234", "12345", "123456" };


        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till secret app");
            Menu();
            bool runRrogram = true;
            while (runRrogram)

            {
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 1)
                    {
                        LoggIn();
                    }
                    else if (choice == 2)
                    {
                        AddUser();
                    }
                    else if (choice == 3)
                    {
                        ChangePassword();
                    }
                    else if (choice == 4)
                    {
                        ShowUsers();
                    }
                    else if (choice == 9)
                    {
                        Menu();
                    }

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
            Console.WriteLine("Hello from EndApplication()");
        }

    }
}