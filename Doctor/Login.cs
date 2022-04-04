using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                if(textBox1.Text=="DemoDoctor" && textBox2.Text=="DemoPassword")
                {
                    
                    Doc_Login doc = new Doc_Login();
                    doc.Show();
                    //this.Close();
                    

                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
