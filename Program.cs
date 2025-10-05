using System;

namespace Kodanalys
{
    class Program
    {
        static string[] userList = new string[10];
        static int user = 0;

        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                string? menuChoice = Console.ReadLine();

                if (menuChoice == "1")
                {
                    Console.Write("Ange namn: ");
                    string? userName = Console.ReadLine();
                    if (user < 10)
                    {
                        userList[user] = userName!;
                        user++;
                    }
                    else
                    {
                        Console.WriteLine("Listan är full!");
                    }
                }
                else if (menuChoice == "2")
                {
                    Console.WriteLine("Användare:");
                    for (int i = 0; i < user; i++)
                    {
                        Console.WriteLine(userList[i]);
                    }
                }
                else if (menuChoice == "3")
                {
                    Console.Write("Ange namn att ta bort: ");
                    string? userToRemove = Console.ReadLine();
                    int userIndex = -1;
                    for (int i = 0; i < user; i++)
                    {
                        if (userList[i] == userToRemove)
                        {
                            userIndex = i;
                            break;
                        }
                    }

                    if (userIndex != -1)
                    {
                        for (int i = userIndex; i < user - 1; i++)
                        {
                            userList[i] = userList[i + 1];
                        }
                        user--;
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (menuChoice == "4")
                {
                    Console.Write("Ange namn att söka: ");
                    string? searchName = Console.ReadLine();
                    bool found = false;
                    for (int i = 0; i < user; i++)
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
                else if (menuChoice == "5")
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                }
                Console.WriteLine();
            }
        }
    }
}
