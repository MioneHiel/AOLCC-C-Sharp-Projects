using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment


{
    internal class MathOperation
    {
        // Void method that takes two integers as parameters
        public void PerformMathOperation(int number1, int number2)
        {
            // Making a math operation using the first integer 
            int result = number1 * 5;

            // Displaying the second integer to the screen
            Console.WriteLine($"Math operation result: {result}, Second number: {number2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class
            MathOperation mathOperation = new MathOperation();

            // Calling the method in the class, passing in two numbers
            mathOperation.PerformMathOperation(31, 24);

            // Calling the method in the class, specifying the parameters by name
            mathOperation.PerformMathOperation(number1: 18, number2: 20);

            Console.ReadLine();
        }
        
    }
}
