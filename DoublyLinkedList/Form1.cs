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

        #region Обработка нажатий кнопок

        private void addNode_button_Click(object sender, EventArgs e)
        {
            listRandom.addNode();

            RefreshWindow();
        }


        private void Serialization_button_Click(object sender, EventArgs e)
        {

        }

        private void Deserialization_button_Click(object sender, EventArgs e)
        {

        } 
        #endregion

        #region Методы для отображения интерфейса
        private void RefreshWindow()
        {
            count_label.Text = $"count: {listRandom.Count}";

            list_textBox.Text = listRandom.GetAllListData();

            //string data = listRandom.GetAllListData();
            //for (int i = 0; i < data.Length; i++)
            //    if (data[i] == '\n')
            //        list_textBox.Text += Environment.NewLine;
            //    else
            //        list_textBox.Text += data[i];
        } 
        #endregion

    }
}