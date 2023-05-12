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
    public partial class Admin_Interface : Form
    {
        Update_User_Form form;
        public Admin_Interface()
        {
            InitializeComponent();
            form = new Update_User_Form(this);
            btn_users.Click += btn_users_Click;
            btn_drivers.Click += btn_drivers_Click;
            btn_fareMetrix.Click += btn_fareMetrix_Click;
        }
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=my_grand_tours_project");
        private void btn_users_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage1;
            display();
        }

        private void btn_drivers_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage2;
        }

        private void btn_fareMetrix_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage3;
        }
        public void display()
        {
            CRUD_OPERATION_FOR_USERS.displayusersandsearh("Select user_info.First_Name, user_info.Last_Name, user_info.Age, user_info.Address, account_role.Role, accounts.Status, accounts.Username, accounts.Password " +
                "FROM ((user_info Inner join accounts On user_info.Account_ID = accounts.Account_ID)" +
                " Inner join account_role On user_info.Role_ID = account_role.Role_ID) ORDER BY First_Name ASC, Last_Name ASC", dataGridView1);
        }


        private void btn_logout_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_logout.Text == "Logout")
                {
                    if (MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                    {
                        Form1 form = new Form1();
                        this.Hide();
                        form.Show();
                        
                    }
                   
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Add_User_Form addform = new Add_User_Form();
                addform.ShowDialog();


            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Admin_Interface_Load(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Edit
                form.clear();
                form.user_id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                form.first_name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.last_name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.age = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.address = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.role = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.status = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.username = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.password = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                
                form.updateusers();
                form.ShowDialog();
                return;
            }

            if (e.ColumnIndex == 1)
            {
                //Delete
                if (MessageBox.Show("Are you sure you want to delete this field! ", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CRUD_OPERATION_FOR_USERS.DeleteUsers(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
                    
                    display();
                   
                }
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbx_search.Text != string.Empty)
            {

                CRUD_OPERATION_FOR_USERS.displayusersandsearh("Select user_info.First_Name, user_info.Last_Name, user_info.Age, user_info.Address, account_role.Role, accounts.Status, accounts.Username, accounts.Password " +
                "FROM ((user_info Inner join accounts On user_info.Account_ID = accounts.Account_ID)" +
                " Inner join account_role On user_info.Role_ID = account_role.Role_ID) WHERE First_Name Like '" +tbx_search.Text + "' '" + "%" + "'  Or Last_Name Like '" + tbx_search.Text + "' '" + "%" + "' ORDER BY First_Name ASC, Last_Name ASC ", dataGridView1);
            }
            if (tbx_search.Text == string.Empty)
            {
                CRUD_OPERATION_FOR_USERS.displayusersandsearh("Select user_info.First_Name, user_info.Last_Name, user_info.Age, user_info.Address, account_role.Role, accounts.Status, accounts.Username, accounts.Password " +
                "FROM ((user_info Inner join accounts On user_info.Account_ID = accounts.Account_ID)" +
                " Inner join account_role On user_info.Role_ID = account_role.Role_ID) ORDER BY First_Name ASC, Last_Name ASC", dataGridView1);
            }
        }
    }
}
