using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           int[] arr = {4,5,6,7};
            int NumSum = 0;
            foreach (int i in arr)
            {
                if (i % 2 != 0) { NumSum += i;  }
            }
            Console.WriteLine(NumSum);


        }
    }
}
