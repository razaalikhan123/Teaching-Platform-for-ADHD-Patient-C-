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

    public partial class GKLEVELSPAGE : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NK6FVOA;Initial Catalog=SE;Integrated Security=True;");
        public GKLEVELSPAGE(String eid)
        {
            InitializeComponent();
            lbleid.Text = eid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gk1 gq = new gk1(lbleid.Text);
            gq.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GKL1 gq = new GKL1(lbleid.Text);
            gq.Visible = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GKL2 gq = new GKL2(lbleid.Text);
            gq.Visible = true;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GKL3 gq = new GKL3(lbleid.Text);
            gq.Visible = true;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gkq2 gq = new gkq2(lbleid.Text);
            gq.Visible = true;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 frm = new Form14(lbleid.Text);
            frm.Visible = true;
            this.Close();
        }

        private void GKLEVELSPAGE_Load(object sender, EventArgs e)
        {

            con.Open();
            string query = "select gq1 from StDetails where StudentEmail = '" + lbleid.Text + "'";
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
                    string result = reader["gq1"].ToString();
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

            string query2 = "select gq2 from StDetails where StudentEmail = '" + lbleid.Text + "'";
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


                    string result2 = reader2["gq2"].ToString();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            gk1 gq = new gk1(lbleid.Text);
            gq.Visible = true;
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            GKL1 gq = new GKL1(lbleid.Text);
            gq.Visible = true;
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            GKL2 gq = new GKL2(lbleid.Text);
            gq.Visible = true;
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            GKL3 gq = new GKL3(lbleid.Text);
            gq.Visible = true;
            this.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            gkq2 gq = new gkq2(lbleid.Text);
            gq.Visible = true;
            this.Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Form14 ff = new Form14(lbleid.Text);
          ff.Show();
            this.Close();
        }
    }
        }


    