using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAldo
{
    class MergeSort
    {
        private int[] a;

        public MergeSort(int[] sortA)
        {
             a=sortA;
        }
        public int[] sort()
        {
            BreakArray(a);
            return a;
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

            for (int i = 0; i < mid; i++)
            {
                left[i] = b[i];
            }
            for (int i = mid; i < n ; i++)
            {
                right[i-mid] = b[i];

            }

            BreakArray(left);
            BreakArray(right);
            Merge(left, right);

        }
    }
}
