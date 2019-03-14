using System;

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

namespace reverse_string
{

    /*
    h  e  l  l  o
    0  4

    o  e  l  l  h
    1  3

    o  l  l  e  h
    2  2

     */



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("" + new string(ReverseString("ferhat".ToCharArray())));
        }
        /* */
        public static char[] ReverseString(char[] s)
        {
            // var index = 0;
            // for (int i = 0; i < s.Length; i++)
            // {
            //     index = s.Length - 1 - i;
            //     if (i >= index) break;
            //     var temp = s[i]; // h
            //     s[i] = s[index];
            //     s[index] = temp; // oellh
            // }
            // return s;


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

        /*
            F e r h a t
        1   i         x
        2     i     x
        3       i x
        4       x i



            t e r h a F
            t a r h e F
            t a h r e F

            index = 5     index = 4
            temp = F      temp = e
            terhat        
            terhaf
         */
    }
}
