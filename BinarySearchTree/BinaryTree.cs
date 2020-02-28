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

        public void CreateTree()
        {
            root = new Node(50);

            
        }
    }
}
