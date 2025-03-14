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
    public partial class LoginPageFixed : Form
    {
        bool checker = false;

        public LoginPageFixed()
        {

            InitializeComponent();
        }

        private void LoginPageFixed_Load(object sender, EventArgs e)
        {

        }

        private void LLogin_Click(object sender, EventArgs e)
        {

        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void LPassword_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BEye_Click(object sender, EventArgs e)
        {

            if (!checker && !string.IsNullOrWhiteSpace(TBPassword.Text))
            {
                TBPassword.UseSystemPasswordChar = false;
                checker = true;
                BEye.BackgroundImage = Properties.Resources.eyeOpen;
            }
            else
            {
                if (checker)
                {
                    TBPassword.UseSystemPasswordChar = true;
                    checker = false;
                    BEye.BackgroundImage = Properties.Resources.eyeClose;
                }
            }
        }

        private void TBPassword_Click(object sender, EventArgs e)
        {

        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpPage signUpPage = new SignUpPage();   
            signUpPage.Show();
            this.Visible = false;



        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {


        }

        private void siticoneCloseButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void siticoneButton2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            MenuPatient menuPatient = new MenuPatient();
            menuPatient.Show();

        }

        private void siticoneCloseButton1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();

        }
    }
}
