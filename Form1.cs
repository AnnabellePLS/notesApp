using System.Data;

namespace NotesApp
{
    public partial class Form1 : Form
    {
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 140;
        }

        private void bttnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMessage.Text);

            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void bttnRead_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null) return;

            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1 && index < table.Rows.Count)
            {
                txtTitle.Text = table.Rows[index]["Title"].ToString();
                txtMessage.Text = table.Rows[index]["Messages"].ToString();

                // Pass data from Form1 to Form2 and open it
                Form2 secondForm = new Form2(txtTitle.Text, txtMessage.Text);
                secondForm.Show();
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null) return;

            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1 && index < table.Rows.Count)
            {
                table.Rows[index].Delete();

                // Clear both text fields on deletion
                txtTitle.Clear();
                txtMessage.Clear();
            }
        }

        private void bttnSave_Click_1(object sender, EventArgs e)
        {
            bttnSave_Click(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
