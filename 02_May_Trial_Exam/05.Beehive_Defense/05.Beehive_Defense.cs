using System;

namespace _05.Beehive_Defense
{
    class Program
    {
        static void Main(string[] args)
        {
            int beesNum = int.Parse(Console.ReadLine());
            int bearHealth = int.Parse(Console.ReadLine());
            int bearAttack = int.Parse(Console.ReadLine());
            bool isBearWon = false;
            bool isBeesWon = false;

            while (true)
            {
                beesNum -= bearAttack;

                if (beesNum < 0)
                {
                    beesNum = 0;
                }

                int beesAttcak = beesNum * 5;
                bearHealth -= beesAttcak;

                if (beesNum < 100)
                {
                    isBearWon = true;
                    break;
                }

                if (bearHealth <= 0)
                {
                    isBeesWon = true;
                    break;
                }
            }

            if (isBearWon)
            {
                Console.WriteLine($"The bear stole the honey! Bees left {beesNum}.");
            }
            else if (isBeesWon)
            {
                Console.WriteLine($"Beehive won! Bees left {beesNum}.");
            }

        }
    }
}
