﻿namespace FinalProdAppsDev
{
    partial class BillingsForms
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
            button1 = new Button();
            panel1 = new Panel();
            Janjan = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(436, 119);
            button1.Name = "button1";
            button1.Size = new Size(229, 103);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(39, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 295);
            panel1.TabIndex = 1;
            // 
            // Janjan
            // 
            Janjan.Location = new Point(372, 17);
            Janjan.Name = "Janjan";
            Janjan.Size = new Size(359, 395);
            Janjan.TabIndex = 2;
            Janjan.Text = "button2";
            Janjan.UseVisualStyleBackColor = true;
            // 
            // BillingsForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Janjan);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "BillingsForms";
            Text = "BillingsForms";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button Janjan;
    }
}