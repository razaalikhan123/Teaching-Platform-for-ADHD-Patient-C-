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
    public partial class MATHL3 : Form
    {
        public MATHL3(string a)
        {
            InitializeComponent();
            lblAll.Text = a;
        }

        private void MATHL3_Load(object sender, EventArgs e)
        {

        }
        int count = 0;
        private void btnStrt_Click(object sender, EventArgs e)
        {
        dir:

            Random random = new Random();

          


            int minRange = 1;
            int midRange = 60;
            int maxRange = 100;
            int randomInRange = random.Next(midRange, maxRange);
            int randomInRange2 = random.Next(minRange, midRange);

            float randomFloat = (float)random.NextDouble();
            float minRange2 = 1.00f;
            float midRange2 = 60.00f;
            float maxRange2 = 100.00f;
            float randomInRange3 = midRange2 + (float)random.NextDouble() * (maxRange2 - midRange2);
            randomInRange3 = (float)Math.Round(randomInRange3, 2);
            float randomInRange4 = minRange2 + (float)random.NextDouble() * (midRange2 - minRange2);
            randomInRange4 = (float)Math.Round(randomInRange4, 2);

            lblnum1.Text = randomInRange.ToString();

            lblnum2.Text = randomInRange2.ToString();

            count++;
            if (count < 5)
            {
                int res = (randomInRange - randomInRange2) ^ 2 * (randomInRange + randomInRange2) ^ 2;
                lblhead.Text = "a^2-b^2=(a-b)^2*(a+b)^2";
                lblans.Text = res.ToString();
                lbloper.Text = "(a-b)^2";
                lblnum1.Text = randomInRange.ToString();
                lblnum2.Text = randomInRange2.ToString();
            }
            else if (count > 4 && count < 10)
            {
                int res = ((randomInRange ^ 2) + (2 * (randomInRange * randomInRange2)) + (randomInRange2 ^ 2));
                lblhead.Text = "(a-b)^2=a^2+2ab-b^2";
                lblans.Text = res.ToString();
                lbloper.Text = "(a-b)^2";
                lblnum1.Text = randomInRange.ToString();
                lblnum2.Text = randomInRange2.ToString();
            }
            else if (count > 9 && count < 15)
            {
                int res = ((randomInRange ^ 2) + (2 * (randomInRange * randomInRange2)) - (randomInRange2 ^ 2));
                lblhead.Text = "(a+b)^2=a^2+2ab+b^2";
                lblans.Text = res.ToString();
                lbloper.Text = "(a+b)^2";
                lblnum1.Text = randomInRange.ToString();
                lblnum2.Text = randomInRange2.ToString();
            }

            else
            {
                count = 0;
                goto dir;
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Mathslevelpage mth = new Mathslevelpage(lblAll.Text);
            mth.Show();
            this .Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
