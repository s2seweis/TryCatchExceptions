using System;

namespace TryCatchExceptions.CallStack
{
    internal class LevelTwo
    {
        public static void LevelTwoMethod()
        {
            throw new Exception("Something went wrong!");
        }
    }
}
