using System;
using System.Threading;

namespace _06.Honey_Winter_Reserves
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHoney = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            bool isHoneyGoalReached = false;
            double totalAddedHoney = 0.00;

            while (input != "Winter has come")
            {
                string beeName = input;
                double totalAddedHoneyFromBee = 0.00;

                for (int currentMonth = 1; currentMonth <= 6; currentMonth++)
                {
                    double addedHoneyFromBee = double.Parse(Console.ReadLine());
                    totalAddedHoneyFromBee += addedHoneyFromBee;
                }

                if (totalAddedHoneyFromBee < 0)
                {
                    Console.WriteLine($"{beeName} was banished for gluttony");
                }

                totalAddedHoney += totalAddedHoneyFromBee;

                if (totalAddedHoney >= neededHoney)
                {
                    isHoneyGoalReached = true;
                    break;
                }

                input = Console.ReadLine();
            }

            if (isHoneyGoalReached)
            {
                Console.WriteLine($"Well done! Honey surplus {totalAddedHoney - neededHoney:f2}.");
            }
            else
            {
                Console.WriteLine($"Hard Winter! Honey needed {neededHoney - totalAddedHoney:f2}.");
            }
        }
    }
}
