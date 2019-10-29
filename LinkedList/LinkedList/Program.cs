using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create linked list
            List list = new List();
            list.AddNode(10);
            list.AddNode(20);
            list.AddNode(30);
            list.AddNode(40);
            list.AddNode(50);

            Console.WriteLine("1. Linked List : \t");
            list.Display();
        }
    }
}
