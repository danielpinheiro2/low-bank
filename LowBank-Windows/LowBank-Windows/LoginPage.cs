using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowBank_Windows
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void customButton1_Click(object sender, EventArgs e)
        {
            // ir para o home page

            Form1 homepage = new Form1();
            homepage.Show();
            this.Hide();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
