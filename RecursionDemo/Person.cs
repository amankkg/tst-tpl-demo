using System;

namespace RecursionDemo
{
    class Person
    {
        public string Name { get; private set; }

        public Person? Mother { get; private set; } = null;
        public Person? Father { get; private set; } = null;

        public void PrintFatherhood()
        {
            Console.WriteLine(Name);

            Father?.PrintFatherhood();
        }
    }
}
