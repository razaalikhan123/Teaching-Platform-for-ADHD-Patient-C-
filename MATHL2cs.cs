using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Numerics;



namespace SE_Project
{
    public partial class MATHL2cs : Form
    {
        public MATHL2cs(string a)
        {
            InitializeComponent();
            btnSubmit.Hide();
            lblAll.Text = a;

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
                lblnum1.Text = randomInRange3.ToString();
                lblnum2.Text = randomInRange4.ToString();
                float res2 = randomInRange3 / randomInRange4;
                lblhead.Text = "Division";
                lblans.Text = res2.ToString();
                lbloper.Text = "/";
            }
            else if (count > 4 && count < 10)
            {
                lblhead.Text = "MOD";
                float res = randomInRange % randomInRange2;
                lblans.Text = res.ToString();
                lbloper.Text = "%";
                lblnum1.Text = randomInRange.ToString();
                lblnum2.Text = randomInRange2.ToString();
            }
            else if (count > 9 && count < 15)
            {
                int res = (randomInRange^2);
                lblhead.Text = "a^2";
                lblans.Text = res.ToString();
                lbloper.Text = "a^2";
                lblnum1.Text = randomInRange.ToString();
                lblnum2.Text = randomInRange.ToString();
            }

            else
            {
                count = 0;
                goto dir;
            }
        }

        private void lblnum1_Click(object sender, EventArgs e)
        {

        }

        private void MATHL2cs_Load(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
