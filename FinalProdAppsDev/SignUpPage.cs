using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProdAppsDev
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BExit_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        /*
               private void timer1_Tick(object sender, EventArgs e)
               {
               siticoneProgressBar1.Value = 50;

               if (siticoneProgressBar1.Value < 100)
                   {
                       siticoneProgressBar1.Value += 5; // Increments by 5
                   }
                   else
                   {
                       timer1.Stop(); // Stops when reaching 100%
                   }
               }
   */


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneLabel4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLinkedLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //            Application.Run(new SignUpPage());

            LoginPageFixed loginPage = new LoginPageFixed();
            loginPage.Show();
            this.Visible = false;



        }

        private void siticonePanel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            LoginPageFixed loginPage = new LoginPageFixed();
            loginPage.Show();
            this.Visible = false;

        }

        private void siticoneCloseButton1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void registerButton1_MouseClick(object sender, MouseEventArgs e)
        {
            signUpPanel1.Visible = false;
            signUpPanel2.Visible = true;
        }
        private void SignUpLineProgress(object sender, EventArgs e)
        {
            siticonehLineProgress1.Value = 0;
            timer1.Interval = 100; // Adjust speed (100ms)
            timer1.Start();
        }
        private void siticonehLineProgress1_Click(object sender, EventArgs e)
        {
            siticonehLineProgress1.Value = 50;
            if (siticonehLineProgress1.Value < 100)
            {
                siticonehLineProgress1.Value += 5;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void siticoneDateTimePicker1_Click(object sender, EventArgs e)
        {

        }
    }
}
