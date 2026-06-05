using System;
using System.Collections;
namespace LeetCodeProblems
{
    class LeetCodeProblems
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 2, 1 };
            int count = 0;
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                count = numbers.Count(n => n == 2);
                result = result + count;
                Console.WriteLine(result);
            }
        }
    }
}