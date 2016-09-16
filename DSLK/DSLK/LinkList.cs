using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;

namespace DSLK
{
    class LinkList
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            for (int i = 0; i < 4; i++)
            {
                list.AddLast(i);

            }

            LinkedListNode<int> node = list.First;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
        }
            Console.ReadKey();
    }

    }
}
