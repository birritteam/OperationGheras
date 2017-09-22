using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GherasEO
{
    public partial class LoginForm : Form
    {
        public bool isVerfiedUser { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            userName = userNameTextBox.Text;
            password = passwordTextBox.Text;

            if (userName.Equals("Nawzat") && password.Equals("123")) { isVerfiedUser = true; }
            
            if (isVerfiedUser)
            {
                this.Hide();
            }
        }
    }
}
