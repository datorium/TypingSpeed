﻿namespace TypingSpeed
{
    partial class Form1
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
            this.labelTextOriginal = new System.Windows.Forms.Label();
            this.textBoxTextType = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTextOriginal
            // 
            this.labelTextOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextOriginal.Location = new System.Drawing.Point(26, 26);
            this.labelTextOriginal.Name = "labelTextOriginal";
            this.labelTextOriginal.Size = new System.Drawing.Size(748, 104);
            this.labelTextOriginal.TabIndex = 0;
            this.labelTextOriginal.Text = "A contango market implies oil traders believe crude prices will rally in the futu" +
    "re, encouraging them to store oil now and to sell at a later date.";
            // 
            // textBoxTextType
            // 
            this.textBoxTextType.Location = new System.Drawing.Point(31, 159);
            this.textBoxTextType.Multiline = true;
            this.textBoxTextType.Name = "textBoxTextType";
            this.textBoxTextType.Size = new System.Drawing.Size(719, 167);
            this.textBoxTextType.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(586, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxTextType);
            this.Controls.Add(this.labelTextOriginal);
            this.Name = "Form1";
            this.Text = "Datorium Typing Speed App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextOriginal;
        private System.Windows.Forms.TextBox textBoxTextType;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

