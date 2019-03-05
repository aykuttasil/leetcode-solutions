using System;

namespace power_of_three
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfThree(1));
        }

        public static bool IsPowerOfThree(int n)
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
}
