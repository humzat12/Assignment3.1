using System;

namespace Assignment3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter your hourly pay rate: ");
            double payRate = Convert.ToDouble(Console.ReadLine());

            const double minPayRate = 7.50;

            if (payRate < minPayRate)
            {
                Console.WriteLine("Sorry, your hourly pay rate must be at minimum 7.50");
            }

            else
            {
                Console.WriteLine("Your hourly pay rate is $" + payRate);

            }
            Console.ReadLine();
        }
       
    }
}
