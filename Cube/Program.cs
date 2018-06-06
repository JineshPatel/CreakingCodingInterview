using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube
{
    public class Program
    {
        //a3+b3 = c3 + d3
        public static void Main(string[] args)
        {
            //Hashtable<int,Pair> map = new Hashtable();
            Dictionary<double, KeyValuePair<int, int>> dic = new Dictionary<double, KeyValuePair<int, int>>();
            for (int a = 1; a < 10; a++)
            {
                for (int b =  1; b < 10; b++)
                {
                    var result = Math.Pow(a, 3) + Math.Pow(b, 3);
                    //if (dic.ContainsKey(result))
                    //{
                    //    Console.WriteLine($"{dic[result]} == {new Pair(a, b).toString()}");
                    //}
                    //else
                    //{
                    //    dic.Add(result, new KeyValuePair<int, int>(a, b));
                    //}
                    for (int c = 1; c < 10; c++)
                    {
                        for (int d = 1; d < 10; d++)
                        {
                            if (Math.Pow(a, 3) + Math.Pow(b, 3) == Math.Pow(c, 3) + Math.Pow(d, 3))
                            {
                                Console.WriteLine($"({a},{b})= ({c},{d})");
                            }
                        }
                    }
                }

            }

            Dictionary<int, List<Tuple<int, int>>> solutions =
    new Dictionary<int, List<Tuple<int, int>>>();

            for (int a = 1; a <= 100; ++a)
                for (int b = a; b <= 100; ++b)
                {
                    int sum = a * a * a + b * b * b;

                    List<Tuple<int, int>> list = null;

                    if (!solutions.TryGetValue(sum, out list))
                    {
                        list = new List<Tuple<int, int>>();

                        solutions.Add(sum, list);
                    }

                    list.Add(new Tuple<int, int>(a, b));
                }

            String report = String.Join(Environment.NewLine,
              solutions.Values
              .Where(list => list.Count > 1) // more than one item
              .Select(list => String.Join(", ",
                list.Select(item => String.Format("({0}, {1})", item.Item1, item.Item2)))));

            Console.Write(report);
        }
    }

    public class Pair
    {
        int a, b;
        public Pair(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public String toString()
        {
            return "(" + this.a + ", " + this.b + ")";
        }
    }
}
