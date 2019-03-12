using System;

/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 *
 * https://leetcode.com/problems/longest-common-prefix/description/
 *
 * algorithms
 * Easy (32.92%)
 * Total Accepted:    413.6K
 * Total Submissions: 1.3M
 * Testcase Example:  '["flower","flow","flight"]'
 *
 * Write a function to find the longest common prefix string amongst an array
 * of strings.
 * 
 * If there is no common prefix, return an empty string "".
 * 
 * Example 1:
 * 
 * 
 * Input: ["flower","flow","flight"]
 * Output: "fl"
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: ["dog","racecar","car"]
 * Output: ""
 * Explanation: There is no common prefix among the input strings.
 * 
 * 
 * Note:
 * 
 * All given inputs are in lowercase letters a-z.
 * 
 */
namespace longest_common_prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            var strArray = new string[]{"aykut", "ayk", "ayll"};
            Console.WriteLine(LongestCommonPrefix1(strArray));
        }


        public static string LongestCommonPrefix1(string[] strs)
        {
            var a = "ayk";
            return a.IndexOf("aykut").ToString();
        }


        public static string LongestCommonPrefix(string[] strs)
        {
            var commonPrefix = "";
            var loop = 1;
            for (int i = 0; i < strs.Length; i++)
            {
                var c = strs[i]; // aykut
                var q = c.Substring(0, loop); // a , ay , ayk

                var allContains = true;
                for (int y = 1; y < strs.Length; y++)
                {
                    var e = strs[y]; // ayk , naber
                    var r = e.Substring(0, loop); // a , n
                    if (q != r)
                    {
                        allContains = false;

                        break;
                    }
                }
                if (!allContains)
                {
                    break;
                }
                else
                {
                    commonPrefix = q;
                }
                
                loop += 1;
            }

            return commonPrefix;
        }
    }
}
