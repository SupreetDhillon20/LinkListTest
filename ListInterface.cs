using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public interface ListInterface
    {
        Node? Head { get; }
        Node? Tail { get; }
        int counter { get; }

        void AddTheFirst(string data);
        void AddTheLast(string data);
        void RemoveFirst();
        void RemoveLast();
        //bool Contains(string data);
        string GetValue(int index);
        void PrintList();
    }
}
