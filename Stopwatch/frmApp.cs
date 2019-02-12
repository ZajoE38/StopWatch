using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class frmApp : Form
    {   
        public frmApp()
        {
            InitializeComponent();
            ResetStopwatch();
            ResetTimer();
        }

        //================================STOPWATCH====================================//

        int hours, minutes, seconds, miliseconds;
        int laps;
        bool isActive;        
        
        private void btnStopwatch_Click(object sender, EventArgs e)
        {
            panelStopwatch.Visible = true;
            panelTimer.Visible = false;
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            panelStopwatch.Visible = false;
            panelTimer.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                miliseconds++;
                //can be nested
                if (miliseconds >= 60)
                {
                    seconds++;
                    miliseconds = 0;
                }
                if (seconds >= 60)
                {
                    minutes++;
                    seconds = 0;
                }
                if (minutes >= 60)
                {
                    hours++;
                    minutes = 0;
                }
            }           
            PrintStopwatch();      
        }      

        private void PrintStopwatch()
        {
            lblHours.Text = String.Format("{0:00}", hours);
            lblMinutes.Text = String.Format("{0:00}", minutes);
            lblSeconds.Text = String.Format("{0:00}", seconds);
            lblMiliseconds.Text = String.Format("{0:00}", miliseconds);
        }        

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnReset.Visible = false;
            btnPause.Visible = true;
            btnLap.Visible = true;            

            timer1.Start();
            isActive = true;
        }
                
        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            isActive = false;

            btnStart.Visible = true;
            btnReset.Visible = true;
            btnPause.Visible = false;            
            btnLap.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            isActive = false;
            btnReset.Visible = false;
            ResetStopwatch();
            PrintStopwatch();
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            laps++;
            string hours = String.Format("{0:00}", this.hours);
            string minutes = String.Format("{0:00}", this.minutes);
            string seconds = String.Format("{0:00}", this.seconds);
            string milisecs = String.Format("{0:00}", this.miliseconds);
            string lap = laps.ToString() + "   " +
                hours + ":" + minutes + ":" + seconds + ":" + milisecs;
            lstLaps.Items.Add(lap);
        }

        public void ResetStopwatch()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
            miliseconds = 0;
            laps = 0;
            lstLaps.Items.Clear();
        }

        //================================TIMER====================================//       

        int timerHours, timerMinutes, timerSeconds;
        int tempHours, tempMinutes, tempSeconds;
        bool isTimerActive = false;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isTimerActive)
            {
                if (IsTimerZero())
                {                    
                    timer2.Stop();                    
                    isTimerActive = false;                    
                    btnStart.Visible = true;
                    btnPause.Visible = false;
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Time's up");                    
                    //TODO: pause have to be pressed to change to start button
                }
                else
                {
                    timerSeconds--;
                    if (timerSeconds == 0 && timerMinutes > 0)
                    {
                        timerMinutes--;
                        timerSeconds = 59;
                        //can be non-nested
                        if (timerMinutes == 0 && timerHours > 0)
                        {
                            timerHours--;
                            timerMinutes = 59;
                        }
                    }                    
                }
            }            
            PrintTimer();
        }

        private bool IsTimerZero()
        {
            return (timerHours == 0 && timerMinutes == 0 && timerSeconds == 0);
        }
                
        private void btnTimerStart_Click(object sender, EventArgs e)
        {
            if (IsTimerZero() == false)
            {
                timer2.Start();
                btnTimerReset.Enabled = true;
                btnTimerPause.Visible = true;
                btnTimerStart.Visible = false;
                isTimerActive = true;
            }
        }
        
        private void btnTimerPause_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            isTimerActive = false;

            btnTimerPause.Visible = false;
            btnTimerStart.Visible = true;
        }

        private void btnTimerReset_Click(object sender, EventArgs e)
        {
            ResetTimer();
            PrintTimer();

            if (isTimerActive == false)
            {
                btnTimerReset.Enabled = false;
                btnStart.Visible = true;
                btnPause.Visible = false;
            }
        }

        private void panelSetTime_MouseHover(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.Gray;
        }

        private void panelSetTime_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = SystemColors.Control;
        }

        private void panelSetTime_Click(object sender, EventArgs e)
        {
            Form setTime = new frmSetTime();
            DialogResult button = setTime.ShowDialog();
            if (button == DialogResult.OK)
            {
                string text = (string)setTime.Tag;
                string[] values = new string[3];
                values = text.Split(' ');
                timerHours = tempHours = Int32.Parse(values[0]);
                timerMinutes = tempMinutes = Int32.Parse(values[1]);
                timerSeconds = tempSeconds = Int32.Parse(values[2]);
                PrintTimer();
            }
        }

        private void PrintTimer()
        {
            lblTimerHours.Text = String.Format("{0:00}", this.timerHours);
            lblTimerMinutes.Text = String.Format("{0:00}", this.timerMinutes);
            lblTimerSeconds.Text = String.Format("{0:00}", this.timerSeconds);
        }

        private void ResetTimer()
        {
            timerHours = tempHours;
            timerMinutes = tempMinutes;
            timerSeconds = tempSeconds;
        }
    }
}
