using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryCatchExceptions.TryCatch;

namespace TryCatchExceptions.TryCatch
{
    // Declares the IndexTrycatchExampleOne class with internal access modifier,
    // meaning it can only be accessed within this assembly.
    internal class IndexTrycatchExampleOne
    {
        // Public method that contains the main logic for this class.
        public void IndexMainRun()
        {
            // Try Catch Block
            //Console.WriteLine("Try Catch Example");
            // Creates an instance of the TryCatchExampleOne class.
            // This will call the constructor of TryCatchExampleOne, which may execute some code.
            //TryCatchExampleOne tryCatchExampleOne = new TryCatchExampleOne();

            //Finally Example
            //Console.WriteLine("Finally Example");
            //FinallyExample finallyExample = new FinallyExample();
            //DebugExample debug = new DebugExample();

            // Throw Example
            //Console.WriteLine("Throw Example Example");
            //Console.WriteLine("Enter your Age:");
            //string userInput = Console.ReadLine(); // Benutzereingabe erfassen
            //ThrowExample throwExample = new ThrowExample(userInput); // Übergibt die Eingabe an den Konstruktor
            // Der Alterwert wird in der Klasse ThrowExample verarbeitet

            // MultipleExceptions
            //Console.WriteLine("Multiple Exceptions Example");
            //MultipleExceptions multipleExceptions = new MultipleExceptions();

            // DefaultException
            Console.WriteLine("Default Exception");
            DefaultException defaultException = new DefaultException();

        }
    }
}
