using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GherasEO.GUI
{
    public partial class JobSeekerForm : Form
    {
        public string currentUser { get; set; }

        public JobSeekerForm()
        {
            InitializeComponent();
        }

        public JobSeekerForm(string currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.currentUserLabel.Text = this.currentUser;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            if (page1.Visible)
            {
                currentPageGroupBox.Text = "الصفحة الثانية (2 من 3)";
                page1.Hide();
                page2.Show();
                
                //page1.Visible = false;
                //page2.Visible = true;
               // page2.Dock = DockStyle.Fill;
                previousButton.Enabled = true;
            }
            else if (page2.Visible)
            {
                currentPageGroupBox.Text = "الصفحة الثالثة (3 من 3)";
                page2.Hide();
                page3.Show();

                //page2.Visible = false;
                //page3.Visible = true;
                //page3.Dock = DockStyle.Fill;
                nextButton.Enabled = false;
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (page3.Visible)
            {
                currentPageGroupBox.Text = "الصفحة الثانية (2 من 3)";
                page3.Visible = false;
                page2.Visible = true;
                //page2.Dock = DockStyle.Fill;
                nextButton.Enabled = true;
            }
            else if (page2.Visible)
            {
                currentPageGroupBox.Text = "الصفحة الأولى (1 من 3)";
                page2.Visible = false;
                page1.Visible = true;
                //page1.Dock = DockStyle.Fill;
                previousButton.Enabled = false;
            }
        }

       

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
