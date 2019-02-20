using System;

namespace reverse_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("" + (1/10));
        }

        public static int Reverse(int x)
        {
            return 1;
        }


        public static int reverse(int x)
        {
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
}
