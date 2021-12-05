using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Day05
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

        public int GetHashCode([DisallowNull] Point obj)
        {
            return (obj.X * 10000 + obj.Y).GetHashCode();
        }

        public bool Equals( Point x, Point y)
        {
            return x.Equals(y);
        }
    }

    public class Line
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public bool IsSlanted { get; private set; }

        public Line(string input)
        {
            var data = input.Split(" -> ");
            StartPoint = new Point(data[0]);
            EndPoint = new Point(data[1]);

            IsSlanted = (StartPoint.X != EndPoint.X) && (StartPoint.Y != EndPoint.Y);
        }

        public List<Point> GetPoints(bool includeSlanted = false)
        {
            var result = new List<Point>();
            if (!includeSlanted && IsSlanted)
            {
                return result;
            }

            var tmp = new Point(StartPoint.X, StartPoint.Y);
            result.Add(tmp);
            var count = 0;
            do
            {

                count++;
                var diffX = (EndPoint.X - tmp.X);
                var diffY = (EndPoint.Y - tmp.Y);
                if (diffX != 0)
                {
                    diffX = diffX / Math.Abs(diffX);
                }

                if (diffY != 0)
                {
                    diffY = diffY / Math.Abs(diffY);
                }

                tmp = new Point(tmp.X + diffX, tmp.Y + diffY);
                result.Add(tmp);

            } while (tmp != EndPoint || count > 10000);

            return result;
        }
    }
}
