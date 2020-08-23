using System;

namespace _04.Beehive_Population
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialPopulation = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());

            for (int currentYear = 1; currentYear <= years; currentYear++)
            {
                int newBees = (initialPopulation / 10) * 2;
                initialPopulation += newBees; 

                if (currentYear % 5 == 0)
                {
                    int leftbees = (initialPopulation / 50) * 5;
                    initialPopulation -= leftbees;
                }

                int diedBees = (initialPopulation / 20) * 2;
                initialPopulation -= diedBees;
            }

            Console.WriteLine($"Beehive population: {initialPopulation}");
        }
    }
}
