using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal abstract class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public int Millage { get; set; }

        public virtual string ShowInfo()
        {
            //Console.WriteLine($"Brand:{Brand}     Color:{Color}     Millage:{Millage} "); 
            return $"Brand:{Brand}     Color:{Color}     Millage:{Millage} ";
        }

        public abstract void Drive(int km);

    }
}
