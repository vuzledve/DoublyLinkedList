
namespace DoublyLinkedList.MyList
{

    public class ListRandom
    {
        private ListNode? Head;
        private ListNode? Tail;
        private int count;

        public int Count { get => count; }
        public ListRandom()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        public void addNode() //вставка в конец списка
        {
            ListNode newNode = new ListNode();
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
            count++;
        }

        private ListNode GetRandomNode()
        {
            ListNode node = Head;
            int rnd = new Random().Next(count);
            for (int i = 0; i < rnd; i++)
            {
                node= node.Next;
            }
            return node;
        }

        public string GetAllListData()
        {
            string data = "";
            ListNode tmp = Head;
            for (int i=0; i< count;i++)
            {
                data += tmp.Data + Environment.NewLine;
                tmp = tmp.Next;
            }
            return data;
        }
        public void FileWrite(string path)
        {
           // string path = "C:/temp/MyTest.txt";
            Stream s = new FileStream("path", FileMode.Create);
            Serialize(s);
        }
        public void Serialize(Stream s)
        {
            
        }

        public void Deserialize(Stream s)
        {
        }
    }
}
