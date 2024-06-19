using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class gkq2 : Form
    {int loc = 4;
        public gkq2(string eid)
        {
            InitializeComponent();
            lbleid.Text = eid;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NK6FVOA;Initial Catalog=SE;Integrated Security=True;");
        SqlCommand cmd;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int marks = 0;
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                marks = marks + 1;
            else
                marks = marks + 0;
            bool isChecked1 = radioButton17.Checked;
            if (isChecked1)
                marks = marks + 1;
            else
                marks = marks + 0;
            bool isChecked2 = radioButton21.Checked;
            if (isChecked2)
                marks = marks + 1;
            else
                marks = marks + 0;
            bool isChecked3 = radioButton5.Checked;
            if (isChecked3)
                marks = marks + 1;
            else
                marks = marks + 0;
            marks = marks + 0;
            bool isChecked4 = radioButton8.Checked;
            if (isChecked4)
                marks = marks + 1;
            else
                marks = marks + 0;
            con.Open();
            cmd = new SqlCommand("UPDATE StDetails SET gq2 = '" + marks + "' WHERE StudentEmail = '" + lbleid.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("quiz ended" + marks);
            con.Close();
            GKLEVELSPAGE gkl = new GKLEVELSPAGE(lbleid.Text);
            gkl.Show();
            this.Hide();

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbleid_Click(object sender, EventArgs e)
        {

        }

        private void gkq2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            GKLEVELSPAGE gkl = new GKLEVELSPAGE(lbleid.Text);
            gkl.Show();
            this.Hide();

        }
    }
}
