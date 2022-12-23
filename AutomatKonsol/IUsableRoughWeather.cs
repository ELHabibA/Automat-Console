using System;
namespace AutomatKonsol
{
    public interface IUsableRoughWeather
    {

        public void Use(string name)
        {
            Console.WriteLine($"Now you can USE Your {name} !");
        }

    }
}

