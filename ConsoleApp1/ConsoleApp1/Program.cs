using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car sayini daxil et:");
            int carcount = Convert.ToInt32(Console.ReadLine());
            Car [] cararr = new Car[carcount];
            Car car = new Car();
            for (int i = 0; i < cararr.Length; i++)
            {
                Console.WriteLine($"{i+1}.Brandi daxil edin :");
                string brand = Console.ReadLine();
                Console.WriteLine($"{i + 1}.Color daxil edin:");
                string color = Console.ReadLine();
                Console.WriteLine($"{i + 1}.Millage daxil edin");
                int millage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i + 1}.Fuel Capacity daxil edin:");
                int fuelcapacity= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i + 1}.Current Fuel daxil edin :");
                int currentfuel= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i + 1}.Fuel For 1 km daxil edin :");
                int fuelfor1km = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i + 1}.Masin nece km surulecek:");
                int km = Convert.ToInt32(Console.ReadLine());

                car = new Car();
                car.Brand = brand;
                car.Color = color;
                car.Millage = millage;
                car.FuelCapacity = fuelcapacity;
                car.CurrentFuel = currentfuel;
                car.FuelFor1Km = fuelfor1km;

                car.Drive(km);
                cararr[i] = car;
                
               

            }
            
           // car.Drive(km);


            Console.WriteLine("\n\n1.Masinlari Millage-e gore filtirle.\n2.Butun masinlari goster.\n3.Prosesi bitir.");


            int check = Convert.ToInt32(Console.ReadLine());

            switch (check)
            {
                case 1:

                    Console.WriteLine("\nMaksimum ve minimum deyeri daxil edin:\nMin:");
                    int min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Max");
                    int max = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n\n=============================== CARS ========================================\n");

                    foreach ( var item in car.FiltirMillage(cararr , min, max))
                    {
                        Console.WriteLine(item.ShowInfo()); 
                    }


                    break;

                    case 2:
                     Console.WriteLine("\n\n================================ CARS ====================================\n");

                    foreach (var item in cararr)
                    {
                        Console.WriteLine(item.ShowInfo());
                       // item.ShowInfo();
                    }
                    break;

                default:
                    break;
            }


          
            
           
        }
    }
}
