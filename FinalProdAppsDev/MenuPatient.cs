using SiticoneNetCoreUI;
using System;
using System.Collections;
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
    public partial class MenuPatient : Form
    {

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private bool allFilled;
        string FirstName;
        string LastName;
        string MiddleName;
        Label LLastName;

        public MenuPatient()
        {
            InitializeComponent();

            panel2.MouseDown += Panel_MouseDown;
            panel2.MouseMove += Panel_MouseMove;
            panel2.MouseUp += Panel_MouseUp;



        }
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newPosition = new Point(
                    dragFormPoint.X + (Cursor.Position.X - dragCursorPoint.X),
                    dragFormPoint.Y + (Cursor.Position.Y - dragCursorPoint.Y)
                );
                this.Location = newPosition;
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void SetButtonStyles(SiticoneNetCoreUI.SiticoneButton activeButton, params SiticoneNetCoreUI.SiticoneButton[] otherButtons)
        {

            activeButton.ButtonBackColor = Color.White;
            activeButton.Font = new Font(activeButton.Font, FontStyle.Bold);
            activeButton.Size = new Size(170, 45);


            foreach (var btn in otherButtons)
            {
                btn.Font = new Font(activeButton.Font, FontStyle.Regular);
                btn.ButtonBackColor = Color.FromArgb(128, 255, 255, 255);
                btn.Size = new Size(156, 39);
                btn.BorderColor = Color.White;
            }
        }

        private void PatientRecords_MouseClick(object sender, MouseEventArgs e)
        {

            MainPatientRecordPanel.Visible = true;
            SetButtonStyles(PatientRecords, BAppointments, BScanQr, BBilling);
        }

        private void BAppointments_MouseClick(object sender, MouseEventArgs e)
        {
            MainPatientRecordPanel.Visible = false;
            SetButtonStyles(BAppointments, PatientRecords, BScanQr, BBilling);
        }

        private void BScanQr_MouseClick(object sender, MouseEventArgs e)
        {
            MainPatientRecordPanel.Visible = false;
            SetButtonStyles(BScanQr, BAppointments, PatientRecords, BBilling);
        }

        private void BBilling_MouseClick(object sender, MouseEventArgs e)
        {
            MainPatientRecordPanel.Visible = false;
            SetButtonStyles(BBilling, PatientRecords, BAppointments, BScanQr);
        }

        private void TBSearchBar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void BLogout_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void AddPatientB_Click(object sender, EventArgs e)
        {

        }

        private void AddPatientB_MouseClick(object sender, MouseEventArgs e)
        {
            EnabledButtons(false, false);
            foreach (Control ctrl in PDetailsPatient.Controls)
            {
                if (ctrl is SiticoneNetCoreUI.SiticoneTextBox textBox)
                {
                    textBox.Text = "";
                }

            }
        }

        private void BSaveDetails_MouseClick(object sender, MouseEventArgs e)
        {
            PDetailsPatient.Visible = false;
            Header.Visible = true;
            FlowPanel.Visible = true;
        }

        private void PDetailsPatient_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BSaveDetails_MouseClick_1(object sender, MouseEventArgs e)
        {

            foreach (Control ctrl in PDetailsPatient.Controls)
            {
                if (ctrl is SiticoneTextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        allFilled = false;
                        break;
                    }
                    else
                    {
                        allFilled = true;
                        break;
                    }
                }
            }

            if (allFilled)
            {
                int panelWidth = FlowPanel.Width - FlowPanel.Padding.Left - FlowPanel.Padding.Right;
                FirstName = TBFn.Text;
                LastName = TBLn.Text;
                MiddleName = TBMn.Text;

                Panel panel = new Panel()
                {
                    Size = new Size(panelWidth - 30, 90),
                    Location = new Point(10, 30),
                    BackColor = Color.FromArgb(210, 225, 237),
                    BorderStyle = BorderStyle.None,
                    Margin = new Padding(10, 8, 1, 4),

                };

                Label Idno = new Label
                {

                    Text = $"{panelList.Count + 1}",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    Location = new Point(25, 35)
                };

                Label LFirstName = new Label
                {

                    Text = $"{FirstName}",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    Location = new Point(275, 35)


                };

                LLastName = new Label
                {

                    Text = $"{LastName}",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    Location = new Point(125, 35)


                };

                Label LMiddleName = new Label
                {

                    Text = $"{MiddleName}",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    Location = new Point(432, 35)


                };


                Button UpdateButton = new Button
                {
                    BackColor = Color.FromArgb(9, 195, 51),
                    Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location = new Point(675, 28),
                    Name = "update",
                    Size = new Size(73, 33),
                    TabIndex = 7,
                    Text = "Update",
                    UseVisualStyleBackColor = false

                };

                Button viewButton = new Button
                {
                    BackColor = Color.FromArgb(58, 94, 116),
                    Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location = new Point(600, 28),
                    Name = "View",
                    Size = new Size(73, 33),
                    TabIndex = 7,
                    Text = "View",
                    UseVisualStyleBackColor = false

                };

                viewButton.Click += (s, args) => ViewDetails(FirstName, LastName, MiddleName);
                UpdateButton.Click += (s, args) => UpdateDetails(FirstName, LastName, MiddleName);

                panel.Controls.Add(LMiddleName);
                panel.Controls.Add(LLastName);
                panel.Controls.Add(LFirstName);
                panel.Controls.Add(Idno);
                panel.Controls.Add(viewButton);
                panel.Controls.Add(UpdateButton);

                panelList.Add(panel);
                FlowPanel.Controls.Add(panel);
                EnabledButtons(true, false);
            }
            else
            {
                MessageBox.Show("Please fill in all fields before proceeding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BCancel_MouseClick(object sender, MouseEventArgs e)
        {
            EnabledButtons(true, false);
        }




        private void EnabledButtons(bool isDetailsOpen, bool isViewDetailsPatient)
        {
            if (isViewDetailsPatient)
            {
                if (isDetailsOpen)
                {
                    FlowPanel.Visible = false;
                    Header.Visible = false;
                    TBSearchBar.Enabled = false;
                    AddPatientB.Enabled = false;


                }
                else
                {
                    FlowPanel.Visible = true;
                    Header.Visible = true;
                    TBSearchBar.Enabled = true;
                    AddPatientB.Enabled = true;

                }



            }
            else
            {
                if (isDetailsOpen)
                {
                    PDetailsPatient.Visible = false;
                    FlowPanel.Visible = true;
                    Header.Visible = true;
                    TBSearchBar.Enabled = true;
                    AddPatientB.Enabled = true;
                    AddPatientB.Enabled = true;
                }
                else
                {
                    TBSearchBar.Text = "";
                    FlowPanel.Visible = false;
                    Header.Visible = false;
                    TBSearchBar.Enabled = false;
                    AddPatientB.Enabled = false;
                    PDetailsPatient.Visible = true;
                }
            }



        }

        private void ViewDetails(string firstName, string lastName, string middleName)
        {
            DFirstname.Text = firstName;
            DLastname.Text = lastName;
            DMiddleName.Text = middleName;

            EnabledButtons(true, true);
            ViewPanel.Visible = true;
        }

        private void UpdateDetails(string firstName, string lastName, string middleName)
        {
            ULFirstname.Text = firstName;
            ULLastname.Text = lastName;
            ULMiddlename.Text = middleName;

            EnabledButtons(true, true);
            PUpdateDetails.Visible = true;

        }

        private void BViewMedical_MouseClick_1(object sender, MouseEventArgs e)
        {
            EnabledButtons(false, true);
            ViewPanel.Visible = false;
        }

        private void BUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            FirstName = ULFirstname.Text;
            LastName = ULLastname.Text;
            MiddleName = ULMiddlename.Text;

            EnabledButtons(false, true);
            PUpdateDetails.Visible = false;

            LLastName.Text = LastName;
        }

        private void BExit_MouseClick(object sender, MouseEventArgs e)
        {
            EnabledButtons(false, true);
            PUpdateDetails.Visible = false;
        }


        //private void TBFn_TextChanged(object sender, EventArgs e)
        //{
        //    CheckTextBoxes();
        //}

        //private void CheckTextBoxes()
        //{

        //}

    }
}
