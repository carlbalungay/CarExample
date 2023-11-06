using System;
using System.ComponentModel.Design;

namespace CarExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //selection of cars and choose one and it gives the details of the car, number of gears, top speed, make, colour.
            Car nissan = CreateNissan();
            Car mclaren = CreateMclaren();
            Car tesla = CreateCar("3", 6, "Tesla", "white", "truck", 200);

            Console.WriteLine("Please choose a Car ID (type number)");
            Console.WriteLine($"{nissan.Id}. {nissan.Name}");
            Console.WriteLine($"{mclaren.Id}. {mclaren.Name}");
            Console.WriteLine($"{tesla.Id}. {tesla.Name}");


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
            else
            {
                Console.WriteLine("car doesnt exist");
            }

            //display another option to view gear speeds for different cars ,1 - 0-10% of max speed 2, 10%-20% of max speed, 3- 20%-50%, 4- 50%-65%, 5- 65%-80%, 6- 80%-100

            // 1 0-12% 2 12-24% 2 24-36% 3 36-48% 4 48-60% 5 60-100%

            // 1 0 - 15% 2 15-25% 3 25-55% 4 55-100%



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
        static Car CreateCar(string id, int totalNumberOfGears, string name, string colour, string make, float topSpeed)
        {
            Car car = new Car();
            car.Id = id;
            car.Name = name;
            car.Colour = colour;
            car.TotalNumberOfGears = totalNumberOfGears;
            car.Make = make;
            car.TopSpeed = topSpeed;

            return car;
        }
        static void PrintCarDetails(Car car)
        {
            Console.WriteLine(car.Name);
            Console.WriteLine($"gears: {car.TotalNumberOfGears}");
            Console.WriteLine($"topspeed: {car.TopSpeed}mph");
            Console.WriteLine($"make: {car.Make}");
            Console.WriteLine($"colour: {car.Colour}");
        }

        static Car CreateNissan()
        {
            Car nissan = new Car();
            nissan.Id = "1";
            nissan.Name = "Nissan GTR";
            nissan.TotalNumberOfGears = 4;
            nissan.TopSpeed = 195;
            nissan.Make = "nissan";
            nissan.Colour = "black";

            return nissan;
        }

        static Car CreateMclaren()
        {
            Car mclaren = new Car();
            mclaren.Id = "2";
            mclaren.Name = "McLaren P1";
            mclaren.TotalNumberOfGears = 5;
            mclaren.TopSpeed = 240;
            mclaren.Make = "mclaren";
            mclaren.Colour = "black";

            return mclaren;
        }
    }
}