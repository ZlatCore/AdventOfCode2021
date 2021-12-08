using System;
using System.Linq;
using System.Collections.Generic;

namespace Day08
{
    class Program
    {
        static void Main(string[] args)
        {
           // Solve1(InputData.GetInput());
            Solve2(InputData.GetInput());
        }

        public static void Solve1(string[] input)
        {
            var rightSide = new List<string>();
            foreach (var x in input)
            { 
                var res = x.Split(" | ");
                rightSide.AddRange(res[1].Split(" "));
            }

            var count = rightSide.Count(x =>
                x.Length == 2
                || x.Length == 3
                || x.Length == 4
                || x.Length == 7
            );

            Console.WriteLine($"First result is {count}");
        }

        public static void Solve2(string[] input)
        {
            var res = 0;
            foreach (var i in input)
            {
                res += SolveRow(i);
            }

            Console.WriteLine($"result {res}");
        }

        public static int SolveRow(string input)
        {
            var data = input.Split(" | ");

            var hints = data[0].Split(" ");
            var number = data[1].Split(" ");

            var cHints = hints.Select(x => x.ToCharArray().ToHashSet());
            var cNumber = number.Select(x => x.ToCharArray().ToHashSet()).ToArray();

            var decrypt = new HashSet<char>[10];
            decrypt[1] = cHints.Where(x => x.Count == 2).FirstOrDefault();
            decrypt[4] = cHints.Where(x => x.Count == 4).FirstOrDefault();
            decrypt[7] = cHints.Where(x => x.Count == 3).FirstOrDefault();
            decrypt[8] = cHints.Where(x => x.Count == 7).FirstOrDefault();
            var tmp5 = cHints.Where(x => x.Count == 5);
            var tmp6 = cHints.Where(x => x.Count == 6);
            foreach (HashSet<char> a in tmp5)
            {
                var b = new HashSet<char>();
                b.UnionWith(a.ToList());
                b.ExceptWith(decrypt[7]);
                if (b.Count == 2)
                {
                    decrypt[3] = a;
                }
            }
            foreach (HashSet<char> a in tmp6)
            {
                var b = new HashSet<char>();
                b.UnionWith(a.ToList());
                b.ExceptWith(decrypt[7]);
                if (b.Count == 4)
                {
                    decrypt[6] = a;
                }
            }
            tmp5 = tmp5.Where(x => !x.SetEquals(decrypt[3]));
            tmp6 = tmp6.Where(x => !x.SetEquals(decrypt[6]));
            foreach (HashSet<char> a in tmp5)
            {
                var b = new HashSet<char>();
                b.UnionWith(a.ToList());
                b.ExceptWith(decrypt[3]);
                b.ExceptWith(decrypt[4]);
                if (b.Count == 1)
                {
                    decrypt[2] = a;
                }
                if (b.Count == 0)
                {
                    decrypt[5] = a;
                }
            }
            foreach (HashSet<char> a in tmp6)
            {
                var b = new HashSet<char>();
                b.UnionWith(a.ToList());
                b.ExceptWith(decrypt[3]);
                if (b.Count == 2)
                {
                    decrypt[0] = a;
                }
                if (b.Count == 1)
                {
                    decrypt[9] = a;
                }
            }

            int[] resultDigits = new int[4];
            for (int i = 0; i < resultDigits.Length; i++)
            {
                for (int j = 0; j < decrypt.Length; j++)
                {
                    if (cNumber[i].SetEquals(decrypt[j]))
                    {
                        resultDigits[i] = j;
                        break;
                    }
                }
            }

            return resultDigits[0] * 1000 + resultDigits[1] * 100 + resultDigits[2] * 10 + resultDigits[3];

        }
    }
}
