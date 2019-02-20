/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 *
 * https://leetcode.com/problems/reverse-integer/description/
 *
 * algorithms
 * Easy (25.08%)
 * Total Accepted:    601.9K
 * Total Submissions: 2.4M
 * Testcase Example:  '123'
 *
 * Given a 32-bit signed integer, reverse digits of an integer.
 * 
 * Example 1:
 * 
 * 
 * Input: 123
 * Output: 321
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: -123
 * Output: -321
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: 120
 * Output: 21
 * 
 * 
 * Note:
 * Assume we are dealing with an environment which could only store integers
 * within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of
 * this problem, assume that your function returns 0 when the reversed integer
 * overflows.
 * 
 */
public class Solution {
    public int Reverse(int x) {
          int rev = 0;
            while (x != 0)
            {
                int pop = x % 10;
                Console.WriteLine("pop:" + pop);

                x /= 10;
                Console.WriteLine("x:" + x);

                if (rev > (Int32.MaxValue / 10) || (rev == Int32.MaxValue / 10 && pop > 7)) { return 0; }

                if (rev < Int32.MinValue / 10 || (rev == Int32.MinValue / 10 && pop < -8)) { return 0; }
                rev = rev * 10 + pop;
                Console.WriteLine("rev:" + rev);
            }
            return rev;
    }
}
