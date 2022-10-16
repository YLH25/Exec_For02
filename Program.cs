using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //等腰星形三角形
            for (int i = 3; i > 0; i--)
            {
                string value = new string(' ', i - 1) + new string('*', 3 - i) + "*" + new string('*', 3 - i) + new string(' ', i - 1);
                Console.WriteLine(value);
            }
            ////等腰星形三角形2
            //for (int i = 3; i > 0; i--)
            //{
            //    for (int j = i; j >= 2; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = i; j < 3; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("*");
            //    for (int j = i; j < 3; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    for (int j = i; j >= 2; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
