namespace DoublyLinkedList
{
    public partial class Form1 : Form
    {
        class ListNode
        {
            public ListNode Previous;
            public ListNode Next;
            public ListNode Random; // произвольный элемент внутри списка
            public string Data;
        }


        class ListRandom
        {
            public ListNode Head;
            public ListNode Tail;
            public int Count;

            public void Serialize(Stream s)
            {
            }

            public void Deserialize(Stream s)
            {
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}