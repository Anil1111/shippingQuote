using System;

namespace packageShippingQuote
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight: ");
            float weight = float.Parse(Console.ReadLine());

            //Checks if package weight is greater than 50, if it is, display rejection message and end program. 
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package width: ");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length: ");
            float length = float.Parse(Console.ReadLine());


            //checks if dimensions do not exceed maximum dimensions. If they do, end program. 
            if ((length + height + width) > 50 )
            {
                Console.WriteLine("Package too big to be shipped via Package express. Have a good day!");
                Console.ReadLine();
                Environment.Exit(0);
            };

            //Gets shipping price
            decimal shippingPrice = Math.Round(((Convert.ToDecimal(height) +
                                       Convert.ToDecimal(width) +
                                       Convert.ToDecimal(length)) *
                                       Convert.ToDecimal(weight)) / 100, 2);

           //converts shipping price to string to format for output
           string shippingPriceString = Convert.ToString(shippingPrice);

            //Reformats price to always diplay 2 decimal points.

            if (shippingPriceString.Contains("."))
            {
                if (shippingPriceString.Split('.')[1].Length == 1) {
                    shippingPriceString = shippingPriceString + "0";
                        };
            } else
            {
                shippingPriceString = shippingPriceString + ".00";
            };

            //output total
            Console.WriteLine("Your estimated total for shipping this package is: " + "$" + shippingPriceString);
            Console.WriteLine("Thank you.");
            Console.ReadLine();

        }
    }
}
