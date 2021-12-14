using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day14
{
    class Program
    {
        static void Main(string[] args)
        {
            Solve(InputData.GetInput());
        }

        static void Solve(string[] input)
        {
            var conversion = new Dictionary<string, string[]>();
            for (int i = 1; i < input.Length; i++)
            {
                var split = input[i].Split(" -> ");
                string[] product = new string[2]
                    {
                        $"{split[0][0]}{split[1]}",
                        $"{split[1]}{split[0][1]}"

                    };
                conversion.Add(split[0], product);
            }

            var resultAfter = new Dictionary<string, long>();
            for (int i = 1; i < input[0].Length; i++)
            {
                var newKey = $"{input[0][i - 1]}{input[0][i]}";
                resultAfter.TryGetValue(newKey, out var addcount);
                resultAfter[newKey] = addcount + 1;
            }

            string first = $"{input[0][0]}{input[0][1]}";
            string last = $"{input[0][input[0].Length-1]}{input[0][input[0].Length - 2]}";

            for (int i = 0; i < 40; i++)
            {
                first = conversion[first][0];
                last = conversion[last][1];
                resultAfter = OneDayChange(conversion, resultAfter);
            }

            var res = GetScore(resultAfter, first, last);

            Console.WriteLine($"Result is: {res}");
        }



        static Dictionary<string, long> OneDayChange(Dictionary<string, string[]> conversion, Dictionary<string, long> input)
        {
            var result = new Dictionary<string, long>();

            foreach (var pair in input)
            {
                if (conversion.TryGetValue(pair.Key, out var products))
                {
                    foreach (var p in products)
                    {
                        result.TryGetValue(p, out long count);
                        result[p] = count + pair.Value;
                    }
                }
            }

            return result;
        }

        
        static long GetScore(Dictionary<string, long> input, string first, string last)
        {
            var dict = new Dictionary<char, long>();
            foreach (var pair in input)
            {
                dict.TryGetValue(pair.Key[0], out long c1);
                dict[pair.Key[0]] = c1 + pair.Value;
                dict.TryGetValue(pair.Key[1], out long c2);
                dict[pair.Key[1]] = c2 + pair.Value;
            }

            input.TryGetValue(first, out long fc1);
            dict[first[0]] += fc1;

            input.TryGetValue(last, out long fc2);
            dict[last[1]] += fc2;

            foreach (var key in dict.Keys.ToList())
            {
                dict[key] /= 2;
            }

            var sorted = dict.OrderByDescending(x => x.Value).ToList();
            return sorted[0].Value - sorted[sorted.Count() - 1].Value +1;
        }
    }
}
