using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAldo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 7,6,5,4,3,2,1,0} ;
            //a[0] = 1; { 7,2,1,6,8,5,3,4} 
            //a[1] = 2;
            //a[2] = 5;
            //int[] b = new int[] { 3,4,6,7,8,9};
            Console.WriteLine("Unsorted Array");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            SelectionSort s = new SelectionSort();
            // a = s.Sort(a);
            BubbleSort bs = new BubbleSort();
            //a = b.sort(a);
            InsertionSort i = new InsertionSort();
            // a = i.sort(a);

            MergeSort m = new MergeSort(a);
            //  a = m.sort();
            MergeSortedArray ma = new MergeSortedArray();
            //   ma.sort(a, b);

            QuickSort q = new QuickSort(a);
            a = q.sort(0, a.Length - 1);
            Console.WriteLine();
            Console.WriteLine("Sorted Array");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
