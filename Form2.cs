namespace NotesApp
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string title, string message)
        {
            InitializeComponent();

           
            txtTitle.Text = title;
            txtMessage.Text = message;
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
