using System;


namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main()
        {
            //Do while loop
            int count = 0;
            do
            {
                Console.WriteLine("Inside the loop");
                
                //Add one to count each time
                count++;
            }
            
            //Continue to loop until count reaches 5
            while (count < 5);


            //This is the while loop
            int counting = 0;
           
            
            //Continue to loop until count reaches 3
            while (counting < 3) 
            {
                Console.WriteLine("Counting Numbers");
               
                
                //Add one to counting each time
                counting++;
            }
            Console.ReadLine();
        }
    }
}
