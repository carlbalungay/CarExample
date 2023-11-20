using System;
using System.ComponentModel.Design;

namespace CarExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car nissan = new Car("1", "Nissan GTR", 4, 195, "nissan", "black");
            Car mclaren = new Car("2", "McLaren P1", 5, 240, "mclaren", "black");
            Car tesla = new Car("3", "Tesla", 6, 200, "truck", "white");
            Car lambo = new Car("4", "Lambo",6, 500, "sports", "red");

            Console.WriteLine("Please choose a Car ID (type number)");
            Console.WriteLine($"{nissan.Id}. {nissan.Name}");
            Console.WriteLine($"{mclaren.Id}. {mclaren.Name}");
            Console.WriteLine($"{tesla.Id}. {tesla.Name}");
            Console.WriteLine($"{lambo.Id}. {lambo.Name}");


            string choice = Console.ReadLine();

            if (choice == nissan.Id)
            {
                SelectCar(nissan);
            }
            else if (choice == mclaren.Id)
            {
                SelectCar(mclaren);
            }
            else if (choice == tesla.Id)
            {
                SelectCar(tesla);
            }
            else if (choice == lambo.Id)
            {
                SelectCar(lambo);
            }
            else
            {
                Console.WriteLine("car doesnt exist");
            }

        }

        static void SelectCar(Car car)
        {
            PrintCarDetails(car);
            Console.WriteLine("View Gear Details? yes or no");
            string choice2 = Console.ReadLine();
            if (choice2 == "yes")
            {
                Console.WriteLine($"Which gear would you like to view? 1 to {car.TotalNumberOfGears}");
                string chosenGear = Console.ReadLine();
                car.DisplayGearSpeed(chosenGear);
            }
            else if (choice2 == "no")
            {
                Environment.Exit(0);
            }
        }
        static void PrintCarDetails(Car car)
        {
            Console.WriteLine(car.Name);
            Console.WriteLine($"gears: {car.TotalNumberOfGears}");
            Console.WriteLine($"topspeed: {car.TopSpeed}mph");
            Console.WriteLine($"make: {car.Make}");
            Console.WriteLine($"colour: {car.Colour}");
        }
        

    }
}