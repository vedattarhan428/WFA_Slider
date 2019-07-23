using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace WFA_Slider
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MetroButton5_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        Random rnd = new Random();
        int index = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {

            index = rnd.Next(0, imageList.Images.Count);
            pictureBox1.Image = imageList.Images[index];
        }

        private void MetroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Interval = metroTrackBar1.Value;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Image = imageList.Images[0];
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Image = imageList.Images[imageList.Images.Count - 1];
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            index--;
            if (index == -1)
            {
                index = imageList.Images.Count - 1;
            }
            pictureBox1.Image = imageList.Images[index];
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            index++;
            if (index == imageList.Images.Count)
            {
                index = 0;
            }
            pictureBox1.Image = imageList.Images[index];
        }
    }
}
