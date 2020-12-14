using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace AssignmentTwo
{

    // Pinkod vid start, namn på bassgrupp == password. Om fel kod == felmeddelande
    // Meny med olika val
    // Lista alla deltagare och använd komma , som separatör
    // 10 detaljer om varje medlem så som fav mat eller band
    // Största driv till programmering.
    // Möjlighet att ta bort en person

    class ClassMate
    {
        string name;
        int age;
        int length;
        string adress;
        string hobby;
        string favFood;
        string favDrink;
        string favBand;
        int nrChildren;
        string programmingDrive;

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
        static List<ClassMate> listOfClassMates = new List<ClassMate>();

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
            foreach (var classMate in listOfClassMates)
            {
                Console.Write($"Name: {classMate.Name} Age: {classMate.Age} Length: {classMate.Length} Adress: {classMate.Adress} Hobby: {classMate.Hobby} Favorite Food: {classMate.FavFood} Favorite Drink: {classMate.FavDrink} Favorite Band: {classMate.FavBand} Children: {classMate.NrChildren}");
            }
        }6
        private static void DisplayMembersDriveToProgramming()
        {
            foreach (var classMate in listOfClassMates)
            {
               Console.WriteLine($"{classMate.Name}, Programmerings driv: {classMate.ProgrammingDrive}");
            }
            Menu();
        }
        private static void RemoveMember()
        {
            string input = "";
            Console.WriteLine("Who do you wanna remove?");
            for (int i = 0; i < listOfClassMates.Count; i++)
            {
                Console.WriteLine($"{i+1}. {listOfClassMates[i].Name}");
            }
            input = Console.ReadLine();
            Menu();
        }
        static void CreateMembers()
        {
            ClassMate DennisLindquist = new ClassMate("Dennis Lindquist", 32, 182, "Älvdalen", "Musik/Gitarr", "Friterad kyckling", "Öl", "Metallica", 1, "Att får skapa och kunna vara kreativ. Men även att få göra ett byte av karriär.");
            ClassMate FredrikHoffman = new ClassMate("Fredrik Hoffman", 28, 192, "Odensala", "Musik, socialisera, film", "Entrecote med rotfrukter och vitlökssmör", "Trocadero Zero", "Armin Van Buuren", 0, "Möjlighet till karriärutveckling");
            ClassMate BennyChristensen = new ClassMate("Benny Christensen", 38, 194, "Brunflo", "Datorspel, fiske, programmering, landsvägscykling", "Älgkebab", "Coca Cola", "Foo Fighters", 2, "Att kunna skapa något från grunden och lösa problem med det jag skapat. Att sedan kunna använda detta till att tjäna hutlösa summor pengar är ju i sig ytterligare en morot");
            ClassMate HakanEriksson = new ClassMate("Håkan Eriksson", 44, 187, "Uppsala", "Moto-X, sporthojar, online gaming", "Shish kebab", "Loka Citron", "Disturbed", 0, "Social engineering, datasäkerhet, pentesting.");
            ClassMate TinaEriksson = new ClassMate("Tina Eriksson", 30, 165, "Brunflo", "Spela TV-spel", "Potatis & purjolöksoppa", "Kaffe", "Avicii", 2, "Få ett bra jobb, som jag tycker om.");
            ClassMate TobiasBinett = new ClassMate("Tobias Binett", 31, 192, "Hudiksvall", "Träning, musik, spel, familjen", "Kött", "Öl", "The Black Dahlia Murder", 2, "Att kunna skapa något användbart för mig själv och andra och att ha möjligheten att arbeta med det.");
            ClassMate EmilOrjes = new ClassMate("Emil Örjes", 26, 184, "Falun", "Snowboard, gitarr, musik, hunden, TV-spel", "Feta hamburgare", "Öl", "System of a Down", 0, "Att lära sig ett nytt yrke helt från grunden som känns givande.");
            ClassMate MattiasVikstrom = new ClassMate("Mattias Vikström", 33, 187, "Umeå", "Fiske, matlagning", "Cowboysoppa", "Gin och Tonic", "Infected Mushroom", 0, "Personlig utveckling och kreativitet.");
            ClassMate NicklasEriksson = new ClassMate("Nicklas Eriksson", 26, 175, "Umeå", "Skidor, cykel, simma, springa, fjällvandring, klättring och dataspel", "Gröt med jordnötssmör", "Whiskey", "Falling in Reverse och Self Deception", 0, "Drivet kommer från att man får vara kreativ och en problemlösare på samma gång. Sen så drivs man såklart av att få testa på en annan karriär än den man har haft tidigare.");
            ClassMate JosefineRonnqvist = new ClassMate("Josefine Rönnqvist", 34, 164, "Gideå", "Sy, pussla, umgås", "Frukt", "Vatten", "Halsbandet", 2, "Personlig utveckling och karriärbyte.");
            listOfClassMates.Add(DennisLindquist);
            listOfClassMates.Add(FredrikHoffman);
            listOfClassMates.Add(BennyChristensen);
            listOfClassMates.Add(HakanEriksson);
            listOfClassMates.Add(TinaEriksson);
            listOfClassMates.Add(TobiasBinett);
            listOfClassMates.Add(EmilOrjes);
            listOfClassMates.Add(MattiasVikstrom);
            listOfClassMates.Add(NicklasEriksson);
            listOfClassMates.Add(JosefineRonnqvist);


        }
    }
}
