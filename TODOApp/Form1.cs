using System.Windows.Forms;

namespace TODOApp
{
    public partial class Form1 : Form
    {
        SchoolTaskAddForm SchoolAddForm = new SchoolTaskAddForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//SPORTS
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //SCHOOL
        {
            SchoolAddForm = new SchoolTaskAddForm();
            SchoolAddForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)//FRIEND
        {

        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}