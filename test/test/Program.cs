using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.ReadLine();
        }
    }

}
/*素数筛选法
            bool[] a = new bool[1000];
            int i,j;
            for (i = 0; i < 1000; i++)
                a[i] = false;
            a[1] = true;
            for (i = 2; i <= Math.Sqrt(1000.0); i++)
            {
                if(a[i])
                    for (j = 2 * i; j < 1000; j += i)
                        a[j] = true;
            }
            for (i = 1; i < 1000; i++)
                if (!a[i])
                    Console.WriteLine(i);
 * 
 * /
/*
 * 打印菱形
             int n,m,z;
            n = Convert.ToInt32(Console.ReadLine());
            m = 2 * n - 1;
            for (int i = 1; i <= m; i++)
            {
                if (i <= n)
                    z = i;
                else
                    z = m - i + 1;
                Console.SetCursorPosition(10+n - z, i);
                for (int j = 0; j < 2 * z- 1; j++)
                     Console.Write('*');
            } 
*/