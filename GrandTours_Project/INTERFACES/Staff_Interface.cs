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

namespace GrandTours_Project
{
    public partial class Staff_Interface : Form
    {
        public Staff_Interface()
        {
            InitializeComponent();
           btn_passengers.Click += btn_passengers_Click;
            btn_schedules.Click += btn_schedules_Click;
            btn_bookings.Click += btn_bookings_Click;
        }
        MySqlConnection connectionstring = new MySqlConnection("server=localhost;user id=root;database=my_grand_tours_project"); 
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string days, months, year;
            days = dateTimePicker1.Value.Day.ToString();
            months = dateTimePicker1.Value.Month.ToString();
            year = dateTimePicker1.Value.Year.ToString();          
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btn_logout.Text == "Logout")
                {
                    if (MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                    {
                        Form1 form = new Form1();
                        form.Show();
                        this.Hide();
                    }
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_passengers_Click(object sender, EventArgs e)
        {       
            tabControl1.SelectedTab = tabPage1;
        }

        private void btn_schedules_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void btn_bookings_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btn_addReservation_Click(object sender, EventArgs e)
        {
            ReservationForm1 form1 = new ReservationForm1();
            form1.ShowDialog();
            
        }
    }
}
