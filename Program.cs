using System;
using worex.tasks.code_PS;

namespace worex.tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pattern Matcher : \n");

            string[] strings1 = { "cat", "dog", "dog" };
            string[] patterns1 = { "a", "b", "b" };
            Console.WriteLine(ProblemSolvingHelper.PatternMatch(strings1, patterns1));

            string[] strings2 = { "cat", "dog", "doggy" };
            string[] patterns2 = { "a", "b", "b" };
            Console.WriteLine(ProblemSolvingHelper.PatternMatch(strings2, patterns2));

            Console.WriteLine("-------------");


            Console.WriteLine("Index Checker : \n");
            int[] nums1 = { 0, 1, 2, 3, 5, 2 };
            int k1 = 3;
            Console.WriteLine(ProblemSolvingHelper.IndexChecker(nums1, k1));  

            int[] nums2 = { 0, 1, 2, 3, 5, 2 };
            int k2 = 2;
            Console.WriteLine(ProblemSolvingHelper.IndexChecker(nums2, k2));
        }
    }
}
