using System.Collections.Generic;

namespace RecursionDemo
{
    class Fibonacci
    {
        static Dictionary<ulong, ulong> MemoizedValues = new Dictionary<ulong, ulong>();

        public static ulong Fib(ulong n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            // Memoization
            if (MemoizedValues.ContainsKey(n)) return MemoizedValues[n];

            var newEntry = Fib(n - 1) + Fib(n - 2);

            MemoizedValues.Add(n, newEntry);

            return newEntry;
        }
    }
}
