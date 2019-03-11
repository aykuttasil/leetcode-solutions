using System;
using System.Collections.Generic;
using System.Linq;
/*
* @lc app=leetcode id=136 lang=csharp
*
* [136] Single Number
*
* https://leetcode.com/problems/single-number/description/
*
* algorithms
* Easy (58.77%)
* Total Accepted:    422.8K
* Total Submissions: 715.1K
* Testcase Example:  '[2,2,1]'
*
* Given a non-empty array of integers, every element appears twice except for
* one. Find that single one.
* 
* Note:
* 
* Your algorithm should have a linear runtime complexity. Could you implement
* it without using extra memory?
* 
* Example 1:
* 
* 
* Input: [2,2,1]
* Output: 1
* 
* 
* Example 2:
* 
* 
* Input: [4,1,2,1,2]
* Output: 4
* 
* 
*/
namespace single_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 4, 1, 2, 3, 4 };
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }        

            // var result = SingleNumber(nums);
            Console.WriteLine(result);
        }
        /*

        {
        1:1
        2:1
        3:2
        }
         */
        public static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {

                if (pairs.ContainsKey(nums[i]))
                {
                    pairs[nums[i]]++;
                }
                else
                {
                    pairs.Add(nums[i], 1);
                }
                //   Console.WriteLine(nums[i].ToString()+","+pairs[nums[i]].ToString());
            }


            var s = 0;
            foreach (var item in pairs.Keys)
            {
                if (pairs[item] == 1)
                {
                    s = item;
                    break;
                }
            }

            return s;

            /* 
            var q = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                //var isExist = false;
                var count = 0;
                for (int y = 0; y < nums.Length; y++)
                {
                    if (num == nums[y])
                    {
                        count++;
                        //isExist = true;
                    }
                }
                if (count == 1)
                {
                    q = num;
                    break;
                }
            }
            return q;
            */
        }
    }
}
