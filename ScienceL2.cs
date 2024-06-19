using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace SE_Project
{
    public partial class ScienceL2 : Form
    {
        public ScienceL2(String eid)
        {
            InitializeComponent();
            lbleid.Text = eid;
        }
        int count = 1;
        private void Form9_Load(object sender, EventArgs e)
        {
            if (count == 1)
            {

                string fullPath = @"C:\\Users\\PC Mart\\Downloads\\SE Project FINAL\\SE Project\\SE Project\\SE Project\\Resources\\c1\\Science1.txt";
                try
                {
                    if (File.Exists(fullPath))
                    {

                        var str = File.ReadAllText(fullPath);
                        label2.Text = str;
                        // File exists, proceed with reading or writing

                    }
                    else
                    {
                        string str2 = "f not found";
                        label2.Text = str2;

                    }

                }
                catch (IOException ex)
                {
                    lblAll.Text = $"An error occurred while reading the file: {ex.Message}";
                }
                count++;

            }
        }
            private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHead_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Science_levels_page scw = new Science_levels_page(lbleid.Text);
            scw.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
