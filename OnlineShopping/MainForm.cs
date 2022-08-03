using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShopping
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();


        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            form2 r = new form2();
            r.Show();
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            Admin_form af = new Admin_form();
            af.Show();


        }
    }
}
