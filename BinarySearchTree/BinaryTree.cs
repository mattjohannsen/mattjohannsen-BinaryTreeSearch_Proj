using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        //first node in tree
        private Node root;

        public BinaryTree()
        {
            root = null;
        }
        public void Insert(int data)
        {
            if (root == null)
            {
                root = new Node(data);
            }
            else
            {
                root.Insert(data);
            }

            //if (data < root.data)
            //{
                
            //    Node temp = new Node(data);
            //    //temp.left = root.left;
            //    temp.right = root;
            //    //root = temp;
            //}
        }
        public void Insert(int data, Node inputLeft, Node inputRight)
        {
            Node temp = new Node(data);
            temp.left = inputLeft;
            temp.right = inputRight;
        }
    }
}
