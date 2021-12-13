using System;
using System.Collections.Generic;
using System.Linq;

namespace Day13
{
    class Program
    {
        static void Main(string[] args)
        {
            Solve(InputData.GetInput());
        }

        static void Solve(string[] input)
        {
            var startingPoints = new List<Point>();
            var folds = new List<(char, int)>();

            foreach (var i in input)
            {
                if (string.IsNullOrEmpty(i))
                {
                    continue;
                }

                if (Char.IsNumber(i[0]))
                {
                    startingPoints.Add(new Point(i));
                    continue;
                }

                var split = i.Split(" ");
                var split2 = split[2].Split("=");
                folds.Add((split2[0][0], int.Parse(split2[1])));
            }

            var result1 = DoFold(startingPoints, folds.First());

            Console.WriteLine($"Points after first fold: {result1.Count}");

            var result2 = new List<Point>();
            result2.AddRange(startingPoints);
            foreach (var fold in folds)
            {
                result2 = DoFold(result2, fold);
            }

            var maxX = result2.Aggregate(0, (x, i) => x > i.X ? x : i.X) +1;
            var maxY = result2.Aggregate(0, (y, i) => y > i.Y ? y : i.Y) +1;
            Console.WriteLine($"Points after all folds: {result2.Count}");
            bool[,] drawing = new bool[maxX+1, maxY];
            for (int i = 0; i < result2.Count; i++)
            {
                drawing[result2[i].X,result2[i].Y] = true;
            }


           // Solution for day 2 needs to be visually detected in console.
            for (int i = 0; i < maxY; i++)
            {
                for (int j = 0; j < maxX; j++)
                {
                    Console.Write(drawing[j, i] ? "#" : ".");
                }
                Console.WriteLine();
            }

        }

        static List<Point> DoFold(List<Point> Input, (char, int) foldPosition)
        {
            if (foldPosition.Item1 == 'x')
            {
                return DoXFold(Input, foldPosition.Item2);
            }
            else if (foldPosition.Item1 == 'y')
            {
                return DoYFold(Input, foldPosition.Item2);
            }

            return new List<Point>();
        }

        static List<Point> DoXFold(List<Point> input, int foldPos)
        {
            HashSet<Point> result = new HashSet<Point>();
            foreach (var i in input)
            {
                if (i.X <= foldPos)
                {
                    result.Add(i);
                    continue;
                }

                var diff = i.X - foldPos;
                result.Add(new Point(foldPos - diff, i.Y));
            }

            return result.ToList();
        }

        static List<Point> DoYFold(List<Point> input, int foldPos)
        {
            HashSet<Point> result = new HashSet<Point>();
            foreach (var i in input)
            {
                if (i.Y <= foldPos)
                {
                    result.Add(i);
                    continue;
                }

                var diff = i.Y - foldPos;
                result.Add(new Point(i.X, foldPos - diff));
            }

            return result.ToList();
        }
    }
}
