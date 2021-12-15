using System;
using System.Collections.Generic;
using System.Linq;

namespace Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            // SolveD(InputData.GetInput());

            var managedInput = GenerateVertical(GenerateHorizontal(InputData.GetInput()));
            SolveD2(managedInput, 500);
        }

        static int[] GenerateHorizontal(string[] input)
        {
            var finalRes = new List<int>();
            foreach (var line in input)
            {
                var baseLine = line.ToCharArray().Select(x => x - '0').ToList();
                finalRes.AddRange(baseLine);
                for (int i = 0; i < 4; i++)
                {
                    baseLine = baseLine.Select(x => x == 9 ? 1 : x + 1).ToList();
                    finalRes.AddRange(baseLine);
                }
            }

            return finalRes.ToArray();
        }

        static int[] GenerateVertical(int[] input)
        {
            var finalRes = new List<int>();
            var baseline = input.ToList();
            finalRes.AddRange(baseline);
            for (int i = 0; i < 4; i++)
            {
                baseline = baseline.Select(x => x == 9 ? 1 : x + 1).ToList();
                finalRes.AddRange(baseline);
            }

            return finalRes.ToArray();
        }

        static void SolveD2(int[] input, int partLength)
        {
            int totalLength = input.Length;
            Node[] matrix = new Node[totalLength];
            for (int i = 0; i < input.Length; i++)
            {
                matrix[i] = new Node(i, input[i]);

            }

            matrix[0] = new Node(0, 0);
            matrix[0].PathWeight = 0;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(matrix[0]);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                var near = GetNearbyNodes(matrix, current, partLength, totalLength);
                foreach (var next in near)
                {
                    if (next.PathWeight > current.PathWeight + next.Weight)
                    {
                        next.PathWeight = current.PathWeight + next.Weight;
                        queue.Enqueue(next);
                    }
                }
            }

            Console.WriteLine($"Last weight is {matrix[totalLength - 1].PathWeight}");

        }

        static void SolveD(string[] input)
        {
            int partLength = input[0].Length;
            int totalLength = input.Length * partLength;
            Node[] matrix = new Node[input.Length * partLength];
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    matrix[i * partLength + j] = new Node(i * partLength + j, input[i][j] - '0');
                }
            }

            matrix[0] = new Node(0, 0);
            matrix[0].PathWeight = 0;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(matrix[0]);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                var near = GetNearbyNodes(matrix, current, partLength, totalLength);
                foreach (var next in near)
                {
                    if (next.PathWeight > current.PathWeight + next.Weight)
                    {
                        next.PathWeight = current.PathWeight + next.Weight;
                        queue.Enqueue(next);
                    }
                }
            }

            Console.WriteLine($"Last weight is {matrix[totalLength - 1].PathWeight}");

        }


        static List<Node> GetNearbyNodes(Node[] matrix, Node current, int partLength, int totalLength)
        {
            var result = new List<Node>();
            if (current.Position % partLength != partLength - 1)
            {
                result.Add(matrix[current.Position + 1]);
            }

            if (totalLength - partLength > current.Position)
            {
                result.Add(matrix[current.Position + partLength]);
            }

            if (current.Position % partLength != 0)
            {
                result.Add(matrix[current.Position - 1]);
            }

            if (current.Position >= partLength)
            {
                result.Add(matrix[current.Position - partLength]);
            }

            return result;
        }









        static void Solve(string[] input)
        {
            int partLength = input[0].Length;
            int[] matrix = new int[input.Length * partLength];
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    matrix[i * partLength + j] = input[i][j] - '0';
                }
            }

            var results = new List<long>();
            

            WhatCouldGoWrong(results, matrix, partLength, 0, 0);


            var lightestPath = results.OrderBy(x => x).First();
            Console.WriteLine($"There is {results.Count} paths");
            Console.WriteLine($"Lightest one is {lightestPath} heavy");

        }

        static void WhatCouldGoWrong(List<long> solutions, int[] matrix, int partLength, int pos, long weight)
        {
            if (pos == matrix.Length - 1)
            {
                solutions.Add(weight);
                return;
            }

            if (pos < matrix.Length - partLength)
            {
                var newPos = pos + partLength;
                var downPath = matrix[newPos];
                WhatCouldGoWrong(solutions, matrix, partLength, newPos, weight + downPath);
            }

            if (pos < matrix.Length && pos % partLength != partLength-1)
            {
                var rightPath = matrix[pos+1];
                WhatCouldGoWrong(solutions, matrix, partLength, pos+1, weight + rightPath);
            }
        }

        //TOO SLOW
        //static void WhatCouldGoWrong2(List<Path> solutions, int[] matrix, int partLength, int pos, Path currentPath)
        //{
        //    if (pos == matrix.Length - 1)
        //    {
        //        solutions.Add(currentPath);
        //        return;
        //    }

        //    if (pos < matrix.Length - partLength)
        //    {
        //        var newPos = pos + partLength;
        //        var downPath = currentPath.AddPoint("D", matrix[newPos]);
        //        WhatCouldGoWrong2(solutions, matrix, partLength, newPos, downPath);
        //    }

        //    if (pos < matrix.Length && pos % partLength != partLength - 1)
        //    {
        //        var rightPath = currentPath.AddPoint("D", matrix[pos + 1]);
        //        WhatCouldGoWrong2(solutions, matrix, partLength, pos + 1, rightPath);
        //    }
        //}
    }
}
