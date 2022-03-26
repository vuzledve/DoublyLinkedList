using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList.MyList
{
    public class ListNode
    {
        public ListNode? Previous;
        public ListNode? Next;
        public ListNode? Random; // произвольный элемент внутри списка
        public string Data;
        public ListNode()
        {
            Previous = null;
            Next = null;
            Random = null;
            Data = StrMethods.RandomStr(3,7);
        }
        public ListNode(string data)
        {
            Previous = null;
            Next = null;
            Random = null;
            Data = data;
        }
    }
}
