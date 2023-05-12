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
    public partial class ReservationForm1 : Form
    {
        public ReservationForm1()
        {
            InitializeComponent();
            fillcombobox();
        }
        public DateTime date;
        public DateTime time;
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=my_grand_tours_project");
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Do you want to cancel?", "Cancel Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== (DialogResult.Yes))
                {
                    this.Close();
                }
                
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbx_firstName.Text.Trim().Length < 3 && tbx_lastName.Text.Trim().Length < 3 && cmb_Destination.Text.Trim().Length < 3)

                {
                    MessageBox.Show("Please Input all Fields!");
                    lbl_warndeaparturetime.Visible = true;
                    lbl_warndeparturedate.Visible = true;
                    lbl_warndestination.Visible = true;
                    lbl_warnfirstname.Visible = true;
                    lbl_warnLastname.Visible = true;
                    return;
                }
                else if (tbx_firstName.Text.Trim().Length < 3)
                {

                    lbl_warnfirstname.Visible = true;
                    return;
                }
                else if (tbx_lastName.Text.Trim().Length < 3)
                {
                    lbl_warnLastname.Visible = true;
                    return;
                }
                else if (cmb_Destination.Text.Trim().Length < 3)
                {
                    lbl_warndestination.Visible = true;
                    return;
                }
                else if (System.Convert.ToDateTime(dtp_Date.Value.ToShortDateString().Trim()) == null)
                {
                    lbl_warndeparturedate.Visible = true;
                    return;
                }
                else if (System.Convert.ToDateTime(dtp_Time.Value.ToShortTimeString().Trim()) == null)
                {
                    lbl_warndeaparturetime.Visible = true;
                    return;
                }
                else if (btn_next.Text == "Next")
                {
                    DB_Reservation reservation = new DB_Reservation(System.Convert.ToDateTime(dtp_Date.Value.ToShortDateString().Trim()), System.Convert.ToDateTime(lbl_reserve_date.Text.Trim()), System.Convert.ToDateTime(dtp_Time.Value.ToShortTimeString().Trim()),
                    cmb_Destination.Text.Trim());
                    CRUD_OPERATION_FOR_RESERVATION.addReserveDestination(reservation);
                    
                    ReservationForm2 form = new ReservationForm2();
                    form.ShowDialog();
                    this.Hide();
                }
                
            }
            catch(MySqlException err)
            {
                MessageBox.Show(err.Message);
            }
           
        }
        private void fillcombobox()
        {
            try
            {
                

                string querry = "SELECT CONCAT(Destination_From, ' -' , Destination_To) AS destination FROM fare_metrix";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(querry, con);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    string destination = reader.GetString("destination");
                    cmb_Destination.Items.Add(destination);

                }

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
        private void cmb_Destination_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_reserve_date.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void ReservationForm1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_warndeaparturetime.Visible = false;
            lbl_warndeparturedate.Visible = false;
            lbl_warndestination.Visible = false;
            lbl_warnfirstname.Visible = false;
            lbl_warnLastname.Visible = false;
        }
    }
}
