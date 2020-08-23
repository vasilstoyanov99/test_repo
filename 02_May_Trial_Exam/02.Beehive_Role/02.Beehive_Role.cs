using System;
using System.Runtime.InteropServices.ComTypes;

namespace _02.Beehive_Role
{
    class Program
    {
        static void Main(string[] args)
        {
            int beeIQ = int.Parse(Console.ReadLine());
            int beeStrength = int.Parse(Console.ReadLine());
            string beeGender = Console.ReadLine();
            string beeRole = "";

            if (beeGender == "female")
            {
                if (beeIQ >= 80 && beeStrength >= 80)
                {
                    beeRole = "Queen Bee";
                }
            }
            else if (beeIQ >= 80)
            {
                beeRole = "Repairing Bee";
            }
            else if (beeIQ >= 60)
            {
                beeRole = "Cleaning Bee";
            }
            else if (beeGender == "male" && beeStrength >= 80)
            {
                beeRole = "Drone Bee";
            }
            else if (beeStrength >= 60)
            {
                beeRole = "Guard Bee";
            }
            else
            {
                beeRole = "Worker Bee";
            }

            Console.WriteLine(beeRole);
        }
    }
}
