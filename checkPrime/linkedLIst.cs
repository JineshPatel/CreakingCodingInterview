using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkPrime
{
    public class Node
    {
        public Node next;
        public object data;
    }

    public class linkedLIst
    {
        public Node head;


        public void printAllNode()
        {
            Node cur = head;
            while (cur!=null)
            {
                Console.Write($"{cur.data}  ");
                cur = cur.next;
            }
            Console.WriteLine();
        }

        public void add(object data )
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else if(head.next ==null)
            {
                Node toadd = new Node();
                toadd.data = data;

                head.next = toadd;
                toadd.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;
                toAdd.next = null;
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }

        public Node  delete(Node head,object data)
        {
            Node n = head;
            if(n.data == data)
            {
                return head.next;
            }
            while (n.next!=null)
            {
                if (n.next.data==data)
                {
                    n.next = n.next.next;
                    return head;
                }
                n = n.next;
            }
            return head;
        }

        public int kthLastElement(Node  head,int k)
        {
             
            if (head==null)
            {
                return 0;
            }
            else
            {
                Console.WriteLine($"head data is {head.data}");
            }
            int index = kthLastElement(head.next, k) + 1;
            Console.WriteLine(index);
            if (index==k)
            {
                Console.WriteLine($"kth elemnt from last is {head.data}");
            }
            return index;
        }

        public Node reverse(Node node)
        {
            //linkedLIst reversed = new linkedLIst();
            Node head = null;
            while (node !=null)
            {
                Node navo = new Node();
                navo.data = node.data;
                navo.next = head;
                head = navo;
                node = node.next;
            }
            return head;
        }
        public Node reverseIteratice(Node head)
        {
            Node current = new Node();
            Node pre = new Node();
            Node next = new Node();

            while (current.next!=null)
            {
                
                next = current.next;
                current.next = pre;
                pre = current;
                current = next;

            }
            head = pre;
            return head;
        }
       public Boolean isPlanDrom(Node head)
        {
            Node reversed = reverse(head);
            return isEqual(head,reversed);
        }

        private bool isEqual(Node one, Node two)
        {
            while(one!=null && two!=null)
            {
                if (!one.data.Equals(two.data))
                {
                    return false;
                }
                else
                {
                    one = one.next;
                    two = two.next;
                }
            }
            return one==null && two == null;
        }

        public Node loop(Node head)
        {
            Node fast= head;
            Node slow = head;

            while (fast!=null && fast.next!=null)

            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow==fast)
                {
                    break;
                }
            }
            if (fast==null || fast.next ==null)
            {
                return null;
            }
            slow = head;

            while (fast!=slow)
            {
                slow = slow.next;
                fast = fast.next;

            }

            return fast;
        }

        public void printRecursion(Node head)
        {
            if (head==null)
            {
                return;
            }

            Console.Write(head.data + " ");
            printRecursion(head.next);
        }

        public void reversePrintRecursion(Node head)
        {
            if (head==null)
            {
                return;
            }
            reversePrintRecursion(head.next);
            Console.Write(head.data + " ");

        }


        public void reverseLinkedList(Node p)
        {
            if (p.next==null)
            {
                head = p;
                return;
            }
            reverseLinkedList(p.next);
            Node n = p.next;//point to next node.
            n.next = p;
            p.next = null;

        }
    }
}
