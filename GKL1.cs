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
    public partial class GKL1 : Form
    {
       
        int count = 1;
        public GKL1(string a)
        {
            InitializeComponent();
            lbleid.Text = a;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
   
            

        }

        private void Form7_Load(object sender, EventArgs e)
        {

            if (count == 1)
            {

                string fullPath = @"C:\\Users\\PC Mart\\Downloads\\SE Project FINAL\\SE Project\\SE Project\\SE Project\\Resources\\c2\\GK1.txt";
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

    

        private void btnPrevious_Click(object sender, EventArgs e)
        {
           

           

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lblHead_Click(object sender, EventArgs e)
        {

        }

        private void label2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            GKLEVELSPAGE gk =new GKLEVELSPAGE(lbleid.Text);
            gk.Show();
            this.Hide();
        }
    }
}
    

