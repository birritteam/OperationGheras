using GherasEO.GUI;
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
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        public string currentUser { get; set; }

        private void MainUI_Load(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.isVerfiedUser = false;
            frm.ShowDialog();
            currentUser = frm.userName;
            currentUserLabel.Text = currentUser;

            if (!frm.isVerfiedUser)
            {
                this.Close();
                //Application.Exit();
                return;
            }
        }

        private void jobSeekerButton_Click(object sender, EventArgs e)
        {

            JobSeekerForm f2 = new JobSeekerForm(currentUser);
            f2.ShowDialog();
        }
    }
}
