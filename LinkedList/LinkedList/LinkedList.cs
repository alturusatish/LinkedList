using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }

    }

    public class List
    {
        public Node Head { get; set; }

        public List()
        {
            Head = null;
        }

        public void AddNode(int data)
        {
            if (Head == null)
            {
                Head = new Node(data);
            }
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = new Node(data);
            }
        }

        public void Display()
        {
            Node temp = Head;
            while (temp.Next != null)
            {
                Console.Write(temp.Data + "-->");
                temp = temp.Next;
            }
            Console.Write(temp.Data + "\n");
        }

        public void Display(Node node)
        {
            while (node.Next != null)
            {
                Console.Write(node.Data + "-->");
                node = node.Next;
            }
            Console.Write(node.Data + "\n");
        }
    }
}
