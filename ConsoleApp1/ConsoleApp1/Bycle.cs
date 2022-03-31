using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Bycle:Vehicle
    {

        public override void Drive(int km)
        {
            Millage = +km;
        }


        public override string  ShowInfo()
        {
           // Console.WriteLine($"Brand:{Brand}     Color:{Color}     Millage:{Millage} ");
           return $"{base.ShowInfo()}";
        }
    }
}
