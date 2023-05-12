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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int role;
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=my_grand_tours_project");
        private void btn_Login_Click(object sender, EventArgs e)
        {
            con.Open();
           MySqlCommand cmd= new MySqlCommand("Select Role_ID From accounts  WHERE Username = '"+tbx_username.Text+"' AND Password = '"+tbx_password.Text+"'",con);
            MySqlCommand cmd1 = new MySqlCommand("Select Role From account_role WHERE Role_ID = '"+role+"'", con);
            int i = Convert.ToInt32(cmd1.ExecuteNonQuery());
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    role = int.Parse(reader["Role_ID"].ToString());
                    if(role != i)
                    {
                        MessageBox.Show("Data not Found" + role);
                    }
                    else if(role == i)
                    {
                        Admin_Interface form = new Admin_Interface();
                        form.Show();
                    }
                   
                }
               
            }
            else
            {
                MessageBox.Show("Data not  Found");
            }
            con.Close();
            //if(reader.HasRows.ToString() == "Role")
            //{

            //}

            //int role = Convert.ToInt32(cmd1.ExecuteScalar());
            //int role_ID = Convert.ToInt32(cmd.ExecuteScalar());
            //if(role_ID == role)
            //{
            //    Admin_Interface form = new Admin_Interface();
            //    form.Show();
            //    this.Hide();
            //}



            //Staff_Interface form = new Staff_Interface();
            //form.ShowDialog();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbx_password.PasswordChar = show_password.Checked ? '\0' : '*';
        }

        private void tbx_password_TextChanged(object sender, EventArgs e)
        {
            tbx_password.PasswordChar = '*';
        }

        private void lbl_clickHere_MouseHover(object sender, EventArgs e)
        {
            lbl_clickHere.ForeColor = Color.Orange;
        }

        private void lbl_clickHere_MouseLeave(object sender, EventArgs e)
        {
            lbl_clickHere.ForeColor = Color.FromArgb(10, 36, 99);
        }

        private void tbx_username_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbx_username_Click(object sender, EventArgs e)
        {
            tbx_username.SelectAll();
        }

        private void tbx_password_Click(object sender, EventArgs e)
        {
            tbx_password.SelectAll();

        }
    }
}
