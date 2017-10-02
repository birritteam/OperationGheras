using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GherasEO.GUI
{
    public partial class PersonalData : UserControl
    {
        public PersonalData()
        {
            InitializeComponent();
        }

        private void delayedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (delayedRadioButton.Checked == true)
            {
                delayReasonTB.Enabled = true;
                exemptionReasonTB.Enabled = false;
                exemptionReasonTB.Text = "";
                delayReasonTB.Focus();
            }
            else
                delayReasonTB.Enabled = false;
               
            
               
        }

        private void exemptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (exemptRadioButton.Checked == true)
            {
                exemptionReasonTB.Enabled = true;
                delayReasonTB.Enabled = false;
                delayReasonTB.Text = "";
                exemptionReasonTB.Focus();
            }
            else
                exemptionReasonTB.Enabled = false;
        }

        private void finishedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (finishedRadioButton.Checked == true)
            {
                exemptionReasonTB.Text = "";
                delayReasonTB.Text = "";
            }
                
                
        }
    }
}
