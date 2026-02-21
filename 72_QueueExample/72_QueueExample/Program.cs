using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72_QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GENERIC COLLECTION QUEUE
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // NON GENERIC COLLECTION QUEUE
            Queue queue2 = new Queue();
            queue2.Enqueue(1);
            queue2.Enqueue(2);
            queue2.Enqueue(3);
            queue2.Enqueue(4);

            queue2.Dequeue();
            foreach (var item in queue2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
