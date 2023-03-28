using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaHomeTask1.Task1
{
    public class MatrixSpiralSnake
    {
        private int[,] array;
        public int N { get; private set; }
        public int M { get; private set; }

        public MatrixSpiralSnake(int n, int m)
        {
            N = n; M = m;
            array = new int[N, M];
        }

        public void SpiralSnake(int numberToBeginWith)
        {
            int row = 0, column = 0;

            int maxColumn = M - 1;
            int maxRow = N - 1;
            int min = 0;

            for (int i = 1; i <= N * M; i++)
            {
                array[row, column] = numberToBeginWith;

                if (column == maxColumn && row != min)
                    row--;
                else if (row == maxRow)
                    column++;
                else if (column == min)
                    row++;
                else if (row == min && column != min + 1)
                    column--;
                else
                {
                    maxColumn -= 1;
                    maxRow -= 1;
                    min += 1;
                    row++;
                }

                numberToBeginWith++;
            }
        }

        public void SpiralSnakeReverse(int numberToBeginWith)
        {
            int row = N - 1, column = M - 1;

            int maxColumn = M - 1;
            int maxRow = N - 1;
            int min = 0;

            for (int i = 1; i <= N * M; i++)
            {
                array[row, column] = numberToBeginWith;

                if (row == min && column != maxColumn)
                    column++;
                else if (column == min)
                    row--;
                else if (row == maxRow)
                    column--;
                else if (column == maxColumn && row != min + 1)
                    row++;

                else
                {
                    maxColumn -= 1;
                    maxRow -= 1;
                    min += 1;
                    row++;
                }

                numberToBeginWith++;
            }
        }

        public override string? ToString()
        {
            string output = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    output += array[i, j].ToString() + " ";
                }
                output += "\n";
            }
            return output;
        }
    }
}
