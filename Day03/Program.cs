using System;
using System.Linq;

namespace Day03
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
            var counts = new int[input[0].Length];

            foreach (var single in input)
            {
                for (int i = 0; i < counts.Length; i++)
                {
                    if (single[i] == '1')
                    {
                        counts[i]++;
                    }
                }
            }

            var len = input.Length;
            var final1 = string.Empty;
            var final2 = string.Empty;
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > counts.Length - counts[i])
                {
                    final1 = $"{final1}1";
                    final2 = $"{final2}0";
                }
                else
                {
                    final1 = $"{final1}0";
                    final2 = $"{final2}1";
                }
            }

            var result1 = Convert.ToInt32(final1, 2);
            var result2 = Convert.ToInt32(final2, 2);

            Console.WriteLine(result1 * result2);

        }

        static void Solve2(string[] input)
        {
            var counts = input[0].Length;
            var tmpInput1 = input.ToList();
            for (int i = 0; i < counts; i++)
            {
                var higher = tmpInput1.Where(a => a[i] == '1').ToList();
                var lower = tmpInput1.Where(a => a[i] == '0').ToList();
                tmpInput1 = higher.Count >= lower.Count ? higher : lower;
            }

            var final1 = tmpInput1.First();

            var tmpInput2 = input.ToList();
            for (int i = 0; i < counts; i++)
            {
                var higher = tmpInput2.Where(a => a[i] == '1').ToList();
                var lower = tmpInput2.Where(a => a[i] == '0').ToList();
                tmpInput2 = higher.Count >= lower.Count ? lower : higher;
                if (tmpInput2.Count < 2)
                {
                    break;
                }
            }

            var final2 = tmpInput2.First();

            var result1 = Convert.ToInt32(final1, 2);
            var result2 = Convert.ToInt32(final2, 2);

            Console.WriteLine(result1 * result2);
        }
    }
}
