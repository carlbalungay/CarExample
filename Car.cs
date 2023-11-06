
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
            float lowestSpeedPerGear = 0;
            float highestSpeedPerGear = 0;

            if (chosenGear == "1")
            {
                lowestSpeedPerGear = 0;
                highestSpeedPerGear = speedPerGear;
            }
            else if (chosenGear == "2")
            {
                lowestSpeedPerGear = speedPerGear;
                highestSpeedPerGear = speedPerGear * 2;
            }
            else if (chosenGear == "3")
            {
                lowestSpeedPerGear = speedPerGear * 2;
                highestSpeedPerGear = speedPerGear * 3;
            }
            else if (chosenGear == "4")
            {
                lowestSpeedPerGear = speedPerGear * 3;
                highestSpeedPerGear = speedPerGear * 4;
            }
            else if (chosenGear == "5")
            {
                lowestSpeedPerGear = speedPerGear * 4;
                highestSpeedPerGear = speedPerGear * 5;
            }
            else if (chosenGear == "6")
            {
                lowestSpeedPerGear = speedPerGear * 5;
                highestSpeedPerGear = speedPerGear * 6;
            }
            Console.WriteLine($"{lowestSpeedPerGear}mph - {highestSpeedPerGear}mph");
        }
    }
}
