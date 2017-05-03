using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries_Contacts_hackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Contacts c = new Contacts();
            for (int a0 = 0; a0 < n; a0++)
            {
                string[] tokens_op = Console.ReadLine().Split(' ');
                string op = tokens_op[0];
                string contact = tokens_op[1];

                if(op=="add")
                {
                    c.add(contact);
                }
                else if(op == "find")
                {
                    Console.WriteLine( c.find(contact));
                }
            }
        }
       
       
    }
}
