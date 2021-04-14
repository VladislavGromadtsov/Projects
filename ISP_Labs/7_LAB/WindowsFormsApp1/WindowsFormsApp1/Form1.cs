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
    public partial class Form1 : Form
    {

        Class1 num;
        Class1 num2;
        public ListBox list1 = new ListBox();


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            list1.Name = "MyList";
            list1.Left = 1;
            list1.Top = 95;
            list1.Height = 52;
            list1.Width = 100;
            this.Controls.Add(list1);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox2.Text) ==0)
                {
                    throw new Exception("Can not devide by zero!");
                }
                if (Convert.ToDouble(textBox4.Text) == 0)
                {
                    throw new Exception("Can not devide by zero!");
                }

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" )
                {
                    throw new Exception("Fill the boxes!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }

            num = new Class1(textBox1.Text, textBox2.Text);
            num2 = new Class1(textBox3.Text, textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //textBox3.Visible = true;
            //textBox3.Text = num.Show();
            //textBox3.Text = textBox3.Text+ "\n" + Convert.ToString(num.NUM);
            groupBox1.Visible = true;
            num.Show(comboBox1);
            num2.Show(comboBox2);
            //            MessageBox.Show(Convert.ToString(0.00000000001));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
       //     listBox1.Items.Clear();
       //     listBox1.Items.Add(num+num2);

            list1.Items.Clear();
            list1.Items.Add(num + num2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
        //    listBox1.Items.Clear();
        //    listBox1.Items.Add(num - num2);

            list1.Items.Clear();
            list1.Items.Add(num - num2);
        }

        private void button7_Click(object sender, EventArgs e)
        {

          //  listBox1.Items.Clear();
//            listBox1.Items.Add(num * num2);

            list1.Items.Clear();
            list1.Items.Add(num * num2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
  //          listBox1.Items.Clear();
  //          listBox1.Items.Add(num / num2);

            list1.Items.Clear();
            list1.Items.Add(num / num2);

        }

        private void button9_Click(object sender, EventArgs e)
        {
    //        listBox1.Items.Clear();
      //      int a = num.Compare(num, num2);
        //    if (a==0) listBox1.Items.Add("=");
          //  if(a>0) listBox1.Items.Add(">");
           // if (a < 0) listBox1.Items.Add("<");

            list1.Items.Clear();
            int a = num.Compare(num, num2);
            if (a == 0) list1.Items.Add("=");
            if (a > 0) list1.Items.Add(">");
            if (a < 0) list1.Items.Add("<");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num > num2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num < num2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num == num2);
        }
    }
}
