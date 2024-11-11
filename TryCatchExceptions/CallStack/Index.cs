using System;

namespace TryCatchExceptions.CallStack
{
    internal class IndexCallStack
    {
        public IndexCallStack()
        {
            IndexMainRun();
        }

        public void IndexMainRun()
        {
            Console.WriteLine("App running before the try block!");

            try
            {
                // Create an instance of LevelOne and call its method directly.
                // LevelOne levelOne = new LevelOne();
                // levelOne.LevelOneMethod();

                // Only calling the constructor without invoking any method.
                LevelOne levelOne = new LevelOne();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in Main: " + ex.Message);
            }

            Console.WriteLine("App running after the try block!");
        }

        //static void LevelOne()
        //{
        //    LevelTwo();
        //}

        //static void LevelTwo()
        //{
        //    throw new Exception("Something went wrong!");
        //}
    }
}
