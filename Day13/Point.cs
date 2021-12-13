using System;
using System.Collections.Generic;
using System.Text;

namespace Day13
{
    public struct Point : IEqualityComparer<Point>, IEquatable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(string input) : this()
        {
            var data = input.Split(",");
            X = Convert.ToInt32(data[0], 10);
            Y = Convert.ToInt32(data[1], 10);
        }

        public Point(int x, int y) : this()
        {
            X = x;
            Y = y;
        }

        public bool Equals(Point other)
        {
            if (X != other.X)
                return false;

            return Y == other.Y;
        }

        public static bool operator ==(Point point1, Point point2)
        {
            return point1.Equals(point2);
        }

        public static bool operator !=(Point point1, Point point2)
        {
            return !point1.Equals(point2);
        }

        public int GetHashCode(Point obj)
        {
            return (obj.X * 10000 + obj.Y).GetHashCode();
        }

        public bool Equals(Point x, Point y)
        {
            return x.Equals(y);
        }
    }

}
