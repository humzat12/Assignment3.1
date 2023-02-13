using System;

namespace Assignment3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter your hourly pay rate");
            double payRate = Convert.ToDouble(Console.ReadLine());
            const double minPayRate = 7.50;
            const double maxPayRate = 49.99;

            if (payRate < minPayRate)
            {
                Console.WriteLine("Error your hourly pay rate must be at least $" + minPayRate);

            }
            

            if (payRate > maxPayRate)
            {
                Console.WriteLine("Error your hourly pay rate must be less than $" + maxPayRate);

            }
          else
            {
                Console.WriteLine("Hourly Pay Rate $" + payRate);
            }
       
            Console.ReadLine();
        }
    }
}
