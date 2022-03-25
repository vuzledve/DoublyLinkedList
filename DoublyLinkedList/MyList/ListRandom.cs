using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList.MyList
{
    class ListRandom
    {
        public ListNode? Head;
        public ListNode? Tail;
        public int Count;

        public ListRandom()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void Serialize(Stream s)
        {
        }

        public void Deserialize(Stream s)
        {
        }
    }
}
