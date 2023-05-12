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
    public partial class Add_User_Form : Form
    {
       
        public Add_User_Form()
        {
            InitializeComponent();
          
            fillcomboboxforrole();
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            addRoleToolStripMenuItem.Click += addRoleToolStripMenuItem_Click;
        }
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=my_grand_tours_project");
        
        public int Account_id = 0;

        public void AutoincrementID()
        {
            con.Open();
           
            MySqlCommand cmd = new MySqlCommand("select count(User_ID) from user_info ", con);
            int j = Convert.ToInt32(cmd.ExecuteScalar());
            j++;
            lbl_account_id.Text = Account_id + j.ToString();
            //string auto = "UPDATE user_info as table1 SET table1.User_ID = '" + ((lbl_account_id.Text = Account_id + j.ToString())) + "'";
            //MySqlCommand cmd1 = new MySqlCommand(auto, con);
            //int i = Convert.ToInt32(cmd.ExecuteScalar());

            //lbl_account_id.Text = Account_id + i.ToString();
            //cmd1.ExecuteNonQuery();
            
            lbl_account_id.Visible = false;
            

            con.Close();
        }
           
              
        private void Add_User_Form_Load(object sender, EventArgs e)
        {
            AutoincrementID();
            tabControl1.Visible = false;
        }

      

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage1;
            AutoincrementID();
        }

        private void addRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            display();
            tabControl1.SelectedTab = tabPage2;
        }

        private void btn_Saverole_Click(object sender, EventArgs e)
        {
            try
            {
                DB_Account_Role role = new DB_Account_Role(tbx_role.Text.Trim());
                CRUD_OPERATIONS_FOR_ROLES.addRole(role);
               
                display();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

       public void display()
        {
            CRUD_OPERATIONS_FOR_ROLES.displayusersandsearh("SELECT Role From account_role", dataGridView1);
        }

       
        private void fillcomboboxforrole()
        {
            try
            {

                con.Open();
                string querry = "SELECT Role FROM account_role";
               
                MySqlCommand cmd = new MySqlCommand(querry, con);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    string role = reader.GetString("Role");
                    
                    cmb_role.Items.Add(role);
                  

                }
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void cmb_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select Role_ID FROM account_role WHERE Role = '"+ cmb_role.Text+ "'",con);
            int role = System.Convert.ToInt32(cmd.ExecuteScalar());
            lbl_role_id.Text = role.ToString();
            lbl_role_id.Visible = false;

            con.Close();
        }
        public void clear()
        {
            tbx_firstName.Text = tbx_lastName.Text = tbx_password.Text = tbx_role.Text= cmb_role.Text = tbx_username.Text = tbx_address.Text = tbx_age.Text = "";
        }
        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to cancel?", "Cancel User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                {
                    clear();
                    
                    this.Close();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_next_Click_1(object sender, EventArgs e)
        {
           
            try
            {
                if (tbx_firstName.Text.Trim().Length < 3 && tbx_lastName.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Please Input all Fields!");

                    lbl_warnfirstname.Visible = true;
                    lbl_warnLastname.Visible = true;
                    lbl_warnAge.Visible = true;
                    lbl_warnAddress.Visible = true;
                    lbl_warnRole.Visible = true;
                    lbl_warnUsername.Visible = true;
                    lbl_warnPassword.Visible = true;
                    lbl_warnStatus.Visible = true;
                    return;
                }
                else if (tbx_firstName.Text.Trim().Length < 3)
                {
                    MessageBox.Show("First Name is Empty.");
                    lbl_warnfirstname.Visible = true;
                    return;
                }
                else if (tbx_lastName.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Last Name is Empty.");
                    lbl_warnLastname.Visible = true;
                    return;
                }
                else if (tbx_age.Text.Trim().Length < 0)
                {
                    MessageBox.Show("Your Age is Empty.");
                    lbl_warnAge.Visible = true;
                    return;
                }
                else if (tbx_address.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Address is Empty.");
                    lbl_warnAddress.Visible = true;
                    return;
                }
                else if (tbx_username.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Username is Empty.");
                   lbl_warnUsername.Visible = true;
                    return;
                }
                else if (tbx_password.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Address is Empty.");
                    lbl_warnPassword.Visible = true;
                    return;
                }
                else if (cmb_status.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Address is Empty.");
                    lbl_warnStatus.Visible = true;
                    return;
                }
               if(btn_save.Text == "Save")
                {
                    DB_User_Info user = new DB_User_Info(int.Parse(lbl_account_id.Text.Trim()), tbx_firstName.Text.Trim(), tbx_lastName.Text.Trim(), int.Parse(tbx_age.Text.Trim()), tbx_address.Text.Trim(), int.Parse(lbl_account_id.Text.Trim()), int.Parse(lbl_role_id.Text.Trim()));
                    DB_Accounts account = new DB_Accounts(int.Parse(lbl_account_id.Text.Trim()), tbx_username.Text.Trim(), tbx_password.Text.Trim(), cmb_status.Text.Trim(), int.Parse(lbl_role_id.Text.Trim()));
                   
                    CRUD_OPERATION_FOR_USERS.AddUsers_Info(user, account);
                    clear();
                    AutoincrementID();
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
                if (MessageBox.Show("Do you want to cancel?", "Cancel User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                {
                    clear();

                    this.Close();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Exit", "Exit", MessageBoxButtons.OKCancel , MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
