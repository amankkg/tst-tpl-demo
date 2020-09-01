namespace RecursionDemo
{
    class Factorial
    {
        public static ulong Recursive(ulong n) => n * (n > 1 ? Recursive(n - 1) : 1);

        public static ulong Loop(ulong n)
        {
            var i = n;
            var x = n;

            while (--i > 0) x *= i;

            return x;
        }
    }
}
