using System;
using System.Collections.Generic;
using System.Text;

namespace Day15
{
    public class Node
    {
        public int Position { get; set; }
        public long Weight { get; set; }
        public long PathWeight { get; set; }

        public Node(int pos, long weight) 
        {
            Position = pos;
            Weight = weight;
            PathWeight = long.MaxValue;
        }
    }
}
