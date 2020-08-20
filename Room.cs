using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace HotelDatabase
{
    public partial class Room : Form
    {
        //SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-E46E7DDB;Initial Catalog=Hotel_Database;Integrated Security=True");
        //SqlCommand cm = new SqlCommand();
        SqlConnection cn = new SqlConnection();
        SqlCommand cm;

        public Room()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Data Source=LAPTOP-E46E7DDB;Initial Catalog=Hotel_Database;Integrated Security=True";
            //Data Source=LAPTOP-E46E7DDB;Initial Catalog=Hotel_Database;Integrated Security=True
            cm = cn.CreateCommand();

            disp_data();


        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            /**try
            {
                this.reservation_InfoTableAdapter.FillBy(this.hotel_DatabaseDataSet3.Reservation_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }**/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm.CommandType = CommandType.Text;
            //cm.CommandText = "Update Reservation_Info set Reservation_ID = '" + RID_textBox1.Text + "' where Reservation_ID = '" + RID_textBox1.Text + "'";
            if (textBox3.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Room_Info] set [Room #] = '" + textBox3.Text + "' where [Room #] = '" + RID_textBox.Text + "'";
            }
            if (textBox4.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Room_Info] set [Floor] = '" + textBox4.Text + "' where [Room #] = '" + RID_textBox.Text + "'";
            }
            if (textBox5.Text != "")//
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Room_Info] set [Bed Type] = '" + textBox5.Text + "' where [Room #] = '" + RID_textBox.Text + "'";
            }
            if (checkBox1.Text != "")//*******
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Room_Info] set [Smoking] = '" + checkBox1.Text + "' where [Room #] = '" + RID_textBox.Text + "'";
            }
            if (richTextBox1.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Room_Info] set [Description] = '" + richTextBox1.Text + "' where [Room #] = '" + RID_textBox.Text + "'";
            }
            cm.ExecuteNonQuery();
            cn.Close();
            disp_data(); //displays data after changes are made

            MessageBox.Show("Room Updated");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();

        }
        private void disp_data()
        {
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from [Hotel_Database].[dbo].[Room_Info]";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "Insert into Room_Info values('" + textBox3.Text + "','" + null + "','" + textBox4.Text + "','" + null + "','" + textBox5.Text + "','" + checkBox1.Text + "','" + richTextBox1.Text + "')";
            cm.ExecuteNonQuery();
            cn.Close();
            textBox5.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            richTextBox1.Text = "";
            disp_data(); //displays data after adding new info

            MessageBox.Show("New Room Information Added");
        }

        private void RDeleteButton_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "Delete from [Hotel_Database].[dbo].[Room_Info] where [Room #] = '" + RID_textBox.Text + "'";
            cm.ExecuteNonQuery();
            cn.Close();

            RID_textBox.Text = "";

            disp_data(); //displays data after adding new info

            MessageBox.Show("Room Deleted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from [Hotel_Database].[dbo].[Room_Info] where [Room #] = '" + RID_textBox.Text + "'";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Try to see if there is a way to set up a table that could set up all of this information at the same time
            cn.Open();
            cm.CommandType = CommandType.Text;
            if(textBox2.Text != "")
                cm.CommandText = "select * from Room_Info where [Reservation] = '" + textBox2.Text + "'";
            if (dateTimePicker1.Checked == true)
            {
                //cm.CommandText = "select * from Reservation_Info where [Start Date] = '" + dateTimePicker1.Text + "' OR [End Date] = '" + dateTimePicker1.Text + "'";
                cm.CommandText = "select * from Reservation_Info where [Start Date] = '" + dateTimePicker1.Text + "'";
                cm.CommandText = "select * from Reservation_Info where [End Date] = '" + dateTimePicker1.Text + "'";
                cm.CommandText = "select * from Event_Info where [EDate] = '" + dateTimePicker1.Text + "'";
            }
            if (dateTimePicker1.Checked == true)
            {
                //cm.CommandText = "select * from Reservation_Info where [Start Date] = '" + dateTimePicker2.Text + "' OR [End Date] = '" + dateTimePicker2.Text + "'";
                cm.CommandText = "select * from Reservation_Info where [Start Date] = '" + dateTimePicker2.Text + "'";
                cm.CommandText = "select * from Reservation_Info where [End Date] = '" + dateTimePicker2.Text + "'";
                cm.CommandText = "select * from Event_Info where [EDate] = '" + dateTimePicker1.Text + "'";
            } 
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cn.Close();
        }


    }
}
