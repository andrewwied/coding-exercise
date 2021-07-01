using System;

namespace Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            KataClass kata = new KataClass();

            int inputNumber = 9;

            String result = kata.CyclicPermutations(inputNumber);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}