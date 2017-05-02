using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAldo
{
    public class MergeSortedArray
    {

        public int[] sort(int[] a, int[] b)
        {
            int j = 0;
            int l = a.Count(s => s != 0);
            for (int i = 0; i < a.Length-1; i++)
            {
                if (a[i] > b[j])
                {
                    a = shift(a, i, l);
                    a[i] = b[j];
                    j++;
                    l++;
                }
            }
            if (j<b.Length)
            {
                while (j!=b.Length)
                {
                    a[l] = b[j];
                    l++;
                    j++;
                }
            }

            return a;

        }

        private int[] shift(int[] a, int i, int l)
        {
            for (int j = l - 1; i <= j; j--)
            {
                a[j + 1] = a[j];
            }
            return a;
        }
    }
}
