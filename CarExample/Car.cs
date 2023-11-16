
using System.Security.Cryptography;

namespace CarExample
{
    //next lesson:constructors
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
            DisplayGearSpeedSolution1(chosenGear);
            DisplayGearSpeedSolution2(chosenGear);
            DisplayGearSpeedSolution3(chosenGear);
        }

        private void DisplayGearSpeedSolution3(string chosenGear)
        {
            int chosenGearNumber = int.Parse(chosenGear);
            if (chosenGearNumber > TotalNumberOfGears)
            {
                Console.WriteLine("incorrect number chosen");
                Environment.Exit(0);
            }
            float speedPerGear = TopSpeed / TotalNumberOfGears;
            float lowestSpeedPerGear = speedPerGear * (chosenGearNumber - 1);
            float highestSpeedPerGear = speedPerGear * chosenGearNumber;

            Console.WriteLine($"{lowestSpeedPerGear}mph - {highestSpeedPerGear}mph Solution3");

        }
        private void DisplayGearSpeedSolution2(string chosenGear)
        {
            int chosenGearNumber = int.Parse(chosenGear);
            if (chosenGearNumber > TotalNumberOfGears)
            {
                Console.WriteLine("incorrect number chosen");
                Environment.Exit(0);
            }
            float speedPerGear = TopSpeed / TotalNumberOfGears;
            float lowestSpeedPerGear = 0;
            float highestSpeedPerGear = 0;

            for (int i = 1; i <= TotalNumberOfGears; i++)
            {
                lowestSpeedPerGear = highestSpeedPerGear;
                highestSpeedPerGear = speedPerGear * i;
                if (chosenGearNumber == i)
                {
                    break;
                }
            }
            Console.WriteLine($"{lowestSpeedPerGear}mph - {highestSpeedPerGear}mph Solution2");

        }


        private void DisplayGearSpeedSolution1(string chosenGear)
        {
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
            Console.WriteLine($"{lowestSpeedPerGear}mph - {highestSpeedPerGear}mph Solution 1");
        }
    }
}
