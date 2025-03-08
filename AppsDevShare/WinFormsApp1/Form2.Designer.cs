namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            LoginPanel = new Panel();
            BEye = new Button();
            BLogin = new Button();
            linkSignUp = new LinkLabel();
            label2 = new Label();
            LPassword = new Label();
            TBPassword = new TextBox();
            label1 = new Label();
            TBUsername = new TextBox();
            LLogin = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            Company = new Label();
            BExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            LoginPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LoginPanel);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1061, 754);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Script MT Bold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(4, 30, 70);
            label4.Location = new Point(581, 572);
            label4.Name = "label4";
            label4.Size = new Size(432, 48);
            label4.TabIndex = 15;
            label4.Text = "Your health, our priority!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(4, 30, 70);
            label5.ImageAlign = ContentAlignment.BottomRight;
            label5.Location = new Point(569, 267);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 14;
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(4, 30, 70);
            label3.Location = new Point(569, 182);
            label3.Name = "label3";
            label3.Size = new Size(466, 41);
            label3.TabIndex = 12;
            label3.Text = "Welcome to MediTrack!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(735, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.FromArgb(201, 58, 94, 116);
            LoginPanel.BorderStyle = BorderStyle.FixedSingle;
            LoginPanel.Controls.Add(BEye);
            LoginPanel.Controls.Add(BLogin);
            LoginPanel.Controls.Add(linkSignUp);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(LPassword);
            LoginPanel.Controls.Add(TBPassword);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(TBUsername);
            LoginPanel.Controls.Add(LLogin);
            LoginPanel.Location = new Point(107, 138);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(418, 505);
            LoginPanel.TabIndex = 4;
            // 
            // BEye
            // 
            BEye.BackColor = Color.White;
            BEye.BackgroundImage = (Image)resources.GetObject("BEye.BackgroundImage");
            BEye.BackgroundImageLayout = ImageLayout.Stretch;
            BEye.FlatAppearance.BorderSize = 0;
            BEye.FlatStyle = FlatStyle.Flat;
            BEye.Location = new Point(364, 273);
            BEye.Name = "BEye";
            BEye.Size = new Size(23, 19);
            BEye.TabIndex = 14;
            BEye.UseVisualStyleBackColor = false;
            BEye.MouseClick += BEye_MouseClick_1;
            // 
            // BLogin
            // 
            BLogin.BackColor = Color.FromArgb(217, 217, 217);
            BLogin.Font = new Font("Verdana", 17F, FontStyle.Bold);
            BLogin.ForeColor = Color.FromArgb(58, 94, 116);
            BLogin.Location = new Point(112, 353);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(177, 60);
            BLogin.TabIndex = 12;
            BLogin.Text = "Login";
            BLogin.UseVisualStyleBackColor = false;
            BLogin.MouseClick += BLogin_MouseClick;
            // 
            // linkSignUp
            // 
            linkSignUp.ActiveLinkColor = Color.Teal;
            linkSignUp.AutoSize = true;
            linkSignUp.BackColor = Color.Transparent;
            linkSignUp.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            linkSignUp.LinkColor = Color.White;
            linkSignUp.Location = new Point(221, 460);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(68, 21);
            linkSignUp.TabIndex = 11;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Sign up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(117, 460);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 10;
            label2.Text = "No Account?";
            // 
            // LPassword
            // 
            LPassword.AutoSize = true;
            LPassword.BackColor = Color.Transparent;
            LPassword.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LPassword.ForeColor = Color.White;
            LPassword.Location = new Point(24, 229);
            LPassword.Name = "LPassword";
            LPassword.Size = new Size(103, 22);
            LPassword.TabIndex = 4;
            LPassword.Text = "Password:";
            // 
            // TBPassword
            // 
            TBPassword.Cursor = Cursors.Hand;
            TBPassword.Font = new Font("Segoe UI", 19F);
            TBPassword.Location = new Point(24, 263);
            TBPassword.Name = "TBPassword";
            TBPassword.Size = new Size(372, 41);
            TBPassword.TabIndex = 3;
            TBPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 107);
            label1.Name = "label1";
            label1.Size = new Size(110, 22);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // TBUsername
            // 
            TBUsername.Cursor = Cursors.Hand;
            TBUsername.Font = new Font("Segoe UI", 19F);
            TBUsername.Location = new Point(24, 145);
            TBUsername.Multiline = true;
            TBUsername.Name = "TBUsername";
            TBUsername.Size = new Size(372, 44);
            TBUsername.TabIndex = 1;
            // 
            // LLogin
            // 
            LLogin.AutoSize = true;
            LLogin.BackColor = Color.Transparent;
            LLogin.Font = new Font("Verdana", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LLogin.ForeColor = Color.White;
            LLogin.Location = new Point(143, 27);
            LLogin.Name = "LLogin";
            LLogin.Size = new Size(123, 41);
            LLogin.TabIndex = 0;
            LLogin.Text = "Login";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(58, 94, 113);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(Company);
            panel3.Controls.Add(BExit);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1061, 35);
            panel3.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(3, -2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // Company
            // 
            Company.AutoSize = true;
            Company.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Company.ForeColor = SystemColors.ButtonHighlight;
            Company.Location = new Point(51, 6);
            Company.Name = "Company";
            Company.Size = new Size(82, 20);
            Company.TabIndex = 9;
            Company.Text = "MediTrack";
            // 
            // BExit
            // 
            BExit.BackgroundImage = (Image)resources.GetObject("BExit.BackgroundImage");
            BExit.BackgroundImageLayout = ImageLayout.Zoom;
            BExit.FlatAppearance.BorderSize = 0;
            BExit.FlatStyle = FlatStyle.Flat;
            BExit.Location = new Point(1027, 3);
            BExit.Name = "BExit";
            BExit.Size = new Size(20, 25);
            BExit.TabIndex = 0;
            BExit.UseVisualStyleBackColor = false;
            BExit.MouseClick += BExit_MouseClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 754);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label Company;
        private Button BExit;
        private Panel LoginPanel;
        private Label LLogin;
        private TextBox TBUsername;
        private Label label1;
        private Label LPassword;
        private LinkLabel linkSignUp;
        private Label label2;
        private Button BLogin;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BEye;
        private TextBox TBPassword;
    }
}