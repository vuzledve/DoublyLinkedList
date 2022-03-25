using System.Text;

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
            Stream s = new FileStream(path, FileMode.Create);
            Serialize(s);
        }
        public void Serialize(Stream s)
        {
            try 
            {
                ListNode tmp = Head;
                for (int i = 0; i < count; i++)
                {
                    byte[] bytes = new byte[tmp.Data.Length];
                    bytes = Encoding.ASCII.GetBytes(tmp.Data);
                   // byte[] bytes = Encoding.ASCII.GetBytes(tmp.Data);
                    if (s.CanWrite)
                    {
                        s.Write(bytes, 0, bytes.Length);
                    }
                    else
                    {
                        throw new Exception("FileStream can't write");
                    }
                    tmp = tmp.Next;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error:" + e);
            }
            finally
            {
                s.Close();
            }
            
        }

        public void Deserialize(Stream s)
        {
            //string someString = Encoding.ASCII.GetString(bytes);
        }
    }
}
