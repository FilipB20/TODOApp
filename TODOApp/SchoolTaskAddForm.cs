using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TODOApp
{
    partial class SchoolTaskAddForm : Form
    {
        string Name, Description, Course;
        DateTime DueDate;
        SchoolTask schoolTask;
        System.Windows.Forms.ListView listView;
        public SchoolTaskAddForm(System.Windows.Forms.ListView listView)
        {
            this.listView=listView;
            InitializeComponent();
        }
        public SchoolTask GetSchoolTask()
        {
            return schoolTask;
        }

        private void button1_Click(object sender, EventArgs e)//SAVE
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//NAME
        {
            Name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//DESCRIPTION
        {
            Description = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//NAME OF THE COURSE
        {
            Course = textBox3.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)//DATE PICKER
        {
            DueDate = dateTimePicker1.Value;
        }

        private void button1_Click_1(object sender, EventArgs e)//SAVE
        {
            this.Text = $"{Name} {Description} {DueDate.ToString()} {Course}";
            SchoolTask schoolTask = new SchoolTask(Name, Description, DueDate, Course);
            listView.Items.Add(schoolTask.ToString());
            this.Close();

        }
    }
}
