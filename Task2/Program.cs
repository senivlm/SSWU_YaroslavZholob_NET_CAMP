using SigmaHomeTask1.Task1;
using SigmaHomeTask1.Task2;

namespace SigmaHomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task Longest Line");
            MatrixLongestLine matrixLongestLine = new MatrixLongestLine(5,10);
            matrixLongestLine.Initialize();
            Console.WriteLine(matrixLongestLine.ToString());
            matrixLongestLine.FindTheLongestString();
        }
    }
}