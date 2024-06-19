using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Data.SqlClient;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;
using System.Reflection;

namespace SE_Project
{
    public partial class Form14 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NK6FVOA;Initial Catalog=SE;Integrated Security=True;"); public Form14(string eid)
        {
            InitializeComponent();
            lbleid.Text = eid;

        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            lbname.Hide();
            lbfname.Hide();
            lbgender.Hide();
            lbage.Hide();
            lbsmail.Hide();
            lbpmail.Hide();
            lbpcnic.Hide();
            lbpcell.Hide();

            panel6.Hide();
            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            textBox1.Hide();

            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();

            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();
            panel4.Hide();
            panel5.Hide();



        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(lbleid.Text);
            frm.Show();
        }

        private void btngame1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(lbleid.Text);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            panel6.Hide();

            btngame1.Show();
            btngame1.BringToFront();
            btngame2.Show();
            btngame2.BringToFront();
            btngame3.Show();
            btngame3.BringToFront();
            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();

            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            textBox1.Hide();
            panel4.Hide();
            panel5.Hide();

        }

        private void btnmath_Click(object sender, EventArgs e)
        {
            Mathslevelpage mth = new Mathslevelpage(lbleid.Text);
            mth.Visible = true;
            this.Close();

        }

        private void btnscience_Click(object sender, EventArgs e)
        {
            Science_levels_page sco = new Science_levels_page(lbleid.Text);
            sco.Visible = true;

            this.Close();
        }

        private void btngk_Click(object sender, EventArgs e)
        {
            GKLEVELSPAGE gKLEVELSPAGE = new GKLEVELSPAGE(lbleid.Text);
            gKLEVELSPAGE.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            panel6.Hide();
            btngk.Show();
            btngk.BringToFront();
            btnscience.Show();
            btnscience.BringToFront();
            btnmath.Show();
            btnmath.BringToFront();

            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();
            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            textBox1.Hide();
            panel4.Hide();
            panel5.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();
            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();
            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            panel4.Hide();
            textBox1.Hide();
            panel5.Hide();
            panel6.Show();
            panel6.Visible = true;
            panel6.BringToFront();
            txtmail.BringToFront();
            txtname.BringToFront();
            txtsubject.BringToFront();
            pictureBox2.BringToFront();
            button10.BringToFront();
            pictureBox12.BringToFront();
            pictureBox11.BringToFront();
            pictureBox3.BringToFront();
            label3.BringToFront();
            label4.BringToFront();
            label5.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            panel6.Hide();
            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();
            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();
            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            panel4.Hide();
            panel6.Hide();
            panel5.Show();
            panel5.Visible = true;
        }

        private void btnbr_Click(object sender, EventArgs e)
        {
            morning ms = new morning();
            ms.Show();
            ms.Visible = true;
        }

        private void btnlu_Click(object sender, EventArgs e)
        {
            midday md = new midday();
            md.Show();
            md.Visible = true;
        }

        private void btndn_Click(object sender, EventArgs e)
        {
            dinner dnr = new dinner();
            dnr.Show();
            dnr.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            panel6.Hide();
            btnlu.Show();
            btnlu.BringToFront();
            btnbr.Show();
            btnbr.BringToFront();
            btndn.Show();
            btndn.BringToFront();
            textBox1.Show();
            textBox1.BringToFront();
            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();
            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();
            panel4.Hide();
            panel5.Hide();

        }

        private void pnlroutine_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide(); ;
            panel6.Hide();
            panel4.Show();
            panel4.Visible = true;

            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();
            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();
            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            textBox1.Hide();
            panel5.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel7.Hide(); 
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            panel6.Hide();
            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            textBox1.Hide();

            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();

            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();
            panel4.Hide();
            panel5.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Close();
            panel7.Show();
            panel7.Visible = true; 
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();


            con.Open();
            string query = "SELECT ID, StudentName, StudentEmail, gq1, gq2, scq1, scq2, mq1, mq2, score1, score2 FROM StDetails WHERE StudentEmail = '" + lbleid.Text + "'";
            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // Assuming you have columns gq1, gq2, scq1, scq2, mq1, mq2, score1, and score2 in your table
                textBox2.Text = reader["gq1"].ToString();
                textBox3.Text = reader["gq2"].ToString();
                textBox4.Text = reader["scq1"].ToString(); // Corrected from "scq1" to "scq1"
                textBox5.Text = reader["scq2"].ToString(); // Corrected from "scq2" to "scq2"
                textBox6.Text = reader["mq1"].ToString();
                textBox7.Text = reader["mq2"].ToString();
                textBox8.Text = reader["score1"].ToString();
                textBox9.Text = reader["score2"].ToString();
            }

            reader.Close();
            con.Close();

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;


            textBox2.BringToFront();
            textBox3.BringToFront();
            textBox4.BringToFront();


            textBox5.BringToFront();
            textBox6.BringToFront();
            textBox7.BringToFront();
            textBox8.BringToFront();
            textBox9.BringToFront();
            panel6.Hide();
            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();
            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();
            panel4.Hide();
            panel5.Hide();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click_3(object sender, EventArgs e)
        {

            try
            {
                string gmail = "focus.first66@gmail.com";
                string fromMail = "focusfirstclient@gmail.com";
                string fromPassword = "acvovdhzsiqxddxy";

                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);

                message.Subject = txtsubject.Text;
                message.To.Add(new MailAddress(gmail));
                message.Body = "Name:" + txtname.Text + "Email:" + txtmail.Text + "<html><body> Query Alert </body></html>" + body.Text;
                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPassword),
                    EnableSsl = true,
                };

                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbname.Text = "Name: ";
            lbfname.Text = "Father Name: ";
            lbgender.Text = "Gender: ";
            lbage.Text = "Age: ";
            lbsmail.Text = "Student Email: ";
            lbpmail.Text = "Parent Email: ";
            lbpcnic.Text = "Parent Cnic: ";
            lbpcell.Text = "Parent Cell Phone: ";

            lbname.Visible = true;
            lbname.BringToFront();

            lbfname.Visible = true;
            lbfname.BringToFront();

            lbgender.Visible = true;
            lbgender.BringToFront();

            lbage.Visible = true;
            lbage.BringToFront();

            lbsmail.Visible = true;
            lbsmail.BringToFront();

            lbpmail.Visible = true;
            lbpmail.BringToFront();

            lbpcnic.Visible = true;
            lbpcnic.BringToFront();

            lbpcell.Visible = true;
            lbpcell.BringToFront();

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            con.Open();
            string query = "SELECT ID, StudentName, FatherName, Gender, Age, StudentEmail, ParentEmail, ParentCnic, ParentPh FROM StDetails WHERE StudentEmail ='" + lbleid.Text + "'";
            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // Assuming you have three columns in your table
                textBox2.Text = reader["StudentName"].ToString();
                textBox3.Text = reader["FatherName"].ToString();
                textBox4.Text = reader["Gender"].ToString();
                textBox5.Text = reader["Age"].ToString();
                textBox6.Text = reader["StudentEmail"].ToString();
                textBox7.Text = reader["ParentEmail"].ToString();
                textBox8.Text = reader["ParentCnic"].ToString();
                textBox9.Text = reader["ParentPh"].ToString();
          
            }

            reader.Close();
            
            con.Close();
            panel7.Show();
            panel7.Visible = true;
            panel7.BringToFront();
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;


            textBox2.BringToFront();
            textBox3.BringToFront();
            textBox4.BringToFront();


            textBox5.BringToFront();
            textBox6.BringToFront();
            textBox7.BringToFront();
            textBox8.BringToFront();
            textBox9.BringToFront();

            panel6.Hide();
            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            textBox1.Hide();

            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();

            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();
            panel4.Hide();
            panel5.Hide();

        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            lbldash.Text = "DASHBOARD";
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            lbname.Hide();
            lbfname.Hide();
            lbgender.Hide();
            lbage.Hide();
            lbsmail.Hide();
            lbpmail.Hide();
            lbpcnic.Hide();
            lbpcell.Hide();

            panel7.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            panel6.Hide();
            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            textBox1.Hide();

            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();

            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();
            panel4.Hide();
            panel5.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            lbldash.Text = "HOME";
            lbname.Hide();
            lbfname.Hide();
            lbgender.Hide();
            lbage.Hide();
            lbsmail.Hide();
            lbpmail.Hide();
            lbpcnic.Hide();
            lbpcell.Hide();

            panel7.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide(); ;
            panel6.Hide();
            panel4.Show();
            panel4.Visible = true;

            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();
            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();
            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            textBox1.Hide();
            panel5.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            lbldash.Text = "CLASSES";
            lbname.Hide();
            lbfname.Hide();
            lbgender.Hide();
            lbage.Hide();
            lbsmail.Hide();
            lbpmail.Hide();
            lbpcnic.Hide();
            lbpcell.Hide();

            panel7.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            panel6.Hide();
            btngk.Show();
            btngk.BringToFront();
            btnscience.Show();
            btnscience.BringToFront();
            btnmath.Show();
            btnmath.BringToFront();

            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();
            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            textBox1.Hide();
            panel4.Hide();
            panel5.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            lbldash.Text = "GAMES";
            lbname.Hide();
            lbfname.Hide();
            lbgender.Hide();
            lbage.Hide();
            lbsmail.Hide();
            lbpmail.Hide();
            lbpcnic.Hide();
            lbpcell.Hide();

            panel7.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            panel6.Hide();

            btngame1.Show();
            btngame1.BringToFront();
            btngame2.Show();
            btngame2.BringToFront();
            btngame3.Show();
            btngame3.BringToFront();
            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();

            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            textBox1.Hide();
            panel4.Hide();
            panel5.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            lbldash.Text = "OVERVIEW"; 
            con.Close();
            panel7.Show();
            panel7.Visible = true;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();

            lbname.Visible = true;
            lbname.BringToFront();


            lbfname.Visible = true;
            lbfname.BringToFront();

            lbgender.Visible = true;
            lbgender.BringToFront();

            lbage.Visible = true;
            lbage.BringToFront();

            lbsmail.Visible = true;
            lbsmail.BringToFront();

            lbpmail.Visible = true;
            lbpmail.BringToFront();

            lbpcnic.Visible = true;
            lbpcnic.BringToFront();

            lbpcell.Visible = true;
            lbpcell.BringToFront();


            con.Open();
            string query = "SELECT ID, StudentName, StudentEmail, gq1, gq2, scq1, scq2, mq1, mq2, score1, score2 FROM StDetails WHERE StudentEmail = '" + lbleid.Text + "'";
            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // Assuming you have columns gq1, gq2, scq1, scq2, mq1, mq2, score1, and score2 in your table
                textBox2.Text = reader["gq1"].ToString();
                textBox3.Text = reader["gq2"].ToString();
                textBox4.Text = reader["scq1"].ToString(); // Corrected from "scq1" to "scq1"
                textBox5.Text = reader["scq2"].ToString(); // Corrected from "scq2" to "scq2"
                textBox6.Text = reader["mq1"].ToString();
                textBox7.Text = reader["mq2"].ToString();
                textBox8.Text = reader["score1"].ToString();
                textBox9.Text = reader["score2"].ToString();
            }

            reader.Close();
            con.Close();
            lbname.Text = "General Knowledge Quiz 1: ";
            lbfname.Text = "General Knowledge Quiz 2: ";
            lbgender.Text = "Science Quiz 1: ";
            lbage.Text = "Science Quiz 2: ";
            lbsmail.Text = "Maths Quiz 1: ";
            lbpmail.Text = "Maths Quiz 2: ";
            lbpcnic.Text = "Rocket Blitz Score: ";
            lbpcell.Text = "Match The Shap Score: ";

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;


            textBox2.BringToFront();
            textBox3.BringToFront();
            textBox4.BringToFront();


            textBox5.BringToFront();
            textBox6.BringToFront();
            textBox7.BringToFront();
            textBox8.BringToFront();
            textBox9.BringToFront();
            panel6.Hide();
            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();
            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();
            panel4.Hide();
            panel5.Hide();

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            lbldash.Text = "DAILY ROUTINE";
            lbname.Hide();
            lbfname.Hide();
            lbgender.Hide();
            lbage.Hide();
            lbsmail.Hide();
            lbpmail.Hide();
            lbpcnic.Hide();
            lbpcell.Hide();

            panel7.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            panel6.Hide();
            btnlu.Show();
            btnlu.BringToFront();
            btnbr.Show();
            btnbr.BringToFront();
            btndn.Show();
            btndn.BringToFront();
            textBox1.Show();
            textBox1.BringToFront();
            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();
            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();
            panel4.Hide();
            panel5.Hide();

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            lbldash.Text = "CONTACT US";
            lbname.Hide();
            lbfname.Hide();
            lbgender.Hide();
            lbage.Hide();
            lbsmail.Hide();
            lbpmail.Hide();
            lbpcnic.Hide();
            lbpcell.Hide();

            panel7.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();
            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();
            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            panel4.Hide();
            textBox1.Hide();
            panel5.Hide();
            panel6.Show();
            panel6.Visible = true;
            panel6.BringToFront();
            txtmail.BringToFront();
            txtname.BringToFront();
            txtsubject.BringToFront();
            pictureBox2.BringToFront();
            button10.BringToFront();
            pictureBox12.BringToFront();
            pictureBox11.BringToFront();
            pictureBox3.BringToFront();
            label3.BringToFront();
            label4.BringToFront();
            label5.BringToFront();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            lbldash.Text = "ABOUT";
            lbname.Hide();
            lbfname.Hide();
            lbgender.Hide();
            lbage.Hide();
            lbsmail.Hide();
            lbpmail.Hide();
            lbpcnic.Hide();
            lbpcell.Hide();

            panel7.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            panel6.Hide();
            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();
            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();
            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            panel4.Hide();
            panel6.Hide();
            panel5.Show();
            panel5.Visible = true;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            lbldash.Text = "PROFILE INFORMATION";
            lbname.Text = "Name: ";
            lbfname.Text = "Father Name: ";
            lbgender.Text = "Gender: ";
            lbage.Text = "Age: ";
            lbsmail.Text = "Student Email: ";
            lbpmail.Text = "Parent Email: ";
            lbpcnic.Text = "Parent Cnic: ";
            lbpcell.Text = "Parent Cell Phone: ";

            lbname.Visible = true;
            lbname.BringToFront();

            lbfname.Visible = true;
            lbfname.BringToFront();

            lbgender.Visible = true;
            lbgender.BringToFront();

            lbage.Visible = true;
            lbage.BringToFront();

            lbsmail.Visible = true;
            lbsmail.BringToFront();

            lbpmail.Visible = true;
            lbpmail.BringToFront();

            lbpcnic.Visible = true;
            lbpcnic.BringToFront();

            lbpcell.Visible = true;
            lbpcell.BringToFront();

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();

            con.Open();
            string query = "SELECT ID, StudentName, FatherName, Gender, Age, StudentEmail, ParentEmail, ParentCnic, ParentPh FROM StDetails WHERE StudentEmail ='" + lbleid.Text + "'";
            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // Assuming you have three columns in your table
                textBox2.Text = reader["StudentName"].ToString();
                textBox3.Text = reader["FatherName"].ToString();
                textBox4.Text = reader["Gender"].ToString();
                textBox5.Text = reader["Age"].ToString();
                textBox6.Text = reader["StudentEmail"].ToString();
                textBox7.Text = reader["ParentEmail"].ToString();
                textBox8.Text = reader["ParentCnic"].ToString();
                textBox9.Text = reader["ParentPh"].ToString();

            }

            reader.Close();

            con.Close();
            panel7.Show();
            panel7.Visible = true;
            panel7.BringToFront();
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;


            textBox2.BringToFront();
            textBox3.BringToFront();
            textBox4.BringToFront();


            textBox5.BringToFront();
            textBox6.BringToFront();
            textBox7.BringToFront();
            textBox8.BringToFront();
            textBox9.BringToFront();

            panel6.Hide();
            btnbr.Hide();
            btndn.Hide();
            btnlu.Hide();
            textBox1.Hide();

            btngame1.Hide();
            btngame2.Hide();
            btngame3.Hide();

            btnmath.Hide();
            btnscience.Hide();
            btngk.Hide();
            panel4.Hide();
            panel5.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Science_levels_page scl = new Science_levels_page(lbleid.Text);
            scl.Visible = true;

            this.Close();
        }
    }
        }
    
