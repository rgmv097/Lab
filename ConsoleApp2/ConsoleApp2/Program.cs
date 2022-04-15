using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] NumArray= { 4, 7, 9, 11, 17 };
            int max = 0;
            
            foreach (int number in NumArray)
            {
                if (number > max)
                {
                    max = number;   
                }
            }
            Console.WriteLine(max);
        }
    }
}
