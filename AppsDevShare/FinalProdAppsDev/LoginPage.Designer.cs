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
            pictureBox3 = new PictureBox();
            Company = new Label();
            BExit = new Button();
            BEye = new Button();
            linkSignUp = new LinkLabel();
            label2 = new Label();
            LPassword = new Label();
            TBPassword = new TextBox();
            label1 = new Label();
            TBUsername = new TextBox();
            LLogin = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            siticonePanel1 = new SiticoneNetCoreUI.SiticonePanel();
            BLogin = new SiticoneNetCoreUI.SiticoneButton();
            Description = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            siticonePanel1.SuspendLayout();
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
            panel3.Size = new Size(1109, 36);
            panel3.TabIndex = 3;
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
            BExit.BackgroundImage = Properties.Resources.exit;
            BExit.BackgroundImageLayout = ImageLayout.Zoom;
            BExit.FlatAppearance.BorderSize = 0;
            BExit.FlatStyle = FlatStyle.Flat;
            BExit.Location = new Point(1074, 6);
            BExit.Name = "BExit";
            BExit.Size = new Size(20, 25);
            BExit.TabIndex = 0;
            BExit.UseVisualStyleBackColor = true;
            BExit.MouseClick += BExit_MouseClick;
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
            BEye.Location = new Point(366, 266);
            BEye.Name = "BEye";
            BEye.Size = new Size(18, 13);
            BEye.TabIndex = 0;
            BEye.TabStop = false;
            BEye.UseVisualStyleBackColor = false;
            BEye.MouseClick += BEye_MouseClick_1;
            // 
            // linkSignUp
            // 
            linkSignUp.ActiveLinkColor = Color.Teal;
            linkSignUp.AutoSize = true;
            linkSignUp.BackColor = Color.Transparent;
            linkSignUp.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            linkSignUp.LinkColor = Color.White;
            linkSignUp.Location = new Point(218, 452);
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
            label2.Location = new Point(114, 452);
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
            LPassword.Location = new Point(21, 221);
            LPassword.Name = "LPassword";
            LPassword.Size = new Size(103, 22);
            LPassword.TabIndex = 4;
            LPassword.Text = "Password:";
            // 
            // TBPassword
            // 
            TBPassword.Cursor = Cursors.Hand;
            TBPassword.Font = new Font("Segoe UI", 19F);
            TBPassword.Location = new Point(21, 255);
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
            label1.Location = new Point(21, 99);
            label1.Name = "label1";
            label1.Size = new Size(110, 22);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // TBUsername
            // 
            TBUsername.Cursor = Cursors.Hand;
            TBUsername.Font = new Font("Segoe UI", 19F);
            TBUsername.Location = new Point(21, 137);
            TBUsername.Multiline = true;
            TBUsername.Name = "TBUsername";
            TBUsername.Size = new Size(372, 44);
            TBUsername.TabIndex = 1;
            TBUsername.TextChanged += TBUsername_TextChanged;
            // 
            // LLogin
            // 
            LLogin.AutoSize = true;
            LLogin.BackColor = Color.Transparent;
            LLogin.Font = new Font("Verdana", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LLogin.ForeColor = Color.White;
            LLogin.Location = new Point(155, 32);
            LLogin.Name = "LLogin";
            LLogin.Size = new Size(123, 41);
            LLogin.TabIndex = 0;
            LLogin.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.log;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(757, 57);
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
            label3.Location = new Point(582, 179);
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
            label5.Location = new Point(6, 181);
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
            label4.Location = new Point(582, 527);
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
            label6.Location = new Point(6, 181);
            label6.Name = "label6";
            label6.Size = new Size(0, 32);
            label6.TabIndex = 16;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Background;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(siticonePanel1);
            panel1.Controls.Add(Description);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 688);
            panel1.TabIndex = 0;
            // 
            // siticonePanel1
            // 
            siticonePanel1.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            siticonePanel1.BackColor = Color.Transparent;
            siticonePanel1.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            siticonePanel1.BorderDashPattern = null;
            siticonePanel1.BorderGradientEndColor = Color.Purple;
            siticonePanel1.BorderGradientStartColor = Color.Blue;
            siticonePanel1.BorderThickness = 2F;
            siticonePanel1.Controls.Add(BLogin);
            siticonePanel1.Controls.Add(BEye);
            siticonePanel1.Controls.Add(label6);
            siticonePanel1.Controls.Add(label5);
            siticonePanel1.Controls.Add(linkSignUp);
            siticonePanel1.Controls.Add(LLogin);
            siticonePanel1.Controls.Add(label2);
            siticonePanel1.Controls.Add(TBUsername);
            siticonePanel1.Controls.Add(LPassword);
            siticonePanel1.Controls.Add(label1);
            siticonePanel1.Controls.Add(TBPassword);
            siticonePanel1.CornerRadiusBottomLeft = 15F;
            siticonePanel1.CornerRadiusBottomRight = 15F;
            siticonePanel1.CornerRadiusTopLeft = 15F;
            siticonePanel1.CornerRadiusTopRight = 15F;
            siticonePanel1.EnableAcrylicEffect = false;
            siticonePanel1.EnableMicaEffect = false;
            siticonePanel1.EnableRippleEffect = false;
            siticonePanel1.FillColor = Color.FromArgb(58, 94, 113);
            siticonePanel1.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            siticonePanel1.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            siticonePanel1.Location = new Point(113, 98);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            siticonePanel1.RippleAlpha = 50;
            siticonePanel1.RippleAlphaDecrement = 3;
            siticonePanel1.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel1.RippleMaxSize = 600F;
            siticonePanel1.RippleSpeed = 15F;
            siticonePanel1.ShowBorder = false;
            siticonePanel1.Size = new Size(418, 505);
            siticonePanel1.TabIndex = 18;
            siticonePanel1.TabStop = true;
            siticonePanel1.UseBorderGradient = false;
            siticonePanel1.UseMultiGradient = false;
            siticonePanel1.UsePatternTexture = false;
            siticonePanel1.UseRadialGradient = false;
            // 
            // BLogin
            // 
            BLogin.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            BLogin.AccessibleName = "Login";
            BLogin.AutoSizeBasedOnText = false;
            BLogin.BackColor = Color.Transparent;
            BLogin.BadgeBackColor = Color.Red;
            BLogin.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            BLogin.BadgeValue = 0;
            BLogin.BadgeValueForeColor = Color.BlanchedAlmond;
            BLogin.BorderColor = Color.White;
            BLogin.BorderWidth = 2;
            BLogin.ButtonBackColor = Color.FromArgb(217, 217, 217);
            BLogin.ButtonImage = null;
            BLogin.CanBeep = true;
            BLogin.CanGlow = false;
            BLogin.CanShake = true;
            BLogin.ContextMenuStripEx = null;
            BLogin.CornerRadiusBottomLeft = 15;
            BLogin.CornerRadiusBottomRight = 15;
            BLogin.CornerRadiusTopLeft = 15;
            BLogin.CornerRadiusTopRight = 15;
            BLogin.CustomCursor = Cursors.Default;
            BLogin.DisabledTextColor = Color.FromArgb(150, 150, 150);
            BLogin.EnableLongPress = false;
            BLogin.EnablePressAnimation = true;
            BLogin.EnableRippleEffect = true;
            BLogin.EnableShadow = false;
            BLogin.EnableTextWrapping = false;
            BLogin.Font = new Font("Arial Rounded MT Bold", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BLogin.ForeColor = Color.FromArgb(58, 94, 116);
            BLogin.GlowColor = Color.FromArgb(100, 255, 255, 255);
            BLogin.GlowIntensity = 100;
            BLogin.GlowRadius = 20F;
            BLogin.GradientBackground = false;
            BLogin.GradientColor = Color.FromArgb(114, 168, 255);
            BLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            BLogin.HintText = null;
            BLogin.HoverBackColor = Color.FromArgb(58, 94, 116);
            BLogin.HoverFontStyle = FontStyle.Regular;
            BLogin.HoverTextColor = Color.WhiteSmoke;
            BLogin.HoverTransitionDuration = 250;
            BLogin.ImageAlign = ContentAlignment.MiddleLeft;
            BLogin.ImagePadding = 5;
            BLogin.ImageSize = new Size(16, 16);
            BLogin.IsRadial = false;
            BLogin.IsReadOnly = false;
            BLogin.IsToggleButton = false;
            BLogin.IsToggled = false;
            BLogin.Location = new Point(114, 352);
            BLogin.LongPressDurationMS = 1000;
            BLogin.Name = "BLogin";
            BLogin.NormalFontStyle = FontStyle.Regular;
            BLogin.ParticleColor = Color.FromArgb(200, 200, 200);
            BLogin.ParticleCount = 15;
            BLogin.PressAnimationScale = 0.97F;
            BLogin.PressedBackColor = Color.Teal;
            BLogin.PressedFontStyle = FontStyle.Regular;
            BLogin.PressTransitionDuration = 150;
            BLogin.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            BLogin.RippleColor = Color.FromArgb(255, 255, 255);
            BLogin.RippleOpacity = 0.3F;
            BLogin.RippleRadiusMultiplier = 0.6F;
            BLogin.ShadowBlur = 5;
            BLogin.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            BLogin.ShadowOffset = new Point(2, 2);
            BLogin.ShakeDuration = 500;
            BLogin.ShakeIntensity = 5;
            BLogin.Size = new Size(177, 51);
            BLogin.TabIndex = 17;
            BLogin.Text = "Login";
            BLogin.TextAlign = ContentAlignment.MiddleCenter;
            BLogin.TextColor = Color.FromArgb(58, 94, 116);
            BLogin.TooltipText = null;
            BLogin.UseAdvancedRendering = true;
            BLogin.UseParticles = false;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.BackColor = Color.Transparent;
            Description.Font = new Font("Verdana", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Description.ForeColor = Color.FromArgb(4, 30, 70);
            Description.ImageAlign = ContentAlignment.BottomRight;
            Description.Location = new Point(582, 245);
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
            ClientSize = new Size(1107, 687);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            siticonePanel1.ResumeLayout(false);
            siticonePanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private PictureBox pictureBox3;
        private Label Company;
        private Button BExit;
        private Button BEye;
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
        private SiticoneNetCoreUI.SiticonePanel siticonePanel1;
        private SiticoneNetCoreUI.SiticoneButton BLogin;
    }
}