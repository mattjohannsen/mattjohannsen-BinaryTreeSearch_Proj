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
        public Node root;

        public BinaryTree()
        {
            root = null;
        }
        public void Insert(int inputData)
        {
            if (root != null)
            //The root is not empty, so let's figure out where to put the new node
            {
                //If the inputData is greater than the current data, then go right.
                if (inputData > root.data)
                {
                    //If this node's right node is empty, then create a right node for this node.
                    if (root.right == null)
                    {
                        root.right = new Node(inputData);
                    }
                    else
                    {
                        //If this node's right node is not empty, then insert the inputData into this right node to continue.
                        //This process will continue until we find an empty place to create a node for our value.
                        Insert(root.right, inputData);
                    }
                }
                else
                //The inputData must be smaller than the current Node's data, so we will go left to search for a spot to create our new node.
                {
                    //If the inputData is less than or equal to the data, then insert into the left node.
                    if (root.left == null)
                    {
                        //If the leftnode is empty, then create a left node for this node.
                        root.left = new Node(inputData);
                    }
                    else
                    {
                        //If this node's left node is not empty, then insert the inputData into this left node to continue.
                        //This process will continue until we find an empty place to create a node for our value.
                        Insert(root.left, inputData);
                    }
                }
            }
            else
            //The root is empty, so make a new root node
            {
                root = new Node(inputData);
            }
        }
        public void Insert(Node inputNode, int inputData)
        //The node is not empty, so let's figure out where to put the new node
        {
            //If the inputData is greater than the current data, then go right.
            if (inputData > inputNode.data)
            {
                //If this node's right node is empty, then create a right node for this node.
                if (inputNode.right == null)
                {
                    inputNode.right = new Node(inputData);
                }
                else
                {
                    //If this node's right node is not empty, then insert the inputData into this right node to continue.
                    //This process will continue until we find an empty place to create a node for our value.
                    Insert(inputNode.right, inputData);
                }
            }
            else
            //The inputData must be smaller than the current Node's data, so we will go left to search for a spot to create our new node.
            {
                //If the inputData is less than or equal to the data, then insert into the left node.
                if (inputNode.left == null)
                {
                    //If the leftnode is empty, then create a left node for this node.
                    inputNode.left = new Node(inputData);
                }
                else
                {
                    //If this node's left node is not empty, then insert the inputData into this left node to continue.
                    //This process will continue until we find an empty place to create a node for our value.
                    Insert(inputNode.left, inputData);
                }
            }
        }
        public bool Search(Node inputNode, int inputData)
        {
            if (inputNode.data == inputData)
            {
                Console.WriteLine($"       We found {inputData}! It is in our Binary Search Tree");
                return true;
            }
            //If the inputData is greater than the root data, then go right.
            else if (inputData > inputNode.data)
            {
                //If this right node is empty, then this value was not found in our Binary Search tree.
                if (inputNode.right == null)
                {
                    Console.WriteLine($"       {inputData} not found in Binary Search Tree");
                    return false;
                }
                else
                {
                    //If this node's right node is not empty, then search this node for the desired value.
                    //This process will continue until we find the desired value or all null values.
                    return Search(inputNode.right, inputData);
                }
            }
            else
            //If the inputData is less than the root data, then go left.
            {
                //If this left node is empty, then this value was not found in our Binary Search tree.
                if (inputNode.left == null)
                {
                    Console.WriteLine($"       {inputData} not found in Binary Search Tree");
                    return false;
                }
                else
                {
                    //If this node's left node is not empty, then search this node for the desired value.
                    //This process will continue until we find the desired value or all null values.
                    return Search(inputNode.left, inputData);
                }
            }
        }
    }
}
