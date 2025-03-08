using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Properties;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        bool checker = false;
        public Form2()
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
                BEye.BackgroundImage = Image.FromFile(@"C:\Users\Admin\OneDrive\Desktop\Hospital-AppsDevFinal\AppsDevShare\WinFormsApp1\Images\eyeOpen.png");
            }
            else
            {
                if (checker)
                {
                    TBPassword.UseSystemPasswordChar = true;
                    checker = false;
                    BEye.BackgroundImage = Image.FromFile(@"C:\Users\Admin\OneDrive\Desktop\Hospital-AppsDevFinal\AppsDevShare\WinFormsApp1\Images\eyeClose.png");
                }
            }
            
        }
    }
}
