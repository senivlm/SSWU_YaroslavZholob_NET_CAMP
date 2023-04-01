using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaHomeTask1.Task2
{// якщо все так відкрито, то, можливо, краще структуру?
    internal class Chain
    {
        public int Value { get; set; }
        public int BeginIndex { get; set; }
        public int Count { get; set; }
    }
    internal class MatrixLongestLine
    {
        private int[,] array;
        public int N { get; private set; }
        public int M { get; private set; }

        public MatrixLongestLine(int n, int m)
        {
            N = n; M = m;
            array = new int[N, M];
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
        public void Initialize()
        {
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {// От цієї чарівної константи нам тут не треба)
                    array[i, j] = random.Next(0, 17);
                }
            }
        }
        public void FindTheLongestString()
        {
            var rowLength = N;
            var columnLength = M;

            List<Chain> sequences = new List<Chain>();

            int? value = null;
            int startIndex = 0;
            int count = 0;
// Алгоритмічно неправильно!
            for (int row = 0; row < rowLength; row++)
            {
                for (int column = 0; column < columnLength; column++)
                {
                    if (value != array[row, column])
                    {
                        if (value.HasValue)
                        {
                            sequences.Add(new Chain
                            {
                                Value = value.Value,
                                BeginIndex = startIndex,
                                Count = count
                            });
                        }

                        value = array[row, column];
                        startIndex = column;
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }

                sequences.Add(new Chain
                {
                    Value = value.Value,
                    BeginIndex = startIndex,
                    Count = count
                });

            }
//Роздруку тут не потрібно, слід повернути результат в методі, наприклад кортежем, а ще краще екземпляром класу, або через ref,out параметри....
            var longestSequence = sequences.OrderByDescending(m => m.Count).First();

            Console.WriteLine($"\nColor: {longestSequence.Value}\nStart index: {longestSequence.BeginIndex}\nEnd index: {longestSequence.BeginIndex + longestSequence.Count - 1}\nLength {longestSequence.Count}");
        }

    }
}
