using ProblemSolving.Solutions.Easy;
using ProblemSolving.Solutions.Medium;
using ProblemSolving.Solutions.Hard;

namespace ProblemSolving
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter elements of an array with single space: ");
            int[] array = new int[1000];
            array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine($"Program for finding average: ({string.Join(" + ", array)})/{array.Length}" +
                $" = {array.Sum()/array.Length}");
        }
    }
}