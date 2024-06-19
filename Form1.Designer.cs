namespace SE_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alien = new System.Windows.Forms.PictureBox();
            this.ship = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblscore = new System.Windows.Forms.Label();
            this.lblover = new System.Windows.Forms.Label();
            this.lbleid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = global::SE_Project.Properties.Resources.player__2_;
            this.player.Location = new System.Drawing.Point(247, 374);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(70, 60);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alien
            // 
            this.alien.Image = global::SE_Project.Properties.Resources.enemy1_removebg_preview;
            this.alien.Location = new System.Drawing.Point(89, 71);
            this.alien.Name = "alien";
            this.alien.Size = new System.Drawing.Size(65, 65);
            this.alien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.alien.TabIndex = 1;
            this.alien.TabStop = false;
            this.alien.Tag = "enemy";
            // 
            // ship
            // 
            this.ship.Image = global::SE_Project.Properties.Resources.enemy_2_removebg_preview;
            this.ship.Location = new System.Drawing.Point(418, 71);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(65, 65);
            this.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ship.TabIndex = 2;
            this.ship.TabStop = false;
            this.ship.Tag = "enemy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SE_Project.Properties.Resources.star;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "stars";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SE_Project.Properties.Resources.star;
            this.pictureBox2.Location = new System.Drawing.Point(0, 292);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(599, 274);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "stars";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblscore.Location = new System.Drawing.Point(2, -3);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(172, 39);
            this.lblscore.TabIndex = 5;
            this.lblscore.Text = "Score : 0";
            // 
            // lblover
            // 
            this.lblover.AutoSize = true;
            this.lblover.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblover.ForeColor = System.Drawing.Color.IndianRed;
            this.lblover.Location = new System.Drawing.Point(133, 253);
            this.lblover.Name = "lblover";
            this.lblover.Size = new System.Drawing.Size(306, 62);
            this.lblover.TabIndex = 6;
            this.lblover.Text = "Game-Over";
            // 
            // lbleid
            // 
            this.lbleid.AutoSize = true;
            this.lbleid.BackColor = System.Drawing.Color.Transparent;
            this.lbleid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleid.ForeColor = System.Drawing.Color.White;
            this.lbleid.Location = new System.Drawing.Point(558, 39);
            this.lbleid.Name = "lbleid";
            this.lbleid.Size = new System.Drawing.Size(0, 23);
            this.lbleid.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.lbleid);
            this.Controls.Add(this.lblover);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.ship);
            this.Controls.Add(this.alien);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shooting Games";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox alien;
        private System.Windows.Forms.PictureBox ship;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lblover;
        private System.Windows.Forms.Label lbleid;
    }
}