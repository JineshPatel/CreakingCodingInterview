using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAldo
{
    class BubbleSort
    {

        public int[] sort(int[] a)
        {
            for (int j = 0; j < a.Length - 1; j++)
            {
                bool swap = false;
                for (int i = 0; i < a.Length - j-1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        swap = true;
                    }

                }
                if (!swap)
                {
                    break;
                }
            }
            return a;
        }
    }
}
