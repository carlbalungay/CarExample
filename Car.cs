
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
            if (chosenGear == "1")
            {
                Console.WriteLine($"{gearSpeedLowest}mph - {TopSpeed * 0.1f}mph");
            }
            else if (chosenGear == "2")
            {
                gearSpeedLowest = TopSpeed * 0.1f;
                Console.WriteLine($"{gearSpeedLowest}mph - {TopSpeed * 0.2f}mph");
            }
            else if (chosenGear == "3")
            {
                gearSpeedLowest = TopSpeed * 0.2f;
                Console.WriteLine($"{gearSpeedLowest}mph - {TopSpeed * 0.5f}mph");
            }
            else if (chosenGear == "4")
            {
                gearSpeedLowest = TopSpeed * 0.5f;
                Console.WriteLine($"{gearSpeedLowest}mph - {TopSpeed * 0.65f}mph");
            }
            else if (chosenGear == "5")
            {
                gearSpeedLowest = TopSpeed * 0.65f;
                Console.WriteLine($"{gearSpeedLowest}mph - {TopSpeed * 0.80f}mph");
            }
            else if (chosenGear == "6")
            {
                gearSpeedLowest = TopSpeed * 0.80f;
                Console.WriteLine($"{gearSpeedLowest}mph - {TopSpeed}mph");
            }
        }
    }
}
