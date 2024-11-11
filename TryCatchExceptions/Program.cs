using System; // Importing System namespace for basic functions like Console.
using TryCatchExceptions.CallStack;
using TryCatchExceptions.TryCatch; // Importing the namespace that contains the IndexTrycatchExampleOne class.

namespace TryCatchExceptions
{
    internal class Program
    {
        // The Main method is the entry point of the application.
        static void Main(string[] args)
        {
            // Creating an instance of the IndexTrycatchExampleOne class.
            //IndexTrycatchExampleOne indexTrycatchExampleOne = new IndexTrycatchExampleOne();

            //TryCatch Folder
            // Calling the IndexMainRun method of the created instance.
            //indexTrycatchExampleOne.IndexMainRun();

            // CallStack folder
            IndexCallStack indexCallStack = new IndexCallStack();

            // Waiting for a key press before closing the console window.
            Console.ReadKey();
        }
    }
}
