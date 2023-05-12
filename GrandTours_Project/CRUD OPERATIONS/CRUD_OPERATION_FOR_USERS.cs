using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandTours_Project
{
    class CRUD_OPERATION_FOR_USERS
    {
        public int id = 0;
        public static MySqlConnection GetConnection()
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
        public static void AddUsers_Info(DB_User_Info user, DB_Accounts accounts)
        {
            string sql = "Insert Into user_info Value (@user_id,@first_name, @last_name, @age, @address, @account_id, @role_id)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("user_id", MySqlDbType.Int32).Value = user.user_id;
            cmd.Parameters.Add("first_name", MySqlDbType.VarChar).Value = user.First_Name;
            cmd.Parameters.Add("last_name", MySqlDbType.VarChar).Value = user.Last_Name;
            cmd.Parameters.Add("age", MySqlDbType.Int32).Value = user.Age;
            cmd.Parameters.Add("address", MySqlDbType.VarChar).Value = user.Address;
            cmd.Parameters.Add("account_id", MySqlDbType.Int32).Value = user.Account_ID ;
            cmd.Parameters.Add("role_id", MySqlDbType.Int32).Value = user.Role_ID;
            MySqlCommand alter = new MySqlCommand("ALTER TABLE user_info AUTO_INCREMENT = 1", con);
           

            string sql1 = "Insert Into accounts Value (@account_id,@username, @password, @status, @role_id)";
            MySqlCommand cmd1 = new MySqlCommand(sql1, con);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("account_id", MySqlDbType.Int32).Value = accounts.account_id;
            cmd1.Parameters.Add("username", MySqlDbType.VarChar).Value = accounts.Username;
            cmd1.Parameters.Add("password", MySqlDbType.VarChar).Value = accounts.Password;
            cmd1.Parameters.Add("status", MySqlDbType.VarChar).Value = accounts.Status;
            cmd1.Parameters.Add("role_id", MySqlDbType.Int32).Value = accounts.role_id;
            try
            {
                alter.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("User not Inserted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
       public static void UpdateUsers(DB_User_Info user,DB_Accounts accounts,string id)
        {
            string querry = "UPDATE user_info  Value SET First_Name = @first_name, Last_Name = @last_name, " +
                "Age =  @age,Address =  @address, Account_ID = @account_id,Role_ID = @role_id where User_ID = @user_id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(querry, con);
            cmd.Parameters.Add("user_id", MySqlDbType.Int32).Value = user.user_id;
            cmd.Parameters.Add("first_name", MySqlDbType.VarChar).Value = user.First_Name;
            cmd.Parameters.Add("last_name", MySqlDbType.VarChar).Value = user.Last_Name;
            cmd.Parameters.Add("age", MySqlDbType.Int32).Value = user.Age;
            cmd.Parameters.Add("address", MySqlDbType.VarChar).Value = user.Address;
            cmd.Parameters.Add("account_id", MySqlDbType.Int32).Value = user.Account_ID;
            cmd.Parameters.Add("role_id", MySqlDbType.Int32).Value = user.Role_ID;


            string querryforaccount = "UPDATE accounts Value SET Username = @username, Password = @password,  Status = @status, Role_ID = @role_ID where Account_ID = @account";
            //MySqlConnection con = GetConnection();
            MySqlCommand cmd1 = new MySqlCommand(querryforaccount, con);
            cmd1.Parameters.Add("account", MySqlDbType.VarChar).Value = accounts.account_id;
            cmd1.Parameters.Add("username", MySqlDbType.VarChar).Value = accounts.Username;
            cmd1.Parameters.Add("password", MySqlDbType.VarChar).Value = accounts.Password;
            cmd1.Parameters.Add("status", MySqlDbType.VarChar).Value = accounts.Status;
            cmd1.Parameters.Add("role_ID", MySqlDbType.Int32).Value = accounts.role_id;
            try
            {
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Users not Updated. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
       
        public static void DeleteUsers(string name,string status)
        {
            string sql = "Delete table1, table2  FROM user_info as table1 Inner join accounts as table2  ON table1.Account_ID = table2.Account_ID " +
                "where table1.First_Name = @first_name AND table2.Status = @status";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("first_name", MySqlDbType.VarChar).Value = name;     
            cmd.Parameters.Add("status", MySqlDbType.VarChar).Value = status;

           
            try
            {
                //cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Users not Deleted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void displayusersandsearh(string querry, DataGridView dgv)
        {
            string sql = querry;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgv.DataSource = dt;
            con.Close();
        }
    }
}
