using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class Mathslevelpage : Form
    {
        public Mathslevelpage(String eid)
        {
            InitializeComponent();
            lbleid.Text = eid;  
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NK6FVOA;Initial Catalog=SE;Integrated Security=True;");
        private void Mathslevelpage_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "select mq1 from StDetails where StudentEmail = '" + lbleid.Text + "'";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                // Execute the SELECT query
                SqlDataReader reader = command.ExecuteReader();

                // Check if there are any rows returned
                if (reader.HasRows)
                {
                    // Read the first row
                    reader.Read();

                    // Get the value from the specified column (change "YourColumnName" to the actual column name)
                    string result = reader["mq1"].ToString();
                    int intValue = Int32.Parse(result);

                    // Close the reader
                    reader.Close();


                    if (intValue >= 1 && intValue <= 5)
                    {



                        guna2Button1.Visible = false;
                        guna2Button2.Visible = true;
                        guna2Button3.Visible = true;
                        guna2Button4.Visible = true;
                        guna2Button5.Visible = true;
                    }
                }
            }
            con.Close();
            con.Open();

            string query2 = "select mq2 from StDetails where StudentEmail = '" + lbleid.Text + "'";
            using (SqlCommand command2 = new SqlCommand(query2, con))
            {
                // Execute the SELECT query
                SqlDataReader reader2 = command2.ExecuteReader();

                // Check if there are any rows returned
                if (reader2.HasRows)
                {
                    // Read the first row
                    reader2.Read();

                    // Get the value from the specified column (change "YourColumnName" to the actual column name)


                    string result2 = reader2["mq2"].ToString();
                    int intValue2 = Int32.Parse(result2);

                    // Close the reader
                    reader2.Close();


                    if (intValue2 >= 1 && intValue2 <= 5)
                    {



                        guna2Button1.Visible = false;
                        guna2Button2.Visible = true;
                        guna2Button3.Visible = true;
                        guna2Button4.Visible = true;
                        guna2Button5.Visible = false;
                    }

                }
            }
            con.Close();
        
    }
        private void button1_Click(object sender, EventArgs e)
        {
            mq1 mq = new mq1(lbleid.Text);
            mq.Visible = true;
            this.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            mq2 mqq = new mq2(lbleid.Text);
            mqq.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MATHL1 mc1 = new MATHL1(lbleid.Text);
            mc1.Visible = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MATHL2cs mc2 =new MATHL2cs(lbleid.Text);
            mc2.Visible = true;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MATHL3 mc3 =new MATHL3(lbleid.Text);
            mc3.Visible = true;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 frm =new Form14(lbleid.Text);
            frm.Visible=true;
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            mq1 mq = new mq1(lbleid.Text);
            mq.Visible = true;
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MATHL1 mc1 = new MATHL1(lbleid.Text);
            mc1.Visible = true;
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MATHL2cs mc2 = new MATHL2cs(lbleid.Text);
            mc2.Visible = true;
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            MATHL3 mc3 = new MATHL3(lbleid.Text);
            mc3.Visible = true;
            this.Close();
        
    
    }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            mq2 mqq = new mq2(lbleid.Text);
            mqq.Visible = true;
            this.Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14 (lbleid.Text);
            
            f14.Show();
            this.Close();

        }
    }
}
