﻿namespace AL_DS_Lib.LeetCode
{
    public static class _0509_FibonacciNumber
    {
        public static int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
