using System;


namespace BooleanLogic
{
    internal class Program
    {
        static void Main()
        {
            //Console Heading
            Console.WriteLine("Car Insurance Application");

            //Asking for age
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            //Asking for DUI
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            string answer = Console.ReadLine().ToLower();
            bool dui = answer == "yes";

            //Asking for Speeding Tickets
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            //Checking if Qualified for Insurance
            Console.WriteLine("Qualified for Insurance?");
            bool qualified = (age > 15) && !dui && (tickets <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
