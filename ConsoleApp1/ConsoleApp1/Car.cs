using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Car:Vehicle
    {
        public int FuelCapacity { get; set; }


        public int CurrentFuel { get; set; }
        public int FuelFor1Km { get; set; }

        public override void Drive(int km)
        {
            if  (km * FuelFor1Km <= CurrentFuel)
            {
                CurrentFuel = CurrentFuel - km * FuelFor1Km;
                Millage += km;
            }
            else
            {
                Console.WriteLine("Masin bu yolu gede bilmez!!!");
            }

        }
        public override string ShowInfo()
        {
            //Console.WriteLine($"    Fuel Capacity:{FuelCapacity}     Current Fuel:{CurrentFuel}    Fuel for 1 km: {FuelFor1Km}");
            return $"{base.ShowInfo()}  Fuel Capacity:{FuelCapacity}     Current Fuel:{CurrentFuel}    Fuel for 1 km: {FuelFor1Km}";
        }


        public Car[]  FiltirMillage( Car[] cars , int min , int max )
        {

            Car[] newcar = new Car[0];

            for (int i = 0; i < cars.Length; i++)
            {

                if (cars[i].Millage >min && cars[i].Millage < max)
                {
                    Array.Resize(ref newcar, newcar.Length+1);
                    newcar[newcar.Length-1] = cars[i];
                }

            }
            return newcar;



        }


    }
}
