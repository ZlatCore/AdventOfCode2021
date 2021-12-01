using System;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            Solve1(InputData.GetInput());
            Solve2(InputData.GetInput());
            Console.ReadKey();
        }

        static void Solve1(int[] input)
        {
            var inc = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > input[i - 1])
                {
                    inc++;
                }
            }

            Console.WriteLine(inc);
            
        }

        static void Solve2(int[] input)
        {
            var inc = 0;
            for (int i = 3; i < input.Length; i++)
            {
                if (input[i - 3] < input[i])
                {
                    inc++;
                }
            }

            Console.WriteLine(inc);
        }
    }
}
