using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class mq2 : Form
    {
        int loc = 4;
        public mq2(string eid)
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
            cmd = new SqlCommand("UPDATE StDetails SET mq2 = '" + marks + "' WHERE StudentEmail = '" + lbleid.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("quiz ended" + marks);
            con.Close();
            Mathslevelpage mth = new Mathslevelpage(lbleid.Text);
            mth.Show();
            this.Close();
        }

        private void mq2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Mathslevelpage mth = new Mathslevelpage(lbleid.Text);
            mth.Show();
            this.Close();
        }
    }
}
