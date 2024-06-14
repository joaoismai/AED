using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao6
{
    internal class Ex64
    {
        public class TreeNode
        {
            public int Data { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        public class BinaryTree
        {
            private TreeNode root;

            public BinaryTree()
            {
                root = null;
            }

            public TreeNode AddNode(int data)
            {
                var newNode = new TreeNode(data);
                if (root == null)
                {
                    root = newNode;
                }
                else
                {
                    InsertNode(root, newNode);
                }
                return newNode;
            }

            private void InsertNode(TreeNode current, TreeNode newNode)
            {
                if (newNode.Data < current.Data)
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                    }
                    else
                    {
                        InsertNode(current.Left, newNode);
                    }
                }
                else if (newNode.Data > current.Data)
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                    }
                    else
                    {
                        InsertNode(current.Right, newNode);
                    }
                }
            }

            public void DisplayTree(TreeNode node)
            {
                if (node == null)
                    return;

                DisplayTree(node.Left);
                Console.Write(node.Data + " ");
                DisplayTree(node.Right);
            }
        }
    }
}
