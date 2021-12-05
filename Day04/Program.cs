using System;
using System.Collections.Generic;
using System.Linq;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            Solve1();
            Solve2();
        }

        static void Solve1()
        {
            var boardsData = InputData.GetInputBoards();
            var numbers = InputData.GetInputNumbers();
            var boards = new List<Board>();

            var count = 0;
            var newList = new string[5];
            for (int i = 0; i < boardsData.Length; i++)
            {
                if (boardsData[i].Length < 4)
                {
                    continue;
                }

                newList[count] = boardsData[i];
                count++;
                if (count == 5)
                {
                    boards.Add(new Board(newList.ToList()));
                    count = 0;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                foreach (var board in boards)
                {
                    var res = board.CheckForNumber(numbers[i]);
                    if (res > 0)
                    {
                        Console.WriteLine(res);
                        return;
                    }
                }                    
            }

            Console.WriteLine("ERROR");
        }

        static void Solve2()
        {
            var boardsData = InputData.GetInputBoards();
            var numbers = InputData.GetInputNumbers();
            var boards = new List<Board>();

            var count = 0;
            var newList = new string[5];
            for (int i = 0; i < boardsData.Length; i++)
            {
                if (boardsData[i].Length < 4)
                {
                    continue;
                }

                newList[count] = boardsData[i];
                count++;
                if (count == 5)
                {
                    boards.Add(new Board(newList.ToList()));
                    count = 0;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                var boardsToRemove = new List<Board>();
                foreach (var board in boards)
                {
                    var res = board.CheckForNumber(numbers[i]);
                    if (res > 0)
                    {
                        if (boards.Count < 2)
                        {
                            Console.WriteLine(res);
                            return;
                        }

                        boardsToRemove.Add(board);
                    }
                }

                boards.RemoveAll(x => boardsToRemove.Contains(x));
                boardsToRemove.Clear();
            }

            Console.WriteLine("ERROR");
        }

    }
}
