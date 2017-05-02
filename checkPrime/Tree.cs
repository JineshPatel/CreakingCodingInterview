using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkPrime
{
   public class TreeNode
    {
       public int data;
       public TreeNode left;
       public TreeNode right;
    }
    class Tree
    {
        TreeNode root = null;
        public TreeNode createMinimalBST(int[] a)
        {
            return createMinimalBST(a, 0, a.Length - 1);
        }

        private TreeNode createMinimalBST(int[] a, int start, int end)
        {
            if (end<start)
            {
                return null;
            }
            int mid = start + end / 2;
            TreeNode n = new TreeNode();
            n.data = a[mid];
            n.left = createMinimalBST(a, start, mid - 1);
            n.right = createMinimalBST(a, mid + 1, end);
            return n;
        }
        public int FindHeight(TreeNode root)
        {
            if (root==null)
            {
                return -1;
            }
            return Math.Max(FindHeight(root.left), FindHeight(root.right)) + 1;
        }
        
       public void levelOrder(TreeNode root)
        {
            if (root==null)
            {
                return;
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while(q.Count!=0)
            {
                TreeNode current = q.Peek();
                Console.WriteLine(current.data);
                if (current.left!=null)
                {
                    q.Enqueue(current.left);
                }
                if (current.right!=null)
                {
                    q.Enqueue(current.right);
                }
                q.Dequeue();
            }
        }

        public bool IsBSTUtil(TreeNode root, int min, int max)

        {
            if (root==null)
            {
                return true;
            }
            if (root.data > min && root.data < max
                && IsBSTUtil(root.left, min, root.data) && IsBSTUtil(root.right, root.data, max))
            {
                return true;
            }

            else
                return false;
        }

        public TreeNode Delete(TreeNode root,int data)
        {
            if (root==null)
            {
                return root;
            }
            else if(data< root.data)
            {
              root.left=  Delete(root.left, data);
            }
            else if (data>root.data)
            {
                root.right = Delete(root.right, data);
            }
            else
            {
                //case 1 : No Child
                if (root.left==null && root.right==null)
                {
                    root = null;
                }
                //CASE 2 : One Child
                else if(root.left==null )
                {
                    TreeNode temp = root;
                    root = root.right;
                    temp = null;
                }
                else if (root.right == null)
                {
                    TreeNode temp = root;
                    root = root.left;
                    temp = null;

                }
                else
                {
                    int temp = findMinTree(root.left);
                    root.data = temp;
                    root.right = Delete(root.right, temp);
                }
                
            }
            return root;
        }

        public TreeNode getSuccessor(TreeNode root,int data)
        {
            TreeNode current = find(root, data);
            if (current==null)
            {
                return null;
            }
            //IF we have right subtree
            if (current.right!=null)
            {
                return findMinNode(current.right);
            }
            else
            {
                TreeNode sucessor = null;
                TreeNode ancetor = root;
                while (ancetor!=current)
                {
                    if (current.data < ancetor.data)
                    {
                        sucessor = ancetor;
                        ancetor = ancetor.left;
                    }
                    else
                        ancetor = ancetor.right;
                }
                return sucessor;
            }

        }

        private TreeNode findMinNode(TreeNode root)
        {
            if (root==null)
            {
                return root;
            }
            while (root.left!=null)
            {
                root = root.left;
            }
            return root;
        }

        private TreeNode find(TreeNode root, int data)
        {
            if (root == null)
                return root;
            if (root.data ==data)
            {
                return root;
            }
            else if(data<root.data)
            {
                return find(root.left, data);
            }
            else
            {
                 return find(root.right, data);
            }
        }

        public bool IsBST(TreeNode root)
        {
            return IsBSTUtil(root, int.MinValue, int.MaxValue);
        }
        private int findMaxTree(TreeNode root)
        {
            if (root == null)
            {
                return -1;
            }
            else if (root.right == null)
            {
                return root.data;
            }
            return findMinTree(root.right); ;

        }

        public void PreOrder(TreeNode root)
        {
            if (root==null)
            {
                return;
            }
            Console.WriteLine(root.data);
            PreOrder(root.left);
            PreOrder(root.right);
        }
        public void inOrder(TreeNode root)
        {
            if (root==null)
            {
                return;
            }
            inOrder(root.left);
            Console.WriteLine(root.data);
            inOrder(root.right);
        }
        public int findMinTree(TreeNode root)
        {
            
            if (root==null)
            {
                return -1;
            }
            else if(root.left==null)
            {
                return root.data;
            }
            return findMinTree(root.left); ;
        }
        TreeNode getNewNode(int data)
        {
            TreeNode node = new TreeNode();
            node.data = data;
            node.left = null;
            node.right = null;
            return node;
        }

        public TreeNode Insert(TreeNode root, int data)
        {
            if (root==null)
            {
                root = getNewNode(data);
            }
            else if (data<=root.data)
            {
                    root.left = Insert(root.left,data);
            }
            else
            {
                    root.right = Insert(root.right,data);
            }
            
            return root;
        }

       public bool search(TreeNode root,int data)
        {
            if (root==null)
            {
                return false;
            }
            else if(root.data == data)
            {
                return true;
            }
            else if(data<=root.data)
            {
               return  search(root.left, data);
            }
            else
            {
                return search(root.right, data);
            }

        }
    }
}
