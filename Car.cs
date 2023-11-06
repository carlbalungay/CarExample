
using System.Security.Cryptography;

namespace CarExample
{
    internal class Car
    {
        public string Id = " ";
        public string Name = " ";
        public int TotalNumberOfGears = 0;
        public float TopSpeed = 0;
        public string Make = " ";
        public string Colour = " ";

        public void DisplayGearSpeed(string chosenGear)
        {
            float gearSpeedLowest = 0;
            //correct speed per gear according to total number of gears
            //total gears 6
            //200 top speed
            //split top speed into 6 gears
            //find the percentage of each of the splits
            //
            //

            float speedPerGear = TopSpeed / TotalNumberOfGears;

            
            if (chosenGear == "1")
            {
                Console.WriteLine($"{gearSpeedLowest}mph - {speedPerGear}mph");
            }
            else if (chosenGear == "2")
            {
                Console.WriteLine($"{speedPerGear}mph - {speedPerGear * 2}mph");
            }
            else if (chosenGear == "3")
            {
                Console.WriteLine($"{gearSpeedLowest * 2}mph - {speedPerGear * 3}mph");
            }
            else if (chosenGear == "4")
            {
                Console.WriteLine($"{gearSpeedLowest * 3}mph - {speedPerGear * 4}mph");
            }
            else if (chosenGear == "5")
            {
                Console.WriteLine($"{speedPerGear * 4}mph - {speedPerGear * 5}mph");
            }
            else if (chosenGear == "6")
            {
                Console.WriteLine($"{speedPerGear * 5}mph - {speedPerGear * 6}mph");
            }
        }
    }
}
