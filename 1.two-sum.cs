/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 *
 * https://leetcode.com/problems/two-sum/description/
 *
 * algorithms
 * Easy (40.30%)
 * Total Accepted:    1.4M
 * Total Submissions: 3.5M
 * Testcase Example:  '[2,7,11,15]\n9'
 *
 * Given an array of integers, return indices of the two numbers such that they
 * add up to a specific target.
 * 
 * You may assume that each input would have exactly one solution, and you may
 * not use the same element twice.
 * 
 * Example:
 * 
 * 
 * Given nums = [2, 7, 11, 15], target = 9,
 * 
 * Because nums[0] + nums[1] = 2 + 7 = 9,
 * return [0, 1].
 * 
 * 
 * 
 * 
 */
using System;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {    
        var result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int y = i + 1; y < nums.Length; y++)
            {
                if (nums[i] + nums[y] == target)
                {
                    result = new[] { i, y };
                    break;
                }
            }
        }        
        return result;
    }
}
