
namespace Demo
{
    partial class demoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(demoForm));
            this.logo = new System.Windows.Forms.PictureBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.password = new CustomControls.RJControls.RJTextBox();
            this.username = new CustomControls.RJControls.RJTextBox();
            this.noAccText = new System.Windows.Forms.Label();
            this.signinBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.profileIcon = new FontAwesome.Sharp.IconPictureBox();
            this.closeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.minimizeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.rememberMe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(10, 10);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 50);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // loginPanel
            // 
            this.loginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginPanel.Controls.Add(this.rememberMe);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.usernameLabel);
            this.loginPanel.Controls.Add(this.password);
            this.loginPanel.Controls.Add(this.username);
            this.loginPanel.Controls.Add(this.noAccText);
            this.loginPanel.Controls.Add(this.signinBtn);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.profileIcon);
            this.loginPanel.Location = new System.Drawing.Point(51, 150);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Padding = new System.Windows.Forms.Padding(5);
            this.loginPanel.Size = new System.Drawing.Size(300, 300);
            this.loginPanel.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordLabel.Location = new System.Drawing.Point(21, 148);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(79, 20);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usernameLabel.Location = new System.Drawing.Point(21, 86);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 20);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.password.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.password.BorderSize = 2;
            this.password.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.password.Location = new System.Drawing.Point(25, 172);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(7);
            this.password.PasswordChar = true;
            this.password.Size = new System.Drawing.Size(250, 32);
            this.password.TabIndex = 2;
            this.password.Texts = "";
            this.password.UnderlinedStyle = true;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.username.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.username.BorderSize = 2;
            this.username.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.username.Location = new System.Drawing.Point(25, 110);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.Padding = new System.Windows.Forms.Padding(7);
            this.username.PasswordChar = false;
            this.username.Size = new System.Drawing.Size(250, 32);
            this.username.TabIndex = 1;
            this.username.Texts = "";
            this.username.UnderlinedStyle = true;
            // 
            // noAccText
            // 
            this.noAccText.AutoSize = true;
            this.noAccText.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noAccText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.noAccText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.noAccText.Location = new System.Drawing.Point(22, 269);
            this.noAccText.Name = "noAccText";
            this.noAccText.Size = new System.Drawing.Size(179, 17);
            this.noAccText.TabIndex = 5;
            this.noAccText.Text = "Don\'t have an account yet?";
            // 
            // signinBtn
            // 
            this.signinBtn.FlatAppearance.BorderSize = 0;
            this.signinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinBtn.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signinBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.signinBtn.Location = new System.Drawing.Point(207, 262);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(75, 30);
            this.signinBtn.TabIndex = 4;
            this.signinBtn.Text = "Register";
            this.signinBtn.UseVisualStyleBackColor = true;
            this.signinBtn.Click += new System.EventHandler(this.signinBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.loginBtn.FlatAppearance.BorderSize = 2;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loginBtn.Location = new System.Drawing.Point(25, 224);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 30);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Log in";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // profileIcon
            // 
            this.profileIcon.BackColor = System.Drawing.Color.Transparent;
            this.profileIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.profileIcon.IconChar = FontAwesome.Sharp.IconChar.User;
            this.profileIcon.IconColor = System.Drawing.Color.White;
            this.profileIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.profileIcon.IconSize = 50;
            this.profileIcon.Location = new System.Drawing.Point(0, 29);
            this.profileIcon.Margin = new System.Windows.Forms.Padding(5);
            this.profileIcon.Name = "profileIcon";
            this.profileIcon.Padding = new System.Windows.Forms.Padding(5);
            this.profileIcon.Size = new System.Drawing.Size(300, 50);
            this.profileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.profileIcon.TabIndex = 0;
            this.profileIcon.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.closeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.closeBtn.IconSize = 25;
            this.closeBtn.Location = new System.Drawing.Point(817, 8);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.minimizeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.minimizeBtn.IconSize = 25;
            this.minimizeBtn.Location = new System.Drawing.Point(791, 8);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(25, 25);
            this.minimizeBtn.TabIndex = 3;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // rememberMe
            // 
            this.rememberMe.AutoSize = true;
            this.rememberMe.BackColor = System.Drawing.Color.Transparent;
            this.rememberMe.FlatAppearance.BorderSize = 0;
            this.rememberMe.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rememberMe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rememberMe.Location = new System.Drawing.Point(146, 228);
            this.rememberMe.Name = "rememberMe";
            this.rememberMe.Size = new System.Drawing.Size(129, 23);
            this.rememberMe.TabIndex = 3;
            this.rememberMe.Text = "Remember me";
            this.rememberMe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rememberMe.UseVisualStyleBackColor = false;
            // 
            // demoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.logo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(850, 600);
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "demoForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.demoForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.demoForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.demoForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.demoForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel loginPanel;
        private FontAwesome.Sharp.IconPictureBox profileIcon;
        private System.Windows.Forms.Button signinBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label noAccText;
        private FontAwesome.Sharp.IconPictureBox closeBtn;
        private FontAwesome.Sharp.IconPictureBox minimizeBtn;
        private CustomControls.RJControls.RJTextBox username;
        private CustomControls.RJControls.RJTextBox password;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.CheckBox rememberMe;
    }
}

