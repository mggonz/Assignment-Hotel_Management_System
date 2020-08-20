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

namespace HotelDatabase
{
    public partial class Event : Form
    {
        //SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-E46E7DDB;Initial Catalog=Hotel_Database;Integrated Security=True");
        //SqlCommand cm = new SqlCommand();
        SqlConnection cn = new SqlConnection();
        SqlCommand cm;

        public Event()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Data Source=LAPTOP-E46E7DDB;Initial Catalog=Hotel_Database;Integrated Security=True";
            //Data Source=LAPTOP-E46E7DDB;Initial Catalog=Hotel_Database;Integrated Security=True
            cm = cn.CreateCommand();

            disp_data();
            /** TODO: This line of code loads data into the 'hotel_DatabaseDataSet3.Event_Info' table. You can move, or remove it, as needed.
            this.event_InfoTableAdapter.Fill(this.hotel_DatabaseDataSet3.Event_Info);
            // TODO: This line of code loads data into the 'hotel_DatabaseDataSet3.Reservation_Info' table. You can move, or remove it, as needed.
            this.reservation_InfoTableAdapter1.Fill(this.hotel_DatabaseDataSet3.Reservation_Info);
            // TODO: This line of code loads data into the 'hotel_DatabaseDataSet1.Reservation_Info' table. You can move, or remove it, as needed.
            this.reservation_InfoTableAdapter.Fill(this.hotel_DatabaseDataSet1.Reservation_Info);**/

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            /**try
            {
                this.reservation_InfoTableAdapter.FillBy(this.hotel_DatabaseDataSet1.Reservation_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }**/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //should update information
            /**this.Validate();
            this.reservation_InfoBindingSource.EndEdit();
            this.reservation_InfoTableAdapter.UpdateAll(this.hotel_DatabaseDataSet3);**/

            cn.Open();
            cm.CommandType = CommandType.Text;
            //cm.CommandText = "Update Reservation_Info set Reservation_ID = '" + RID_textBox1.Text + "' where Reservation_ID = '" + RID_textBox1.Text + "'";
            if (enumTextBox.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Event_Info] set [Enum] = '" + enumTextBox.Text + "' where [Enum] = '" + textBox1.Text + "'";
            }
            if (room_numTextBox.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Event_Info] set [Room_num] = '" + room_numTextBox.Text + "' where [Enum] = '" + textBox1.Text + "'";
            }
            if (eNameTextBox.Text != "")//
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Event_Info] set [EName] = '" + eNameTextBox.Text + "' where [Enum] = '" + textBox1.Text + "'";
            }
            if (start_TimeTextBox.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Event_Info] set [Start_Time] = '" + start_TimeTextBox.Text + "' where [Enum] = '" + textBox1.Text + "'";
            }
            if (end_TimeTextBox.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Event_Info] set [End_Time] = '" + end_TimeTextBox.Text + "' where [Enum] = '" + textBox1.Text + "'";
            }
            if (eContactFNameTextBox.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Event_Info] set [EContactFName] = '" + eContactFNameTextBox.Text + "' where [Enum] = '" + textBox1.Text + "'";
            }
            if (eContactMInitTextBox.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Event_Info] set [EContactMInit] = '" + eContactMInitTextBox.Text + "' where [Enum] = '" + textBox1.Text + "'";
            }
            if (eContactLNameTextBox.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Event_Info] set [EContactLName] = '" + eContactLNameTextBox.Text + "' where [Enum] = '" + textBox1.Text + "'";
            }
            if (eContactPhoneTextBox.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Event_Info] set [EContactPhone] = '" + eContactPhoneTextBox.Text + "' where [Enum] = '" + textBox1.Text + "'";
            }
            cm.CommandText = "Update [Hotel_Database].[dbo].[Event_Info] set [EDate] = '" + eDateDateTimePicker.Text + "' where [Enum] = '" + textBox1.Text + "'";
            cm.ExecuteNonQuery();
            cn.Close();
            disp_data(); //displays data after changes are made

            MessageBox.Show("Event Updated");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();

        }

        private void RDeleteButton_Click(object sender, EventArgs e)
        {
            //Should remove data
            //this.reservation_InfoBindingSource.RemoveCurrent();
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "Delete from [Hotel_Database].[dbo].[Event_Info] where [Enum] = '" + textBox1.Text + "'";
            cm.ExecuteNonQuery();
            cn.Close();
            textBox1.Text = "";

            disp_data(); //displays data after adding new info

            MessageBox.Show("Event Deleted");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //search button
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from [Hotel_Database].[dbo].[Event_Info] where [Enum] = '" + textBox1.Text + "'";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            event_InfoDataGridView.DataSource = dt;

            cn.Close();
        }

        private void disp_data()
        {
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from Event_Info";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            event_InfoDataGridView.DataSource = dt;

            cn.Close();
        }

        private void EAddButton_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "Insert into [Hotel_Database].[dbo].[Event_Info] values('" + enumTextBox.Text + "','" + room_numTextBox.Text + "','" + eNameTextBox.Text + "','" + Convert.ToDateTime(eDateDateTimePicker.Text) + "','" + start_TimeTextBox.Text + "','" + end_TimeTextBox.Text + "','" + eContactFNameTextBox.Text + "','" + eContactMInitTextBox.Text + "','" + eContactLNameTextBox.Text + "','" + eContactPhoneTextBox.Text + "','" + emp_IDTextBox.Text + "','" + richTextBox1.Text + "')";
            cm.ExecuteNonQuery();
            cn.Close();
            enumTextBox.Text = "";
            room_numTextBox.Text = "";
            eNameTextBox.Text = "";
            //eDateDateTimePicker.Text = "";
            start_TimeTextBox.Text = "";
            end_TimeTextBox.Text = ""; 
            eContactFNameTextBox.Text = "";
            eContactMInitTextBox.Text = "";
            eContactLNameTextBox.Text = "";
            eContactPhoneTextBox.Text = "";
            emp_IDTextBox.Text = "";
            richTextBox1.Text = "";
            disp_data(); //displays data after adding new info

            MessageBox.Show("New Event Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //able to find all the events that an employee will work at*** work on this idea to find employee depending on any information data there is for them
            //search button*******
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from Event_Info where [Emp_ID] = '" + textBox2.Text + "'";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            event_InfoDataGridView.DataSource = dt;

            cn.Close();
        }

    }
}
