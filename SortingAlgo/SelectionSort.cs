using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAldo
{
    class SelectionSort
    {
        private int smallest;

        public int[] Sort(int[] a)
        {
            for (int j = 0; j < a.Length-1; j++)
            {
                smallest = j;
                for (int i = j+1; i < a.Length-1; i++)
                {
                    if (a[smallest] > a[i + 1])
                    {
                        smallest = i+1;
                    }
                }
                if (a[j] > a[smallest])
                {


                    int temp = a[j];
                    a[j] = a[smallest];
                    a[smallest] = temp;
                }
            }
            return a;
            
        }
    }
}
