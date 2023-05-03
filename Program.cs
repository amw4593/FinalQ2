using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalQ2
{
    internal class Program
    {
        class MyQueue
        {
            private List<int> list;

            public MyQueue()
            {
                list = new List<int>();
            }

            public void Enqueue(int n)
            {
                list.Add(n);
            }

            public int Dequeue()
            {
                int firstItem = list[0];
                list.RemoveAt(0);
                return firstItem;
            }

            public int Peek()
            {
                return list[0];
            }
        }
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);

            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Peek());

        }
    }
}
