using System;

namespace Day02
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
            var hor = 0;
            var ver = 0;

            foreach (var ins in input)
            {
                var data = ins.Split(" ");

                int moveValue = int.Parse(data[1]);
                if (data[0] == "forward")
                {
                    hor += moveValue;
                    continue;
                }
                if (data[0] == "down")
                {
                    ver += moveValue;
                    continue;
                }
                if (data[0] == "up")
                {
                    ver -= moveValue;
                    continue;
                }

                Console.WriteLine("Error!");
            }

            
            Console.WriteLine($"horizontal: {hor}, Vertical: {ver}, for a total of {hor * ver}");
        }

        static void Solve2(string[] input)
        {
            var hor = 0;
            var aim = 0;
            var depth = 0;

            foreach (var ins in input)
            {
                var data = ins.Split(" ");

                int moveValue = int.Parse(data[1]);
                if (data[0] == "forward")
                {
                    hor += moveValue;
                    depth += aim * moveValue;
                    continue;
                }
                if (data[0] == "down")
                {
                    aim += moveValue;
                    continue;
                }
                if (data[0] == "up")
                {
                    aim -= moveValue;
                    continue;
                }

                Console.WriteLine("Error!");
            }


            Console.WriteLine($"hor: {hor}, depth: {depth}, for a total of {hor * depth}");
        }
    }
}
