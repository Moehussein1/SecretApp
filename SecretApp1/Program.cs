namespace SecretAppla
{
    internal class Program
    {
        static string[] userNames = { "Pelle", "Stina", "Ali" };
        static string[] userPasswords = { "1234", "12345", "12346" };

        static void Main(string[] args)
        {
            Console.WriteLine("Hej");

            bool runRrogram = true;
            while (runRrogram)
            {
                Console.WriteLine("" +
                    "1. Logga in\r\n" +
                    "2. Lägg till användare\r\n" +
                    "3. Ändra lösenord\r\n" +
                    "4. Vissa användar Lista\r\n" +
                    "0. Avsluta\r\n");

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
                    else if (choice == 0)
                    {
                        runRrogram = false;
                    }
                }
                else
                {
                    Console.WriteLine("Välj i menyn");
                }
            }

            Console.WriteLine("Hej då");
            Thread.Sleep(3000);
        }

        static void AddUser()
        {
            Console.WriteLine("Hello from AddUser()");
        }

        static void ShowUsers()
        {
            int i = 0;
            while (i < userNames.Length)
            {
                Console.WriteLine(userNames[i].ToUpper());
                i++;
            }
        }

        static void LoggIn()
        {
            Console.WriteLine("Helo from LoggIn");
        }

        static void ChangePassword()
        {
            Console.WriteLine("Hello from ChangePassword()");
        }

        static void EndApplication()
        {
            Console.WriteLine("Hello from EndApplication()");
        }
    }
}
