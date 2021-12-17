using System;

namespace Day17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[4] { 143, 177, -106, -71 };
            Solve2(input);
        }

        static void Solve2(int[] input)
        {
            var count = 0;

            for (int x = 1; x < 178; x++)
            {
                
                for (int y = -106; y < 106; y++)
                {
                    count += CheckVector(input, x, y) ? 1 : 0;
                }
            }

            Console.WriteLine(count);
        }

        static bool CheckVector(int[] target, int x, int y)
        {
            var velx = x;
            var vely = y;
            var currentx = 0;
            var currenty = 0;
            for (int i = 0; i < 999; i++)
            {
                currentx += velx;
                currenty += vely;
                velx = Math.Max(0, velx - 1);
                vely--;

                if (currentx >= target[0] && currentx <= target[1]
                 && currenty >= target[2] && currenty <= target[3])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
