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
            // Welcome message
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");

            // Prompt for package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if weight exceeds limit
            if (weight > 50)

            {
                // Display error message and end program
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
                Console.ReadLine();
                return;
            }
            // Prompt for package dimensions
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // Calculate dimensions total
            int dimensionsTotal = width + height + length;

            // Check if dimensions exceed limit
            if (dimensionsTotal > 50)
            {
                // Display error message and end program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // Calculate shipping quote
            decimal quote = (decimal)(width * height * length) / 100;

            // Display the quote to the user
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
            Console.WriteLine("Thank you for using Package Express!");
            Console.ReadLine();
        }
    }
}
