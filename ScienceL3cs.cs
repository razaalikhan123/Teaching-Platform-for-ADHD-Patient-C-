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
    public partial class ScienceL3cs : Form
    {
        public ScienceL3cs(String eid)
        {
            
            InitializeComponent();
            lbleid.Text = eid;
        }
        int count = 1;

        private void button1_Click(object sender, EventArgs e)
        {
           
     








        }
        
        private void button3_Click(object sender, EventArgs e)
        {

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ScienceL2 form9 = new ScienceL2(lblAll.Text);
            form9.Show();
            Visible = false;
        }

        private void ScienceL3cs_Load(object sender, EventArgs e)
        {
            if (count == 1)
            {
        
                string fullPath = @"C:\\Users\\PC Mart\\Downloads\\SE Project FINAL\\SE Project\\SE Project\\SE Project\\Resources\\c1\\Science 2.txt";
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

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Science_levels_page scw = new Science_levels_page(lbleid.Text);
            scw.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }
    }
    }

