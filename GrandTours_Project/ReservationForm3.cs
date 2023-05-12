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
    public partial class ReservationForm3 : Form
    {
        public ReservationForm3()
        {
            InitializeComponent();
        }
        ReservationForm1 form1 = new ReservationForm1();
        ReservationForm2 form2 = new ReservationForm2();

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DB_Passenger passenger = new DB_Passenger(form1.tbx_firstName.Text.Trim(), form1.tbx_lastName.Text.Trim(),double.Parse(lbl_totalPrice.Text.Trim()),
                double.Parse(tbx_AmountReceived.Text.Trim()), double.Parse(tbx_Change.Text.Trim()), int.Parse(AccessibleName.Trim()));
          

            CRUD_OPERATION_FOR_RESERVATION.AddPassenger(passenger);
            
        }
    }
}
