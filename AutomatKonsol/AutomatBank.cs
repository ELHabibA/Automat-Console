using System;
namespace AutomatKonsol
{
    public class AutomatBank
    {
        public double Saldo { get; set; }

        // List to keep the purchased products price
        public List<double> ProductPrice = new List<double>();

        public AutomatBank(double deposite)
        {
           
            Saldo = deposite;
        }

        public AutomatBank()
        {

        }

      

    }
}

