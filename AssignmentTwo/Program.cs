using System;
using System.ComponentModel.Design;

namespace AssignmentTwo
{

    // Pinkod vid start, namn på bassgrupp == password. Om fel kod == felmeddelande
    // Meny med olika val
    // Lista alla deltagare och använd komma , som separatör
    // 10 detaljer om varje medlem så som fav mat eller band
    // Största driv till programmering.
    // Möjlighet att ta bort en person

    class ClassMates
    {

    }

    class Program
    {

        static void Main(string[] args)
        {
            LogIn();
            Menu();
            Console.ReadKey();
        }

        private static void LogIn()
        {
            string input;
            bool wrongInput = true;

            Console.WriteLine("Password:");
            do
            {
                input = Console.ReadLine();
                if (input.Trim().ToLower() == "norr")
                {
                    wrongInput = false;
                }
                else
                {
                    Console.WriteLine("Wrong password, try again:");
                }
            } while (wrongInput);
            
        }
        private static void Menu()
        {
            string input = "";
            Console.WriteLine("Menu");
            Console.WriteLine("1. List all members");
            Console.WriteLine("2. Ten details");
            Console.WriteLine("3. Drive to programming");
            Console.WriteLine("4. Remove member");
            Console.WriteLine("q. Quit");

            while (input.Trim().ToLower() != "q")
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ListAllMembers();
                        break;
                    case "2":
                        DisplayMemberDetails();
                        break;
                    case "3":
                        DisplayMembersDriveToProgramming();
                        break;
                    case "4":
                        RemoveMember();
                        break;
                    case "q":
                        Console.WriteLine("Bye bye.");
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }   
        }

        private static void ListAllMembers()
        {

        }
        private static void DisplayMemberDetails()
        {

        }
        private static void DisplayMembersDriveToProgramming()
        {

        }
        private static void RemoveMember()
        {

        }
    }
}
