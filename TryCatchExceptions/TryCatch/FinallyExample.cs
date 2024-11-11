using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExceptions.TryCatch
{
    internal class FinallyExample
    {
        public FinallyExample()
        {
            FinallyMethod();
        }

        private void FinallyMethod()
        {
            int result = 0; // Initialize the result variable.

            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = int.Parse(Console.ReadLine()); // Convert the input string to an integer.
                int num2 = 20;
                result = num2 / num1;
                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            } finally
            {
                // This code executes no matter what!
                // Code to cleanup or finalize
                // Ideal for cleaning up resources
                // Like closing file streams or database connections 
                Console.WriteLine("This always executes");
            }
        }
    }
}
