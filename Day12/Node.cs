using System;
using System.Collections.Generic;
using System.Text;

namespace Day12
{
    public class Node
    {
        public string Name { get; set; }
        public List<string> SurroundingNodes { get; set; }

        public bool CanBeVisitedMultipleTimes { get; private set; }

        public bool IsEnd { get; private set; }
        public bool IsStart { get; private set; }

        public Node(string name, string next)
        {
            Name = name;
            SurroundingNodes = new List<string>();
            SurroundingNodes.Add(next);

            CanBeVisitedMultipleTimes = Char.IsUpper(Name[0]);
            IsEnd = Name == "end";
            IsStart = Name == "start";
        }

        public void AddNode(string next)
        {
            SurroundingNodes.Add(next);
        }
    }
}
