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
            BinaryTree binarytree = new BinaryTree();
            binarytree.Insert(100);
            binarytree.Insert(82);
            binarytree.Insert(116);
            binarytree.Insert(78);
            binarytree.Insert(93);
            binarytree.Insert(105);
            binarytree.Insert(123);
            //binarytree.Search(93);
            //Console.WriteLine($"{binarytree.Search(105)}");
            //Console.WriteLine($"{binarytree.Search(100)}");
            //Console.WriteLine($"{binarytree.Search(82)}");
            //Console.WriteLine($"{binarytree.Search(116)}");
            //Console.WriteLine($"{binarytree.Search(78)}");
            //Console.WriteLine($"{binarytree.Search(93)}");
            //Console.WriteLine($"{binarytree.Search(105)}");
            //Console.WriteLine($"{binarytree.Search(123)}");
            //Console.WriteLine($"{binarytree.Search(77)}");
            Console.ReadLine();
        }
    }
}
