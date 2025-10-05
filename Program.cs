using System;

namespace Kodanalys
{
    class Program
    {
        static string[] userList = new string[10];
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
            if (userCount < 10)
            {
                userList[userCount] = userName!;
                userCount++;
            }
            else
                {
                    Console.WriteLine("Listan är full!");
                }
        }

        static void ListUsers()
        {
            Console.WriteLine("Användare:");
            for (int i = 0; i < userCount; i++)
                {
                    Console.WriteLine(userList[i]);
                }
        }
        static void RemoveUser()
        {
            Console.Write("Ange namn att ta bort: ");
            string? userToRemove = Console.ReadLine();
            int userIndex = -1;
            for (int i = 0; i < userCount; i++)
            {
                if (userList[i] == userToRemove)
                {
                    userIndex = i;
                    break;
                }
            }

            if (userIndex != -1)
            {
                for (int i = userIndex; i < userCount - 1; i++)
                {
                    userList[i] = userList[i + 1];
                }
                userCount--;
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
            bool found = false;
            for (int i = 0; i < userCount; i++)
            {
                if (userList[i] == searchName)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("Användaren finns i listan.");
            }
            else
            {
                Console.WriteLine("Användaren hittades inte.");
            }
        }
    }
}
