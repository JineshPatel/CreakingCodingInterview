using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloombergCoding
{
    class Program
    {

        static void Main(string[] args)
        {
            TreeNode rootPtr = new TreeNode();
            rootPtr = null;
            Tree a = new Tree();

            rootPtr = a.Insert(rootPtr, "Apple", 0, 1);

            rootPtr = a.Insert(rootPtr, "Orange", 1, 2);
            rootPtr = a.Insert(rootPtr, "Apple", 2, 3);
            rootPtr = a.Insert(rootPtr, "Pear", 2, 4);

            rootPtr = a.Insert(rootPtr, "Cherry", 3, 5);
            rootPtr = a.Insert(rootPtr, "Cherry", 3, 6);
            rootPtr = a.Insert(rootPtr, "Orange", 3, 7);
            rootPtr = a.Insert(rootPtr, "Orange", 3, 8);

            Dictionary<String, int> stringCount = a.UniqueStringAndCount(rootPtr);


            Console.Write("There are ");

            foreach (var item in stringCount)
            {
                Console.Write($"{item.Value} { item.Key},");
            }
            Console.ReadKey();
        }


    }

    public class TreeNode
    {
        public string data;
        public List<TreeNode> childNodes;
        public int parentID;
        public int ID;


        public void addChild(TreeNode node)
        {
            childNodes.Add(node);
        }
        // public TreeNode right;
    }

    class Tree
    {
        TreeNode root = null;
        /// <summary>
        ///  we will insert the node with parent and Unique ID
        /// </summary>
        /// <param name="root"></param>
        /// <param name="data"></param>
        /// <param name="parentID"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public TreeNode Insert(TreeNode root, string data, int parentID, int id)
        {
            if (parentID == 0)
            {
                root = getNewNode(data, parentID, id);
            }
            else
            {
                TreeNode t = getNode(parentID, root);
                t.addChild(getNewNode(data, parentID, id));
            }
            return root;
        }
        TreeNode result = new TreeNode();

        /// <summary>
        /// We will find the parent node to add child to it.
        /// </summary>
        /// <param name="parentID"></param>
        /// <param name="root"></param>
        /// <returns></returns>
        private TreeNode getNode(int parentID, TreeNode root)
        {

            if (root.ID == parentID)
            {
                return root;
            }
            if (root.childNodes.Any(a => a.ID == parentID))
            {
                result = root.childNodes.FirstOrDefault(a => a.ID == parentID);
            }

            if (root.childNodes.Count > 0)
            {
                foreach (var child in root.childNodes)
                {
                    getNode(parentID, child);
                }
            }
            return result;
        }

        /// <summary>
        /// get new node for to insert in tree.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="parentID"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        TreeNode getNewNode(string data, int parentID, int id)
        {
            TreeNode node = new TreeNode();
            node.data = data;
            node.parentID = parentID;
            node.ID = id;
            node.childNodes = new List<TreeNode>();
            return node;
        }

        //Dictionary to count unique string.
        Dictionary<String, int> stringCount = new Dictionary<string, int>();

        /// <summary>
        /// Count unique string recursively.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public Dictionary<String, int> UniqueStringAndCount(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            if (stringCount.ContainsKey(root.data.ToString()))
            {
                stringCount[root.data.ToString()]++;
            }
            else
            {
                stringCount.Add(root.data.ToString(), 1);
            }
            Console.WriteLine(root.data);
            if (root.childNodes.Count > 0)
            {
                foreach (var child in root.childNodes)
                {
                    UniqueStringAndCount(child);
                }
            }
            return stringCount;
        }
    }
}
