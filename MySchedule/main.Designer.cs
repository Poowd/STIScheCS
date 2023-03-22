namespace MySchedule
{
    partial class main
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.schedules1 = new MySchedule.schedules();
            this.student1 = new MySchedule.student();
            this.schlprogram1 = new MySchedule.schlprogram();
            this.room1 = new MySchedule.room();
            this.coach1 = new MySchedule.coach();
            this.dashboard1 = new MySchedule.dashboard();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.checkBox6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkBox5);
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 860);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MySchedule.Properties.Resources.FoodGuy_Powd_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(0, 779);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.FlatAppearance.BorderSize = 0;
            this.checkBox6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox6.ForeColor = System.Drawing.Color.White;
            this.checkBox6.Location = new System.Drawing.Point(0, 84);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.checkBox6.Size = new System.Drawing.Size(200, 40);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Dashboard";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(0, 833);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "@FoodGuy.Powd";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "ScheCS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.FlatAppearance.BorderSize = 0;
            this.checkBox5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.Location = new System.Drawing.Point(0, 314);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.checkBox5.Size = new System.Drawing.Size(200, 40);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Room";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.FlatAppearance.BorderSize = 0;
            this.checkBox4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(0, 268);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.checkBox4.Size = new System.Drawing.Size(200, 40);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Program";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.FlatAppearance.BorderSize = 0;
            this.checkBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(0, 222);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.checkBox3.Size = new System.Drawing.Size(200, 40);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Student";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.FlatAppearance.BorderSize = 0;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(0, 176);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.checkBox2.Size = new System.Drawing.Size(200, 40);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Coach";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(0, 130);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(200, 40);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Schedule";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1248, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 50);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 50);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dashboard";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(919, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 50);
            this.label2.TabIndex = 9;
            this.label2.Text = "Admin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // schedules1
            // 
            this.schedules1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.schedules1.Enabled = false;
            this.schedules1.Location = new System.Drawing.Point(200, 50);
            this.schedules1.Name = "schedules1";
            this.schedules1.Size = new System.Drawing.Size(1387, 810);
            this.schedules1.TabIndex = 11;
            this.schedules1.Visible = false;
            // 
            // student1
            // 
            this.student1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.student1.Enabled = false;
            this.student1.Location = new System.Drawing.Point(200, 50);
            this.student1.Name = "student1";
            this.student1.Size = new System.Drawing.Size(1387, 810);
            this.student1.TabIndex = 6;
            this.student1.Visible = false;
            // 
            // schlprogram1
            // 
            this.schlprogram1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.schlprogram1.Enabled = false;
            this.schlprogram1.Location = new System.Drawing.Point(200, 50);
            this.schlprogram1.Name = "schlprogram1";
            this.schlprogram1.Size = new System.Drawing.Size(1387, 810);
            this.schlprogram1.TabIndex = 6;
            this.schlprogram1.Visible = false;
            // 
            // room1
            // 
            this.room1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.room1.Enabled = false;
            this.room1.Location = new System.Drawing.Point(200, 50);
            this.room1.Name = "room1";
            this.room1.Size = new System.Drawing.Size(1387, 810);
            this.room1.TabIndex = 6;
            this.room1.Visible = false;
            // 
            // coach1
            // 
            this.coach1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.coach1.Enabled = false;
            this.coach1.Location = new System.Drawing.Point(200, 50);
            this.coach1.Name = "coach1";
            this.coach1.Size = new System.Drawing.Size(1387, 810);
            this.coach1.TabIndex = 6;
            this.coach1.Visible = false;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.dashboard1.Enabled = false;
            this.dashboard1.Location = new System.Drawing.Point(200, 50);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1387, 810);
            this.dashboard1.TabIndex = 8;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(188)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1587, 860);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.schedules1);
            this.Controls.Add(this.student1);
            this.Controls.Add(this.schlprogram1);
            this.Controls.Add(this.room1);
            this.Controls.Add(this.coach1);
            this.Controls.Add(this.dashboard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.main_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private schedules schedules1;
        private student student1;
        private schlprogram schlprogram1;
        private room room1;
        private coach coach1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox6;
        private dashboard dashboard1;
        private Label label4;
        private PictureBox pictureBox2;
    }
}