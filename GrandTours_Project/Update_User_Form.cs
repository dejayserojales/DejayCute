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
    public partial class Update_User_Form : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=my_grand_tours_project");
        private readonly Admin_Interface _parent;
        public Update_User_Form(Admin_Interface parent)
        {
            InitializeComponent();
            fillcomboboxforrole();
            _parent = parent;
        }
        public int Account_id = 0;
        public string user_id, age;
        public string first_name, last_name, contact, address, role, username, password, status;
        public void AutoincrementID()
        {
            con.Open();

            MySqlCommand cmd = new MySqlCommand("select count(User_ID) from user_info ", con);
            int j = Convert.ToInt32(cmd.ExecuteScalar());
            lbl_account_id.Text = Account_id + j.ToString();
            lbl_account_id.Visible = false;


            con.Close();
        }

        private void Update_User_Form_Load(object sender, EventArgs e)
        {
            AutoincrementID();
        }

        private void cmb_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select Role_ID FROM account_role WHERE Role = '" + cmb_role.Text + "'", con);
            int role = System.Convert.ToInt32(cmd.ExecuteScalar());
            lbl_role_id.Text = role.ToString();
            lbl_role_id.Visible = false;

            con.Close();
        }
        private void fillcomboboxforrole()
        {
            try
            {

                con.Open();
                string querry = "SELECT Role_id , Role FROM account_role";

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

        private void btn_cancel_Click(object sender, EventArgs e)
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

      
        public void updateusers()
        {

            btn_save.Text = "Update";


            tbx_firstName.Text = first_name;
            tbx_lastName.Text = last_name;
            tbx_age.Text = age;
            tbx_address.Text = address;
            cmb_role.Text = role;
            tbx_username.Text = username;
            tbx_password.Text = password;
            cmb_status.Text = status;




        }
        public void clear()
        {
            tbx_firstName.Text = tbx_lastName.Text  = cmb_role.Text = cmb_role.Text = tbx_address.Text = tbx_age.Text = "";
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tbx_firstName.Text.Trim().Length < 3 && tbx_lastName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Please Input all Fields!");

                lbl_warnfirstname.Visible = true;
                lbl_warnLastname.Visible = true;
                lbl_warnAge.Visible = true;
                lbl_warnAddress.Visible = true;
                lbl_warnRole.Visible = true;
                
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
          
            else if (cmb_status.Text.Trim().Length < 3)
            {
                MessageBox.Show("Address is Empty.");
                lbl_warnStatus.Visible = true;
                return;
            }
            if (btn_save.Text == "Update")
            {
                DB_User_Info user = new DB_User_Info(int.Parse(lbl_account_id.Text.Trim().ToString()), tbx_firstName.Text.Trim(), tbx_lastName.Text.Trim(), int.Parse(tbx_age.Text.Trim().ToString()), tbx_address.Text.Trim(), int.Parse(lbl_account_id.Text.Trim().ToString()), int.Parse(lbl_role_id.Text.Trim().ToString()));
                DB_Accounts account = new DB_Accounts(int.Parse(lbl_account_id.Text.Trim().ToString()), tbx_username.Text.Trim(), tbx_password.Text.Trim(), cmb_status.Text.Trim().ToString(), int.Parse(lbl_role_id.Text.Trim().ToString()));
                CRUD_OPERATION_FOR_USERS.UpdateUsers(user,account, user_id);
              

            }
            _parent.display();
        }
    }
}
