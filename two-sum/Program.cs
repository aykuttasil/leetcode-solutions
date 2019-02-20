using System;
using System.Collections.Generic;

namespace two_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 3, 2, 4 };
            var target = 6;
            var x = TwoSum(nums, target);

            Console.WriteLine(x[0]);
            Console.WriteLine(x[1]);
        }

        public static int[] TwoSum(int[] nums, int target)
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
            Console.WriteLine(b - a);
            return result;


            /* 
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map.GetValueOrDefault(complement), i };
                }
                map.Add(nums[i], i);
            }
            return new List<int>(map.Keys).ToArray();
            */
        }
    }
}