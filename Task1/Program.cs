using SigmaHomeTask1.Task1;
using SigmaHomeTask1.Task2;

namespace SigmaHomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task Spiral Snake\nEnter rows number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter columns number:");
            int m = int.Parse(Console.ReadLine());
            MatrixSpiralSnake matrixSpiralSnake = new MatrixSpiralSnake(n,m);
            matrixSpiralSnake.SpiralSnake(1);
            Console.WriteLine(matrixSpiralSnake.ToString());
            matrixSpiralSnake.SpiralSnakeReverse(1);
            Console.WriteLine(matrixSpiralSnake.ToString());
        }
    }
}