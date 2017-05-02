using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAldo
{
    class InsertionSort
    {

        public int[] sort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int value = a[i];
                int hole = i;
                while (hole>0 && a[hole-1]>value)
                {
                    a[hole] = a[hole - 1];
                    hole--;
                }
                a[hole] = value;
            }
            return a;
        }
    }
}
