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
            if (root != null)
            {
                root.Insert(data);
            }
            else
            {
                root = new Node(data);
            }
        }
        public bool Search(int inputData)
        {
            if (root.data == inputData)
            {
                Console.WriteLine($"       We found {inputData}! It is in our Binary Search Tree");
                return true;
            }
            //If the inputData is greater than the root data, then go right.
            else if (inputData > root.data)
            {
                //If this right node is empty, then this value was not found in our Binary Search tree.
                if (root.right == null)
                {
                    Console.WriteLine($"       {inputData} not found in Binary Search Tree");
                    return false;
                }
                else
                {
                    //If this node's right node is not empty, then search this node for the desired value.
                    //This process will continue until we find the desired value or all null values.
                    root.right.Search(inputData);
                }
            }
            else
            //If the inputData is less than the root data, then go left.
            {
                //If this left node is empty, then this value was not found in our Binary Search tree.
                if (root.left == null)
                {
                    Console.WriteLine($"       {inputData} not found in Binary Search Tree");
                    return false;
                }
                else
                {
                    //If this node's left node is not empty, then search this node for the desired value.
                    //This process will continue until we find the desired value or all null values.
                    root.left.Search(inputData);
                }
            }
            return false;
        }
    }
}
