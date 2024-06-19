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
    public partial class MATHL1 : Form
    {
        public MATHL1(string a)
        {
            InitializeComponent();
            lblAll.Text = a;    
        }
        int count = 0;
        private void lblnum1_Click(object sender, EventArgs e)
        {

        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {

           
           
        }
        void randomnum()
        {

            


        }

        private void btnStrt_Click(object sender, EventArgs e)
        {
            dir:
   
            Random random = new Random();


            int minRange = 1;
            int midRange = 60;
            int maxRange = 100;
            int randomInRange = random.Next(midRange, maxRange );
            int randomInRange2 = random.Next(minRange, midRange );

            float randomFloat = (float)random.NextDouble();
            float minRange2 = 1.00f;
            float midRange2 = 60.00f;
            float maxRange2 = 100.00f;
            float randomInRange3 = midRange2 + (float)random.NextDouble() * (maxRange2 - midRange2);

            float randomInRange4 = minRange2 + (float)random.NextDouble() * (midRange2 - minRange2);


            lblnum1.Text = randomInRange.ToString();

            lblnum2.Text = randomInRange2.ToString();

            count++;
            if (count < 5)
            {
                lblnum1.Text = randomInRange.ToString();
                lblnum2.Text = randomInRange2.ToString();
                lblhead.Text = "Addition";
                int res = randomInRange + randomInRange2;
                lblans.Text = res.ToString();
                lbloper.Text = "+";
            }
            else if( count >4 && count < 10)
            {
                lblnum1.Text = randomInRange.ToString();
                lblnum2.Text = randomInRange2.ToString();
                int res = randomInRange - randomInRange2;
                lblans.Text = res.ToString();
                lblhead.Text = "Subraction";
                lbloper.Text = "-";
            }
            else if (count > 9 && count < 15)
            {
                lblnum1.Text = randomInRange.ToString();
                lblnum2.Text = randomInRange2.ToString();
                int res = randomInRange * randomInRange2;
                lblhead.Text = "Multiplication";
                lblans.Text = res.ToString();
                lbloper.Text = "*";
            }

            else
            {
                count = 0;
                goto dir;
            }





        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbloper_Click(object sender, EventArgs e)
        {

        }

        private void lblnum2_Click(object sender, EventArgs e)
        {

        }

        private void lblans_Click(object sender, EventArgs e)
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
            Mathslevelpage mth = new Mathslevelpage(lblAll.Text);
            mth.Show();
            this.Close();
        }
    }
}
