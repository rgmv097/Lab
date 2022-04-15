using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr=new int[5];

            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i]>max)
                {

                    max = arr[i];
                }

                            }
            Console.WriteLine("MAX Value in ARRY");
            Console.WriteLine(max);
        }
    }
}
