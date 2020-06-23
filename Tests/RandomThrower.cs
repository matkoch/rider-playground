using System;

namespace Tests
{
    public static class RandomThrower
    {
        public static void M ()
        {
            if (new Random().Next(0, 1) == 2)
                throw new Exception();
        }
    }
}