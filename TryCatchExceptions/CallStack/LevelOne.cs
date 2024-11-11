using System;

namespace TryCatchExceptions.CallStack
{
    internal class LevelOne
    {
        public LevelOne()
        {
            LevelOneMethod();
        }
        public void LevelOneMethod()
        {
            try
            {
                LevelTwo.LevelTwoMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught in LevelOne: {ex.Message}");
            }
        }
    }
}
