using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao6
{
    internal class Ex62
    {
        public class Stack
        {
            private int[] array;
            private int top;
            private int maxSize;

            public Stack(int maxSize)
            {
                this.maxSize = maxSize;
                array = new int[maxSize];
                top = -1; // Inicializa o topo como -1 (pilha vazia)
            }

            public bool IsEmpty()
            {
                return top == -1;
            }

            public int Size()
            {
                return top + 1;
            }

            public bool IsFull()
            {
                return top == maxSize - 1;
            }

            public int? Top()
            {
                if (IsEmpty())
                    return null;
                return array[top];
            }

            public bool Push(int value)
            {
                if (IsFull())
                    return false;
                array[++top] = value;
                return true;
            }

            public int? Pop()
            {
                if (IsEmpty())
                    return null;
                return array[top--];
            }

            public void PrintStack()
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.Write(array[i]);
                    if (i > 0)
                        Console.Write(", ");
                }
                Console.WriteLine();
            }
        }
    }
}
