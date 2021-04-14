using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //int i = ChoiceV.choice1;
            //int j = ChoiceV.choice2;
            switch (Choice.choice)
            {
                case 1:
                    {
                        pictureBox1.Image = Image.FromFile($@"C:\PC\EDUCATION\2_SEMESTR_1_K\ISP\PROJECT\WindowsFormsApp1\WindowsFormsApp1\FOOT_F\{Buf.footbuf1.name} {Buf.footbuf1.surname}.jpg");
                        pictureBox2.Image = Image.FromFile($@"C:\PC\EDUCATION\2_SEMESTR_1_K\ISP\PROJECT\WindowsFormsApp1\WindowsFormsApp1\FOOT_F\{Buf.footbuf2.name} {Buf.footbuf2.surname}.jpg");
                        label3.Text = ($"{Buf.footbuf1.name} {Buf.footbuf1.surname}");
                        label4.Text = ($"{Buf.footbuf2.name} {Buf.footbuf2.surname}");
                    }; break;
                case 2:
                    {
                        pictureBox1.Image = Image.FromFile($@"C:\PC\EDUCATION\2_SEMESTR_1_K\ISP\PROJECT\WindowsFormsApp1\WindowsFormsApp1\FOOT_F\{Buf.bask1.name} {Buf.bask1.surname}.jpg");
                        pictureBox2.Image = Image.FromFile($@"C:\PC\EDUCATION\2_SEMESTR_1_K\ISP\PROJECT\WindowsFormsApp1\WindowsFormsApp1\FOOT_F\{Buf.bask2.name} {Buf.bask2.surname}.jpg");
                        label3.Text = ($"{Buf.bask1.name} {Buf.bask1.surname}");
                        label4.Text = ($"{Buf.bask2.name} {Buf.bask2.surname}");
                    }; break;
                case 3:
                    {
                        pictureBox1.Image = Image.FromFile($@"C:\PC\EDUCATION\2_SEMESTR_1_K\ISP\PROJECT\WindowsFormsApp1\WindowsFormsApp1\FOOT_F\{Buf.hock1.name} {Buf.hock1.surname}.jpg");
                        pictureBox2.Image = Image.FromFile($@"C:\PC\EDUCATION\2_SEMESTR_1_K\ISP\PROJECT\WindowsFormsApp1\WindowsFormsApp1\FOOT_F\{Buf.hock2.name} {Buf.hock2.surname}.jpg");
                        label3.Text = ($"{Buf.hock1.name} {Buf.hock1.surname}");
                        label4.Text = ($"{Buf.hock2.name} {Buf.hock2.surname}");
                    }; break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 n = new Form2();
            this.Hide();
            n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer pl = new System.Media.SoundPlayer(@"C:\PC\EDUCATION\2_SEMESTR_1_K\ISP\PROJECT\WindowsFormsApp1\WindowsFormsApp1\SOUND.wav");
            pl.Play();
            System.Threading.Thread.Sleep(5000);
            try
            {
                switch (Choice.choice)
                {
                    case 1:
                        {
                            if (Buf.footbuf1.salary > Buf.footbuf2.salary)
                            {
                                if (Buf.footbuf1.marr == 1) throw new Exception($"{Buf.footbuf1.name} {Buf.footbuf1.surname}");
                                label1.ForeColor = Color.Red;
                                label2.ForeColor = Color.Black;
                                label1.Text = "WIN!!!";
                                label2.Text = "LOSE!!";
                            }
                            else
                            {

                                if (Buf.footbuf2.marr == 1) throw new Exception($"{Buf.footbuf2.name} {Buf.footbuf2.surname}");
                                label2.ForeColor = Color.Red;
                                label1.ForeColor = Color.Black;
                                label2.Text = "WIN!!!";
                                label1.Text = "LOSE!!";

                            }
                        }; break;
                    case 2:
                        {
                            if (Buf.bask2.salary > Buf.bask2.salary)
                            {

                                if (Buf.bask1.marr == 1) throw new Exception($"{Buf.bask1.name} {Buf.bask1.surname}");
                                label1.ForeColor = Color.Red;
                                label2.ForeColor = Color.Black;
                                label1.Text = "WIN!!!";
                                label2.Text = "LOSE!!";
                            }
                            else
                            {
                                if (Buf.bask2.marr == 1) throw new Exception($"{Buf.bask2.name} {Buf.bask2.surname}");

                                label2.ForeColor = Color.Red;
                                label1.ForeColor = Color.Black;
                                label2.Text = "WIN!!!";
                                label1.Text = "LOSE!!";

                            }
                        }; break;
                    case 3:
                        {

                            if (Buf.hock1.salary > Buf.hock2.salary)
                            {
                                if (Buf.hock1.marr == 1) throw new Exception($"{Buf.hock1.name} {Buf.hock1.surname}");

                                label1.ForeColor = Color.Red;
                                label2.ForeColor = Color.Black;
                                label1.Text = "WIN!!!";
                                label2.Text = "LOSE!!";
                            }
                            else
                            {
                                if (Buf.hock2.marr == 1) throw new Exception($"{Buf.hock2.name} {Buf.hock2.surname}");

                                label2.ForeColor = Color.Red;
                                label1.ForeColor = Color.Black;
                                label2.Text = "WIN!!!";
                                label1.Text = "LOSE!!";

                            }
                        }; break;
                }
                label1.Visible = true;
                label2.Visible = true;
            }
            catch (Exception ex)
            {
                System.Media.SoundPlayer pl1 = new System.Media.SoundPlayer(@"C:\PC\EDUCATION\2_SEMESTR_1_K\ISP\PROJECT\WindowsFormsApp1\WindowsFormsApp1\SOUND1.wav");
                pl1.Play();

                MessageBox.Show($"{ex.Message} is already merried!\nYOU LOSE! ;)");
            }
        }
    }
}
