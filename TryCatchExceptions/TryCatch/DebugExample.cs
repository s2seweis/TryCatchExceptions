using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExceptions.TryCatch
{
    internal class DebugExample
    {
        public DebugExample()
        {
            DebugMethod();
        }

        private void DebugMethod()
        {
            int result = 0; // Initialize the result variable.

            Debug.WriteLine("Main method is running!");

            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = int.Parse(Console.ReadLine()); // Convert the input string to an integer.
                int num2 = 20;
                result = num2 / num1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                //Debug.WriteLine("Line:500", ex.StackTrace);
                //Debug.WriteLine(ex.StackTrace);
                // This next line is only executed during "Debugging"
                Debug.WriteLine(ex.ToString());
            }

            Console.WriteLine("Result: " + result);
        }
    }
}

// Clean Debug Console = Strg + Alt + A
