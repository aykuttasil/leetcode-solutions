/*
 * @lc app=leetcode id=344 lang=csharp
 *
 * [344] Reverse String
 *
 * https://leetcode.com/problems/reverse-string/description/
 *
 * algorithms
 * Easy (62.68%)
 * Total Accepted:    383.9K
 * Total Submissions: 611K
 * Testcase Example:  '["h","e","l","l","o"]'
 *
 * Write a function that reverses a string. The input string is given as an
 * array of characters char[].
 * 
 * Do not allocate extra space for another array, you must do this by modifying
 * the input array in-place with O(1) extra memory.
 * 
 * You may assume all the characters consist of printable ascii
 * characters.
 * 
 * 
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: ["h","e","l","l","o"]
 * Output: ["o","l","l","e","h"]
 * 
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: ["H","a","n","n","a","h"]
 * Output: ["h","a","n","n","a","H"]
 * 
 * 
 * 
 * 
 */
public class Solution
{
    public char[] ReverseString(char[] s)
    {
        var first = 0;
        var last = s.Length - 1;

        while (first < last)
        {

            var temp = s[first];
            s[first] = s[last];
            s[last] = temp;

            first++;
            last--;
        }
        return s;
    }
}

