using AdressBook.Interfaces;
using AdressBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook.Services
{
    public class MenuService
    {
     ListService listService = new ListService();
        public void MainMenu() 
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("**** AdressBook ****");
                Console.WriteLine();
                Console.WriteLine("### Main Menu ###");
                Console.WriteLine();
                Console.WriteLine("1. Show all contacts");
                Console.WriteLine();
                Console.WriteLine("2. Search for specific contact");
                Console.WriteLine();
                Console.WriteLine("3. Remove a specific contact");
                Console.WriteLine();
                Console.WriteLine("4. Add a new contact");
                Console.WriteLine();
                Console.WriteLine("5. Quit program");
                Console.WriteLine();
                Console.Write("Please select one of options above :");
                var answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        Console.Clear();
                        var list = listService.ShowList();
                        Console.Clear();
                        Console.WriteLine("###  All Contacts  ###");
                        Console.WriteLine();
                        int index = 1;

                        foreach (Person person in list)
                        {
                            Console.WriteLine($"{index}.");
                            Console.WriteLine($"Name:  {person.FirstName} {person.LastName}");
                            Console.WriteLine();
                            Console.WriteLine($"Email: {person.Email}");
                            Console.WriteLine();
                            Console.WriteLine($"Phone: {person.PhoneNumber}");
                            Console.WriteLine();
                            Console.WriteLine($"Adress: {person.StreetName} {person.StreetNumber}");
                            Console.WriteLine();
                            Console.WriteLine($"City: {person.City}");
                            Console.WriteLine();
                            Console.WriteLine();

                            index++;
                            }
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("Please enter email of person you are searching for: ");
                        string searchedEmail = Console.ReadLine() ?? "";
                        Console.WriteLine();
                        Person foundPerson= listService.SearchEmail(searchedEmail);

                        if (foundPerson != null)
                        {
                            Console.WriteLine($"Name:  {foundPerson.FirstName} {foundPerson.LastName}");
                            Console.WriteLine();
                            Console.WriteLine($"Email: {foundPerson.Email}");
                            Console.WriteLine();
                            Console.WriteLine($"Phone: {foundPerson.PhoneNumber}");
                            Console.WriteLine();
                            Console.WriteLine($"Adress: {foundPerson.StreetName} {foundPerson.StreetNumber}");
                            Console.WriteLine();
                            Console.WriteLine($"City: {foundPerson.City}");
                            Console.WriteLine();
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Person not Found, press any key to return to main menu");
                            Console.ReadKey();
                            break;
                        }

                        

                    //case "3":
                    //    Console.Clear();
                    //    RemoveContact();
                    //    break;

                    case "4":
                        Console.Clear();
                        var newPerson = new Person();

                        Console.Write("First:");
                        newPerson.FirstName=Console.ReadLine() ?? "";
                        Console.Write("Last:");
                        newPerson.LastName = Console.ReadLine() ?? "";
                        Console.Write("Email:");
                        newPerson.Email = Console.ReadLine() ?? "";
                        Console.Write("Street:");
                        newPerson.StreetName = Console.ReadLine() ?? "";
                        Console.Write("Num:");
                        newPerson.StreetNumber = int.Parse(Console.ReadLine())  ;
                        Console.Write("Phone:");
                        newPerson.PhoneNumber = int.Parse(Console.ReadLine());
                        Console.Write("City:");
                        newPerson.City = Console.ReadLine() ?? "";
                        
                        listService.AddPerson(newPerson);

                        break;

                    case "5":
                        Console.Clear();
                        QuitMenu();
                        break;

                    default:
                        Console.WriteLine("invalid option, try again");
                        break;

                }

                

            }
        }

        private void QuitMenu()
        {
            Console.Clear();
            Console.Write("Are you sure you want to quit? (Y/N)");
            var quit = Console.ReadLine();

            switch (quit)
            {
                case "y":
                    Console.WriteLine("Press any key to exit program");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                case "n":
                    Console.WriteLine("Press any key to return to Main Menu");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("invalid option, press any key to try again");
                    Console.ReadKey();
                    QuitMenu();
                    break;

            }
            
        }



    }
}
