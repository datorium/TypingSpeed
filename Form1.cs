using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingSpeed
{
    public partial class Form1 : Form
    {
        int sec = 0;
        bool typingStarted = false;

        public Form1()
        {
            InitializeComponent();
            InitializeProgressBars();
            InitializeTypingTimer();
        }

        private void InitializeTypingTimer()
        {
            TypingTimer.Interval = 1000;            
        }


        private void InitializeProgressBars()
        {
            TypingProgress.Maximum = SourceText.Text.Length;
            TimeProgress.Maximum = 60;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.Image = Properties.Resources.close_red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.Image = Properties.Resources.close_blue;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TargetText_TextChanged(object sender, EventArgs e)
        {
            if(!typingStarted)
            {
                TypingTimer.Start();
                typingStarted = true;
            }
            
            if (TextsAreIdentical())
            {
                AllowTyping();
                TypingProgress.Value = TargetText.Text.Length;
                if(TargetText.Text.Length == SourceText.Text.Length)
                {
                    TypingOver();
                }
            }
            else
            {
                BlockTyping();
            }
            UpdateCurrentCPM();
        }

        private void UpdateCurrentCPM()
        {
            CurrentCPM.Text = "Current CPM: " + CalculateCPM();
        }

        private bool TextsAreIdentical()
        {
            int charCount = TargetText.Text.Length;
            string sourceSubstring = SourceText.Text.Substring(0, charCount);
            if(TargetText.Text == sourceSubstring)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AllowTyping()
        {
            TargetText.MaxLength = SourceText.Text.Length;
            TargetText.ForeColor = Color.Black;
        }

        private void BlockTyping()
        {
            TargetText.MaxLength = TargetText.Text.Length;
            TargetText.ForeColor = Color.Red;
        }

        private void TypingTimer_Tick(object sender, EventArgs e)
        {
            sec += 1;
            if (sec > 60)
            {
                TypingOver();
            }

            try
            {
                TimeProgress.Value = sec;
            }
            catch
            {

            }
            
        }

        private int CalculateCPM()
        {
            int cpm;
            try
            {
                cpm = TargetText.Text.Length * 60 / sec;
                return cpm;
            }
            catch
            {
                return 0;
            }            
        }

        private void TypingOver()
        {
            TypingTimer.Stop();
            TargetText.Enabled = false;
            MessageBox.Show("Time is up! Your result is " + CalculateCPM());
        }
    }
}
