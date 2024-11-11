using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExceptions.TryCatch
{
    internal class MultipleExceptions
    {
        public MultipleExceptions()
        {
            MultipleExceptionsMethod();
        }

        private void MultipleExceptionsMethod()
        {
            int result = 0; // Initialize the result variable.

            Debug.WriteLine("Main method is running!");

            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = int.Parse(Console.ReadLine()); // Convert the input string to an integer.
                int num2 = 20;
                result = num2 / num1;

                Console.WriteLine("Result: " + result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Dont divide by zero! " + ex.Message);

            } catch(FormatException ex)
            {
                Console.WriteLine("I told you to enter a number! " + ex.Message);
            } catch(OverflowException ex)
            {
                Console.WriteLine("Number to high!" + ex.Message);
            }catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                //Debug.WriteLine(ex.ToString());
            } finally
            {
                Console.WriteLine("This code will always be executed!");
            }

            //Console.WriteLine("Result: " + result);
        }
    }
}

