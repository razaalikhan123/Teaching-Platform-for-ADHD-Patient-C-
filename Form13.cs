using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project
{

    public partial class Form13 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NK6FVOA;Initial Catalog=SE;Integrated Security=True;");
        public Form13()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select ID from StDetails where StudentEmail ='" + txtemail.Text + "'and Password ='" + txtpass.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dta = new DataTable();
            sda.Fill(dta);
            string eid = txtemail.Text;
            if (dta.Rows.Count > 0)
            {


                Form14 frm = new Form14(eid);
                frm.Visible = true;
                MessageBox.Show("Logged Inn" + eid);

            }
            else
            {
                MessageBox.Show("Invalid Email Or Password");

            }
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtemail.Show();
            txtpass.Show();
            txtemail.Visible = true;
            txtpass.Visible = true;
            button8.Show();
            button8.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            txtemail.Hide();
            txtpass.Hide();
            button8.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12();
            form.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select ID from StDetails where StudentEmail ='" + txtemail.Text + "'and Password ='" + txtpass.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dta = new DataTable();
            sda.Fill(dta);
            string eid = txtemail.Text;
            if (dta.Rows.Count > 0)
            {


                Form14 frm = new Form14(eid);
                frm.Visible = true;
                frm.Show();
                this.Hide();
                MessageBox.Show("Logged Inn" + eid);

            }
            else
            {
                MessageBox.Show("Invalid Email Or Password");

            }
            con.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

