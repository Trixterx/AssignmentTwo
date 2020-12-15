using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;

namespace AssignmentTwo
{

    // Pinkod vid start, namn på bassgrupp == password. Om fel kod == felmeddelande.
    // Meny med olika val.
    // Lista alla deltagare och använd komma , som separatör.
    // 10 detaljer om varje medlem så som fav mat eller band.
    // Största driv till programmering.
    // Möjlighet att ta bort en person.
    
    class ClassMate
    {
        private string name;
        private int age;
        private int length;
        private string adress;
        private string hobby;
        private string favFood;
        private string favDrink;
        private string favBand;
        private int nrChildren;
        private string programmingDrive;

        public ClassMate()
        {

        }

        public ClassMate(string name, int age, int length, string adress, string hobby, string favFood, string favDrink, string favBand, int nrChildren, string programmingDrive)
        {
            this.name = name;
            this.age = age;
            this.length = length;
            this.adress = adress;
            this.hobby = hobby;
            this.favFood = favFood;
            this.favDrink = favDrink;
            this.favBand = favBand;
            this.nrChildren = nrChildren;
            this.programmingDrive = programmingDrive;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Length { get => length; set => length = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Hobby { get => hobby; set => hobby = value; }
        public string FavFood { get => favFood; set => favFood = value; }
        public string FavDrink { get => favDrink; set => favDrink = value; }
        public string FavBand { get => favBand; set => favBand = value; }
        public int NrChildren { get => nrChildren; set => nrChildren = value; }
        public string ProgrammingDrive { get => programmingDrive; set => programmingDrive = value; }
    }

    class Program
    {
        private static List<ClassMate> listOfClassMates = new List<ClassMate>();

        static void Main(string[] args)
        {
            LogIn();
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
            CreateMembers();
            Menu();
        }
        private static void Menu()
        {
            string input = "";
            Console.WriteLine();
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
            foreach (var classMate in listOfClassMates)
            {
                Console.Write($"{classMate.Name},");
            }
            Menu();
        }
        private static void DisplayMemberDetails()
        {
            int counter = 1;
            foreach (var classMate in listOfClassMates)
            {
                Console.Write($"{counter}.{classMate.Name}\n  Age: {classMate.Age}\n  Length: {classMate.Length}\n  Adress: {classMate.Adress}\n  Hobby: {classMate.Hobby}\n  Fav Food: {classMate.FavFood}\n  Fav Drink: {classMate.FavDrink}\n  Fav Band: {classMate.FavBand}\n  Children: {classMate.NrChildren}\n");
                counter++;
            }
            Menu();
        }
        private static void DisplayMembersDriveToProgramming()
        {
            int counter = 1;
            foreach (var classMate in listOfClassMates)
            {
               Console.WriteLine($"{counter}.{classMate.Name}\n  Programming Drive: {classMate.ProgrammingDrive}");
                counter++;
            }
            Menu();
        }
        private static void RemoveMember()
        {
            int counter = 1;
            int input;
            foreach (var classMate in listOfClassMates)
            {
                Console.WriteLine($"{counter}.{classMate.Name}");
                counter++;
            }
            Console.WriteLine("Who do you wanna remove?");
            input = Convert.ToInt32(Console.ReadLine());
            listOfClassMates.RemoveAt(input-1);
            Menu();
        }
        private static void CreateMembers()
        {
            listOfClassMates.Add(new ClassMate { Name = "Dennis Lindquist", Age = 32, Length = 182, Adress = "Älvdalen", Hobby = "Musik/Gitarr", FavFood = "Friterad kyckling", FavDrink = "Öl", FavBand = "Metallica", NrChildren = 1, ProgrammingDrive = "Att får skapa och kunna vara kreativ. Men även att få göra ett byte av karriär." });
            listOfClassMates.Add(new ClassMate { Name = "Fredrik Hoffman", Age = 28, Length = 192, Adress = "Odensala", Hobby = "Musik, socialisera, film", FavFood = "Entrecote med rotfrukter och vitlökssmör", FavDrink = "Trocadero Zero", FavBand = "Armin Van Buuren", NrChildren = 0, ProgrammingDrive = "Möjlighet till karriärutveckling" });
            listOfClassMates.Add(new ClassMate { Name = "Benny Christensen", Age = 38, Length = 194, Adress = "Brunflo", Hobby = "Datorspel, fiske, programmering, landsvägscykling", FavFood = "Älgkebab", FavDrink = "Coca Cola", FavBand = "Foo Fighters", NrChildren = 2, ProgrammingDrive = "Att kunna skapa något från grunden och lösa problem med det jag skapat. Att sedan kunna använda detta till att tjäna hutlösa summor pengar är ju i sig ytterligare en morot" });
            listOfClassMates.Add(new ClassMate { Name = "Håkan Eriksson", Age = 44, Length = 187, Adress = "Uppsala", Hobby = "Moto-X, sporthojar, online gaming", FavFood = "Shish kebab", FavDrink = "Loka Citron", FavBand = "Disturbed", NrChildren = 0, ProgrammingDrive = "Social engineering, datasäkerhet, pentesting." });
            listOfClassMates.Add(new ClassMate { Name = "Tina Eriksson", Age = 30, Length = 165, Adress = "Brunflo", Hobby = "Spela TV-spel", FavFood = "Potatis & purjolöksoppa", FavDrink = "Kaffe", FavBand = "Avicii", NrChildren = 2, ProgrammingDrive = "Få ett bra jobb, som jag tycker om." });
            listOfClassMates.Add(new ClassMate { Name = "Tobias Binett", Age = 31, Length = 192, Adress = "Hudiksvall", Hobby = "Träning, musik, spel, familjen", FavFood = "Kött", FavDrink = "Öl", FavBand = "The Black Dahlia Murder", NrChildren = 2, ProgrammingDrive = "Att kunna skapa något användbart för mig själv och andra och att ha möjligheten att arbeta med det." });
            listOfClassMates.Add(new ClassMate { Name = "Emil Örjes", Age = 26, Length = 184, Adress = "Falun", Hobby = "Snowboard, gitarr, musik, hunden, TV-spel", FavFood = "Feta hamburgare", FavDrink = "Öl", FavBand = "System of a Down", NrChildren = 0, ProgrammingDrive = "Att lära sig ett nytt yrke helt från grunden som känns givande." });
            listOfClassMates.Add(new ClassMate { Name = "Mattias Vikström", Age = 33, Length = 187, Adress = "Umeå", Hobby = "Fiske, matlagning", FavFood = "Cowboysoppa", FavDrink = "Gin och Tonic", FavBand = "Infected Mushroom", NrChildren = 0, ProgrammingDrive = "Personlig utveckling och kreativitet." });
            listOfClassMates.Add(new ClassMate { Name = "Nicklas Eriksson", Age = 26, Length = 175, Adress = "Umeå", Hobby = "Skidor, cykel, simma, springa, fjällvandring, klättring och dataspel", FavFood = "Gröt med jordnötssmör", FavDrink = "Whiskey", FavBand = "Falling in Reverse och Self Deception", NrChildren = 0, ProgrammingDrive = "Drivet kommer från att man får vara kreativ och en problemlösare på samma gång. Sen så drivs man såklart av att få testa på en annan karriär än den man har haft tidigare." });
            listOfClassMates.Add(new ClassMate { Name = "Josefine Rönnqvist", Age = 34, Length = 164, Adress = "Gideå", Hobby = "Sy, pussla, umgås", FavFood = "Frukt", FavDrink = "Vatten", FavBand = "Halsbandet", NrChildren = 2, ProgrammingDrive = "Personlig utveckling och karriärbyte." });
        }
    }
}
