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
    public partial class Reservation : Form
    {
        //SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-E46E7DDB;Initial Catalog=Hotel_Database;Integrated Security=True");
        //SqlCommand cm = new SqlCommand();
        SqlConnection cn = new SqlConnection();
        SqlCommand cm;

        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Data Source=LAPTOP-E46E7DDB;Initial Catalog=Hotel_Database;Integrated Security=True";
            //Data Source=LAPTOP-E46E7DDB;Initial Catalog=Hotel_Database;Integrated Security=True
            cm = cn.CreateCommand();

            dis_data();
            /** TODO: This line of code loads data into the 'hotel_DatabaseDataSet3.Reservation_Info' table. You can move, or remove it, as needed.
            this.reservation_InfoTableAdapter1.Fill(this.hotel_DatabaseDataSet3.Reservation_Info);
            // TODO: This line of code loads data into the 'hotel_DatabaseDataSet1.Reservation_Info' table. You can move, or remove it, as needed.
            this.reservation_InfoTableAdapter.Fill(this.hotel_DatabaseDataSet1.Reservation_Info);**/

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //should update information
            /**this.Validate();
            this.reservationInfoBindingSource1.EndEdit();
            this.reservationInfoBindingSource1.UpdateAll(this.hotel_DatabaseDataSet_All);
            **/

            cn.Open();
            cm.CommandType = CommandType.Text;
            //cm.CommandText = "Update Reservation_Info set Reservation_ID = '" + RID_textBox1.Text + "' where Reservation_ID = '" + RID_textBox1.Text + "'";
            if (textBox5.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Reservation_Info] set [C_Phone] = '" + textBox5.Text + "' where [Reservation_ID] = '" + res_IDTextBox.Text + "'";
            }
            if(textBox6.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Reservation_Info] set [C_LName] = '" + textBox6.Text + "' where [Reservation_ID] = '" + res_IDTextBox.Text + "'";
            }
            if(RoomNum_textBox2.Text != "")//
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Reservation_Info] set [Room #] = '" + RoomNum_textBox2.Text + "' where [Reservation_ID] = '" + Convert.ToInt32(res_IDTextBox.Text) + "'";
            }
            if(RID_textBox1.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Reservation_Info] set [Reservation_ID] = '" + RID_textBox1.Text + "' where [Reservation_ID] = '" + Convert.ToInt32(res_IDTextBox.Text) + "'";
            }
            if(CFName_textBox.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Reservation_Info] set [C_FName] = '" + CFName_textBox.Text + "' where [Reservation_ID] = '" + res_IDTextBox.Text + "'";
            }
            if(CMInit_textBox.Text != "")
            {
                cm.CommandText = "Update [Hotel_Database].[dbo].[Reservation_Info] set [C_MInit] = '" + CMInit_textBox.Text + "' where [Reservation_ID] = '" + res_IDTextBox.Text + "'";
            }
            //if (dateTimePicker1.Text != "")
            //cm.CommandText = "Update [Hotel_Database].[dbo].[Reservation_Info] set [Start Date] = '" + Convert.ToDateTime(dateTimePicker1.Text) + "' where [Reservation_ID] = '" + res_IDTextBox.Text + "'";
            
            //if(dateTimePicker2.Text != "")
            //cm.CommandText = "Update [Hotel_Database].[dbo].[Reservation_Info] set [End Date] = '" + Convert.ToDateTime(dateTimePicker2.Text) + "' where [Reservation_ID] = '" + res_IDTextBox.Text + "'";
            cm.ExecuteNonQuery();
            cn.Close();
            dis_data(); //displays data after changes are made

            MessageBox.Show("Reservation Updated");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();

        }

        private void RDeleteButton_Click(object sender, EventArgs e)
        {
            //Should remove data depending on their Reservation_ID
            //this.reservationInfoBindingSource1.RemoveCurrent();
            
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "Delete [Hotel_Database].[dbo].[Reservation_Info] where [Reservation_ID] = '" + res_IDTextBox.Text + "'";
            cm.ExecuteNonQuery();
            cn.Close();

            res_IDTextBox.Text = "";

            dis_data(); //displays data after adding new info

            MessageBox.Show("Reservation Deleted");

        }

        private void EAddButton_Click(object sender, EventArgs e)
        {
            /** this connects to the reservation add form
             * this.Hide;
            ReservationAdd AddRes = new ReservationAdd();
            AddRes.AcceptButton();
            AddRes.ShowDialog();
            this.reservationInfoBindingSource1.AddNew();
            Room Res = new Room();
            Res.ShowDialog();**/

            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "Insert into [Hotel_Database].[dbo].[Reservation_Info] values('" + RID_textBox1.Text + "','" + RoomNum_textBox2.Text + "','" + null/**dateTimePicker1.Text**/ +"','" + null/**dateTimePicker1.Text**/ +"','" + CFName_textBox.Text + "','" + CMInit_textBox.Text + "','" + textBox6.Text + "','" + textBox5.Text + "')";
            cm.ExecuteNonQuery();
            cn.Close();
            textBox5.Text = "";
            textBox6.Text = "";
            RoomNum_textBox2.Text = "";
            RID_textBox1.Text = "";
            CFName_textBox.Text = "";
            CMInit_textBox.Text = "";
            dis_data(); //displays data after adding new info

            MessageBox.Show("New Reservation Added");

        }

        private void dis_data()
        {
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from [Hotel_Database].[dbo].[Reservation_Info]";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from [Hotel_Database].[dbo].[Reservation_Info] where [Reservation_ID] = '" + res_IDTextBox.Text + "'";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cn.Close();
        }
    }
}
