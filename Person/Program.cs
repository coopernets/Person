using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Person
{
    /// <summary>
    /// James Cooper
    /// SID: 1337466
    /// Feedback Please
    /// </summary>
    class Program
    {
        public static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            Menu();
        }
        static void PrintPerson()
        {
            foreach (Person p in people)
            {
                Console.WriteLine("Name:\t " + p.Title + " " + p.Name);
                Console.WriteLine("Age:\t " + p.Age);
                Console.WriteLine("Address: " + p.Address1);
                Console.WriteLine("\t " + p.Address2);
                Console.WriteLine("\t " + p.Address3);
                Console.WriteLine("\t " + p.Address4);
                Console.WriteLine("\t " + p.Postcode);
                Console.WriteLine("Next Person in the people list");
                Console.WriteLine("Press enter to continue...");
            }
            Console.ReadLine();
            Menu();
        }
        static void CreatePerson()
        {
            Person p = new Person();
            Console.Write("Please enter your name: ");
            p.Name = Console.ReadLine();
            Console.Write("Please enter your age: ");
            p.Age = int.Parse(Console.ReadLine());
            Console.Write("Please enter your Title: ");
            p.Title = Console.ReadLine();
            Console.Write("Please enter the first line of address: ");
            p.Address1 = Console.ReadLine();
            Console.Write("Please enter the second line of address: ");
            p.Address2 = Console.ReadLine();
            Console.Write("Please enter the third line of address: ");
            p.Address3 = Console.ReadLine();
            Console.Write("Please enter the fourth line of address: ");
            p.Address4 = Console.ReadLine();
            Console.Write("Please enter your postcode: ");
            p.Postcode = Console.ReadLine();
            people.Add(p);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Menu();
        }
        static void CheckCaps()
        {
            foreach (Person p in people)
            {
                string input = p.Name;
                FirstCharToUpper(input);
                Console.WriteLine("OUTPUT: " + input);
                p.Name = input;
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Menu();
        }
        static void CheckAge()
        {
            Console.Clear();
            Console.WriteLine("The Following Are true: ");
            Console.WriteLine("");
            foreach (Person p in people)
            {
                if (p.Age < 20)
                {
                    Console.WriteLine(p.Name + " is younger than 20");
                }
                else if (p.Age < 51)
                {
                    Console.WriteLine(p.Name + " is younger than 51, but older than 19");
                }
                else
                {
                    Console.WriteLine(p.Name + " is old... Deal with it...");
                }
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Menu();
        }
        static void Menu()
        {
        START:
            Console.Clear();
            int switchCase;
            Console.WriteLine("Welcome to the Person Tracker");
            Console.WriteLine("Please Select an option");
            Console.WriteLine("1: Create new Person");
            Console.WriteLine("2: Print List of People");
            Console.WriteLine("3: Check for Capital Letters in names");
            Console.WriteLine("4: Do age check for people");
            switchCase = int.Parse(Console.ReadLine());
            switch (switchCase)
            {
                case 1:
                    CreatePerson();
                    break;
                case 2:
                    PrintPerson();
                    break;
                case 3:
                    CheckCaps();
                    break;
                case 4:
                    CheckAge();
                    break;
                default:
                    goto START;
            }
            Console.ReadLine();
        }
        public static string FirstCharToUpper(string input)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
        }
    }
}
