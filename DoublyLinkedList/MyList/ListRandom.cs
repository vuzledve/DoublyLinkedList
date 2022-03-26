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
            Clear();
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
        public void addNode(string data) //вставка в конец списка
        {
            ListNode newNode = new ListNode(data);
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
                node = node.Next;
            }
            return node;
        }

        public string GetAllListData()
        {
            string data = "";
            ListNode tmp = Head;
            for (int i = 0; i < count; i++)
            {
                data += tmp.Data + Environment.NewLine + GetNodeNum(tmp.Random) + Environment.NewLine;
                tmp = tmp.Next;
            }
            return data;
        }
        #region запись в файл
        public void FileWrite(string path)
        {
            Stream s = new FileStream(path, FileMode.Create);
            Serialize(s);
            Clear();
        }
        public void Serialize(Stream s)
        {
            try
            {
                ListNode tmp = Head;
                for (int i = 0; i < count; i++)
                {
                    byte[] nodeData = new byte[tmp.Data.Length];
                    nodeData = Encoding.ASCII.GetBytes(tmp.Data);

                    string str = Convert.ToString(GetNodeNum(tmp.Random));
                    byte[] nodeRandomNum = new byte[str.Length];
                    nodeRandomNum = Encoding.ASCII.GetBytes(str);
                    
                    if (s.CanWrite)
                    {
                        s.Write(nodeData, 0, nodeData.Length);
                        s.WriteByte((byte)'\n');
                        s.Write(nodeRandomNum, 0, nodeRandomNum.Length);
                        s.WriteByte((byte)'\n');
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
        #endregion

        #region чтение из файла
        public void FileRead(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception("File " + path + " does not exists");
            }
            if (File.ReadAllBytes(path).Length > 0)
            {
                Stream s = new FileStream(path, FileMode.Open);
                Clear();
                Deserialize(s);
            }
            else
                throw new Exception("File " + path + " is empty");
        }
        public void Deserialize(Stream s)
        {
            string data = "";

            byte[] temp = new byte[1];
            UTF8Encoding encoding = new UTF8Encoding(true);

            for (int i = 0; s.Read(temp, 0, temp.Length) > 0; i++)
            {
                String str = encoding.GetString(temp, 0, 1);
                // char ch = (char)encoding.GetChars(temp, ch);
                if (str[0] != '\n')
                {
                    //запись в тек. ноду
                    data += str[0];
                }
                else
                {
                    addNode(data);
                    data = "";
                }
            }
            s.Close();

        }
        #endregion

        private void Clear()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        private int GetNodeNum(ListNode node)
        {
            int id = 0;
            if (Head != null)
            {
                ListNode tmp = Head;
                while (tmp!=node)
                {
                    tmp=tmp.Next;
                    id++;
                }
            }
            else
            {
                id = -1;
            }

            return id;
        }
        private ListNode GetNode(int num)
        {
            ListNode tmp = Head;

            for (int i = 0; i < num; i++)
            {
                tmp = tmp.Next;
            }
            return tmp;
        }
    }
}
