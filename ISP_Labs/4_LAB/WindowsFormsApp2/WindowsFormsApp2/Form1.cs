using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Video video;

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult D = openFileDialog1.ShowDialog();
            if (D == DialogResult.OK)
            {
                video = new Microsoft.DirectX.AudioVideoPlayback.Video(openFileDialog1.FileName);
                video.Open(openFileDialog1.FileName);
                video.Owner = panel1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (video.Playing)
            {
                button1.Text = "Играть";
                video.Pause();
            }
            else
            {
                button1.Text = "Пауза";
                video.Play();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            video.Stop();
        }

        
    }
}
