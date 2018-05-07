using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Karar : Form
    {
        public Karar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game goster = new Game();
            goster.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UnFramed goster = new UnFramed();
            goster.Show();
            this.Close();
        }

        private void Karar_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}
