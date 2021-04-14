using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    class Choice
    {
        public static int choice { get; set; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //public int choice;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            Form2 NewForm = new Form2();
            NewForm.Show();
            this.Hide();
            //choice = 1;
            Choice.choice = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            Form2 NewForm = new Form2();
            NewForm.Show();
            this.Hide();
            //choice = 2;
            Choice.choice = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            Form2 NewForm = new Form2();
            NewForm.Show();
            this.Hide();
            //choice = 3;

            Choice.choice = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
