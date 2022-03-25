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

        public void addNode(ListNode newNode) //вставка в конец списка
        {
            newNode.Next = null; //тк список не кольцевой и добавляем всегда в конец - ссылка на след. эл.=null
            
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;               
                newNode.Previous = null;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
            }
            newNode.Random = GetRandomNode();
            Count++;
        }

        private ListNode GetRandomNode()
        {
            ListNode node = Head;
            int rnd = new Random().Next(Count);
            for (int i = 0; i < rnd; i++)
            {
                node= node.Next;
            }
            return node;
        }

        public void Serialize(Stream s)
        {
        }

        public void Deserialize(Stream s)
        {
        }
    }
}
