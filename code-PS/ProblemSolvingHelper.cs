using System;
using System.Collections.Generic;
using System.Text;

namespace worex.tasks.code_PS
{
    public static class ProblemSolvingHelper
    {
        public static bool PatternMatch(string[] strings, string[] patterns)
        {
            if (strings.Length != patterns.Length)
                return false;

            var mapStringToPattern = new Dictionary<string, string>();
            var mapPatternToString = new Dictionary<string, string>();

            for (int i = 0; i < strings.Length; i++)
            {
                string str = strings[i];
                string pat = patterns[i];

                // Check if the current string has been mapped to a pattern
                if (!mapStringToPattern.TryAdd(str, pat))
                {
                    // If it has been mapped, check if it matches the current pattern
                    if (mapStringToPattern[str] != pat)
                        return false;
                }

                // Check if the current pattern has been mapped to a string
                if (!mapPatternToString.TryAdd(pat, str))
                {
                    // If it has been mapped, check if it matches the current string
                    if (mapPatternToString[pat] != str)
                        return false;
                }
            }

            return true;
        }


        public static bool IndexChecker(int[] nums, int k)
        {
            var indices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (indices.TryGetValue(nums[i], out int lastIndex))
                {
                    if (i - lastIndex <= k)
                        return true;
                }

                indices[nums[i]] = i;
            }

            return false;
        }
    }
}
