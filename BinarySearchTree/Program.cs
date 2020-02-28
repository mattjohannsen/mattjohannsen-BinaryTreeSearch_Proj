using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("This the the Binary Search Tree");
            BinaryTree binarytree = new BinaryTree();
            binarytree.CreateTree();
            Console.ReadLine();
        }
    }
}
