using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkPrime
{
    public class sort
    {
        int[] a = new int[] { 5, 2, 3, 1, 4 };
        public sort()
        {
            BreakArray(a);
            PrintOutput(a);
        }

        public void Merge(int[] l, int[] r)
        {
            int nl = l.Length;
            int nr = r.Length;

            int i = 0, j = 0, k = 0;

            while (i < nl && j < nr)
            {
                if (l[i] < r[j])
                {
                    a[k] = l[i];
                    i++;
                }
                else
                {
                    a[k] = r[j];
                    j++;
                }
                k++;
            }
            while (i < nl)
            {
                a[k] = l[i];
                i++; k++;
            }
            while (j < nr)
            {
                a[k] = r[j];
                j++; k++;
            }
        }

        public void BreakArray(int[] b)
        {
            int n = b.Length;
            if (n < 2) return;
            int mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];

            for (int i = 0; i <= mid - 1; i++)
            {
                left[i] = b[i];
            }
            for (int i = mid, j = 0; i <= n - 1; i++,j++)
            {
                right[j] = b[i];

            }

            BreakArray(left);
            BreakArray(right);
            Merge(left, right);

        }


        public void PrintOutput(int[] a)

        {
            int i = 0, j = a.Length;
            for (i = 0, j = a.Length; i < j; i++, j--)
            {
                Console.WriteLine($"{j} {i}");
            }

        }
    }
}


//I have an unsorted array 5, 2, 3, 1, 4 - Output -> 5, 1, 4, 2, 3, 0


//for n to 0 
//  Mergesort -sorted array-o(nlog n)

//  1,2,3,4,5


//  i=0 , j =n ,j<i o(n)
//  //523 14                                     a[] = 1 2 2 6 8 5 3 7    k=0               5,2,3  1,4         2 5 3 1 4

//                                                                                          25  3    1  4
//                                                // l=  1 2 4 6       r = 3 5 7 8          

//                                                    `                                        5 2 


//  //5 23i                                             i  =0                j =0  1 2 3 4 5

