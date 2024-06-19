using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            btnBck.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnDetactive.Hide();
            btnReal.Hide();
            btnRomantic.Hide();
            btnFiction.Hide();
            pictureBox1.Show();
            pictureBox1.BringToFront();
            btnBck.Show();
            btnBck.BringToFront();


        }

        private void btnFiction_Click(object sender, EventArgs e)
        {
            btnDetactive.Hide();
            btnReal.Hide();
            btnRomantic.Hide();
            btnFiction.Hide();
            pictureBox1.Show();
            pictureBox1.BringToFront();
            btnBck.Show();
            btnBck.BringToFront();

        }

        private void btnReal_Click(object sender, EventArgs e)
        {
            btnDetactive.Hide();
            btnReal.Hide();
            btnRomantic.Hide();
            btnFiction.Hide();
            pictureBox2.Show();
            pictureBox2.BringToFront();
            btnBck.Show();
            btnBck.BringToFront();

        }

        private void btnDetactive_Click(object sender, EventArgs e)
        {
            btnDetactive.Hide();
            btnReal.Hide();
            btnRomantic.Hide();
            btnFiction.Hide();
            pictureBox3.Show();
            pictureBox3.BringToFront();
            btnBck.Show();
            btnBck.BringToFront();
        }

        private void btnRomantic_Click(object sender, EventArgs e)
        {
            btnDetactive.Hide();
            btnReal.Hide();
            btnRomantic.Hide();
            btnFiction.Hide();
            pictureBox4.Show();
            pictureBox4.BringToFront();
            btnBck.Show();
            btnBck.BringToFront();
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            btnBck.Hide();
            btnDetactive.Show();
            btnDetactive.BringToFront();
            btnReal.Show();
            btnReal.BringToFront();
            btnRomantic.Show();
            btnRomantic.BringToFront();
            btnFiction.Show();
            btnFiction.BringToFront();


        }
    }
}
