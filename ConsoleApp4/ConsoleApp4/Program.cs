using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];
            bool flag = false;

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i]=Console.ReadLine();
               
                }

            for (int i = 0; i < arr.Length; i++)
            {


                if (arr[i] == "Chingiz")
                {
                    flag = true;

                }

            }
            if (flag) { Console.WriteLine("var"); }
            else
            {
                Console.WriteLine("yoxdur");
                

            }





            }
    }
}
