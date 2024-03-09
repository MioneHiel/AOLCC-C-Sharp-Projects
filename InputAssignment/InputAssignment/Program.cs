using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking the user to type a number
            Console.WriteLine("Please type a whole number:");
            // Converting the user input in to an integer
            int number = Convert.ToInt32(Console.ReadLine());
            // Printing the user input
            Console.WriteLine(number);
            // Keeping the console window open until a key is pressed
            Console.ReadLine();
        }
    }
}