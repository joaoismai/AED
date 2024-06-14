using static Guiao6.Ex64;

namespace Guiao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 6.1
            var myList = new Ex61.LinkedList();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.PrintList();
            */


            /* Exercicio 6.2
            Ex62.Stack myStack = new Ex62.Stack(maxSize: 5);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            Console.WriteLine($"Stack size: {myStack.Size()}");
            Console.WriteLine($"Top element: {myStack.Top()}");
            myStack.PrintStack();
            int? poppedValue = myStack.Pop();
            Console.WriteLine($"Popped value: {poppedValue}");
            myStack.PrintStack();
            */



            /* Exercicio 6.3
            Ex63.Queue myQueue = new Ex63.Queue(maxSize: 5);
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            Console.WriteLine($"Queue size: {myQueue.rear - myQueue.front + 1}");
            Console.WriteLine($"Front element: {myQueue.Front()}");
            myQueue.PrintQueue();
            int? dequeuedValue = myQueue.Dequeue();
            Console.WriteLine($"Dequeued value: {dequeuedValue}");
            myQueue.PrintQueue();
            */



            /* Exercicio 6.4
            BinaryTree binaryTree = new Ex64.BinaryTree();
            TreeNode rootNode = binaryTree.AddNode(5);
            binaryTree.AddNode(6);
            binaryTree.AddNode(10);
            binaryTree.AddNode(2);
            binaryTree.AddNode(3);

            Console.Write("In-order traversal: ");
            binaryTree.DisplayTree(rootNode);
            Console.WriteLine();

            Console.WriteLine("Total number of nodes: " + CountNodes(rootNode));
            Console.ReadLine();
            static int CountNodes(TreeNode node)
            {
                if (node == null)
                    return 0;
                return 1 + CountNodes(node.Left) + CountNodes(node.Right);
            }
            */



            /* Exercicio 6.5
            Ex65 ex65 = new Ex65();
            ex65.Hashtable();
            */
        }
    }
}
