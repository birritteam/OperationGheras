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
    public partial class JobSeekerFormV1 : Form
    {
        public string currentUser { get; set; }

        public JobSeekerFormV1()
        {
            InitializeComponent();
        }

        public JobSeekerFormV1(string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.currentUserLabel.Text = this.currentUser;
        }

        private void idGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void personalDataGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void addTabPage_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void JobSeekerForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
