using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Node
    {
        public int key;
        public Node left, right;
        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }
    class GFG
    {
        Node root;
        // returns true if trees with roots
        // as root1 and root2 are mirror
        Boolean isMirror(Node node1, Node node2)
        {
            // if both trees are empty,
            // then they are mirror image
            if (node1 == null && node2 == null)
                return true;

            if (node1 != null && node2 != null && node1.key == node2.key)
                return (isMirror(node1.left, node2.right)
                        && isMirror(node1.right, node2.left));
            // if none of the above conditions
            // is true then root1 and root2 are
            // mirror images
            return false;
        }
        // returns true if the tree is symmetric
        // i.e mirror image of itself
        Boolean isSymmetric()
        {
            // check if tree is mirror of itself
            return isMirror(root, root);
        }
        // Driver Code
        static public void Main(String[] args)
        {
            GFG tree = new GFG();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(2);
            tree.root.left.left = new Node(3);
            tree.root.left.right = new Node(4);
            tree.root.right.left = new Node(4);
            tree.root.right.right = new Node(3);
            Boolean output = tree.isSymmetric();
            if (output == true)
                Console.WriteLine("Symmetric");
            else
                Console.WriteLine("Not symmetric");
            Console.ReadLine();
        }
    }
}

