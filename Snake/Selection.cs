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
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            Object.Speed = Convert.ToInt32(tbSpeed.Text);
            Close();
        }

        private void OyunAyarlari_Load(object sender, EventArgs e)
        {

        }

        private void tbHiz_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSpeed_Click(object sender, EventArgs e)
        {

        }
    }
}