using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            Hide();
        }
        private void btn_authorization_Click(object sender, EventArgs e)
        {
            Authorization authoriz = new Authorization();
            authoriz.Show();
            Hide();
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
