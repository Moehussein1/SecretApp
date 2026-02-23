namespace SecretApp1
{
    internal class Program
    {
        static string[] userNamesList = { "Pelle", "Stina", "Ali" };
        static string[] userPasswordsList = { "1234", "12345", "123456" };
        static bool userLoggedIn = false;
        static string loggedInUser = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till secret app");

            Menu();
            bool runProgram = true;

            while (runProgram)
            {
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 1) LoggIn();
                    else if (choice == 2) AddUser();
                    else if (choice == 3) ChangePassword();
                    else if (choice == 4) ShowUsers();
                    else if (choice == 5) DeleteUser();
                    else if (choice == 6) LogOut();
                    else if (choice == 9) Menu();
                    else if (choice == 0) runProgram = false;
                }
                else
                {
                    Console.WriteLine("Välj i menyn");
                }
            }

            Console.WriteLine("Hej då");
            Thread.Sleep(1000);
        }

        static void LoggIn()
        {
            Console.Write("Namn: ");
            string name = Console.ReadLine();
            Console.Write("Lösenord: ");
            string password = Console.ReadLine();

            int i = 0;
            while (i < userNamesList.Length)
            {
                if (userNamesList[i] == name && userPasswordsList[i] == password)
                {
                    userLoggedIn = true;
                    loggedInUser = name;
                    Console.WriteLine("Välkommen " + name);
                    return;
                }
                i++;
            }

            Console.WriteLine("Fel namn eller lösenord");
        }

        static void AddUser()
        {
            if (!userLoggedIn)
            {
                Console.WriteLine("Du måste vara inloggad.");
                return;
            }

            Console.Write("Namn: ");
            string name = Console.ReadLine();
            Console.Write("Lösenord: ");
            string password = Console.ReadLine();

            string[] tempNames = new string[userNamesList.Length + 1];
            string[] tempPasswords = new string[userPasswordsList.Length + 1];

            int i = 0;
            while (i < userNamesList.Length)
            {
                tempNames[i] = userNamesList[i];
                tempPasswords[i] = userPasswordsList[i];
                i++;
            }

            tempNames[tempNames.Length - 1] = name;
            tempPasswords[tempPasswords.Length - 1] = password;

            userNamesList = tempNames;
            userPasswordsList = tempPasswords;

            Console.WriteLine("Användare tillagd!");
        }

        static void ChangePassword()
        {
            if (!userLoggedIn)
            {
                Console.WriteLine("Du måste vara inloggad.");
                return;
            }

            Console.Write("Nytt lösenord: ");
            string newPassword = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                Console.WriteLine("Lösenord får inte vara tomt.");
                return;
            }

            int index = Array.IndexOf(userNamesList, loggedInUser);
            userPasswordsList[index] = newPassword;

            Console.WriteLine("Lösenord ändrat.");
        }

        static void DeleteUser()
        {
            if (!userLoggedIn)
            {
                Console.WriteLine("Du måste vara inloggad.");
                return;
            }

            Console.Write("Användare att ta bort: ");
            string name = Console.ReadLine();

            int hit = Array.IndexOf(userNamesList, name);

            if (hit == -1)
            {
                Console.WriteLine("Användaren finns inte");
                return;
            }

            string[] tempNames = new string[userNamesList.Length - 1];
            string[] tempPasswords = new string[userPasswordsList.Length - 1];

            int i = 0;
            int j = 0;

            while (i < userNamesList.Length)
            {
                if (i != hit)
                {
                    tempNames[j] = userNamesList[i];
                    tempPasswords[j] = userPasswordsList[i];
                    j++;
                }
                i++;
            }

            userNamesList = tempNames;
            userPasswordsList = tempPasswords;

            Console.WriteLine("Användaren är borttagen");

            if (name == loggedInUser)
            {
                LogOut();
            }
        }

        static void ShowUsers()
        {
            int i = 0;

            if (userLoggedIn)
            {
                while (i < userNamesList.Length)
                {
                    Console.WriteLine(userNamesList[i] + " - " + userPasswordsList[i]);
                    i++;
                }
            }
            else
            {
                while (i < userNamesList.Length)
                {
                    Console.WriteLine(userNamesList[i]);
                    i++;
                }
            }
        }

        static void LogOut()
        {
            if (userLoggedIn)
            {
                Console.WriteLine("Du loggas ut.");
                userLoggedIn = false;
                loggedInUser = "";
            }
            else
            {
                Console.WriteLine("Ingen är inloggad.");
            }
        }

        static void Menu()
        {
            Console.WriteLine(
                "\n1. Logga in\n" +
                "2. Lägg till användare\n" +
                "3. Ändra lösenord\n" +
                "4. Visa användarlista\n" +
                "5. Ta bort användare\n" +
                "6. Logga ut\n" +
                "9. Visa meny\n" +
                "0. Avsluta\n");
        }
    }
}