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
            //binarytree.Search(binarytree.root, 93);
            Console.WriteLine($"{binarytree.Search(binarytree.root, 105)}");
            Console.WriteLine($"{binarytree.Search(binarytree.root, 100)}");
            Console.WriteLine($"{binarytree.Search(binarytree.root, 82)}");
            Console.WriteLine($"{binarytree.Search(binarytree.root, 116)}");
            Console.WriteLine($"{binarytree.Search(binarytree.root, 78)}");
            Console.WriteLine($"{binarytree.Search(binarytree.root, 93)}");
            Console.WriteLine($"{binarytree.Search(binarytree.root, 105)}");
            Console.WriteLine($"{binarytree.Search(binarytree.root, 123)}");
            Console.WriteLine($"{binarytree.Search(binarytree.root, 77)}");
            Console.ReadLine();
        }
    }
}
