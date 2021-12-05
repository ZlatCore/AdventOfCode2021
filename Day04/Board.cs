using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day04
{
    public class Board
    {
        private int[,] board;
        private bool[,] hitNumbers;
        public Board(List<string> boardInput)
        {
            board = new int[5, 5];
            hitNumbers = new bool[5, 5];
            for (int i = 0; i < 5; i++)
            {
                var lineInput1 = boardInput[i].Replace("  ", " ").Split(" ").Where(x => !string.IsNullOrEmpty(x)).ToList();
                var lineInput = lineInput1.Select(x => Convert.ToInt32(x, 10)).ToList();
                for (int j = 0; j < 5; j++)
                {
                    board[i,j] = lineInput[j];
                    hitNumbers[i, j] = false;
                }
            }
        }

        public int CheckForNumber(int number)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (board[i, j] == number)
                    {
                        hitNumbers[i, j] = true;
                        if (checkBingo())
                        {
                            return getSum() * number;
                        }
                    }
                }
            }

            return 0;
        }

        private bool checkBingo()
        {
            for (int i = 0; i < 5; i++)
            {
                var horizontal = true;
                var vertical = true;
                for (int j = 0; j < 5; j++)
                {
                    horizontal &= hitNumbers[i, j];
                    vertical &= hitNumbers[j, i];
                }

                if (horizontal || vertical)
                {
                    return true;
                }
            }

            return false;
        }

        private int getSum()
        {
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sum += hitNumbers[i, j] ? 0 : board[i, j];
                }
            }

            return sum;
        }


    }
}
