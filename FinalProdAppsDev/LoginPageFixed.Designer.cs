namespace FinalProdAppsDev
{
    partial class LoginPageFixed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPageFixed));
            panel2 = new Panel();
            siticoneCloseButton1 = new SiticoneNetCoreUI.SiticoneCloseButton();
            pictureBox3 = new PictureBox();
            Company = new Label();
            Description = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            siticonePanel1 = new SiticoneNetCoreUI.SiticonePanel();
            BEye = new Button();
            siticoneButton2 = new SiticoneNetCoreUI.SiticoneButton();
            siticoneTextBox1 = new SiticoneNetCoreUI.SiticoneTextBox();
            TBPassword = new SiticoneNetCoreUI.SiticoneTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            linkSignUp = new LinkLabel();
            label2 = new Label();
            LPassword = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            siticonePanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(58, 94, 113);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(siticoneCloseButton1);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(Company);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1107, 35);
            panel2.TabIndex = 27;
            // 
            // siticoneCloseButton1
            // 
            siticoneCloseButton1.BackColor = Color.Transparent;
            siticoneCloseButton1.CountdownFont = new Font("Segoe UI", 9F);
            siticoneCloseButton1.Cursor = Cursors.Default;
            siticoneCloseButton1.EnableGlowEffect = true;
            siticoneCloseButton1.EnableSound = false;
            siticoneCloseButton1.ForeColor = Color.White;
            siticoneCloseButton1.GlowColor = Color.Firebrick;
            siticoneCloseButton1.HoverColor = Color.Red;
            siticoneCloseButton1.IconColor = Color.White;
            siticoneCloseButton1.IconSize = 12;
            siticoneCloseButton1.Location = new Point(1065, -2);
            siticoneCloseButton1.Name = "siticoneCloseButton1";
            siticoneCloseButton1.Size = new Size(37, 37);
            siticoneCloseButton1.TabIndex = 17;
            siticoneCloseButton1.Text = "siticoneCloseButton1";
            siticoneCloseButton1.TooltipText = "Close button";
            siticoneCloseButton1.Click += siticoneCloseButton1_Click;
            siticoneCloseButton1.MouseClick += siticoneCloseButton1_MouseClick;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = Properties.Resources.log;
            pictureBox3.Location = new Point(4, -2);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
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
            Company.Margin = new Padding(4, 0, 4, 0);
            Company.Name = "Company";
            Company.Size = new Size(82, 20);
            Company.TabIndex = 9;
            Company.Text = "MediTrack";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.BackColor = Color.Transparent;
            Description.Font = new Font("Verdana", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Description.ForeColor = Color.FromArgb(4, 30, 70);
            Description.ImageAlign = ContentAlignment.BottomRight;
            Description.Location = new Point(563, 238);
            Description.Name = "Description";
            Description.Size = new Size(464, 256);
            Description.TabIndex = 31;
            Description.Text = resources.GetString("Description.Text");
            Description.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Script MT Bold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(4, 30, 70);
            label4.Location = new Point(563, 547);
            label4.Name = "label4";
            label4.Size = new Size(432, 48);
            label4.TabIndex = 30;
            label4.Text = "Your health, our priority!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(4, 30, 70);
            label3.Location = new Point(559, 161);
            label3.Name = "label3";
            label3.Size = new Size(466, 41);
            label3.TabIndex = 29;
            label3.Text = "Welcome to MediTrack!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.log;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(754, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
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
            siticonePanel1.Controls.Add(BEye);
            siticonePanel1.Controls.Add(siticoneButton2);
            siticonePanel1.Controls.Add(siticoneTextBox1);
            siticonePanel1.Controls.Add(TBPassword);
            siticonePanel1.Controls.Add(label7);
            siticonePanel1.Controls.Add(label6);
            siticonePanel1.Controls.Add(label5);
            siticonePanel1.Controls.Add(linkSignUp);
            siticonePanel1.Controls.Add(label2);
            siticonePanel1.Controls.Add(LPassword);
            siticonePanel1.Controls.Add(label1);
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
            siticonePanel1.Location = new Point(69, 122);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            siticonePanel1.RippleAlpha = 50;
            siticonePanel1.RippleAlphaDecrement = 3;
            siticonePanel1.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel1.RippleMaxSize = 600F;
            siticonePanel1.RippleSpeed = 15F;
            siticonePanel1.ShowBorder = false;
            siticonePanel1.Size = new Size(450, 479);
            siticonePanel1.TabIndex = 32;
            siticonePanel1.TabStop = true;
            siticonePanel1.UseBorderGradient = false;
            siticonePanel1.UseMultiGradient = false;
            siticonePanel1.UsePatternTexture = false;
            siticonePanel1.UseRadialGradient = false;
            siticonePanel1.Paint += siticonePanel1_Paint;
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
            BEye.Location = new Point(376, 235);
            BEye.Name = "BEye";
            BEye.Size = new Size(18, 13);
            BEye.TabIndex = 0;
            BEye.TabStop = false;
            BEye.UseVisualStyleBackColor = false;
            BEye.Click += BEye_Click;
            // 
            // siticoneButton2
            // 
            siticoneButton2.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            siticoneButton2.AccessibleName = "Login";
            siticoneButton2.AutoSizeBasedOnText = false;
            siticoneButton2.BackColor = Color.Transparent;
            siticoneButton2.BadgeBackColor = Color.Red;
            siticoneButton2.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            siticoneButton2.BadgeValue = 0;
            siticoneButton2.BadgeValueForeColor = Color.White;
            siticoneButton2.BorderColor = Color.Transparent;
            siticoneButton2.BorderWidth = 2;
            siticoneButton2.ButtonBackColor = Color.White;
            siticoneButton2.ButtonImage = null;
            siticoneButton2.CanBeep = true;
            siticoneButton2.CanGlow = false;
            siticoneButton2.CanShake = true;
            siticoneButton2.ContextMenuStripEx = null;
            siticoneButton2.CornerRadiusBottomLeft = 10;
            siticoneButton2.CornerRadiusBottomRight = 10;
            siticoneButton2.CornerRadiusTopLeft = 10;
            siticoneButton2.CornerRadiusTopRight = 10;
            siticoneButton2.Cursor = Cursors.Hand;
            siticoneButton2.CustomCursor = Cursors.Hand;
            siticoneButton2.DisabledTextColor = Color.White;
            siticoneButton2.EnableLongPress = false;
            siticoneButton2.EnablePressAnimation = true;
            siticoneButton2.EnableRippleEffect = true;
            siticoneButton2.EnableShadow = false;
            siticoneButton2.EnableTextWrapping = false;
            siticoneButton2.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic);
            siticoneButton2.ForeColor = Color.FromArgb(114, 168, 255);
            siticoneButton2.GlowColor = Color.FromArgb(100, 255, 255, 255);
            siticoneButton2.GlowIntensity = 100;
            siticoneButton2.GlowRadius = 20F;
            siticoneButton2.GradientBackground = false;
            siticoneButton2.GradientColor = Color.FromArgb(114, 168, 255);
            siticoneButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            siticoneButton2.HintText = null;
            siticoneButton2.HoverBackColor = Color.FromArgb(114, 168, 255);
            siticoneButton2.HoverFontStyle = FontStyle.Regular;
            siticoneButton2.HoverTextColor = Color.FromArgb(4, 30, 70);
            siticoneButton2.HoverTransitionDuration = 250;
            siticoneButton2.ImageAlign = ContentAlignment.MiddleLeft;
            siticoneButton2.ImagePadding = 5;
            siticoneButton2.ImageSize = new Size(16, 16);
            siticoneButton2.IsRadial = false;
            siticoneButton2.IsReadOnly = false;
            siticoneButton2.IsToggleButton = false;
            siticoneButton2.IsToggled = false;
            siticoneButton2.Location = new Point(141, 332);
            siticoneButton2.LongPressDurationMS = 1000;
            siticoneButton2.Name = "siticoneButton2";
            siticoneButton2.NormalFontStyle = FontStyle.Regular;
            siticoneButton2.ParticleColor = Color.FromArgb(200, 200, 200);
            siticoneButton2.ParticleCount = 15;
            siticoneButton2.PressAnimationScale = 0.97F;
            siticoneButton2.PressedBackColor = Color.FromArgb(74, 128, 235);
            siticoneButton2.PressedFontStyle = FontStyle.Regular;
            siticoneButton2.PressTransitionDuration = 150;
            siticoneButton2.ReadOnlyTextColor = Color.Red;
            siticoneButton2.RippleColor = Color.FromArgb(255, 255, 255);
            siticoneButton2.RippleOpacity = 0.3F;
            siticoneButton2.RippleRadiusMultiplier = 0.6F;
            siticoneButton2.ShadowBlur = 5;
            siticoneButton2.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            siticoneButton2.ShadowOffset = new Point(2, 2);
            siticoneButton2.ShakeDuration = 500;
            siticoneButton2.ShakeIntensity = 5;
            siticoneButton2.Size = new Size(160, 33);
            siticoneButton2.TabIndex = 51;
            siticoneButton2.Text = "Login";
            siticoneButton2.TextAlign = ContentAlignment.MiddleCenter;
            siticoneButton2.TextColor = Color.FromArgb(4, 30, 70);
            siticoneButton2.TooltipText = null;
            siticoneButton2.UseAdvancedRendering = true;
            siticoneButton2.UseParticles = false;
            siticoneButton2.Click += siticoneButton2_Click;
            siticoneButton2.MouseClick += siticoneButton2_MouseClick;
            // 
            // siticoneTextBox1
            // 
            siticoneTextBox1.AccessibleDescription = "A customizable text input field.";
            siticoneTextBox1.AccessibleName = "Text Box";
            siticoneTextBox1.AccessibleRole = AccessibleRole.Text;
            siticoneTextBox1.BackColor = Color.Transparent;
            siticoneTextBox1.BlinkCount = 3;
            siticoneTextBox1.BlinkShadow = false;
            siticoneTextBox1.BorderColor1 = Color.LightSlateGray;
            siticoneTextBox1.BorderColor2 = Color.LightSlateGray;
            siticoneTextBox1.BorderFocusColor1 = Color.FromArgb(77, 77, 255);
            siticoneTextBox1.BorderFocusColor2 = Color.FromArgb(77, 77, 255);
            siticoneTextBox1.CanShake = true;
            siticoneTextBox1.ContinuousBlink = false;
            siticoneTextBox1.CornerRadiusBottomLeft = 10;
            siticoneTextBox1.CornerRadiusBottomRight = 10;
            siticoneTextBox1.CornerRadiusTopLeft = 10;
            siticoneTextBox1.CornerRadiusTopRight = 10;
            siticoneTextBox1.CursorBlinkRate = 500;
            siticoneTextBox1.CursorColor = Color.Black;
            siticoneTextBox1.CursorHeight = 26;
            siticoneTextBox1.CursorOffset = 0;
            siticoneTextBox1.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            siticoneTextBox1.CursorWidth = 1;
            siticoneTextBox1.DisabledBackColor = Color.WhiteSmoke;
            siticoneTextBox1.DisabledBorderColor = Color.LightGray;
            siticoneTextBox1.DisabledTextColor = Color.Gray;
            siticoneTextBox1.EnableDropShadow = false;
            siticoneTextBox1.FillColor1 = Color.White;
            siticoneTextBox1.FillColor2 = Color.White;
            siticoneTextBox1.Font = new Font("Segoe UI", 9.5F);
            siticoneTextBox1.ForeColor = Color.DimGray;
            siticoneTextBox1.HoverBorderColor1 = Color.Gray;
            siticoneTextBox1.HoverBorderColor2 = Color.Gray;
            siticoneTextBox1.IsEnabled = true;
            siticoneTextBox1.Location = new Point(51, 132);
            siticoneTextBox1.Name = "siticoneTextBox1";
            siticoneTextBox1.PlaceholderColor = Color.Gray;
            siticoneTextBox1.PlaceholderText = "Enter username";
            siticoneTextBox1.ReadOnlyBorderColor1 = Color.LightGray;
            siticoneTextBox1.ReadOnlyBorderColor2 = Color.LightGray;
            siticoneTextBox1.ReadOnlyFillColor1 = Color.WhiteSmoke;
            siticoneTextBox1.ReadOnlyFillColor2 = Color.WhiteSmoke;
            siticoneTextBox1.ReadOnlyPlaceholderColor = Color.DarkGray;
            siticoneTextBox1.SelectionBackColor = Color.FromArgb(77, 77, 255);
            siticoneTextBox1.ShadowAnimationDuration = 1;
            siticoneTextBox1.ShadowBlur = 10;
            siticoneTextBox1.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            siticoneTextBox1.Size = new Size(356, 35);
            siticoneTextBox1.SolidBorderColor = Color.LightSlateGray;
            siticoneTextBox1.SolidBorderFocusColor = Color.FromArgb(77, 77, 255);
            siticoneTextBox1.SolidBorderHoverColor = Color.Gray;
            siticoneTextBox1.SolidFillColor = Color.White;
            siticoneTextBox1.TabIndex = 34;
            siticoneTextBox1.TextPadding = new Padding(16, 0, 6, 0);
            siticoneTextBox1.ValidationErrorMessage = "Invalid input.";
            siticoneTextBox1.ValidationFunction = null;
            // 
            // TBPassword
            // 
            TBPassword.AccessibleDescription = "A customizable text input field.";
            TBPassword.AccessibleName = "Text Box";
            TBPassword.AccessibleRole = AccessibleRole.Text;
            TBPassword.BackColor = Color.Transparent;
            TBPassword.BlinkCount = 3;
            TBPassword.BlinkShadow = false;
            TBPassword.BorderColor1 = Color.LightSlateGray;
            TBPassword.BorderColor2 = Color.LightSlateGray;
            TBPassword.BorderFocusColor1 = Color.FromArgb(77, 77, 255);
            TBPassword.BorderFocusColor2 = Color.FromArgb(77, 77, 255);
            TBPassword.CanShake = true;
            TBPassword.ContinuousBlink = false;
            TBPassword.CornerRadiusBottomLeft = 10;
            TBPassword.CornerRadiusBottomRight = 10;
            TBPassword.CornerRadiusTopLeft = 10;
            TBPassword.CornerRadiusTopRight = 10;
            TBPassword.CursorBlinkRate = 500;
            TBPassword.CursorColor = Color.Black;
            TBPassword.CursorHeight = 26;
            TBPassword.CursorOffset = 0;
            TBPassword.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            TBPassword.CursorWidth = 1;
            TBPassword.DisabledBackColor = Color.WhiteSmoke;
            TBPassword.DisabledBorderColor = Color.LightGray;
            TBPassword.DisabledTextColor = Color.Gray;
            TBPassword.EnableDropShadow = false;
            TBPassword.FillColor1 = Color.White;
            TBPassword.FillColor2 = Color.White;
            TBPassword.Font = new Font("Segoe UI", 9.5F);
            TBPassword.ForeColor = Color.DimGray;
            TBPassword.HoverBorderColor1 = Color.Gray;
            TBPassword.HoverBorderColor2 = Color.Gray;
            TBPassword.IsEnabled = true;
            TBPassword.Location = new Point(51, 224);
            TBPassword.Name = "TBPassword";
            TBPassword.PlaceholderColor = Color.Gray;
            TBPassword.PlaceholderText = "Enter password";
            TBPassword.ReadOnlyBorderColor1 = Color.LightGray;
            TBPassword.ReadOnlyBorderColor2 = Color.LightGray;
            TBPassword.ReadOnlyFillColor1 = Color.WhiteSmoke;
            TBPassword.ReadOnlyFillColor2 = Color.WhiteSmoke;
            TBPassword.ReadOnlyPlaceholderColor = Color.DarkGray;
            TBPassword.SelectionBackColor = Color.FromArgb(77, 77, 255);
            TBPassword.ShadowAnimationDuration = 1;
            TBPassword.ShadowBlur = 10;
            TBPassword.ShadowColor = Color.FromArgb(15, 0, 0, 0);
            TBPassword.Size = new Size(356, 37);
            TBPassword.SolidBorderColor = Color.LightSlateGray;
            TBPassword.SolidBorderFocusColor = Color.FromArgb(77, 77, 255);
            TBPassword.SolidBorderHoverColor = Color.Gray;
            TBPassword.SolidFillColor = Color.White;
            TBPassword.TabIndex = 33;
            TBPassword.TextPadding = new Padding(16, 0, 6, 0);
            TBPassword.ValidationErrorMessage = "Invalid input.";
            TBPassword.ValidationFunction = null;
            TBPassword.Click += TBPassword_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 19F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(179, 33);
            label7.Name = "label7";
            label7.Size = new Size(95, 32);
            label7.TabIndex = 23;
            label7.Text = "Login";
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
            // linkSignUp
            // 
            linkSignUp.ActiveLinkColor = Color.PaleTurquoise;
            linkSignUp.AutoSize = true;
            linkSignUp.BackColor = Color.Transparent;
            linkSignUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            linkSignUp.LinkColor = Color.White;
            linkSignUp.Location = new Point(240, 385);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(59, 19);
            linkSignUp.TabIndex = 11;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Sign up";
            linkSignUp.LinkClicked += linkSignUp_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(151, 385);
            label2.Name = "label2";
            label2.Size = new Size(92, 19);
            label2.TabIndex = 10;
            label2.Text = "No Account?";
            label2.Click += label2_Click;
            // 
            // LPassword
            // 
            LPassword.AutoSize = true;
            LPassword.BackColor = Color.Transparent;
            LPassword.Font = new Font("Verdana", 10F);
            LPassword.ForeColor = Color.White;
            LPassword.Location = new Point(51, 196);
            LPassword.Name = "LPassword";
            LPassword.Size = new Size(81, 17);
            LPassword.TabIndex = 4;
            LPassword.Text = "Password:";
            LPassword.Click += LPassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 102);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // LoginPageFixed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_signUp;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1107, 685);
            Controls.Add(siticonePanel1);
            Controls.Add(Description);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPageFixed";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPageFixed";
            Load += LoginPageFixed_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            siticonePanel1.ResumeLayout(false);
            siticonePanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private SiticoneNetCoreUI.SiticoneCloseButton siticoneCloseButton1;
        private PictureBox pictureBox3;
        private Label Company;
        private Label Description;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private SiticoneNetCoreUI.SiticonePanel siticonePanel1;
        private Button BEye;
        private Label label6;
        private Label label5;
        private LinkLabel linkSignUp;
        private Label label2;
        private Label LPassword;
        private Label label1;
        private Label label7;
        private SiticoneNetCoreUI.SiticoneTextBox TBPassword;
        private SiticoneNetCoreUI.SiticoneTextBox siticoneTextBox1;
        private SiticoneNetCoreUI.SiticoneButton siticoneButton2;
    }
}