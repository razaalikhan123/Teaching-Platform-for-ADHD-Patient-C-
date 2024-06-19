using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SE_Project
{
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NK6FVOA;Initial Catalog=SE;Integrated Security=True;");
        SqlCommand cmd;
        string gender;
        public Registration()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        public void insertd()
        {
            int a = 0;
            int B = 0;
            Random random = new Random();


            int minRange = 100000;
 
            int maxRange =999999;

            int randomInRange2 = random.Next(minRange, maxRange);
            con.Open();
            cmd = new SqlCommand("insert into StDetails values('" + txtname.Text + "','" + txtfname.Text + "','" + gender + "','" + txtage.Text + "','" + txtemail.Text + "','" + txtpass.Text + "','" + txtfemail.Text + "','" + txtpno.Text + "','" + txtpcnic.Text + "','" + randomInRange2 + "','"+a+ "','"+a+"','"+a+"','"+a+"','"+B+ "','"+B+"' ,'"+a+"' ,'"+a+"')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("You Are Now Registered");
            con.Close();
            string gmail= txtfemail.Text;
            string fromMail = "focus.first66@gmail.com";
            string fromPassword = "lbtrintvhwmhzrno";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Request for Parent Auto Generated Code";
            message.To.Add(new MailAddress(gmail));
            message.Body = " Dear "+ txtfname.Text+ "<html><body> \r\n\r\n\r\n\r\nYour Parent code for our app Focus First is\r\n\r\n </body></html>" + randomInRange2;
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
            Form13 frm = new Form13();
            frm.Show();
    
            this.Hide();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text.Trim()))
            {
                errorProvider1.SetError(txtname, "Name is required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtname, string.Empty);
            }
            if (string.IsNullOrEmpty(txtfname.Text.Trim()))
            {
                errorProvider2.SetError(txtfname, "Father Name is required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtfname, string.Empty);
            }
            if (string.IsNullOrEmpty(rdf.Text.Trim())&& string.IsNullOrEmpty(rdm.Text.Trim()) && string.IsNullOrEmpty(rdo.Text.Trim()))
            {
                errorProvider3.SetError(groupBox1, "Select Gender");
                return;
            }
            else
            {
                errorProvider3.SetError(groupBox1, string.Empty);
            }
            if (string.IsNullOrEmpty(txtage.Text.Trim()))
            {
                errorProvider4.SetError(txtage, "Age is required");
                return;
            }
            else
            {
                errorProvider4.SetError(txtage, string.Empty);
            }
            if (string.IsNullOrEmpty(txtemail.Text.Trim()))
            {
                errorProvider5.SetError(txtemail, "Email is required");
                return;
            }
            else
            {
                errorProvider5.SetError(txtemail, string.Empty);
            }
            if (string.IsNullOrEmpty(txtpass.Text.Trim()))
            {
                errorProvider6.SetError(txtpass, "Password is required");
                return;
            }
            else
            {
                errorProvider6.SetError(txtpass, string.Empty);
            }
            if (string.IsNullOrEmpty(txtfemail.Text.Trim()))
            {
                errorProvider7.SetError(txtfemail, "Father Email is required");
                return;
            }
            else
            {
                errorProvider7.SetError(txtfemail, string.Empty);
            }
            if (string.IsNullOrEmpty(txtpno.Text.Trim()))
            {
                errorProvider8.SetError(txtpno, "Father phone.no is required");
                return;
            }
            else
            {
                errorProvider8.SetError(txtpno, string.Empty);
            }
            if (string.IsNullOrEmpty(txtpcnic.Text.Trim()))
            {
                errorProvider9.SetError(txtpcnic, "Cnic.no is required");
                return;
            }
            else
            {
                errorProvider9.SetError(txtpcnic, string.Empty);
            }
            insertd();

            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            gender = "others";
        }

        private void rdm_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void txtage_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text.Trim()))
            {
                errorProvider1.SetError(txtname, "Name is required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtname, string.Empty);
            }
            if (string.IsNullOrEmpty(txtfname.Text.Trim()))
            {
                errorProvider2.SetError(txtfname, "Father Name is required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtfname, string.Empty);
            }
            if (string.IsNullOrEmpty(rdf.Text.Trim()) && string.IsNullOrEmpty(rdm.Text.Trim()) && string.IsNullOrEmpty(rdo.Text.Trim()))
            {
                errorProvider3.SetError(groupBox1, "Select Gender");
                return;
            }
            else
            {
                errorProvider3.SetError(groupBox1, string.Empty);
            }
            if (string.IsNullOrEmpty(txtage.Text.Trim()))
            {
                errorProvider4.SetError(txtage, "Age is required");
                return;
            }
            else
            {
                errorProvider4.SetError(txtage, string.Empty);
            }
            if (string.IsNullOrEmpty(txtemail.Text.Trim()))
            {
                errorProvider5.SetError(txtemail, "Email is required");
                return;
            }
            else
            {
                errorProvider5.SetError(txtemail, string.Empty);
            }
            if (string.IsNullOrEmpty(txtpass.Text.Trim()))
            {
                errorProvider6.SetError(txtpass, "Password is required");
                return;
            }
            else
            {
                errorProvider6.SetError(txtpass, string.Empty);
            }
            if (string.IsNullOrEmpty(txtfemail.Text.Trim()))
            {
                errorProvider7.SetError(txtfemail, "Father Email is required");
                return;
            }
            else
            {
                errorProvider7.SetError(txtfemail, string.Empty);
            }
            if (string.IsNullOrEmpty(txtpno.Text.Trim()))
            {
                errorProvider8.SetError(txtpno, "Father phone.no is required");
                return;
            }
            else
            {
                errorProvider8.SetError(txtpno, string.Empty);
            }
            if (string.IsNullOrEmpty(txtpcnic.Text.Trim()))
            {
                errorProvider9.SetError(txtpcnic, "Cnic.no is required");
                return;
            }
            else
            {
                errorProvider9.SetError(txtpcnic, string.Empty);
            }
            insertd();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
