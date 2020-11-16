using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserAuthenticate
{
    public partial class ProfileForm3 : Form
    {
        public static string SetValueForText2 = "";
        public ProfileForm3()
        {
            InitializeComponent();
        }
        private void profileBtn_Click(object sender, EventArgs e)
        {
            SetValueForText2 = userNamelabel.Text; 
            this.Hide();
            EditForm4 editForm = new EditForm4();
            editForm.Show();
        }
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm1 loginForm = new loginForm1();
            loginForm.Show();
        }

        private void ProfileForm3_Load(object sender, EventArgs e)
        {
            userNamelabel.Text = loginForm1.SetValueForText;
        }
    }
}
