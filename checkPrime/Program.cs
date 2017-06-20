using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aaabbc";
            Console.WriteLine(   compressSting.CompressString(str));



            sort sorting = new sort();
            Console.WriteLine("enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            allFib(n);
            //for (int i = 1; i < n; i++)
            //{
            //    if(isPrime(i))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int[] array = new int[256];
            //string one = "aacdef";
            //string two = "bcdefa";
            //foreach (char item in one)
            //{
            //        array[item]++;

            //}
            //foreach (char item in two)
            //{
            //    array[item]--;
            //    if (array[item]<0)
            //    {
            //        Console.WriteLine("no");
            //    }
            //}
            //Console.WriteLine("Yes");


            //int[,] test = new int[2,2];


            linkedLIst al = new linkedLIst();
           // linkedLIst b = new linkedLIst();
            al.add(1);
            al.add(2);
            al.add(3);
            al.add(4);
            al.add(5);
            al.add(6);
            al.add(4);

            //b.add(5);
            //b.add(9);
            //b.add(2);
            al.kthLastElement(al.head, 2);
            al.printRecursion(al.head);
            al.reversePrintRecursion(al.head);
            // a.head = a.reverse(a.head);

            //  Console.WriteLine($"IsPalindrome : {a.isPlanDrom(a.head)}");

            //Console.WriteLine(   a.loop(a.head));
            //a.printAllNode();



            int[] array = new int[] { 1,2,3,4,5,6,7,8};
            Tree s = new Tree();
          //  TreeNode k = s.createMinimalBST(array);
          //  s.levelOrder(k);


            TreeNode rootPtr = new TreeNode();
            rootPtr = null;
            Tree a = new checkPrime.Tree();
            rootPtr = a.Insert(rootPtr, 15);
            rootPtr = a.Insert(rootPtr, 10);
            rootPtr = a.Insert(rootPtr, 20);
            rootPtr = a.Insert(rootPtr, 25);
            rootPtr = a.Insert(rootPtr, 8);
            rootPtr = a.Insert(rootPtr, 1);
            rootPtr = a.Insert(rootPtr, 12);
          //  a.levelOrder(rootPtr);

            TreeNode root = new TreeNode();
            root = null;
            Tree b = new Tree();
            root = b.Insert(root, 'M'); root = b.Insert(root, 'B');
            root = b.Insert(root, 'Q'); root = b.Insert(root, 'Z');
            root = b.Insert(root, 'A'); root = b.Insert(root, 'C');
            Console.WriteLine(a.IsBST(rootPtr));
            Console.WriteLine(b.IsBST(root));
            // b.levelOrder(root);
            //Console.WriteLine(a.FindHeight(rootPtr));
            //bool test = a.search(rootPtr, n);
            //Console.WriteLine(a.findMinTree(rootPtr));
            //Console.WriteLine(test);
            Console.WriteLine( fibo(n));
            Console.ReadKey();
        }

        public static void allFib(int n )
        {
            int[] memo = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"{i} : {fib(i,memo)}");
            }
            if(memo.Contains(n))
            {
                Console.WriteLine("IsFibo");
            }
            else
            {
                Console.WriteLine("IsNotFibo");
            }
        }

        private static int fib(int i, int[] memo)
        {
            if (i <= 0)
            {
                return 0;
            }
            else if (i == 1) return 1;
            else if (memo[i] > 0) return memo[i];
            memo[i] = fib(i - 1, memo) + fib(i- 2, memo);

            return memo[i];
        }

        public static int fibo(int n) => fibonacci(n, new int[n + 1]);

        private static int fibonacci(int n, int[] v)
        {
            if (n==0 || n==1)
            {
                return n;
            }
            if(v[n]==0)
            {
                v[n] = fibonacci(n - 1, v) + fibonacci(n - 2, v);
            }
            return v[n];
        }

        public static Node addTwoLingkList(Node l1 , Node l2 , int carry)
        {
            if (l1==null && l2 == null && carry ==0)
            {
                return null;
            }
            Node result = new Node();
            int value = carry;
            if (l1!=null)
            {
                value = value +(int) l1.data;
            }
            if (l2!=null)
            {
                value += (int)l2.data;
            }
            result.data = value % 10;
            if (l1!=null && l2!=null)
            {
                Node more = addTwoLingkList(l1 == null ? null : l1.next,
                                            l2 == null ? null : l2.next,
                                            value > 10 ? 1 : 0);
                result.next = more;
            }
            return result;
        }
        private static bool isPrime(int n)
        {
            if (n==1)
            {
                return false;
            }
            for (int x = 2; x * x<= n; x++)
            {
                if (n % x == 0)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
