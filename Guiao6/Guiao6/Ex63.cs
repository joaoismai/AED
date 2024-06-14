using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiao6
{
    internal class Ex63
    {
        public class Queue
        {
            public int[] array;
            public int front;
            public int rear;
            public int maxSize;

            public Queue(int maxSize)
            {
                this.maxSize = maxSize;
                array = new int[maxSize];
                front = 0;
                rear = -1;
            }

            public bool IsEmpty()
            {
                return front > rear;
            }

            public bool IsFull()
            {
                return rear == maxSize - 1;
            }

            public int? Front()
            {
                if (IsEmpty())
                    return null;
                return array[front];
            }

            public bool Enqueue(int value)
            {
                if (IsFull())
                    return false;
                array[++rear] = value;
                return true;
            }

            public int? Dequeue()
            {
                if (IsEmpty())
                    return null;
                int value = array[front++];
                return value;
            }

            public void PrintQueue()
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.Write(array[i]);
                    if (i < rear)
                        Console.Write(", ");
                }
                Console.WriteLine();
            }
        }
    }
}
