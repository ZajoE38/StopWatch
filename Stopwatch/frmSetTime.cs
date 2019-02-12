using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class frmSetTime : Form
    {
        public frmSetTime()
        {
            InitializeComponent();
        }

        string hours, minutes, seconds;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SaveData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveData()
        {
            string msg = null;
            this.hours = txtHours.Text;
            this.minutes = txtMinutes.Text;
            this.seconds = txtSeconds.Text;
            
            msg += hours + " " + minutes + " " + seconds;
            this.Tag = msg;
            this.DialogResult = DialogResult.OK;            
        }

        private bool IsValid()
        {
            return Validator.IsPresent(txtHours, "Hours") &&
                   Validator.IsNumber(txtHours, "Hours") &&
                   Validator.IsTime(txtHours, "Hours") &&
                   Validator.IsPresent(txtMinutes, "Minutes") &&
                   Validator.IsNumber(txtMinutes, "Minutes") &&
                   Validator.IsTime(txtMinutes, "Minutes") &&
                   Validator.IsPresent(txtSeconds, "Seconds") &&
                   Validator.IsNumber(txtSeconds, "Seconds") &&
                   Validator.IsTime(txtSeconds, "Seconds");
        }
    }
}
