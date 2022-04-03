using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medcom_Clients
{
    public partial class Patient_DailyMed : Form
    {
        public Patient_DailyMed()
        {
            InitializeComponent();
        }

        private void ACTIVE_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
            label5.Text = "SKIPPED";
            

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PatientHomePage patient = new PatientHomePage();
            patient.Show();
        }
    }
}
