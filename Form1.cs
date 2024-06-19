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
    public partial class Form1 : Form
    {
       
        public Form1(String eid)
        {
            InitializeComponent();
            lbleid.Text = eid;
            lbleid.Hide();
            lblover.Hide();
             

        }
        bool right, left,space;
        int Score;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NK6FVOA;Initial Catalog=SE;Integrated Security=True;");
      

        void Game_Results()
        {
            foreach(Control j in this.Controls)
            {
                foreach (Control i in this.Controls) 
                {
                    if (j is PictureBox && j.Tag == "bullet")
                    {
                        if (i is PictureBox && i.Tag == "enemy")
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {


                                i.Top = -100;
                                ((PictureBox)j).Image = Properties.Resources.explosion;
                                Score++;
                                lblscore.Text = "Score : " + Score;

                            }
                        }
                    }
                }
            }
            if (player.Bounds.IntersectsWith(alien.Bounds)|| player.Bounds.IntersectsWith(ship.Bounds))
            {
                timer1.Stop();
                lblover.Show();
                lblover.BringToFront();
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT score1 FROM StDetails WHERE StudentEmail = '" + lbleid.Text + "'", con))
                {
                    // Execute the SELECT query
                    SqlDataReader reader = command.ExecuteReader();

                    // Check if there are any rows returned
                    if (reader.HasRows)
                    {
                        // Read the first row
                        reader.Read();

                        // Get the value from the specified column (change "YourColumnName" to the actual column name)
                        string result = reader["score1"].ToString();
                        int intValue = Int32.Parse(result);

                        // Close the reader
                        reader.Close();

                        if (Score > intValue)
                        {

                            SqlCommand cmd;
                            cmd = new SqlCommand("UPDATE StDetails SET score1 = '" + Score + "' WHERE StudentEmail = '" + lbleid.Text + "'", con);
                            cmd.ExecuteNonQuery();

                            
                        }
                    }

                }
                con.Close();
            }
        }
        void Star()
        {
            foreach (Control j in this.Controls)
            {
                if(j is PictureBox && j.Tag == "stars")
                {
                    j.Top += 10;
                    if(j.Top > 400)
                    {
                        j.Top= 0;
                    }
                }
            }
        }
        void Add_Bullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet.Image = Properties.Resources.explosion_removebg_preview;
            bullet.BackColor = System.Drawing.Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Left = player.Left + 15;
            bullet.Top = player.Top - 30;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }
        void Bullet_Movement()
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "bullet")
                {
                    x.Top -= 10;
                    if (x.Top < 100)
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }

        void Enemy_Movement()
        {
            Random  rnd = new Random();
            int x, y;
            if (alien.Top >= 500)
            {
                x = rnd.Next(0, 300);
                alien.Location =new Point(x, 0);
            }
            if (ship.Top >= 500)
            {
                y = rnd.Next(0, 300);
                ship.Location = new Point(y, 0);
            }
            else
            {
                alien.Top += 15;
                ship.Top += 10;
            }
        }
        void Arrow_Key_Movement()
        {
            if (right == true)
            {
                if (player.Left < 425)
                {
                    player.Left += 20;
                }
            }
            if (left == true)
            {
                if (player.Left > 10)
                {
                    player.Left -= 20;
                }
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = true;
                Add_Bullet();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Arrow_Key_Movement();
            Enemy_Movement();
            Bullet_Movement();
            Star();
            Game_Results();
        }
    }
}
