
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            RunProgram();
        }

        static void RunProgram()
        {
            int[] a = { 1, 2, 3, 4, 5 }; 
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            Console.WriteLine("Tong cac : " + sum);
        }
    }
}