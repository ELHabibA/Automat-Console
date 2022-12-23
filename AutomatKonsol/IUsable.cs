using System;
namespace AutomatKonsol
{
    public interface IUsable
    {
       
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


    }
}

