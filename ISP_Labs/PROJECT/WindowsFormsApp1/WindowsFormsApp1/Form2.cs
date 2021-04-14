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
    class ChoiceV
    {
        public static int choice1 { get; set; }
        public static int choice2 { get; set; }
    }
    class Buf
    {
        public static Football footbuf1 { get; set; }
        public static Football footbuf2 { get; set; }
        public static Bascketball bask1 { get; set; }
        public static Bascketball bask2 { get; set; }
        public static Hockey hock1 { get; set; }
        public static Hockey hock2 { get; set; }
    }
    public partial class Form2 : Form
    {
        Football[] football_pl = new Football[5];
        Bascketball[] bascketball_pl = new Bascketball[5];
        Hockey[] hockey_pl = new Hockey[5];

        public int count = 5;

        delegate void IN_1(System.IO.StreamReader streamReader, Football[] X, int z);   
        delegate void IN_2(System.IO.StreamReader streamReader, Bascketball[] X, int z); 
        delegate void IN_3(System.IO.StreamReader streamReader, Hockey[] X, int z); 
        event IN_1 Inputed_1;
        event IN_2 Inputed_2;
        event IN_3 Inputed_3;

        delegate string SH_1(Football[] X, int z);
        delegate string SH_2(Bascketball[] X, int z);
        delegate string SH_3(Hockey[] X, int z);
        event SH_1 Sh1;
        event SH_2 Sh2;
        event SH_3 Sh3;
        
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            HELP q = new HELP();
            IN_1 del_1 = q.Input;
            IN_2 del_2 = q.Input;  
            IN_3 del_3 = q.Input;
            Inputed_1 = del_1;
            Inputed_2 = del_2;    
            Inputed_3 = del_3;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\PC\EDUCATION\2_SEMESTR_1_K\ISP\PROJECT\WindowsFormsApp1\WindowsFormsApp1\FOOTBALL.txt", Encoding.Default);
                Inputed_1(sr, football_pl, count);
                System.IO.StreamReader sr2 = new System.IO.StreamReader(@"C:\PC\EDUCATION\2_SEMESTR_1_K\ISP\PROJECT\WindowsFormsApp1\WindowsFormsApp1\BASKET.txt", Encoding.Default);
                Inputed_2(sr2, bascketball_pl, count);
                System.IO.StreamReader sr3 = new System.IO.StreamReader(@"C:\PC\EDUCATION\2_SEMESTR_1_K\ISP\PROJECT\WindowsFormsApp1\WindowsFormsApp1\HOCKEY.txt", Encoding.Default);
                Inputed_3(sr3, hockey_pl, count);

                MessageBox.Show("Файл открыт!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HELP hell = new HELP();
            SH_1 dell1 = hell.Show;
            SH_2 dell2 = hell.Show;
            SH_3 dell3 = hell.Show;
            Sh1 = dell1;
            Sh2 = dell2;
            Sh3 = dell3;

            switch (Choice.choice)
            {
                case 1:
                    {
                        richTextBox1.Text = Sh1(football_pl, count);
                        MessageBox.Show("Готово!!!");
                    };break;
                case 2:
                    {
                        richTextBox1.Text = Sh2(bascketball_pl, count);
                        MessageBox.Show("Готово!!!");
                    }; break;
                case 3:
                    {
                        richTextBox1.Text = Sh3(hockey_pl, count);
                        MessageBox.Show("Готово!!!");
                    }; break;
            }

            richTextBox1.Visible = true;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            switch (Choice.choice)
            {
                case 1:
                    {
                        for (int i = 0; i < count; i++)
                        {
                            comboBox1.Items.Add($"{ football_pl[i].name} {football_pl[i].surname}");
                            comboBox2.Items.Add($"{ football_pl[i].name} {football_pl[i].surname}");
                        }
                    }; break;
                case 2:
                    {
                        for (int i = 0; i < count; i++)
                        {
                            comboBox1.Items.Add($"{bascketball_pl[i].name} {bascketball_pl[i].surname}");
                            comboBox2.Items.Add($"{bascketball_pl[i].name} {bascketball_pl[i].surname}");
                        }
                    }; break;
                case 3:
                    {
                        for (int i = 0; i < count; i++)
                        {
                            comboBox1.Items.Add($"{hockey_pl[i].name} {hockey_pl[i].surname}");
                            comboBox2.Items.Add($"{hockey_pl[i].name} {hockey_pl[i].surname}");
                        }
                    }; break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 newF = new Form1();
            newF.Show();
            this.Hide();        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox1.SelectedIndex == comboBox2.SelectedIndex)
                {
                    throw new Exception("You can not compare one person!");
                }

                ChoiceV.choice1 = comboBox1.SelectedIndex;
                ChoiceV.choice2 = comboBox2.SelectedIndex;

                switch (Choice.choice)
                {
                    case 1:
                        {
                            Buf.footbuf1 = football_pl[ChoiceV.choice1];
                            Buf.footbuf2 = football_pl[ChoiceV.choice2];
                        }; break;
                    case 2:
                        {
                            Buf.bask1 = bascketball_pl[ChoiceV.choice1];
                            Buf.bask2 = bascketball_pl[ChoiceV.choice2];
                        }; break;
                    case 3:
                        {
                            Buf.hock1 = hockey_pl[ChoiceV.choice1];
                            Buf.hock2 = hockey_pl[ChoiceV.choice2];
                        }; break;
                }


                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
