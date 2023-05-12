using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace GrandTours_Project
{
    class CRUD_OPERATION_FOR_RESERVATION
    {
        public static  MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=my_grand_tours_project";
            MySqlConnection connectionstring = new MySqlConnection(sql);
            try
            {
                connectionstring.Open();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connectionstring;
        }
        public static void AddPassenger (DB_Passenger passenger)
        {
            
            string sql2 = "Insert Into passenger Value (NULL, @first_name, @last_name, @fare_price , @cash_received, @change_return, @seat_number, NULL)";
            MySqlConnection con = GetConnection(); 
            MySqlCommand cmd = new MySqlCommand(sql2, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("first_name", MySqlDbType.VarChar ).Value = passenger.First_Name;
            cmd.Parameters.Add("last_name", MySqlDbType.VarChar).Value = passenger.Last_Name;
            cmd.Parameters.Add("fare_price", MySqlDbType.Double).Value = passenger.Fare_Price;
            cmd.Parameters.Add("change_return", MySqlDbType.Double).Value = passenger.Cash_Change;
            cmd.Parameters.Add("cash_received", MySqlDbType.Double).Value = passenger.Cash_Received;
            cmd.Parameters.Add("seat_number", MySqlDbType.Int32).Value = passenger.Seat_Number;

          
            try
            {
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Student not Inserted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void addReserveDestination(DB_Reservation reservation)
        {
            string sql = "Insert into reservation Value (NULL, @reserve_date, @departure_date, @departure_time, @destination, NULL, NULL)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("reserve_date", MySqlDbType.DateTime).Value = reservation.Date_Reservation;
            cmd.Parameters.Add("departure_date", MySqlDbType.DateTime).Value = reservation.Departure_Date;
            cmd.Parameters.Add("departure_time", MySqlDbType.DateTime).Value = reservation.Departure_Time;
            cmd.Parameters.Add("destination", MySqlDbType.VarChar).Value = reservation.Destination;
            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Passenger not Inserted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

    }
}
