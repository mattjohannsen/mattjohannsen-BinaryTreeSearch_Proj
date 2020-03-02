using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int inputData)
        {
            data = inputData;
            left = null;
            right = null;
        }
        //public Node(int inputData, Node left, Node right)
        //{
        //    data = inputData;
        //    this.left = left;
        //    this.right = right;
        //}
        //public void Insert(int inputData)
        //{
        //    //If the inputData is greater than the current data, then go right.
        //    if (inputData > data)
        //    {
        //        //If this node's right node is empty, then create a right node for this node.
        //        if (right == null)
        //        {
        //            right = new Node(inputData);
        //        }
        //        else
        //        {
        //            //If this node's right node is not empty, then insert the inputData into this right node to continue.
        //            //This process will continue until we find an empty place to create a node for our value.
        //            right.Insert(inputData);
        //        }
        //    }
        //    else
        //    //The inputData must be smaller than the current Node's data, so we will go left to search for a spot to create our new node.
        //    {
        //        //If the inputData is less than or equal to the data, then insert into the left node.
        //        if (left == null)
        //        {
        //            //If the leftnode is empty, then create a left node for this node.
        //            left = new Node(inputData);
        //        }
        //        else
        //        {
        //            //If this node's left node is not empty, then insert the inputData into this left node to continue.
        //            //This process will continue until we find an empty place to create a node for our value.
        //            left.Insert(inputData);
        //        }
        //    }
        //}
        public bool Search(int inputData)
        {
            //If the inputData is equal to the current data. YOU FOUND IT!
            if(data == inputData)
            {
                Console.WriteLine($"       We found {data}! It is in our Binary Search Tree");
                return true;
            }
            //If the inputData is greater than the current data, then go right.
            else if (inputData > data)
            {
                //If this node's right node is empty, then you have run out of option. Value not found.
                if (right == null)
                {
                    Console.WriteLine($"       {inputData} not found in Binary Search Tree");
                    return false;
                }
                else
                {
                    //If this node's right node is not empty, then insert the inputData into this right node to continue.
                    //This process will continue until we find the value or run out of options.
                    return right.Search(inputData);
                }
            }
            else
            //If the inputData is less than the current data, then go left.
            {
                //If this node's left node is empty, then you have run out of option. Value not found.
                if (left == null)
                {
                    Console.WriteLine($"       {inputData} not found in Binary Search Tree");
                    return false;
                }
                else
                {
                    //If this node's left node is not empty, then insert the inputData into this left node to continue.
                    //This process will continue until we find the value or run out of options.
                    return left.Search(inputData);
                }
            }
        }
    }
}
