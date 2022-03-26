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
            List<int> numbers = new List<int>(); //вообще можно было бы сразу искать ноду, которая записана в поле рандом тк при генерации списка кнопкой в интерфейсе номер рандомНоды выбирается из уже существующих. запись номеров в list нужна в случае если возможен вариант когда номер указывает на элемент, который добавится в список позже(например ввод вручную через файл или текстБокс)
            ListNodeField fieldNum = ListNodeField.data; //тут можно bool и вместо switch написать if, но тогда при добавлении полей в ListNode это надо было бы переписывать

            byte[] temp = new byte[1];
            UTF8Encoding encoding = new UTF8Encoding(true);

            while (s.Read(temp, 0, temp.Length) > 0)
            {
                String str = encoding.GetString(temp, 0, 1); //содержит только что прочитанный символ
               
                if (str[0] != '\n')
                {
                    switch (fieldNum)
                    {
                        case ListNodeField.data:
                            data += str[0];
                            break;
                        case ListNodeField.random:
                            if (numbers.Count < count)
                                numbers.Add(Int32.Parse(str)); //если элемент еще не создавался - создаем
                            else
                                numbers[count - 1] = (numbers[count - 1]*10)+ Int32.Parse(str); //count уже учитывает создаваемую ноду
                            break;
                    }       
                }
                else
                {
                    switch (fieldNum)
                    {
                        case ListNodeField.data:
                            addNode(data); //при прочтении первого поля создаем ноду
                            data = "";
                            fieldNum = ListNodeField.random;
                            break;
                        case ListNodeField.random:
                            fieldNum = ListNodeField.data;
                            break;
                    }
                   
                }
            }
            s.Close();

            /* заполнение полей ListNode.Random */
            ListNode tmp = Head;
            for (int i = 0; i < count; i++)
            {
                tmp.Random = GetNode(numbers[i]);
                tmp = tmp.Next;
            }
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

        enum ListNodeField
        {
            data,
            random
        }
    }
}
