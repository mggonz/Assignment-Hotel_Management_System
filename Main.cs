using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDatabase
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation Res = new Reservation();
            Res.ShowDialog();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee R = new Employee();
            R.ShowDialog();
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room room = new Room();
            room.ShowDialog();
        }

        private void EventButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Event ev = new Event();
            ev.ShowDialog();
        }
    }
}
