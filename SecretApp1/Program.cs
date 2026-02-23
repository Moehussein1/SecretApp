using System.ComponentModel.Design;

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
                    else if (choice == 5)
                    {
                        DeleteUser();
                    }
                    else if (choice == 9)
                    {
                        Menu();
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
            Thread.Sleep(1000);
        }

        static void AddUser()
        {
            if (!userLoggedIn)
            {
                Console.WriteLine("Du måste vara inloggad för att lägga till användare.");
                return;
            }
            Console.WriteLine(" här kan du lägga till användare)");
            Console.Write("Namn: ");
            String name = Console.ReadLine();
            Console.Write($"Lösenord:  ");
            String password = Console.ReadLine();

            String[] tempNames = new string[userNamesList.Length + 1];
            String[] tempPasswords = new string[userPasswordsList.Length + 1];
           
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

            
           i = 0;
            while (i < userNamesList.Length) 
            {
                tempNames[i] = userNamesList[i];
                i++;
            }

            tempNames[tempNames.Length - 1] = name;

            userNamesList = tempNames;

            int J = 0;
            while (J < userPasswordsList.Length)
            {
                tempPasswords[J] = userPasswordsList[J];
                J++;
            }

            tempPasswords[tempPasswords.Length - 1] = password;

            userPasswordsList = tempPasswords;

            foreach (var item in userNamesList)
            {
                Console.WriteLine(item);
            }

            foreach (var item in userPasswordsList)
            {
                Console.WriteLine(item);
            }

        }

        static void ShowUsers()
        {
            int j = 0;
            while (j < userNamesList.Length)
            {
                Console.WriteLine(userNamesList[j].ToUpper());
                j++;
            }
        }

        static void LoggIn()
        {
            static void LoggIn()
            {
                Console.WriteLine("Inloggning");
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
        }


        static void ChangePassword()
        {
            
        }

        static void DeleteUser()
        {

            if (!userLoggedIn)
            {
                Console.WriteLine("Du måste vara inloggad för att ta bort användare.");
                return;
            }
            String[] tempNames = new string[userNamesList.Length + 1];
            String[] tempPasswords = new string[userPasswordsList.Length + 1];

            Console.Write("SKriv användaren du vill ta bort: ");
            String name = Console.ReadLine();

            int hit = Array.IndexOf(userNamesList, name);
            if (hit == -1)
            {
                Console.WriteLine("Användaren finns inte");

            }
            else
            {
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
            }




        }
        static void Notloggedin()
        {
            Console.WriteLine("Antiagen så har du glömt skriva in ditt namn eller ditt lösenord. Försök igen!");
        }
        static void EmptyInputsMessage()
        {
            Console.WriteLine("Antigen så har du glömt skriva in ditt namn eller ditt lösenord. Försök igen!");
        }

        static void EndApplication()
        {
            Console.WriteLine("Hello from EndApplication()");
        }

        static void Menu()
        {
            Console.WriteLine("" +
                     "1. Logga in\r\n" +
                     "2. Lägg till användare\r\n" +
                     "3. Ändra lösenord\r\n" +
                     "4. Vissa användar Lista\r\n" +
                     "5. Ta bort namn ur listan\r\n" +
                     "9. Visa Meny\r\n" +
                     "0. Avsluta\r\n");
        }
    }
}