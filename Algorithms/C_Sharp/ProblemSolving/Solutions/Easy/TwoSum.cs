using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Solutions.Easy
{
    internal class TwoSum
    {
        public int[] Solution(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new InvalidOperationException("No two elements of an array can add up to the target!");
        }

        public void Run()
        {
            try
            {
                Console.Write("Enter elements of an array separating with single space: ");
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                Console.Write("Enter target number: ");
                int targetNumber = int.Parse(Console.ReadLine());
                int[] result = Solution(numbers, targetNumber);
                Console.WriteLine($"Result: [{string.Join(",", result)}]");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
