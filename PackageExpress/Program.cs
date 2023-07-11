using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)

            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            int dimensionsTotal = width + height + length;
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            decimal quote = (decimal)(width * height * length) / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

            Console.WriteLine("Thank you for using Package Express!");
            Console.ReadLine();
        }
    }
}
