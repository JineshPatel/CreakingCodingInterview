using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgo
{
    public class LeftRotation
    {
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
    }
}
