using System;
namespace AutomatKonsol
{
    public interface IUsableLiquid
    {

        public void Use(string name)
        {
            Console.WriteLine($"Now you can drink Your {name} !");
        }


    }
}

