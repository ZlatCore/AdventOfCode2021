using System;
using System.Linq;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            Solve1(InputData.GetInput());
            Solve2(InputData.GetInput());
        }
        

        static void Solve1(int[] input)
        {
            var max = input.Aggregate((x, i) => x > i ? x : i);
            var min = input.Aggregate((x, i) => x < i ? x : i);

            var result = GetFuelForNumber1(input, min);
            for (int i = min + 1; i <= max; i++)
            {
                var tmp = GetFuelForNumber1(input, i);
                result = tmp < result ? tmp : result;
            }

            Console.WriteLine($"Result: {result}");
        }

        private static int GetFuelForNumber1(int[] input, int number)
        {
            return input.Select(x => Math.Abs(x - number)).Sum();
        }

        static void Solve2(int[] input)
        {
            var max = input.Aggregate((x, i) => x > i ? x : i);
            var min = input.Aggregate((x, i) => x < i ? x : i);

            var result = GetFuelForNumber2(input, min);
            for (int i = min + 1; i <= max; i++)
            {
                var tmp = GetFuelForNumber2(input, i);
                result = tmp < result ? tmp : result;
            }

            Console.WriteLine($"Result: {result}");
        }

        private static int GetFuelForNumber2(int[] input, int number)
        {
            return input.Select(x => GetFuelForStep(x, number)).Sum();
        }

        private static int GetFuelForStep(int a, int b)
        {
            var diff = Math.Abs(a - b);
            return (diff * (diff + 1)) / 2;
                
        }
    }
}
