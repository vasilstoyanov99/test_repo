using System;

namespace _01.Honeycombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int beesNum = int.Parse(Console.ReadLine());
            int flowersNum = int.Parse(Console.ReadLine());

            double totalHoneyProduced = beesNum * flowersNum * 0.21;
            double totalHoneycombs = totalHoneyProduced / 100;
            double letfHoney = totalHoneyProduced - (Math.Truncate(totalHoneycombs) * 100);

            Console.WriteLine($"{Math.Truncate(totalHoneycombs)} honeycombs filled.");
            Console.WriteLine($"{letfHoney:f2} grams of honey left.");
        }
    }
}
