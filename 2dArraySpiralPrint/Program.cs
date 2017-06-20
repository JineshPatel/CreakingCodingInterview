 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dArraySpiralPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[2][] ;
            a[0][1] = 1;
            a[0][2] = 2;
            a[0][3] = 3;
            a[0][4] = 4;

            a[1][1] = 5;
            a[1][2] = 6;
            a[1][3] = 7;
            a[1][4] = 8;

            a[2][1] = 9;
            a[2][2] = 10;
            a[2][3] = 11;
            a[2][4] = 12;

            a[3][1] = 13;
            a[3][2] = 14;
            a[3][3] = 15;
            a[3][4] = 16;


            printSpiral(a,a[0].Length,a.Length);
        }

        private static void printSpiral(int[][] a, int m, int n)
        {
            int t = 0, b = m - 1, l = 0, r = n - 1;
            int dir = 0;

            while (l<=r && t<=b)
            {
                if (dir==0)
                {
                    for (int k = l; k <= r; k++)
                    {
                        Console.WriteLine(a[t][k]);
                        t++;
                    }
                }
                if (dir==1)
                {
                    for (int k = t; k <= b; k++)
                    {
                        Console.WriteLine(a[k][r]);
                        r--;
                    }
                }
                if (dir==2)
                {
                    for (int k = r; k >= l; k--)
                    {
                        Console.WriteLine(a[b][k]);
                        b--;
                    }
                }

                else if (dir==3)
                {
                    for (int k = b; k >= t; k--)
                    {
                        Console.WriteLine(a[k][l]);
                    }
                }

                dir = (dir + 1) % 4;
            }
        }
    }
}
