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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (textBox1.Text == "DemoPharmacy" && textBox2.Text == "DemoPassword")
                {
                    Phar_homePage doc = new Phar_homePage();
                    doc.Show();
                }
                else
                {
                    MessageBox.Show("INCORRECT CREDENTIALS");
                }
            }

            if (radioButton3.Checked)
            {
                if (textBox1.Text == "DemoPatient" && textBox2.Text == "DemoPassword")
                {
                    PatientHomePage doc2 = new PatientHomePage();
                    doc2.Show();
                }
                else
                {
                    MessageBox.Show("INCORRECT CREDENTIALS");
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
