using System;
using System.Linq;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSumAndCount(int.Parse, array => array.Length, array => array.Sum());
            Func<string, int> parser = x => int.Parse(x);
        }

        static void PrintSumAndCount(Func<string, int> parser,
                                     Func<int[], int> CountGetter,
                                     Func<int[], int> sumCalculator)
        {
            int[] array = Console.ReadLine().Split(", ")
                 .Select(parser)
                 .ToArray();
            Console.WriteLine(CountGetter(array));
            Console.WriteLine(sumCalculator(array));
        }
    }
}
