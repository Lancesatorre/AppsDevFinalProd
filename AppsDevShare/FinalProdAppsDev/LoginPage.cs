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
    public partial class LoginPage: Form
    {
        bool checker = false;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void BExit_MouseClick(object sender, MouseEventArgs e)
        {
            //this.Visible = false;
            //Form3 form3 = new Form3();
            //form3.Show();
            Application.Exit();
        }

        private void BLogin_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void BEye_MouseClick_1(object sender, MouseEventArgs e)
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
    }
}
