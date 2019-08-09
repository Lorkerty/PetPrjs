using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treteeSashke
{
    
    
       
       
    
    class MainClass
    {
        static void Main(string[] args)
        {
            var linkedQueue = new LazyQueue<int>();
            linkedQueue.Enqueue(1);
            linkedQueue.Enqueue(2);
            linkedQueue.Enqueue(3);
            linkedQueue.Enqueue(4);
            linkedQueue.Enqueue(5);

            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Peak());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Dequeue());
            //lazyQueue.Enqueue(1);
            //lazyQueue.Enqueue(14);
            //lazyQueue.Enqueue(122);
            //lazyQueue.Enqueue(2);
            //Console.WriteLine(lazyQueue.Dequeue());
            //Console.WriteLine(lazyQueue.Peak());
            //Console.WriteLine(lazyQueue.Dequeue());



            Console.ReadKey();
        }
        
    }
}
