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

namespace SE_Project
{
    public partial class midday : Form
    {
        public midday()
        {
            InitializeComponent();
        }

        private void midday_Load(object sender, EventArgs e)
        {
            string fullPath = @"C:\\Users\\PC Mart\\3D Objects\\SE Project\\SE Project\\Resources\\daily routine\\lunch.txt";
            try
            {
                if (File.Exists(fullPath))
                {

                    var str = File.ReadAllText(fullPath);
                    lblmidday.Text = str;
                    // File exists, proceed with reading or writing


                }
                else
                {
                    string str2 = "f not found";
                    lblmidday.Text = str2;

                }
            }
            catch (IOException ex)
            {
                lblmidday.Text = $"An error occurred while reading the file: {ex.Message}";
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
