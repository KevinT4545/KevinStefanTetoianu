using System;

namespace ProjectApp1
{
    public static class LoopDemonstrations
    {
        public static void DemonstrateLoops()
        {
            Console.WriteLine("For Loop demonstration:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Count: {i}");
            }

            Console.WriteLine("\nWhile Loop demonstration:");
            int count = 1;
            while (count <= 10)
            {
                Console.WriteLine($"Count: {count}");
                count++;
            }
        }
    }
}