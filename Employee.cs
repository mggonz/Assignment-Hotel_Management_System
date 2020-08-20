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
    public partial class Employee : Form
    {
        //SqlConnection cn = new SqlConnection("Data Source=LAPTOP-E46E7DDB;Initial Catalog=Hotel_Database;Integrated Security=True");
        //Data Source=LAPTOP-E46E7DDB;Initial Catalog=Hotel_Database;Integrated Security=True
        //SqlCommand cm = cn.CreateCommand();
        SqlConnection cn = new SqlConnection();
        SqlCommand cm;

        public Employee()
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

        private void disp_data()
        {
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = @"select * from [Hotel_Database].[dbo].[Employee_Info]";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            employee_InfoDataGridView.DataSource = dt;

            cn.Close();
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
            cm.CommandText = @"Delete from Employee_Info where Emp_ID = '" + textBox1.Text + "'";
            cm.ExecuteNonQuery();
            cn.Close();
            textBox1.Text = "";

            disp_data(); //displays data after adding new info

            MessageBox.Show("Event Deleted");
        }

        private void EAddButton_Click(object sender, EventArgs e)
        {
            /**this.Validate();
            this.reservation_InfoBindingSource.EndEdit();
            this.reservation_InfoTableAdapter.UpdateAll(this.hotel_DatabaseDataSet3);**/
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = @"Insert into Employee_Info values('" + emp_IDTextBox.Text + "','" + fNameTextBox.Text + "','" + mInitTextBox.Text + "','" + lNameTextBox.Text + "','" + occupationTextBox.Text + "','" + dnumTextBox.Text + "')";
            cm.ExecuteNonQuery();
            cn.Close();
            emp_IDTextBox.Text = "";
            fNameTextBox.Text = "";
            mInitTextBox.Text = "";
            lNameTextBox.Text = "";
            occupationTextBox.Text = "";
            dnumTextBox.Text = "";
            disp_data(); //displays data after adding new info

            MessageBox.Show("New Employee Added");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //search button
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = @"select * from Employee_Info where Emp_ID = '" + textBox1.Text + "'";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            employee_InfoDataGridView.DataSource = dt;

            cn.Close();
        }

        private void RDeleteButton_Click_1(object sender, EventArgs e)
        {
            cn.Open();
            cm.CommandType = CommandType.Text;
            cm.CommandText = @"Delete from Employee_Info where Emp_ID = '" + textBox1.Text + "'";
            cm.ExecuteNonQuery();
            cn.Close();
            textBox1.Text = "";

            disp_data(); //displays data after adding new info

            MessageBox.Show("Employee Information Deleted");
        }

        private void RUpdateButton_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm.CommandType = CommandType.Text;
            //cm.CommandText = @"Update Reservation_Info set Reservation_ID = '" + RID_textBox1.Text + "' where Reservation_ID = '" + RID_textBox1.Text + "'";
            if (emp_IDTextBox.Text != "")
            {
                cm.CommandText = @"Update Employee_Info set Emp_ID = '" + emp_IDTextBox.Text + "' where [Emp_ID] = '" + textBox1.Text + "'";
            }
            if (fNameTextBox.Text != "")
            {
                cm.CommandText = @"Update [Hotel_Database].[dbo].[Employee_Info] set [FName] = '" + fNameTextBox.Text + "' where [Emp_ID] = '" + textBox1.Text + "'";
            }
            if (lNameTextBox.Text != "")//
            {
                cm.CommandText = @"Update [Hotel_Database].[dbo].[Employee_Info] set [LName] = '" + lNameTextBox.Text + "' where [Emp_ID] = '" + textBox1.Text + "'";
            }
            if (mInitTextBox.Text != "")
            {
                cm.CommandText = @"Update [Hotel_Database].[dbo].[Employee_Info] set [MInit] = '" + mInitTextBox.Text + "' where [Emp_ID] = '" + textBox1.Text + "'";
            }
            if (occupationTextBox.Text != "")
            {
                cm.CommandText = @"Update [Hotel_Database].[dbo].[Employee_Info] set [Occupation] = '" + occupationTextBox.Text + "' where [Emp_ID] = '" + textBox1.Text + "'";
            }
            if (dnumTextBox.Text != "")
            {
                cm.CommandText = @"Update [Hotel_Database].[dbo].[Employee_Info] set [Dnum] = '" + dnumTextBox.Text + "' where [Emp_ID] = '" + textBox1.Text + "'";
            }
            cm.ExecuteNonQuery();
            cn.Close();
            disp_data(); //displays data after changes are made

            MessageBox.Show("Employee Information Updated");
        }

    }
}
