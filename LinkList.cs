using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class LinkList: ListInterface
    {
        public Node? Head {  get; private set; } // ? for can have null values
        public Node? Tail { get; private set; }
        public int counter {  get; private set; }

        public LinkList() 
        {
            Head = null;
            Tail = null;
            counter = 0;
        }

        public void AddTheFirst(string data)
        {
            Node newNode = new Node(data);
            if(Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }

            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
            counter++;
        }

        public void AddTheLast(string data)
        {
            Node newNode = new Node(data);
            if(Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }

            else 
            { 
                Tail.Next = newNode;
            }
            Tail = newNode;
            counter++;
        }

        public void PrintList()
        {
            Node? current = Head;
            if (current == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }


        public void RemoveLast()
        {
            if (Head == null) 
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (Head.Next == null)
            {
                Head = null;
                Tail = null;
            }

            else
            {
                Node current = Head;
                //while (current.Next.Next != null)
                while (current.Next != Tail)
                { 
                    current = current.Next;
                }
                current.Next = null;
                Tail = current;
            }
            counter--;
        }

        public void RemoveFirst()
        { 
            if (Head != null)
            {
                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                }
                counter--;
            } 

            else
            {
                Console.WriteLine("List is empty.");
            }
        }
        public string GetValue(int index)
        {
            if (index < 0 || index >= counter)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            Node? current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current?.Next;
            }
            return current!.Data;
        }
    }
}
