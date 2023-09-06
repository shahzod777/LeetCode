using ProblemSolving.Solutions.Easy;
using ProblemSolving.Solutions.Medium;
using ProblemSolving.Solutions.Hard;

namespace ProblemSolving
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            array = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Console.WriteLine($"({string.Join("+", array)})/{array.Length} = {array.Sum()/array.Length}");
        }
    }
}