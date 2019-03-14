using System;

/*
 * @lc app=leetcode id=888 lang=csharp
 *
 * [888] Fair Candy Swap
 *
 * https://leetcode.com/problems/fair-candy-swap/description/
 *
 * algorithms
 * Easy (55.59%)
 * Total Accepted:    22K
 * Total Submissions: 39K
 * Testcase Example:  '[1,1]\n[2,2]'
 *
 * Alice and Bob have candy bars of different sizes: A[i] is the size of the
 * i-th bar of candy that Alice has, and B[j] is the size of the j-th bar of
 * candy that Bob has.
 * 
 * Since they are friends, they would like to exchange one candy bar each so
 * that after the exchange, they both have the same total amount of candy.
 * (The total amount of candy a person has is the sum of the sizes of candy
 * bars they have.)
 * 
 * Return an integer array ans where ans[0] is the size of the candy bar that
 * Alice must exchange, and ans[1] is the size of the candy bar that Bob must
 * exchange.
 * 
 * If there are multiple answers, you may return any one of them.  It is
 * guaranteed an answer exists.
 * 
 * 
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: A = [1,1], B = [2,2]
 * Output: [1,2]
 * 
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: A = [1,2], B = [2,3]
 * Output: [1,2]
 * 
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: A = [2], B = [1,3]
 * Output: [2,3]
 * 
 * 
 * 
 * Example 4:
 * 
 * 
 * Input: A = [1,2,5], B = [2,4]
 * Output: [5,4]
 * 
 * 
 * 
 * 
 * Note:
 * 
 * 
 * 1 <= A.length <= 10000
 * 1 <= B.length <= 10000
 * 1 <= A[i] <= 100000
 * 1 <= B[i] <= 100000
 * It is guaranteed that Alice and Bob have different total amounts of
 * candy.
 * It is guaranteed there exists an answer.
 * 
 * 
 * 
 * 
 * 
 * 
 */

namespace fair_candy_swap
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new int[] { 1, 2, 5 };
            var B = new int[] { 2, 4 };
            Console.WriteLine("sonuc:" + FairCandySwap(A, B)[1]);
        }

        public static int[] FairCandySwap(int[] A, int[] B)
        {
            var result = new int[2];

            var sumA = 0;
            foreach (var x in A)
            {
                sumA += x;
            }

            var sumB = 0;
            foreach (var y in B)
            {
                sumB += y;
            }
            var success = (sumA + sumB) / 2;

            for (int i = 0; i < A.Length; i++)
            {
                int Ai = A[i];
                for (int y = 0; y < B.Length; y++)
                {
                    int By = B[y];
                    var tempSumA = sumA - Ai + By;
                    var tempSumB = sumB - By + Ai;
                    if (tempSumA == tempSumB)
                    {
                        result[0] = Ai;
                        result[1] = By;
                        return result;
                    }
                }
            }
            return result;
        }
    }
}
