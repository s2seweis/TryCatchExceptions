using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExceptions.TryCatch
{
    // Define the TryCatchExampleOne class as internal, meaning it can only be accessed within this assembly.
    internal class TryCatchExampleOne
    {
        // Constructor of the TryCatchExampleOne class.
        // This is called automatically when an object of this class is created.
        public TryCatchExampleOne()
        {
            // Call the TryCatchExampleOneMethod inside the constructor.
            TryCatchExampleOneMethod();
        }

        // Private method that contains the main logic for demonstrating try-catch exception handling.
        private void TryCatchExampleOneMethod()
        {
            int result = 0; // Initialize the result variable.

            try
            {
                // Attempt to read a number from the user and parse it.
                Console.WriteLine("Please enter a number");
                int num1 = int.Parse(Console.ReadLine()); // Convert the input string to an integer.

                // Initialize num2 with a value of 20.
                int num2 = 20;

                // Perform division and store the result.
                // This could throw a DivideByZeroException if num1 is 0.
                result = num2 / num1;
            }
            // Catch any exception that occurs during the try block.
            catch (Exception ex)
            {
                // Print the exception message to the console.
                Console.WriteLine("Error: " + ex.Message);
            }

            // Display the result of the division. If an exception occurred, result will still be 0.
            Console.WriteLine("Result: " + result);
        }
    }
}
