using System;

namespace _01.Sweet_Dessert
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var amountOfMonney = decimal.Parse(Console.ReadLine());
            var numberOfGuests = decimal.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berriesPricePerKg = decimal.Parse(Console.ReadLine());

            int portionsCount = (int)Math.Ceiling(numberOfGuests / 6.0M);

            var dinerPrice = (2 * bananaPrice * portionsCount) + (4 * eggPrice * portionsCount) + (0.2M * berriesPricePerKg * portionsCount);

            if (amountOfMonney >= dinerPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {dinerPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(dinerPrice - amountOfMonney):f2}lv more.");
            }
        }
    }
}
