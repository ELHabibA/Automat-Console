using System;
namespace AutomatKonsol
{
    public interface IUsablaMeal
    {

        public void Use(string name)
        {
            Console.WriteLine($"Now you can EAT Your {name} !");
        }
    }

}

