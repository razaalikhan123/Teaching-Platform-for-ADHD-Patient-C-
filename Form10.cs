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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        int count = 1;
        private void Form10_Load(object sender, EventArgs e)
        {
            string X = "LETS Explore Science World  . . .";
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {

                string fullPath = @"D:\\SE Project\\Resources\\c3\\s1.txt";
                try
                {
                    if (File.Exists(fullPath))
                    {

                        var str = File.ReadAllText(fullPath);
                        textBox1.Text = str;
                        // File exists, proceed with reading or writing
                        lblHead.Text = "Science OF Earth";
                        lblHead.ForeColor = Color.OliveDrab;
                    }
                    else
                    {
                        string str2 = "f not found";
                        textBox1.Text = str2;

                    }

                }
                catch (IOException ex)
                {
                    lblAll.Text = $"An error occurred while reading the file: {ex.Message}";
                }
                count++;

            }
            else if (count == 2)
            {

                string fullPath1 = @"D:\\SE Project\\Resources\\c3\\s2.txt";
                try
                {
                    if (File.Exists(fullPath1))
                    {

                        var str1 = File.ReadAllText(fullPath1);
                        textBox1.Text = str1;
                        lblHead.Text = "Science OF Light";
                        lblHead.ForeColor = Color.Yellow;
                        // File exists, proceed with reading or writing
                    }
                    else
                    {
                        string str2 = "f not found";
                        textBox1.Text = str2;

                    }

                }
                catch (IOException ex)
                {
                    lblAll.Text = $"An error occurred while reading the file: {ex.Message}";
                }
                count++;

            }
            else if (count == 3)
            {

                string fullPath2 = @"D:\\SE Project\\Resources\\c3\\s3.txt";
                try
                {
                    if (File.Exists(fullPath2))
                    {

                        var str2 = File.ReadAllText(fullPath2);
                        textBox1.Text = str2;
                        lblHead.Text = "Science OF Air";
                        lblHead.ForeColor = Color.PowderBlue;
                        // File exists, proceed with reading or writing
                    }
                    else
                    {
                        string str2 = "f not found";
                        textBox1.Text = str2;

                    }

                }
                catch (IOException ex)
                {
                    lblAll.Text = $"An error occurred while reading the file: {ex.Message}";
                }
                count++;

            }
            else if (count == 4)
            {

                string fullPath1 = @"D:\\SE Project\\Resources\\c3\\s4.txt";
                try
                {
                    if (File.Exists(fullPath1))
                    {

                        var str1 = File.ReadAllText(fullPath1);
                        textBox1.Text = str1;
                        lblHead.Text = "Science OF Life";
                        lblHead.ForeColor = Color.PeachPuff;
                        // File exists, proceed with reading or writing
                    }
                    else
                    {
                        string str2 = "f not found";
                        textBox1.Text = str2;

                    }

                }
                catch (IOException ex)
                {
                    lblAll.Text = $"An error occurred while reading the file: {ex.Message}";
                }
                count++;

            }
            else if (count == 5)
            {

                string fullPath1 = @"D:\\SE Project\\Resources\\c3\\s5.txt";
                try
                {
                    if (File.Exists(fullPath1))
                    {

                        var str1 = File.ReadAllText(fullPath1);
                        textBox1.Text = str1;
                        lblHead.Text = "Science OF Space";
                        lblHead.ForeColor = Color.Plum;
                        // File exists, proceed with reading or writing
                    }
                    else
                    {
                        string str2 = "f not found";
                        textBox1.Text = str2;

                    }

                }
                catch (IOException ex)
                {
                    lblAll.Text = $"An error occurred while reading the file: {ex.Message}";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count == 2)
            {

                string fullPath = @"D:\\SE Project\\Resources\\c3\\s1.txt";
                try
                {
                    if (File.Exists(fullPath))
                    {

                        var str = File.ReadAllText(fullPath);
                        textBox1.Text = str;
                        // File exists, proceed with reading or writing
                        lblHead.Text = "Science OF Earth";
                        lblHead.ForeColor = Color.OliveDrab;
                    }
                    else
                    {
                        string str2 = "f not found";
                        textBox1.Text = str2;

                    }

                }
                catch (IOException ex)
                {
                    lblAll.Text = $"An error occurred while reading the file: {ex.Message}";
                }
                count--;

            }
            else if (count == 3)
            {

                string fullPath1 = @"D:\\SE Project\\Resources\\c3\\s2.txt";
                try
                {
                    if (File.Exists(fullPath1))
                    {

                        var str1 = File.ReadAllText(fullPath1);
                        textBox1.Text = str1;
                        lblHead.Text = "Science OF Light";
                        lblHead.ForeColor = Color.Yellow;
                        // File exists, proceed with reading or writing
                    }
                    else
                    {
                        string str2 = "f not found";
                        textBox1.Text = str2;

                    }

                }
                catch (IOException ex)
                {
                    lblAll.Text = $"An error occurred while reading the file: {ex.Message}";
                }
                count--;

            }
            else if (count == 4)
            {

                string fullPath2 = @"D:\\SE Project\\Resources\\c3\\s3.txt";
                try
                {
                    if (File.Exists(fullPath2))
                    {

                        var str2 = File.ReadAllText(fullPath2);
                        textBox1.Text = str2;
                        lblHead.Text = "Science OF Air";
                        lblHead.ForeColor = Color.PowderBlue;
                        // File exists, proceed with reading or writing
                    }
                    else
                    {
                        string str2 = "f not found";
                        textBox1.Text = str2;

                    }

                }
                catch (IOException ex)
                {
                    lblAll.Text = $"An error occurred while reading the file: {ex.Message}";
                }
                count--;

            }
            else if (count == 5)
            {

                string fullPath1 = @"D:\\SE Project\\Resources\\c3\\s4.txt";
                try
                {
                    if (File.Exists(fullPath1))
                    {

                        var str1 = File.ReadAllText(fullPath1);
                        textBox1.Text = str1;
                        lblHead.Text = "Science OF Life";
                        lblHead.ForeColor = Color.PeachPuff;
                        // File exists, proceed with reading or writing
                    }
                    else
                    {
                        string str2 = "f not found";
                        textBox1.Text = str2;

                    }

                }
                catch (IOException ex)
                {
                    lblAll.Text = $"An error occurred while reading the file: {ex.Message}";
                }
                count--;





            }
        }
    }
}
