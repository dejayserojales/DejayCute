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
    public partial class ReservationForm2 : Form
    {
        public ReservationForm2()
        {
            InitializeComponent();
        }

        private void btn_compute_Click(object sender, EventArgs e)
        {
            try
            {
                if(btn_compute.Text == "Compute")
                {
                    ReservationForm3 form = new ReservationForm3();
                    form.ShowDialog();

                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ReservationForm2_Load(object sender, EventArgs e)
        {
            try
            {
                ReservationForm1 form = new ReservationForm1();

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

    }
}
