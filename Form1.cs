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
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxClose.Image = Properties.Resources.close_red;
        }

        private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.Image = Properties.Resources.close_blue;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void A(object sender, EventArgs e)
        {

        }

        private void textBoxTextType_TextChanged(object sender, EventArgs e)
        {
            if (TextsAreSame())
            {
                AllowTyping();
            }
            else
            {
                //block and change color to red
                BlockTyping();
            }
        }

        private bool TextsAreSame()
        {

            int characterCount;
            characterCount = textBoxTextType.Text.Length;
            string lablSubstring = labelTextOriginal.Text.Substring(0, characterCount);
            if (textBoxTextType.Text != lablSubstring)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BlockTyping()
        {  
            textBoxTextType.MaxLength = textBoxTextType.Text.Length;
            textBoxTextType.ForeColor = Color.Red;    
        }

        private void AllowTyping()
        {
            textBoxTextType.MaxLength = labelTextOriginal.Text.Length;
            textBoxTextType.ForeColor = Color.Black;
        }
    }
}
