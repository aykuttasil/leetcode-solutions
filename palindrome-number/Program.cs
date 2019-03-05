using System;

namespace palindrome_number
{
    /* 
        - if X's sign is '-' than return false
        - get mod 10 to X
        -       
     */
    class Program
    {
        static void Main(string[] args)
        {
            var result = IsPalindrome(161);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static bool IsPalindrome(int x)
        {
            var temp = x;
            var signX = Math.Sign(x);
            if (signX == -1) return false;

            var reverseInt = 0;
            // x = 345
            while (true)
            {
                var q = x % 10; // 5
                x = x / 10; // 34
                reverseInt = reverseInt * 10 + q;
                if (x == 0) break;
            }

            Console.WriteLine("temp:" + temp + " reverseInt:" + reverseInt);
            if (temp == reverseInt) return true;
            else return false;
        }
    }
}
