using System;

namespace UML2
{
    public class Store
    {
        public void Start()
        {
            MenuCatalog menu = new MenuCatalog();

            while (true)
            {
                try
                {
                    Console.WriteLine("***************************");
                    Console.WriteLine("Welcome to Big Mamma Pizza");
                    Console.WriteLine("***************************");
                    Console.WriteLine("0 - Quit : ");
                    Console.WriteLine("1 - Overview : ");
                    Console.WriteLine("2 - Create : ");
                    Console.WriteLine("3 - Delete : ");
                    Console.WriteLine("4 - Update : ");
                    Console.WriteLine("5 - Search : ");
                    Console.Write("Choose : ");

                    int option = Int32.Parse(Console.ReadLine());
                    if (option == 0)
                    {
                        break;
                    }
                    //quit            


                    else if (option == 1)
                    // viser hvor mange pizzaer der er i øjeblikket
                    {
                        menu.PrintPizza();
                    }
                    // Create option 
                    else if (option == 2)
                    {
                        Console.Write("Skriv Pizza Name : ");
                        string Name = Console.ReadLine();

                        Console.Write("Skriv Price : ");
                        int Price = Int32.Parse(Console.ReadLine());

                        Console.Write("Skriv Number : ");
                        int Number = Int32.Parse(Console.ReadLine());

                        menu.CreatePizza(Name, Price, Number);
                    }
                    else if (option == 3)
                    {
                        // En metode der sletter pizzaer   
                        Console.Write("To Remove, type Name : ");
                        string Name = Console.ReadLine();


                        menu.RemovePizza(Name);

                    }
                    else if (option == 4)
                    {
                        Console.Write(" Skriv nummeret for at opdatere : ");
                        int Number = Int32.Parse(Console.ReadLine());

                        Console.Write(" Skriv Name : ");
                        string Name = Console.ReadLine();

                        Console.Write(" Skriv Price : ");
                        int Price = Int32.Parse(Console.ReadLine());

                        menu.UpdatePizza(Name, Price, Number);
                    }
                    else if (option == 5)
                    {
                        Console.Write("Skriv navnet for at søge : ");
                        string Name = Console.ReadLine();

                        menu.SearchPizza(Name);
                    }
                    else
                    {
                        Console.WriteLine("Fejl, venligst vælg et gyldigt nummer");
                    }

                }
                catch { Console.WriteLine("Fejl, venligst vælg et gyldigt nummer"); }
            }
        }


    }

}