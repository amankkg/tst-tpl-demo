using System;

namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args) // + Main
        {
            Console.WriteLine(Fibonacci.Fib(9600));
        }

        static void ForR(int i)
        {
            Console.WriteLine("Step: " + i);
            
            if (i == 0) return; // break condition
            ForR(i - 1); // recursive call
        }
    }
}
