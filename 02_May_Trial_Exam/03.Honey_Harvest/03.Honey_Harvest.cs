using System;

namespace _03.Honey_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int flowersNum = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double honey = 0.00;

            if (season == "Spring")
            {
                switch (typeFlower)
                {
                    case "Sunflower":
                        honey = 10;
                        break;
                    case "Daisy":
                        honey = 12;
                        honey *= 1.10;
                        break;
                    case "Lavender":
                        honey = 12;
                        break;
                    case "Mint":
                        honey = 10;
                        honey *= 1.10;
                        break;
                }
            }
            else if (season == "Summer")
            {
                switch (typeFlower)
                {
                    case "Sunflower":
                    case "Daisy":
                    case "Lavender":
                        honey = 8;
                        break;
                    case "Mint":
                        honey = 12;
                        break;
                }
            }
            else if (season == "Autumn")
            {
                switch (typeFlower)
                {
                    case "Sunflower":
                        honey = 12;
                        break;
                    case "Daisy":
                    case "Lavender":
                    case "Mint":
                        honey = 6;
                        break;
                }
            }

            double totalProducedHoney = honey * flowersNum;

            if (season == "Summer")
            {
                totalProducedHoney *= 1.10;
            }
            else if (season == "Autumn")
            {
                totalProducedHoney *= 0.95;
            }

            Console.WriteLine($"Total honey harvested: {totalProducedHoney:f2}");
        }
    }
}
