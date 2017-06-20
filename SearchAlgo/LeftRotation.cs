using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgo
{
    public class LeftRotation
    {
        /// <summary>
        /// this will rotate the array to left K times
        /// </summary>
        /// <param name="a"> Array to rotate</param>
        /// <param name="n">Leangth of array</param>
        /// <param name="k">No of times array need to be rotates to the left</param>
        /// <returns>This returns rotated array.</returns>
        public int[] rotate(int[] a,int n,int k)
        {
            int r = n - k;
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = a[(i - r + n) % n];
                Console.Write(b[i] + " ");
            }
            return b;
        }

        public int RotationCount(int[] a, int n)
        {
            int low = 0;
            int high = n - 1;

            while (low <= high)
            {
                // when it's sorted and low will be at the a[low]
                if (a[low] <= a[high])
                {
                    return low;
                }

                int mid = (low + high) / 2;
                int next = (mid + 1) % n; //get next index of middle if it last indext then we need to go to the first index so %n
                int prev = (mid + n - 1) % n;

                // if mid values is less than or equal to next and prev value of mid then it's our index
                if (a[mid] <= a[next] && a[mid] <= prev)
                {
                    return mid;
                }
                // if it's in lower side of the sorted array
                else if (a[mid] <= a[high])
                    high = mid - 1;
                // if it's higher side of the sorted array
                else if (a[mid] >= a[low])
                    low = mid + 1;
            }
            return -1;
        }
    }
}
