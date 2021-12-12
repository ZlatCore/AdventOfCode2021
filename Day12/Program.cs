using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day12
{
    class Program
    {
        static void Main(string[] args)
        {
            Solve(InputData.GetInput());
        }

        private static void Solve(string[] input)
        {
            var nodes = new Dictionary<string, Node>();

            foreach (var s in input)
            {
                var split = s.Split("-");
                if (nodes.ContainsKey(split[0]))
                {
                    nodes[split[0]].AddNode(split[1]);
                }
                else
                {
                    nodes.Add(split[0], new Node(split[0], split[1]));
                }

                if (nodes.ContainsKey(split[1]))
                {
                    nodes[split[1]].AddNode(split[0]);
                }
                else
                {
                    nodes.Add(split[1], new Node(split[1], split[0]));
                }
            }

            var startNode = nodes["start"];
            var results = new HashSet<string>();
            WhatCouldGoWrongWithRecursion(nodes, results, new List<Node>(), startNode, false); //for part one, just set last one to true;

            Console.WriteLine($"Number of results is {results.Count}");
        }

        private static void WhatCouldGoWrongWithRecursion(Dictionary<string, Node> nodes, HashSet<string> results, List<Node> path, Node current, bool visitedSmallTwice)
        {
            var newPath = new List<Node>();
            newPath.AddRange(path);
            newPath.Add(current);
            if (current.IsEnd)
            {
                results.Add(GetStringFromNodeList(path.ToArray()));
                return;
            }

            foreach (var newNode in current.SurroundingNodes)
            {
                var foundNode = newPath.Where(x => x.Name == newNode).FirstOrDefault();
                if (foundNode != null && !foundNode.CanBeVisitedMultipleTimes)
                {
                    if (!visitedSmallTwice && !foundNode.IsStart)
                    {
                        WhatCouldGoWrongWithRecursion(nodes, results, newPath, foundNode, true);
                    }
                    continue;
                }

                WhatCouldGoWrongWithRecursion(nodes, results, newPath, nodes[newNode], visitedSmallTwice);
            }
        }

        private static string GetStringFromNodeList(Node[] path)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(path[0].Name);
            for (int i = 1; i < path.Length; i++)
            {
                sb.Append(",").Append(path[i].Name);
            }

            return sb.ToString();
        }
    }
}
