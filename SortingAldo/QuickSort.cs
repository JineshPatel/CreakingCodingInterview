using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAldo
{
    class QuickSort
    {
        private int pindex;

        private int[] a;
        /// <summary>
        /// setting the unsorted array.
        /// </summary>
        /// <param name="unsorteda"></param>
        public QuickSort(int[] unsorteda)
        {
            a = unsorteda;
        }
        public int[] sort(int start,int end)
        {
            if (start < end)
            {
                pindex = partitionArray( start, end);
                sort( start, pindex - 1);
                sort(pindex + 1, end);

            }
            return a;
        }
        /// <summary>
        /// In this function we will partition the array that way 
        /// so less than and equal values to the pivot will be on left side 
        /// and greater than pivot value will be on the right side
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private int partitionArray( int start, int end)
        {
            int pivot = a[end];
            int pindex = start;

            for (int i = start; i < end; i++)
            {
                if (a[i] <= pivot)
                {
                    int temp = a[pindex];
                    a[pindex] = a[i];
                    a[i] = temp;

                    pindex++;
                }
            }

            int tempEnd = a[end];
            a[end] = a[pindex];
            a[pindex] = tempEnd;
           

            return pindex;

        }
    }
}
