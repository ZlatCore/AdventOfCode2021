using System;
using System.Collections.Generic;
using System.Linq;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            Solve2();
        }

        static void Solve1()
        {
            var data = InputData.GetInput();
            var lineList = data.Select(x => new Line(x)).ToList();

            var pointList = lineList.SelectMany(x => x.GetPoints()).ToList();

            var dict = new Dictionary<Point, int>();

            foreach (var p in pointList)
            {
                dict.TryGetValue(p, out var currentCount);
                dict[p] = currentCount + 1;
            }

            var result = dict.Where(x => x.Value > 1).Count();

          //  var result = pointList.GroupBy(x => x).ToList();
            //    .Where(g => g.Count() > 1)
            //    .Count();

            Console.WriteLine($"Result is: {result}");


        }

        static void Solve2()
        {
            var data = InputData.GetInput();
            var lineList = data.Select(x => new Line(x)).ToList();

            var pointList = lineList.SelectMany(x => x.GetPoints(true)).ToList();

            var dict = new Dictionary<Point, int>();

            foreach (var p in pointList)
            {
                dict.TryGetValue(p, out var currentCount);
                dict[p] = currentCount + 1;
            }

            var result = dict.Where(x => x.Value > 1).Count();

            //  var result = pointList.GroupBy(x => x).ToList();
            //    .Where(g => g.Count() > 1)
            //    .Count();

            Console.WriteLine($"Result is: {result}");


        }
    }
}
