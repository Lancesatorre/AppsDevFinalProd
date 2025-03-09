namespace FinalProdAppsDev
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            panel3 = new Panel();
            BExit = new Button();
            Company = new Label();
            pictureBox3 = new PictureBox();
            LoginPanel = new Panel();
            LLogin = new Label();
            TBUsername = new TextBox();
            label1 = new Label();
            TBPassword = new TextBox();
            LPassword = new Label();
            label2 = new Label();
            linkSignUp = new LinkLabel();
            BLogin = new Button();
            BEye = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            Description = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // BExit
            // 
            BExit.BackgroundImage = Properties.Resources.exit;
            BExit.BackgroundImageLayout = ImageLayout.Zoom;
            BExit.FlatAppearance.BorderSize = 0;
            BExit.FlatStyle = FlatStyle.Flat;
            BExit.Location = new Point(1027, 3);
            BExit.Name = "BExit";
            BExit.Size = new Size(20, 25);
            BExit.TabIndex = 0;
            BExit.UseVisualStyleBackColor = true;
            BExit.MouseClick += BExit_MouseClick;
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
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.log;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(3, -2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
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
            // BEye
            // 
            BEye.BackColor = Color.Transparent;
            BEye.BackgroundImage = Properties.Resources.eyeClose;
            BEye.BackgroundImageLayout = ImageLayout.Stretch;
            BEye.CausesValidation = false;
            BEye.FlatAppearance.BorderSize = 0;
            BEye.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BEye.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BEye.FlatStyle = FlatStyle.Flat;
            BEye.ForeColor = Color.Transparent;
            BEye.Location = new Point(364, 272);
            BEye.Name = "BEye";
            BEye.Size = new Size(23, 19);
            BEye.TabIndex = 0;
            BEye.TabStop = false;
            BEye.UseVisualStyleBackColor = false;
            BEye.MouseClick += BEye_MouseClick_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.log;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(735, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Verdana", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(4, 30, 70);
            label6.ImageAlign = ContentAlignment.BottomRight;
            label6.Location = new Point(569, 267);
            label6.Name = "label6";
            label6.Size = new Size(0, 32);
            label6.TabIndex = 16;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Background;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(Description);
            panel1.Controls.Add(label6);
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
            // Description
            // 
            Description.AutoSize = true;
            Description.BackColor = Color.Transparent;
            Description.Font = new Font("Verdana", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Description.ForeColor = Color.FromArgb(4, 30, 70);
            Description.ImageAlign = ContentAlignment.BottomRight;
            Description.Location = new Point(575, 257);
            Description.Name = "Description";
            Description.Size = new Size(464, 256);
            Description.TabIndex = 17;
            Description.Text = resources.GetString("Description.Text");
            Description.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 754);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private PictureBox pictureBox3;
        private Label Company;
        private Button BExit;
        private Panel LoginPanel;
        private Button BEye;
        private Button BLogin;
        private LinkLabel linkSignUp;
        private Label label2;
        private Label LPassword;
        private TextBox TBPassword;
        private Label label1;
        private TextBox TBUsername;
        private Label LLogin;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Panel panel1;
        private Label Description;
    }
}