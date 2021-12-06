using System;
using System.Collections.Generic;
using System.Linq;

namespace Day06
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysToCheck1= 80;
            var daysToCheck2 = 256;

            Solve1(daysToCheck1);
            Solve2(daysToCheck2);
        }

        static void Solve1(int daysToCheck)
        {
            var list = InputData.GetTestInput().ToList();
            for (int i = 0; i < daysToCheck; i++)
            {
                list = Solve1ForDay(list);
            }

            Console.WriteLine($"There is {list.Count} fish");

        }

        static List<int> Solve1ForDay(List<int> input)
        {
            var newFish = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (--input[i] < 0)
                {
                    input[i] = 6;
                    newFish.Add(8);
                }
            }

            input.AddRange(newFish);
            return input;
        }

        static void Solve2(int daysToCheck)
        {
            long[] arrangedInput = new long[9];

            var input = InputData.GetInput();
            for (int i = 0; i < arrangedInput.Length; i++)
            {
                arrangedInput[i] = input.Where(x => x == i).Count();
            }

            for (int i = 0; i < daysToCheck; i++)
            {
                arrangedInput = Solve2ForDay(arrangedInput);
            }

            var result = arrangedInput.Sum();
            Console.WriteLine($"There is {result} fish");
        }

        static long[] Solve2ForDay(long[] input)
        {
            long tmp = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                input[i - 1] = input[i];
            }
            input[6] += tmp;
            input[8] = tmp;

            return input;
        }
    }
}
