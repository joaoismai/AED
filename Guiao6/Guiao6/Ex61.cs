using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao6
{
    internal class Ex61
    {
        public class Node
        {
            public int Value { get; set; }
            public Node? Next { get; set; }
        }

        public class LinkedList
        {
            private Node? head;

            public void Add(int value)
            {
                var newNode = new Node { Value = value };
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    var current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }

            public void PrintList()
            {
                var current = head;
                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }
    }
}
