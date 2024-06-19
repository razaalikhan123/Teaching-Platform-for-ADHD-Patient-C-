using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace SE_Project
{
    public partial class GKL3 : Form
    {
        int count = 1;
        public GKL3(string a)
        {
            InitializeComponent();
        lbleid.Text = a;
        }

        private void GKL3_Load(object sender, EventArgs e)
        {

            string fullPath = @"C:\\Users\\PC Mart\\Downloads\\SE Project FINAL\\SE Project\\SE Project\\SE Project\\Resources\\c2\\GK3.txt";
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
    

        private void btnNext_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            GKLEVELSPAGE gk = new GKLEVELSPAGE(lbleid.Text);
            gk.Show();
            this.Hide();
        }
    }
}
