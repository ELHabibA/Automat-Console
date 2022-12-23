using System;
namespace AutomatKonsol
{
    class Sandwich : Product, IUsable, IUsablaMeal
    {
        public Sandwich(string name, double price, string informations) : base(name, price, informations)
        {
        }

        public void Description(string name, double price, string informations)
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Price : {price} kr");
            Console.WriteLine($"Description : {informations}");

        }

        public void Buy(string name)
        {
            Console.WriteLine($"{name} is added to your shopping list!");

        }

        public void Use(string name)
        {
            Console.WriteLine($"Now you can EAT Your {name} !");
        }
    }
}

