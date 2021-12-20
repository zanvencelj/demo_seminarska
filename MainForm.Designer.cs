
namespace Demo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.minimizeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.closeBtn = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Homel2 = new System.Windows.Forms.Label();
            this.homel1 = new System.Windows.Forms.Label();
            this.homeDesc = new System.Windows.Forms.Label();
            this.homeH1 = new System.Windows.Forms.Label();
            this.navHome = new FontAwesome.Sharp.IconButton();
            this.navCreate = new FontAwesome.Sharp.IconButton();
            this.navAbout = new FontAwesome.Sharp.IconButton();
            this.navSettings = new FontAwesome.Sharp.IconButton();
            this.createPanel = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.previewBlog = new System.Windows.Forms.WebBrowser();
            this.label12 = new System.Windows.Forms.Label();
            this.blogContent = new CustomControls.RJControls.RJTextBox();
            this.blogTitle = new CustomControls.RJControls.RJTextBox();
            this.blogPostBtn = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.logOutBtn = new FontAwesome.Sharp.IconButton();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.homePanel.SuspendLayout();
            this.createPanel.SuspendLayout();
            this.aboutPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.minimizeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.minimizeBtn.IconSize = 25;
            this.minimizeBtn.Location = new System.Drawing.Point(1137, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(25, 25);
            this.minimizeBtn.TabIndex = 5;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.closeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.closeBtn.IconSize = 25;
            this.closeBtn.Location = new System.Drawing.Point(1163, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.Transparent;
            this.homePanel.Controls.Add(this.label3);
            this.homePanel.Controls.Add(this.label2);
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Controls.Add(this.Homel2);
            this.homePanel.Controls.Add(this.homel1);
            this.homePanel.Controls.Add(this.homeDesc);
            this.homePanel.Controls.Add(this.homeH1);
            this.homePanel.Location = new System.Drawing.Point(18, 730);
            this.homePanel.Name = "homePanel";
            this.homePanel.Padding = new System.Windows.Forms.Padding(10);
            this.homePanel.Size = new System.Drawing.Size(1170, 637);
            this.homePanel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(96, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(774, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "You can create a new blog post by clicking the \"Create Post\" button in the naviga" +
    "tion bar.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(96, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(906, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "This is just a preview of the final software, so things may change a lot with the" +
    " official release. Good Luck!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(96, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "This program can help you manage your website, but is curently under hard develop" +
    "ment!";
            // 
            // Homel2
            // 
            this.Homel2.AutoSize = true;
            this.Homel2.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Homel2.Location = new System.Drawing.Point(96, 300);
            this.Homel2.Name = "Homel2";
            this.Homel2.Size = new System.Drawing.Size(565, 24);
            this.Homel2.TabIndex = 3;
            this.Homel2.Text = "We make quality applications, programs & other types of software.";
            // 
            // homel1
            // 
            this.homel1.AutoSize = true;
            this.homel1.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homel1.Location = new System.Drawing.Point(1039, 609);
            this.homel1.Name = "homel1";
            this.homel1.Size = new System.Drawing.Size(131, 21);
            this.homel1.TabIndex = 2;
            this.homel1.Text = "Made by Vanted";
            // 
            // homeDesc
            // 
            this.homeDesc.AutoSize = true;
            this.homeDesc.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeDesc.Location = new System.Drawing.Point(95, 208);
            this.homeDesc.Name = "homeDesc";
            this.homeDesc.Size = new System.Drawing.Size(351, 29);
            this.homeDesc.TabIndex = 1;
            this.homeDesc.Text = "Official program for ceneje.org";
            // 
            // homeH1
            // 
            this.homeH1.AutoSize = true;
            this.homeH1.Font = new System.Drawing.Font("Ubuntu", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeH1.Location = new System.Drawing.Point(90, 133);
            this.homeH1.Name = "homeH1";
            this.homeH1.Size = new System.Drawing.Size(463, 60);
            this.homeH1.TabIndex = 0;
            this.homeH1.Text = "Welcome to DEMO!";
            // 
            // navHome
            // 
            this.navHome.BackColor = System.Drawing.Color.Transparent;
            this.navHome.FlatAppearance.BorderSize = 0;
            this.navHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.navHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.navHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navHome.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.navHome.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.navHome.IconColor = System.Drawing.Color.WhiteSmoke;
            this.navHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navHome.IconSize = 36;
            this.navHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navHome.Location = new System.Drawing.Point(157, 12);
            this.navHome.Name = "navHome";
            this.navHome.Size = new System.Drawing.Size(144, 50);
            this.navHome.TabIndex = 0;
            this.navHome.Text = "Home";
            this.navHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navHome.UseVisualStyleBackColor = false;
            this.navHome.Click += new System.EventHandler(this.navHome_Click);
            // 
            // navCreate
            // 
            this.navCreate.BackColor = System.Drawing.Color.Transparent;
            this.navCreate.FlatAppearance.BorderSize = 0;
            this.navCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.navCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.navCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navCreate.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.navCreate.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.navCreate.IconColor = System.Drawing.Color.WhiteSmoke;
            this.navCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navCreate.IconSize = 36;
            this.navCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navCreate.Location = new System.Drawing.Point(319, 12);
            this.navCreate.Name = "navCreate";
            this.navCreate.Size = new System.Drawing.Size(144, 50);
            this.navCreate.TabIndex = 0;
            this.navCreate.Text = "Create Post";
            this.navCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navCreate.UseVisualStyleBackColor = false;
            this.navCreate.Click += new System.EventHandler(this.navCreate_Click);
            // 
            // navAbout
            // 
            this.navAbout.BackColor = System.Drawing.Color.Transparent;
            this.navAbout.FlatAppearance.BorderSize = 0;
            this.navAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.navAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.navAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navAbout.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.navAbout.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.navAbout.IconColor = System.Drawing.Color.WhiteSmoke;
            this.navAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navAbout.IconSize = 36;
            this.navAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navAbout.Location = new System.Drawing.Point(505, 12);
            this.navAbout.Name = "navAbout";
            this.navAbout.Size = new System.Drawing.Size(144, 50);
            this.navAbout.TabIndex = 0;
            this.navAbout.Text = "About Me";
            this.navAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navAbout.UseVisualStyleBackColor = false;
            this.navAbout.Click += new System.EventHandler(this.navAbout_Click);
            // 
            // navSettings
            // 
            this.navSettings.BackColor = System.Drawing.Color.Transparent;
            this.navSettings.FlatAppearance.BorderSize = 0;
            this.navSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.navSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.navSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navSettings.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.navSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.navSettings.IconColor = System.Drawing.Color.WhiteSmoke;
            this.navSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.navSettings.IconSize = 36;
            this.navSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navSettings.Location = new System.Drawing.Point(968, 12);
            this.navSettings.Name = "navSettings";
            this.navSettings.Size = new System.Drawing.Size(144, 50);
            this.navSettings.TabIndex = 0;
            this.navSettings.Text = "Settings";
            this.navSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.navSettings.UseVisualStyleBackColor = false;
            this.navSettings.Click += new System.EventHandler(this.navSettings_Click);
            // 
            // createPanel
            // 
            this.createPanel.BackColor = System.Drawing.Color.Transparent;
            this.createPanel.Controls.Add(this.label18);
            this.createPanel.Controls.Add(this.label13);
            this.createPanel.Controls.Add(this.previewBlog);
            this.createPanel.Controls.Add(this.label12);
            this.createPanel.Controls.Add(this.blogContent);
            this.createPanel.Controls.Add(this.blogTitle);
            this.createPanel.Controls.Add(this.blogPostBtn);
            this.createPanel.Controls.Add(this.label4);
            this.createPanel.Controls.Add(this.label5);
            this.createPanel.Controls.Add(this.label6);
            this.createPanel.Controls.Add(this.label8);
            this.createPanel.Controls.Add(this.label9);
            this.createPanel.Controls.Add(this.label10);
            this.createPanel.Location = new System.Drawing.Point(169, 656);
            this.createPanel.Name = "createPanel";
            this.createPanel.Padding = new System.Windows.Forms.Padding(10);
            this.createPanel.Size = new System.Drawing.Size(1176, 638);
            this.createPanel.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(773, 180);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(183, 24);
            this.label18.TabIndex = 16;
            this.label18.Text = "Preview of the post:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(540, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "! You can use HTML code !";
            // 
            // previewBlog
            // 
            this.previewBlog.Location = new System.Drawing.Point(777, 207);
            this.previewBlog.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewBlog.Name = "previewBlog";
            this.previewBlog.Size = new System.Drawing.Size(386, 416);
            this.previewBlog.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(876, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(287, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Posts get uploaded to ceneje.org/blog";
            // 
            // blogContent
            // 
            this.blogContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.blogContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.blogContent.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.blogContent.BorderSize = 2;
            this.blogContent.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blogContent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.blogContent.Location = new System.Drawing.Point(100, 308);
            this.blogContent.Margin = new System.Windows.Forms.Padding(4);
            this.blogContent.Multiline = true;
            this.blogContent.Name = "blogContent";
            this.blogContent.Padding = new System.Windows.Forms.Padding(7);
            this.blogContent.PasswordChar = false;
            this.blogContent.Size = new System.Drawing.Size(627, 186);
            this.blogContent.TabIndex = 12;
            this.blogContent.Texts = "";
            this.blogContent.UnderlinedStyle = false;
            this.blogContent._TextChanged += new System.EventHandler(this.blogContent__TextChanged);
            // 
            // blogTitle
            // 
            this.blogTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.blogTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.blogTitle.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.blogTitle.BorderSize = 2;
            this.blogTitle.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blogTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.blogTitle.Location = new System.Drawing.Point(100, 230);
            this.blogTitle.Margin = new System.Windows.Forms.Padding(4);
            this.blogTitle.Multiline = false;
            this.blogTitle.Name = "blogTitle";
            this.blogTitle.Padding = new System.Windows.Forms.Padding(7);
            this.blogTitle.PasswordChar = false;
            this.blogTitle.Size = new System.Drawing.Size(627, 34);
            this.blogTitle.TabIndex = 11;
            this.blogTitle.Texts = "";
            this.blogTitle.UnderlinedStyle = true;
            // 
            // blogPostBtn
            // 
            this.blogPostBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.blogPostBtn.FlatAppearance.BorderSize = 2;
            this.blogPostBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.blogPostBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.blogPostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blogPostBtn.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blogPostBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.blogPostBtn.IconColor = System.Drawing.Color.Black;
            this.blogPostBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.blogPostBtn.Location = new System.Drawing.Point(100, 543);
            this.blogPostBtn.Name = "blogPostBtn";
            this.blogPostBtn.Size = new System.Drawing.Size(188, 45);
            this.blogPostBtn.TabIndex = 7;
            this.blogPostBtn.Text = "Create";
            this.blogPostBtn.UseVisualStyleBackColor = true;
            this.blogPostBtn.Click += new System.EventHandler(this.blogPostBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(96, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(544, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "*Comming Soon: We will add more features like category, Tags, Slug, Images...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(96, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Content:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(96, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(1032, 639);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Made by Vanted";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(95, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(315, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Add blog post to ceneje.org";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ubuntu", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(90, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(293, 60);
            this.label10.TabIndex = 0;
            this.label10.Text = "Create Post";
            // 
            // aboutPanel
            // 
            this.aboutPanel.BackColor = System.Drawing.Color.Transparent;
            this.aboutPanel.Controls.Add(this.label14);
            this.aboutPanel.Controls.Add(this.label15);
            this.aboutPanel.Controls.Add(this.label16);
            this.aboutPanel.Controls.Add(this.label17);
            this.aboutPanel.Location = new System.Drawing.Point(319, 602);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.aboutPanel.Size = new System.Drawing.Size(1176, 537);
            this.aboutPanel.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(96, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(618, 264);
            this.label14.TabIndex = 3;
            this.label14.Text = resources.GetString("label14.Text");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(1032, 639);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "Made by Vanted";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(95, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(367, 29);
            this.label16.TabIndex = 1;
            this.label16.Text = "It\'s about drive its about power, ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Ubuntu", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(90, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(228, 60);
            this.label17.TabIndex = 0;
            this.label17.Text = "About us";
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.settingsPanel.Controls.Add(this.label11);
            this.settingsPanel.Controls.Add(this.label7);
            this.settingsPanel.Controls.Add(this.logOutBtn);
            this.settingsPanel.Controls.Add(this.label22);
            this.settingsPanel.Controls.Add(this.label24);
            this.settingsPanel.Location = new System.Drawing.Point(489, 523);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.settingsPanel.Size = new System.Drawing.Size(1176, 489);
            this.settingsPanel.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(1021, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Theme";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(102, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(536, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "*Warining! Your password will be forgotten and you will have to log in again...";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logOutBtn
            // 
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.logOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logOutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logOutBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.logOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutBtn.Location = new System.Drawing.Point(106, 133);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(150, 50);
            this.logOutBtn.TabIndex = 3;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(1032, 639);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(131, 21);
            this.label22.TabIndex = 2;
            this.label22.Text = "Made by Vanted";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Ubuntu", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.Location = new System.Drawing.Point(96, 61);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(216, 60);
            this.label24.TabIndex = 0;
            this.label24.Text = "Settings";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.aboutPanel);
            this.Controls.Add(this.createPanel);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.navSettings);
            this.Controls.Add(this.navAbout);
            this.Controls.Add(this.navCreate);
            this.Controls.Add(this.navHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Demo | Home";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            this.aboutPanel.ResumeLayout(false);
            this.aboutPanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox minimizeBtn;
        private FontAwesome.Sharp.IconPictureBox closeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel homePanel;
        private FontAwesome.Sharp.IconButton navHome;
        private FontAwesome.Sharp.IconButton navCreate;
        private FontAwesome.Sharp.IconButton navAbout;
        private FontAwesome.Sharp.IconButton navSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Homel2;
        private System.Windows.Forms.Label homel1;
        private System.Windows.Forms.Label homeDesc;
        private System.Windows.Forms.Label homeH1;
        private System.Windows.Forms.Panel createPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconButton blogPostBtn;
        private CustomControls.RJControls.RJTextBox blogContent;
        private CustomControls.RJControls.RJTextBox blogTitle;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton logOutBtn;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.WebBrowser previewBlog;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
    }
}