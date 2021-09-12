using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();

            
            var aNumber = 0;


            do

                         
                {
                    aNumber++;

                    numbers.Add(aNumber);

                } while (aNumber <100);

                



            // Create a while loop
            // <--- While num is less than 200
               while (aNumber < 200)
            {
                
                 aNumber++;
                
                numbers.Add(aNumber);
                   

            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item}");

            }
            //In the scope of the foreach loop, print each number in numbers



            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1

            //start for loop here
            for(int i=199; i <= numbers.Count && i >=0; i--)
            {
                Console.WriteLine($"{numbers[i]}");
            }

            //------------End of exercise
        }
    }
}
