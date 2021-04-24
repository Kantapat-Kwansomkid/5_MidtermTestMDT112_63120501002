using System;

namespace _5_MidtermTestMDT112_63120501002
{
    class Program
    {
        static void Main(string[] args)
        {
            double InputDate;
            Console.Write("Input your date : ");
            InputDate = double.Parse(Console.ReadLine());

            double InputTime;
            Console.Write("Input your Time : ");
            InputTime = double.Parse(Console.ReadLine());

            string InputFood;
            Console.Write("Input your Time : ");
            InputFood = (Console.ReadLine());

            if (InputDate >= 1)
            {
                Console.WriteLine("Yes");
            }
            else if (InputTime >= 2)
            {
                Console.WriteLine("Yes");
            }
            else if (InputFood >= 3)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("Please enter a valid menu");
            }
            else
            {
                Console.WriteLine("Sorry your order is not available");
            }
            else
            {
                Console.WriteLine("Sorry your order is out of stock");
            }

            Console.WriteLine("Your Delivering is", {0},{1},{2});
            Console.ReadLine();
        }
    }
}
