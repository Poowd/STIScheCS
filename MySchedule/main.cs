using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchedule
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            checkBox6.Checked = true;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //USER CONTROL
                schedules1.Visible = true;
                schedules1.Enabled = true;

                //SIDE PANEL BUTTONS
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
            else
            {
                schedules1.Visible = false;
                schedules1.Enabled = false;

                if (checkBox1.Checked == false &&
                    checkBox2.Checked == false &&
                    checkBox3.Checked == false &&
                    checkBox4.Checked == false &&
                    checkBox5.Checked == false &&
                    checkBox6.Checked == false)
                {
                    checkBox6.Checked = true;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                //USER CONTROL
                coach1.Visible = true;
                coach1.Enabled = true;

                //SIDE PANEL BUTTONS
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
            else
            {
                coach1.Visible = false;
                coach1.Enabled = false;

                if (checkBox1.Checked == false &&
                    checkBox2.Checked == false &&
                    checkBox3.Checked == false &&
                    checkBox4.Checked == false &&
                    checkBox5.Checked == false &&
                    checkBox6.Checked == false)
                {
                    checkBox6.Checked = true;
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                //USER CONTROL
                student1.Visible = true;
                student1.Enabled = true;

                //SIDE PANEL BUTTONS
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
            else
            {
                student1.Visible = false;
                student1.Enabled = false;

                if (checkBox1.Checked == false &&
                    checkBox2.Checked == false &&
                    checkBox3.Checked == false &&
                    checkBox4.Checked == false &&
                    checkBox5.Checked == false &&
                    checkBox6.Checked == false)
                {
                    checkBox6.Checked = true;
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                //USER CONTROL
                schlprogram1.Visible = true;
                schlprogram1.Enabled = true;

                //SIDE PANEL BUTTONS
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
            else
            {
                schlprogram1.Visible = false;
                schlprogram1.Enabled = false;

                if (checkBox1.Checked == false &&
                    checkBox2.Checked == false &&
                    checkBox3.Checked == false &&
                    checkBox4.Checked == false &&
                    checkBox5.Checked == false &&
                    checkBox6.Checked == false)
                {
                    checkBox6.Checked = true;
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                //USER CONTROL
                room1.Visible = true;
                room1.Enabled = true;

                //SIDE PANEL BUTTONS
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox6.Checked = false;
            }
            else
            {
                room1.Visible = false;
                room1.Enabled = false;

                if (checkBox1.Checked == false &&
                    checkBox2.Checked == false &&
                    checkBox3.Checked == false &&
                    checkBox4.Checked == false &&
                    checkBox5.Checked == false &&
                    checkBox6.Checked == false)
                {
                    checkBox6.Checked = true;
                }
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void room1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                //USER CONTROL
                dashboard1.Visible = true;
                dashboard1.Enabled = true;

                //SIDE PANEL BUTTONS
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                dashboard1.Visible = false;
                dashboard1.Enabled = false;

                if (checkBox1.Checked == false &&
                    checkBox2.Checked == false &&
                    checkBox3.Checked == false &&
                    checkBox4.Checked == false &&
                    checkBox5.Checked == false &&
                    checkBox6.Checked == false)
                {
                    checkBox6.Checked = true;
                }
            }
        }
    }
}
