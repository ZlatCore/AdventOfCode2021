using System;
using System.Collections.Generic;
using System.Linq;

namespace Day09
{
    class Program
    {
        static void Main(string[] args)
        {
              Solve1(InputData.GetInput());
            Solve2(InputData.GetInput());

        }

        static void Solve1(string[] input)
        {
            int length = input[0].Length;
            var inputarr = input.SelectMany(x => x.ToCharArray().Select(c => (byte)(c - '0'))).ToArray();

            var found = new List<byte>();
            for (int i = 0; i < inputarr.Length; i++)
            {
                if (CheckNearby(inputarr, length, i))
                {
                    found.Add(inputarr[i]);
                }
            }

            var result = 0;
            found.ForEach(x => result += x + 1);
            Console.WriteLine($"result is {result}");
        }

        public static bool CheckNearby(byte[] matrix, int length, int i)
        {
            bool lowest = true;
            if (i > length)
            {
                lowest &= matrix[i] < matrix[i - length];
            }

            if (i < matrix.Length - length)
            {
                lowest &= matrix[i] < matrix[i + length];
            }

            if (i % length > 0)
            {
                lowest &= matrix[i] < matrix[i - 1];
            }
            if (i% length < length -1)
            {
                lowest &= matrix[i] < matrix[i + 1];
            }

            return lowest;

        }


        static void Solve2(string[] input)
        {
            int length = input[0].Length;
            var inputarr = input.SelectMany(x => x.ToCharArray().Select(c => (byte)(c - '0'))).ToArray();

            var found = new List<int>();
            for (int i = 0; i < inputarr.Length; i++)
            {
                if (CheckNearby(inputarr, length, i))
                {
                    found.Add(i);
                }
            }

            var results = found.Select(x => FindBasinSize(inputarr, length, x))
                .OrderByDescending(x => x)
                .Take(3).ToList();

            var result = results[0] * results[1] * results[2];
            Console.WriteLine($"result is {result}");
        }

        static int FindBasinSize(byte[] input, int length, int lowpoint)
        {
            bool[] visited = new bool[input.Length];
            VisitNearby(input, visited, length, lowpoint);
            
            return visited.Count(x => x);
        }

        static void VisitNearby(byte[] input, bool[] visited, int length, int point)
        {
            if (visited[point] || input[point] > 8)
            {
                return;
            }

            visited[point] = true;

            if (point > length)
            {
                VisitNearby(input, visited, length, point - length);
            }

            if (point < input.Length - length)
            {
                VisitNearby(input, visited, length, point + length);
            }

            if (point%length > 0)
            {
                VisitNearby(input, visited, length, point -1);
            }

            if (point % length < length -1)
            {
                VisitNearby(input, visited, length, point + 1);
            }
        }
    }
}
