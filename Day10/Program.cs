using System;
using System.Linq;
using System.Collections.Generic;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
           // Solve1(InputData.GetInput());
            Solve2(InputData.GetInput());
        }

        static void Solve1(string[] input)
        {
            var errors = input.Select(x => GetFirstIllegalChar(x));

            Console.WriteLine($"Sum of errors is {errors.Sum(x => x.Item1)}");
        }

        static void Solve2(string[] input)
        {
            var notCorrupted = input.Select(x => GetFirstIllegalChar(x)).Where(x => x.Item1 == 0).ToList();

            var scores = notCorrupted.Select(x => GetScoreByStack(x.Item2)).Where(x => x > 0).OrderBy(x => x).ToList();
            var toGet = (scores.Count() - 1) / 2;

            foreach (var s in scores)
            {
                Console.WriteLine($"{s}");
            }

            var result = scores[toGet];

            Console.WriteLine($"Solve2 result: {result}");
        }


        static (int, Stack<char>) GetFirstIllegalChar(string input)
        {
            var stek = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '('
                 || input[i] == '['
                 || input[i] == '{'
                 || input[i] == '<')
                {
                    stek.Push(input[i]);
                    continue;
                }

                if (input[i] == ']')
                {
                    var top = stek.Count > 0 ? stek.Pop() : '0';
                    if (top != '[')
                    {
                        return (57, stek);
                    }
                }

                if (input[i] == ')')
                {
                    var top = stek.Count > 0 ? stek.Pop() : '0';
                    if (top != '(')
                    {
                        return (3, stek);
        }
                }

                if (input[i] == '}')
                {
                    var top = stek.Count > 0 ? stek.Pop() : '0';
                    if (top != '{')
                    {
                        return (1197, stek);
                    }
                }

                if (input[i] == '>')
                {
                    var top = stek.Count > 0 ? stek.Pop() : '0';
                    if (top != '<')
                    {
                        return (25137, stek);
    }
                }
            }

            return (0, stek);
        }

        static long GetScoreByStack(Stack<char> stek)
        {
            long score = 0;

            while (stek.Count > 0)
            {
                var current = stek.Pop();
                score *= 5;
                if (current == '(')
                { 
                    score += 1;
                }
                if (current == '[')
                {
                    score += 2;
                }
                if (current == '{')
                {
                    score += 3;
                }
                if (current == '<')
                {
                    score += 4;
                }
            }

            return score;
        }
    }
}
