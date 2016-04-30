using System;

namespace Project_II
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lL_signupnow = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lL_forgot = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.B_signin = new System.Windows.Forms.Button();
            this.tB_pass = new System.Windows.Forms.TextBox();
            this.tB_user = new System.Windows.Forms.TextBox();
            this.p_forgot = new System.Windows.Forms.Panel();
            this.lL_signin = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.B_forgot = new System.Windows.Forms.Button();
            this.tB_forgot_email = new System.Windows.Forms.TextBox();
            this.p_signup = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_password2 = new System.Windows.Forms.TextBox();
            this.tB_password = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.B_signup = new System.Windows.Forms.Button();
            this.tB_email = new System.Windows.Forms.TextBox();
            this.tB_username = new System.Windows.Forms.TextBox();
            this.errorP_username = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_email = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_password = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_password2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p_forgot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.p_signup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_password2)).BeginInit();
            this.SuspendLayout();
            // 
            // lL_signupnow
            // 
            this.lL_signupnow.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lL_signupnow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lL_signupnow.AutoSize = true;
            this.lL_signupnow.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lL_signupnow.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lL_signupnow.Location = new System.Drawing.Point(491, 510);
            this.lL_signupnow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lL_signupnow.Name = "lL_signupnow";
            this.lL_signupnow.Size = new System.Drawing.Size(95, 20);
            this.lL_signupnow.TabIndex = 21;
            this.lL_signupnow.TabStop = true;
            this.lL_signupnow.Text = "Sign up now!";
            this.lL_signupnow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lL_signupnow_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(324, 510);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Don\'t have an account?";
            // 
            // lL_forgot
            // 
            this.lL_forgot.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lL_forgot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lL_forgot.AutoSize = true;
            this.lL_forgot.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lL_forgot.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lL_forgot.Location = new System.Drawing.Point(376, 484);
            this.lL_forgot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lL_forgot.Name = "lL_forgot";
            this.lL_forgot.Size = new System.Drawing.Size(160, 20);
            this.lL_forgot.TabIndex = 19;
            this.lL_forgot.TabStop = true;
            this.lL_forgot.Text = "Forgot your password?";
            this.lL_forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lL_forgot_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(391, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // B_signin
            // 
            this.B_signin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_signin.BackColor = System.Drawing.Color.DodgerBlue;
            this.B_signin.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.B_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_signin.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_signin.ForeColor = System.Drawing.SystemColors.Window;
            this.B_signin.Location = new System.Drawing.Point(278, 394);
            this.B_signin.Margin = new System.Windows.Forms.Padding(2);
            this.B_signin.Name = "B_signin";
            this.B_signin.Size = new System.Drawing.Size(349, 40);
            this.B_signin.TabIndex = 17;
            this.B_signin.TabStop = false;
            this.B_signin.Text = "Sign in";
            this.B_signin.UseVisualStyleBackColor = false;
            this.B_signin.Click += new System.EventHandler(this.B_signin_Click);
            // 
            // tB_pass
            // 
            this.tB_pass.AcceptsReturn = true;
            this.tB_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_pass.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tB_pass.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_pass.ForeColor = System.Drawing.Color.Gray;
            this.tB_pass.Location = new System.Drawing.Point(278, 332);
            this.tB_pass.Margin = new System.Windows.Forms.Padding(2);
            this.tB_pass.MinimumSize = new System.Drawing.Size(350, 32);
            this.tB_pass.Name = "tB_pass";
            this.tB_pass.Size = new System.Drawing.Size(350, 32);
            this.tB_pass.TabIndex = 2;
            this.tB_pass.Text = "enter your password";
            this.tB_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_pass.TextChanged += new System.EventHandler(this.tB_pass_TextChanged);
            this.tB_pass.GotFocus += new System.EventHandler(this.tB_pass_GotFocus);
            this.tB_pass.LostFocus += new System.EventHandler(this.tB_pass_LostFocus);
            // 
            // tB_user
            // 
            this.tB_user.AcceptsReturn = true;
            this.tB_user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_user.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tB_user.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_user.ForeColor = System.Drawing.Color.Gray;
            this.tB_user.Location = new System.Drawing.Point(278, 288);
            this.tB_user.Margin = new System.Windows.Forms.Padding(2);
            this.tB_user.MinimumSize = new System.Drawing.Size(350, 32);
            this.tB_user.Name = "tB_user";
            this.tB_user.Size = new System.Drawing.Size(350, 32);
            this.tB_user.TabIndex = 1;
            this.tB_user.Text = "enter your email/username";
            this.tB_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_user.TextChanged += new System.EventHandler(this.tB_user_TextChanged);
            this.tB_user.GotFocus += new System.EventHandler(this.tB_user_GotFocus);
            this.tB_user.LostFocus += new System.EventHandler(this.tB_user_LostFocus);
            // 
            // p_forgot
            // 
            this.p_forgot.Controls.Add(this.lL_signin);
            this.p_forgot.Controls.Add(this.label2);
            this.p_forgot.Controls.Add(this.pictureBox2);
            this.p_forgot.Controls.Add(this.B_forgot);
            this.p_forgot.Controls.Add(this.tB_forgot_email);
            this.p_forgot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_forgot.Location = new System.Drawing.Point(0, 0);
            this.p_forgot.Name = "p_forgot";
            this.p_forgot.Size = new System.Drawing.Size(906, 583);
            this.p_forgot.TabIndex = 22;
            this.p_forgot.Visible = false;
            // 
            // lL_signin
            // 
            this.lL_signin.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lL_signin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lL_signin.AutoSize = true;
            this.lL_signin.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lL_signin.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lL_signin.Location = new System.Drawing.Point(513, 504);
            this.lL_signin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lL_signin.Name = "lL_signin";
            this.lL_signin.Size = new System.Drawing.Size(58, 20);
            this.lL_signin.TabIndex = 18;
            this.lL_signin.TabStop = true;
            this.lL_signin.Text = "Sign in!";
            this.lL_signin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lL_signin_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(320, 504);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Remember your password?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(391, 76);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // B_forgot
            // 
            this.B_forgot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_forgot.BackColor = System.Drawing.Color.DodgerBlue;
            this.B_forgot.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.B_forgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_forgot.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_forgot.ForeColor = System.Drawing.SystemColors.Window;
            this.B_forgot.Location = new System.Drawing.Point(278, 340);
            this.B_forgot.Margin = new System.Windows.Forms.Padding(2);
            this.B_forgot.Name = "B_forgot";
            this.B_forgot.Size = new System.Drawing.Size(349, 40);
            this.B_forgot.TabIndex = 15;
            this.B_forgot.TabStop = false;
            this.B_forgot.Text = "Recover password";
            this.B_forgot.UseVisualStyleBackColor = false;
            // 
            // tB_forgot_email
            // 
            this.tB_forgot_email.AcceptsReturn = true;
            this.tB_forgot_email.AcceptsTab = true;
            this.tB_forgot_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tB_forgot_email.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tB_forgot_email.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_forgot_email.ForeColor = System.Drawing.Color.Gray;
            this.tB_forgot_email.Location = new System.Drawing.Point(277, 288);
            this.tB_forgot_email.Margin = new System.Windows.Forms.Padding(2);
            this.tB_forgot_email.MinimumSize = new System.Drawing.Size(350, 32);
            this.tB_forgot_email.Name = "tB_forgot_email";
            this.tB_forgot_email.Size = new System.Drawing.Size(350, 32);
            this.tB_forgot_email.TabIndex = 14;
            this.tB_forgot_email.TabStop = false;
            this.tB_forgot_email.Text = "enter your username";
            this.tB_forgot_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_forgot_email.Click += new System.EventHandler(this.tB_forgot_email_Click);
            this.tB_forgot_email.TextChanged += new System.EventHandler(this.tB_forgot_email_TextChanged);
            // 
            // p_signup
            // 
            this.p_signup.Controls.Add(this.linkLabel1);
            this.p_signup.Controls.Add(this.label3);
            this.p_signup.Controls.Add(this.tB_password2);
            this.p_signup.Controls.Add(this.tB_password);
            this.p_signup.Controls.Add(this.pictureBox3);
            this.p_signup.Controls.Add(this.B_signup);
            this.p_signup.Controls.Add(this.tB_email);
            this.p_signup.Controls.Add(this.tB_username);
            this.p_signup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_signup.Location = new System.Drawing.Point(0, 0);
            this.p_signup.Name = "p_signup";
            this.p_signup.Size = new System.Drawing.Size(906, 583);
            this.p_signup.TabIndex = 19;
            this.p_signup.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(485, 512);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 20);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign in!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(342, 512);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Having an account?";
            // 
            // tB_password2
            // 
            this.tB_password2.AcceptsReturn = true;
            this.tB_password2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tB_password2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tB_password2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_password2.ForeColor = System.Drawing.Color.Gray;
            this.tB_password2.Location = new System.Drawing.Point(278, 403);
            this.tB_password2.Margin = new System.Windows.Forms.Padding(2);
            this.tB_password2.MinimumSize = new System.Drawing.Size(350, 32);
            this.tB_password2.Name = "tB_password2";
            this.tB_password2.Size = new System.Drawing.Size(350, 32);
            this.tB_password2.TabIndex = 17;
            this.tB_password2.Text = "re-enter your password";
            this.tB_password2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_password2.TextChanged += new System.EventHandler(this.tB_password2_TextChanged);
            this.tB_password2.GotFocus += new System.EventHandler(this.tB_password2_GotFocus);
            this.tB_password2.LostFocus += new System.EventHandler(this.tB_password2_LostFocus);
            // 
            // tB_password
            // 
            this.tB_password.AcceptsReturn = true;
            this.tB_password.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tB_password.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tB_password.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_password.ForeColor = System.Drawing.Color.Gray;
            this.tB_password.Location = new System.Drawing.Point(278, 358);
            this.tB_password.Margin = new System.Windows.Forms.Padding(2);
            this.tB_password.MinimumSize = new System.Drawing.Size(350, 32);
            this.tB_password.Name = "tB_password";
            this.tB_password.Size = new System.Drawing.Size(350, 32);
            this.tB_password.TabIndex = 16;
            this.tB_password.Text = "enter your password";
            this.tB_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_password.TextChanged += new System.EventHandler(this.tB_password_TextChanged);
            this.tB_password.GotFocus += new System.EventHandler(this.tB_password_GotFocus);
            this.tB_password.LostFocus += new System.EventHandler(this.tB_password_LostFocus);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(391, 76);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 174);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // B_signup
            // 
            this.B_signup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.B_signup.BackColor = System.Drawing.Color.DodgerBlue;
            this.B_signup.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.B_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_signup.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_signup.ForeColor = System.Drawing.SystemColors.Window;
            this.B_signup.Location = new System.Drawing.Point(278, 461);
            this.B_signup.Margin = new System.Windows.Forms.Padding(2);
            this.B_signup.Name = "B_signup";
            this.B_signup.Size = new System.Drawing.Size(349, 40);
            this.B_signup.TabIndex = 14;
            this.B_signup.TabStop = false;
            this.B_signup.Text = "Sign up";
            this.B_signup.UseVisualStyleBackColor = false;
            this.B_signup.Click += new System.EventHandler(this.B_signup_Click);
            // 
            // tB_email
            // 
            this.tB_email.AcceptsReturn = true;
            this.tB_email.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tB_email.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tB_email.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_email.ForeColor = System.Drawing.Color.Gray;
            this.tB_email.Location = new System.Drawing.Point(278, 314);
            this.tB_email.Margin = new System.Windows.Forms.Padding(2);
            this.tB_email.MinimumSize = new System.Drawing.Size(350, 32);
            this.tB_email.Name = "tB_email";
            this.tB_email.Size = new System.Drawing.Size(350, 32);
            this.tB_email.TabIndex = 13;
            this.tB_email.Text = "enter your email";
            this.tB_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_email.TextChanged += new System.EventHandler(this.tB_email_TextChanged);
            this.tB_email.GotFocus += new System.EventHandler(this.tB_email_GotFocus);
            this.tB_email.LostFocus += new System.EventHandler(this.tB_email_LostFocus);
            // 
            // tB_username
            // 
            this.tB_username.AcceptsReturn = true;
            this.tB_username.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tB_username.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tB_username.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_username.ForeColor = System.Drawing.Color.Gray;
            this.tB_username.Location = new System.Drawing.Point(278, 269);
            this.tB_username.Margin = new System.Windows.Forms.Padding(2);
            this.tB_username.MinimumSize = new System.Drawing.Size(350, 32);
            this.tB_username.Name = "tB_username";
            this.tB_username.Size = new System.Drawing.Size(350, 32);
            this.tB_username.TabIndex = 12;
            this.tB_username.Text = "choose your username";
            this.tB_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_username.TextChanged += new System.EventHandler(this.tB_username_TextChanged);
            this.tB_username.GotFocus += new System.EventHandler(this.tB_username_GotFocus);
            this.tB_username.LostFocus += new System.EventHandler(this.tB_username_LostFocus);
            // 
            // errorP_username
            // 
            this.errorP_username.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorP_username.ContainerControl = this;
            // 
            // errorP_email
            // 
            this.errorP_email.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorP_email.ContainerControl = this;
            // 
            // errorP_password
            // 
            this.errorP_password.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorP_password.ContainerControl = this;
            // 
            // errorP_password2
            // 
            this.errorP_password2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorP_password2.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 583);
            this.Controls.Add(this.p_signup);
            this.Controls.Add(this.p_forgot);
            this.Controls.Add(this.lL_signupnow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lL_forgot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.B_signin);
            this.Controls.Add(this.tB_pass);
            this.Controls.Add(this.tB_user);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pluto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.p_forgot.ResumeLayout(false);
            this.p_forgot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.p_signup.ResumeLayout(false);
            this.p_signup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_password2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lL_signupnow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lL_forgot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button B_signin;
        private System.Windows.Forms.TextBox tB_pass;
        private System.Windows.Forms.TextBox tB_user;
        private System.Windows.Forms.Panel p_forgot;
        private System.Windows.Forms.LinkLabel lL_signin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button B_forgot;
        private System.Windows.Forms.TextBox tB_forgot_email;
        private System.Windows.Forms.Panel p_signup;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_password2;
        private System.Windows.Forms.TextBox tB_password;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button B_signup;
        private System.Windows.Forms.TextBox tB_email;
        private System.Windows.Forms.TextBox tB_username;
        private System.Windows.Forms.ErrorProvider errorP_username;
        private System.Windows.Forms.ErrorProvider errorP_email;
        private System.Windows.Forms.ErrorProvider errorP_password;
        private System.Windows.Forms.ErrorProvider errorP_password2;
    }
}

