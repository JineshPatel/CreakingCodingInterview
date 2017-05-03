using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgo
{
  public  class BinarySearch
    {
        /// <summary>
        /// Find the first and last index of sorted array using binary search.O(log n)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="length"></param>
        /// <param name="findInt"></param>
        /// <returns></returns>
        public int BinarySearchIndexNumber(int[] a ,int length,int findInt,bool firstOccurance)
        {
            int low = 0;
            int high = length - 1;
            int result = -1;

            while (low<=high)
            {
                int mid = (low + high) / 2;
                if (findInt == a[mid])
                {
                    result = mid;
                    if (firstOccurance)
                    {
                        high = mid - 1;
                    }
                    else
                    low = mid + 1;// for last occurance of the number
                  

                }
                else if(findInt<a[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return result;
        }


        /// <summary>
        /// Find the total number of occurrences of a number in sorted array using binary search.
        /// get the first and last index of occurrence and the array is sorted so just subtract lastindex to firstindex.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="length"></param>
        /// <param name="findInt"></param>
        /// <returns></returns>
        public int FindCountOfAnElement(int[] a,int length,int findInt)
        {
            int firstIndex = BinarySearchIndexNumber(a, length, findInt,true);
            int lastIndex = BinarySearchIndexNumber(a, length, findInt,false);
            return lastIndex - firstIndex + 1 ;
        }


    }
}
