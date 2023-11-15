using System;
using System.Collections;

namespace Branching_Assignment
{
    internal class Program
    {
        static void Main()
        {
            
            //Welcome greetings
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter your package details");
            

            //Enter the package Weight
            Console.WriteLine("Please enter package Weight:");
            string Weight = Console.ReadLine();



            //Checks the package Weight
            if (Convert.ToDouble(Weight) > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
                Console.ReadLine();
            }



            //Code will execute if Package weight doesn't exceed maximum
            else
            {
                Console.WriteLine("Please enter package Width:");
                string Width = Console.ReadLine();
                Console.WriteLine("Please enter package Height:");
                string Height = Console.ReadLine();
                Console.WriteLine("Please enter package Length:");
                string Length = Console.ReadLine();



                //Checks if the dimensions total didn't exceed the maximum
                if (Convert.ToDouble(Width) > 50 || Convert.ToDouble(Height) > 50 || Convert.ToDouble(Length) > 50 )
                {
                    Console.WriteLine("Package too big to be shipped via package express");
                    Console.ReadLine();


                }

                //Code will execute if dimensions didn't exceed the maximum
                else
                {
                    
                    //Computes the Quotation for the package
                    double dimensions = (Convert.ToDouble(Width)) * (Convert.ToDouble(Height)) * (Convert.ToDouble(Length));
                    double quote = dimensions * (Convert.ToDouble(Weight))/ 100;
                    decimal quoteamt = Convert.ToDecimal(string.Format("{0:0.00}", quote));
                    Console.WriteLine("Your estimated total for shipping package this package is: $" + quoteamt);
                    Console.ReadLine();
                }




            }

        }
    }
}
