using System;
using System.Collections.Generic;

namespace UML2
{
    public class MenuCatalog
    {
        // Starter med at oprette list af pizzaer
        List<Pizza> pizzas = new List<Pizza>();

        public MenuCatalog()
        {
            Pizza p1 = new Pizza("Kylling", 50, 1);
            Pizza p2 = new Pizza("Shawarma", 65, 2);
            pizzas.Add(p1);
            pizzas.Add(p2);
        }

        //Metoden jeg har brugt til at oprette Pizzaer 
        public void CreatePizza(string Name, int Price, int Number)
        {
            Pizza p = new Pizza(Name, Price, Number);
            pizzas.Add(p);
        }
        //Metoden jeg har brugt til at fjerne pizzaer
        public void RemovePizza(string Name)
        {

            foreach (var pizzaB in pizzas)
            {

                if (Name.Equals(pizzaB.GetName()))
                {
                    pizzas.Remove(pizzaB);
                    Console.WriteLine($" Pizza {pizzaB} is now deleted");
                    break;

                }
            }
        }
        //henviser til Create metode
        public void PrintPizza()
        {
            foreach (var pizza in pizzas)
            {
                Console.WriteLine(pizza);

            }

        }
        public void UpdatePizza(string Name, int Price, int Number)
        {
            // På denne metode anvender vi Number til at finde pizzan, så vi kan ændre navn og pris
            foreach (var pizza in pizzas)
            {
                if (Number == pizza.GetNumber())
                {
                    pizza.SetName(Name);
                    pizza.SetPrice(Price);
                    Console.WriteLine("Pizza has been updated !");
                    break;
                }

            }
        }

        // På denne metode anvender vi pizza listen som indeholder noget tilfælles, og derefter printer den hvis den ind
        public void SearchPizza(string Name)
        {
            foreach (var pizza in pizzas)
            {
                if (pizza.GetName().Contains(Name))
                {
                    Console.WriteLine($"{pizza}");
                }
            }
        }
    }
}