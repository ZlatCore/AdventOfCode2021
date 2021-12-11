using System;
using System.Collections.Generic;
using System.Linq;

namespace Day11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solve1(InputData.GetInput(), 100);
            Solve2(InputData.GetInput());
        }

        static void Solve2(string[] input)
        {
            var lista = new List<int>();
            foreach (var i in input)
            {
                lista.AddRange(i.ToCharArray().Select(x => x - '0'));
            }

            var convertedInput = lista.ToArray();
            DisplayMatrix(convertedInput, 10);
            
            
            for (int i = 1;; i++)
            {
                var flashes = DoOneStep(convertedInput);
                if (flashes == convertedInput.Length)
                {
                    Console.WriteLine($"First big flash is at step {i}");
                    break;
                }
            }

            
        }

        static void Solve1(string[] input, int stepsToSimulate)
        {
            var lista = new List<int>();
            foreach (var i in input)
            {
                lista.AddRange(i.ToCharArray().Select(x => x - '0'));
            }

            var convertedInput = lista.ToArray();
            DisplayMatrix(convertedInput, 10);
            int steps = stepsToSimulate;
            long flashes = 0;
            for (int i = 0; i < steps; i++)
            {
                flashes += DoOneStep(convertedInput);
                DisplayMatrix(convertedInput, 10);
            }

            Console.WriteLine($"First result is {flashes}");
        }

        private static void DisplayMatrix(int[] convertedInput, int baza)
        {
            for (int i = 0; i < baza; i++)
            {
                for (int j = 0; j < baza; j++)
                {
                    Console.Write(convertedInput[baza * i + j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(" =============== ");
        }

        static long DoOneStep(int[] input)
        {
            bool[] flashed = new bool[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                ++input[i];
            }

            bool hadChange = false;
            var counter = 0;
            do
            {
                hadChange = false;
                counter++;
                for (int i = 0; i < input.Length; i++)
                {
                    if (!flashed[i] && input[i] > 9)
                    {
                        flashed[i] = true;
                        hadChange = true;
                        var surr = GetSurrounding(i, 10);
                        foreach (var j in surr)
                        {
                            input[j]++;
                        }
                    }
                }
            } while (hadChange && counter < 100);

            for (int i = 0; i < input.Length; i++)
            {
                if (flashed[i]) 
                {
                    input[i] = 0;
                }
            }

            return flashed.Count(x => x);
        }

        static int[] GetSurrounding(int pos, int baza)
        {
            var results = new List<int>();

            if (pos % baza != 0)
            {
                results.Add(pos - baza - 1);
                results.Add(pos + baza - 1);
                results.Add(pos - 1);
            }

            if (pos % baza != (baza - 1))
            {
                results.Add(pos - baza + 1);
                results.Add(pos + baza + 1);
                results.Add(pos + 1);
            }
            
            results.Add(pos - baza);
           
            
            results.Add(pos + baza);
           
            

            return results.Where(x => x >= 0 && x < 100).ToArray();
        }
    }
}
