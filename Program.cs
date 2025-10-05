using System;

namespace Kodanalys
{
    class Program
    {
        static List<string> users = new List<string>();
        static int userCount = 0;

        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                ShowMenu();
                string? menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        AddUser();
                        break;
                    case "2":
                        ListUsers();
                        break;
                    case "3":
                        RemoveUser();
                        break;
                    case "4":
                        SearchUser();
                        break;
                    case "5":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Meny:");
            Console.WriteLine("1. Lägg till användare");
            Console.WriteLine("2. Lista användare");
            Console.WriteLine("3. Ta bort användare");
            Console.WriteLine("4. Sök användare");
            Console.WriteLine("5. Avsluta");
            Console.Write("Välj ett alternativ: ");
        }
                
        static void AddUser()
        {
            Console.Write("Ange namn: ");
            string? userName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine("Namnet får inte vara tomt.");
                return;
            }
            users.Add(userName);
            Console.WriteLine($"Användare {userName} tillagd.");
        }

        static void ListUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("Inga användare tillagda.");
                return;
            }

            Console.WriteLine("Användare:");
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }
        static void RemoveUser()
        {
            Console.Write("Ange namn att ta bort: ");
            string? userToRemove = Console.ReadLine();
            if (users.Remove(userToRemove!))
            {
                Console.WriteLine($"Användare {userToRemove} borttagen.");
                return;
            }
            else   
            {
                Console.WriteLine("Användaren hittades inte.");
            }
        }

        static void SearchUser()
        {
            Console.Write("Ange namn att söka: ");
            string? searchName = Console.ReadLine();
            if (users.Contains(searchName!))
            {
                Console.WriteLine("Användaren finns i listan.");
                return;
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
            }
        }
    }
}
