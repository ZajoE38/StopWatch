namespace Stopwatch
{
    partial class frmApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnStopwatch = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.panelStopwatch = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMiliseconds = new System.Windows.Forms.Label();
            this.btnLap = new System.Windows.Forms.Button();
            this.lstLaps = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.panelSetTime = new System.Windows.Forms.Panel();
            this.lblTimerSeconds = new System.Windows.Forms.Label();
            this.lblTimerMinutes = new System.Windows.Forms.Label();
            this.lblTimerHours = new System.Windows.Forms.Label();
            this.btnTimerPause = new System.Windows.Forms.Button();
            this.btnTimerReset = new System.Windows.Forms.Button();
            this.btnTimerStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelStopwatch.SuspendLayout();
            this.panelTimer.SuspendLayout();
            this.panelSetTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnStopwatch);
            this.panelMenu.Controls.Add(this.btnTimer);
            this.panelMenu.Location = new System.Drawing.Point(12, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(558, 105);
            this.panelMenu.TabIndex = 0;
            // 
            // btnStopwatch
            // 
            this.btnStopwatch.Location = new System.Drawing.Point(318, 25);
            this.btnStopwatch.Name = "btnStopwatch";
            this.btnStopwatch.Size = new System.Drawing.Size(164, 57);
            this.btnStopwatch.TabIndex = 1;
            this.btnStopwatch.Text = "Stopwatch";
            this.btnStopwatch.UseVisualStyleBackColor = true;
            this.btnStopwatch.Click += new System.EventHandler(this.btnStopwatch_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(82, 25);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(164, 57);
            this.btnTimer.TabIndex = 0;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // panelStopwatch
            // 
            this.panelStopwatch.Controls.Add(this.label3);
            this.panelStopwatch.Controls.Add(this.lblHours);
            this.panelStopwatch.Controls.Add(this.lblSeconds);
            this.panelStopwatch.Controls.Add(this.lblMinutes);
            this.panelStopwatch.Controls.Add(this.label2);
            this.panelStopwatch.Controls.Add(this.label1);
            this.panelStopwatch.Controls.Add(this.lblMiliseconds);
            this.panelStopwatch.Controls.Add(this.btnLap);
            this.panelStopwatch.Controls.Add(this.lstLaps);
            this.panelStopwatch.Controls.Add(this.btnReset);
            this.panelStopwatch.Controls.Add(this.btnPause);
            this.panelStopwatch.Controls.Add(this.btnStart);
            this.panelStopwatch.Location = new System.Drawing.Point(12, 125);
            this.panelStopwatch.Name = "panelStopwatch";
            this.panelStopwatch.Size = new System.Drawing.Size(560, 480);
            this.panelStopwatch.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 71);
            this.label3.TabIndex = 11;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHours
            // 
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(110, 32);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(75, 71);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "00";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeconds
            // 
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(268, 32);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(75, 71);
            this.lblSeconds.TabIndex = 7;
            this.lblSeconds.Text = "00";
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutes
            // 
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(189, 32);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(75, 71);
            this.lblMinutes.TabIndex = 6;
            this.lblMinutes.Text = "00";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 71);
            this.label2.TabIndex = 10;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 71);
            this.label1.TabIndex = 9;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMiliseconds
            // 
            this.lblMiliseconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiliseconds.Location = new System.Drawing.Point(344, 37);
            this.lblMiliseconds.Name = "lblMiliseconds";
            this.lblMiliseconds.Size = new System.Drawing.Size(75, 71);
            this.lblMiliseconds.TabIndex = 8;
            this.lblMiliseconds.Text = "00";
            this.lblMiliseconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLap
            // 
            this.btnLap.Location = new System.Drawing.Point(27, 123);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(164, 57);
            this.btnLap.TabIndex = 5;
            this.btnLap.Text = "Lap";
            this.btnLap.UseVisualStyleBackColor = true;
            this.btnLap.Visible = false;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // lstLaps
            // 
            this.lstLaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLaps.FormattingEnabled = true;
            this.lstLaps.ItemHeight = 29;
            this.lstLaps.Location = new System.Drawing.Point(27, 226);
            this.lstLaps.Name = "lstLaps";
            this.lstLaps.Size = new System.Drawing.Size(504, 207);
            this.lstLaps.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(369, 123);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(164, 57);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(200, 123);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(164, 57);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(198, 123);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(164, 57);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panelTimer
            // 
            this.panelTimer.Controls.Add(this.panelSetTime);
            this.panelTimer.Location = new System.Drawing.Point(12, 129);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(560, 485);
            this.panelTimer.TabIndex = 12;
            // 
            // panelSetTime
            // 
            this.panelSetTime.Controls.Add(this.lblTimerSeconds);
            this.panelSetTime.Controls.Add(this.lblTimerMinutes);
            this.panelSetTime.Controls.Add(this.lblTimerHours);
            this.panelSetTime.Controls.Add(this.btnTimerPause);
            this.panelSetTime.Controls.Add(this.btnTimerReset);
            this.panelSetTime.Controls.Add(this.btnTimerStart);
            this.panelSetTime.Controls.Add(this.label5);
            this.panelSetTime.Controls.Add(this.label4);
            this.panelSetTime.Location = new System.Drawing.Point(84, 32);
            this.panelSetTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSetTime.Name = "panelSetTime";
            this.panelSetTime.Size = new System.Drawing.Size(399, 205);
            this.panelSetTime.TabIndex = 7;
            this.panelSetTime.Click += new System.EventHandler(this.panelSetTime_Click);
            this.panelSetTime.MouseLeave += new System.EventHandler(this.panelSetTime_MouseLeave);
            this.panelSetTime.MouseHover += new System.EventHandler(this.panelSetTime_MouseHover);
            // 
            // lblTimerSeconds
            // 
            this.lblTimerSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerSeconds.Location = new System.Drawing.Point(248, 22);
            this.lblTimerSeconds.Name = "lblTimerSeconds";
            this.lblTimerSeconds.Size = new System.Drawing.Size(75, 71);
            this.lblTimerSeconds.TabIndex = 3;
            this.lblTimerSeconds.Text = "00";
            this.lblTimerSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimerMinutes
            // 
            this.lblTimerMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerMinutes.Location = new System.Drawing.Point(168, 22);
            this.lblTimerMinutes.Name = "lblTimerMinutes";
            this.lblTimerMinutes.Size = new System.Drawing.Size(75, 71);
            this.lblTimerMinutes.TabIndex = 2;
            this.lblTimerMinutes.Text = "00";
            this.lblTimerMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimerHours
            // 
            this.lblTimerHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerHours.Location = new System.Drawing.Point(88, 22);
            this.lblTimerHours.Name = "lblTimerHours";
            this.lblTimerHours.Size = new System.Drawing.Size(75, 71);
            this.lblTimerHours.TabIndex = 1;
            this.lblTimerHours.Text = "00";
            this.lblTimerHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTimerPause
            // 
            this.btnTimerPause.Location = new System.Drawing.Point(219, 111);
            this.btnTimerPause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimerPause.Name = "btnTimerPause";
            this.btnTimerPause.Size = new System.Drawing.Size(164, 57);
            this.btnTimerPause.TabIndex = 7;
            this.btnTimerPause.Text = "Pause";
            this.btnTimerPause.UseVisualStyleBackColor = true;
            this.btnTimerPause.Visible = false;
            this.btnTimerPause.Click += new System.EventHandler(this.btnTimerPause_Click);
            // 
            // btnTimerReset
            // 
            this.btnTimerReset.Enabled = false;
            this.btnTimerReset.Location = new System.Drawing.Point(34, 111);
            this.btnTimerReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimerReset.Name = "btnTimerReset";
            this.btnTimerReset.Size = new System.Drawing.Size(164, 57);
            this.btnTimerReset.TabIndex = 6;
            this.btnTimerReset.Text = "Reset";
            this.btnTimerReset.UseVisualStyleBackColor = true;
            this.btnTimerReset.Click += new System.EventHandler(this.btnTimerReset_Click);
            // 
            // btnTimerStart
            // 
            this.btnTimerStart.Location = new System.Drawing.Point(219, 111);
            this.btnTimerStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimerStart.Name = "btnTimerStart";
            this.btnTimerStart.Size = new System.Drawing.Size(164, 57);
            this.btnTimerStart.TabIndex = 6;
            this.btnTimerStart.Text = "Start";
            this.btnTimerStart.UseVisualStyleBackColor = true;
            this.btnTimerStart.Click += new System.EventHandler(this.btnTimerStart_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 71);
            this.label5.TabIndex = 5;
            this.label5.Text = ":";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 71);
            this.label4.TabIndex = 4;
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 625);
            this.Controls.Add(this.panelTimer);
            this.Controls.Add(this.panelStopwatch);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmApp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatch";
            this.panelMenu.ResumeLayout(false);
            this.panelStopwatch.ResumeLayout(false);
            this.panelTimer.ResumeLayout(false);
            this.panelSetTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnStopwatch;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Panel panelStopwatch;
        private System.Windows.Forms.Button btnLap;
        private System.Windows.Forms.ListBox lstLaps;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMiliseconds;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Label lblTimerHours;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblTimerSeconds;
        private System.Windows.Forms.Label lblTimerMinutes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelSetTime;
        private System.Windows.Forms.Button btnTimerStart;
        private System.Windows.Forms.Button btnTimerReset;
        private System.Windows.Forms.Button btnTimerPause;
    }
}

