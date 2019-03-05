/*
 * @lc app=leetcode id=326 lang=csharp
 *
 * [326] Power of Three
 *
 * https://leetcode.com/problems/power-of-three/description/
 *
 * algorithms
 * Easy (41.34%)
 * Total Accepted:    170.8K
 * Total Submissions: 412.6K
 * Testcase Example:  '27'
 *
 * Given an integer, write a function to determine if it is a power of three.
 * 
 * Example 1:
 * 
 * 
 * Input: 27
 * Output: true
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: 0
 * Output: false
 * 
 * Example 3:
 * 
 * 
 * Input: 9
 * Output: true
 * 
 * Example 4:
 * 
 * 
 * Input: 45
 * Output: false
 * 
 * Follow up:
 * Could you do it without using any loop / recursion?
 */
public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        if (n < 1)
        {
            return false;
        }

        while (n % 3 == 0)
        {
            n /= 3;
        }

        return n == 1;
    }
}

