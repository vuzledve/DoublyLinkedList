using DoublyLinkedList.MyList;

namespace DoublyLinkedList
{
    public partial class Form1 : Form
    {

        #region Инициализация
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
        #endregion

        #region Обработка нажатий кнопок

        private void addNode_button_Click(object sender, EventArgs e)
        {
            listRandom.addNode();
            RefreshWindow();
        }


        private void Serialization_button_Click(object sender, EventArgs e)
        {
            listRandom.FileWrite(@path_textBox.Text);
            RefreshWindow();
        }

        private void Deserialization_button_Click(object sender, EventArgs e)
        {
            listRandom.FileRead(@path_textBox.Text);
            RefreshWindow();
        }

        private void Save_changes_button_Click(object sender, EventArgs e)
        {
            listRandom = new ListRandom(list_textBox.Text);
            RefreshWindow();
            MessageBox.Show("Изменения сохранены");
        }

        private void Refresh_window_button_Click(object sender, EventArgs e)
        {
            RefreshWindow();
        }
        #endregion

        #region Методы для отображения интерфейса
        private void RefreshWindow()
        {
            count_label.Text = $"count: {listRandom.Count}";

            list_textBox.Text = listRandom.GetAllListData();
        }
        #endregion
    }
}