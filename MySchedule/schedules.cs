using MySql.Data.MySqlClient;
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
    public partial class schedules : UserControl
    {
        public schedules()
        {
            InitializeComponent();
            show_schedule();
        }

        private void show_schedule()
        {
            string constring = "datasource = localhost ; port = 3306 ; username = root ; password = admin";
            string Query = "SELECT * FROM classmanagementsystem.schedule_list WHERE STATUS LIKE '%ACTIVE%'";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlDataAdapter Adapter = new MySqlDataAdapter(Query, constring);
            DataTable dtable = new DataTable();
            Adapter.Fill(dtable);

            dataGridView1.DataSource = dtable;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
