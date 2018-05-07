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

namespace Snake
{
    public partial class First : Form

    {
        public First()
        {
            InitializeComponent();
        }

        private void btnGame_click(object sender, EventArgs e)
        {
            Karar goster = new Karar();
            goster.Show();
            this.Hide();
        }

        private void btnContact_click(object sender, EventArgs e)
        {
            İletişim goster = new İletişim();
            goster.Show();
        }

        private void btnObject_Click(object sender, EventArgs e)
        {
            new Object();
            Selection goster = new Selection();
            goster.Show();
        }

        private void First_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\enesc\Desktop\Snake\Snake\Snake\bin\Debug\İmages\Snake.wav";
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
