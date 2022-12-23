using System;
namespace AutomatKonsol
{
    abstract class Product 
    {
        public string Name;
        public double Price;
        public string Informations;


        public Product(string name, double price, string informations)
        {

            Name = name;
            Price = price;
            Informations = informations;
        }


    }
}

