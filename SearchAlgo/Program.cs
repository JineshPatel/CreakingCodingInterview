using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] k = new int[] { 1, 2, 3, 4, 5 };
            LeftRotation l = new LeftRotation();
            k = l.rotate(k, 5, 4);



            int[] a = new int[] {2,4,10,10,10,10,18,20 };
            BinarySearch bs = new BinarySearch();


            int n = Convert.ToInt32(Console.ReadLine());

            int lastindex = bs.BinarySearchIndexNumber(a, a.Length, n,false);
            int firstindex = bs.BinarySearchIndexNumber(a, a.Length, n,true);
            int totalCount = bs.FindCountOfAnElement(a, a.Length, n);

            Console.WriteLine($"Last index of {a[lastindex]} is {lastindex}");
            Console.WriteLine($"first index of {a[firstindex]} is {firstindex}");
            Console.WriteLine($"Total occurrence of {n} is {totalCount}");

            Console.WriteLine($"rotation of the array is {l.RotationCount(k,k.Length)}");

            int[] b = new int[] {12,14,18,21,3,6,8,9 };
            int x = Convert.ToInt32(Console.ReadLine());
            int ans = bs.SearchElementInCircularArray(b, x);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
 