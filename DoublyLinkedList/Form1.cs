using DoublyLinkedList.MyList;

namespace DoublyLinkedList
{
    public partial class Form1 : Form
    {



        ListRandom listRandom;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listRandom = new ListRandom();
            RefreshWindow();
        }

        private void addNode_button_Click(object sender, EventArgs e)
        {
            listRandom.addNode();

            RefreshWindow();
        }

        private void RefreshWindow()
        {
            count_label.Text = $"count: {listRandom.Count}";
            list_textBox.Text = "adsdasd";
            
        }
    }
}