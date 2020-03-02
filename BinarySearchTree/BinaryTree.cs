using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = null;
        }
        public void Insert(int inputData, Node inputNode = null )

        {
            if ((root == null) && (inputNode == null))
            {
                root = new Node(inputData);
                return;
            }
            else if (inputNode == null)
            {
                inputNode = root;
            }
            if (inputData > inputNode.data)
            {
                if (inputNode.right == null)
                {
                    inputNode.right = new Node(inputData);
                }
                else
                {
                    Insert(inputData, inputNode.right);
                }
            }
            else
            {
                if (inputNode.left == null)
                {
                    inputNode.left = new Node(inputData);
                }
                else
                {
                    Insert(inputData, inputNode.left);
                }
            }
        }
        public bool Search(int inputData, Node inputNode = null)
        {
            if (inputNode == null)
            {
                inputNode = root;
            }
            if (inputNode.data == inputData)
            {
                Console.WriteLine($"       We found {inputData}! It is in our Binary Search Tree");
                return true;
            }
            else if (inputData > inputNode.data)
            {
                if (inputNode.right == null)
                {
                    Console.WriteLine($"       {inputData} not found in Binary Search Tree");
                    return false;
                }
                else
                {
                    return Search(inputData, inputNode.right);
                }
            }
            else
            {
                if (inputNode.left == null)
                {
                    Console.WriteLine($"       {inputData} not found in Binary Search Tree");
                    return false;
                }
                else
                {
                    return Search(inputData, inputNode.left);
                }
            }
        }
    }
}
