using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Demo
{
    

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(dark_background);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            demoForm LoginForm = new demoForm();
            LoginForm.Close();
            resetNav();
        }
        
        private void closeBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool mouseDown;
        private Point lastLocation;
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            
            Properties.Settings.Default.userName = "";
            Properties.Settings.Default.userPass = "";
            Properties.Settings.Default.Save();

            ActiveForm.Hide();
            demoForm LoginForm = new demoForm();
            LoginForm.Show();
        }


        public Panel navActive;

        private void navHome_Click(object sender, EventArgs e)
        {
            if(navActive != homePanel) 
            {           
                navActive.Visible = false;
                homePanel.Visible = true;
                homePanel.Location = new Point(12, 68);
                navActive = homePanel;
            }
        }

        private void navCreate_Click(object sender, EventArgs e)
        {
            if (navActive != createPanel)
            {
                navActive.Visible = false;
                createPanel.Visible = true;
                createPanel.Location = new Point(12, 68);
                navActive = createPanel;
            }
        }

        private void navAbout_Click(object sender, EventArgs e)
        {
            if (navActive != aboutPanel)
            {
                navActive.Visible = false;
                aboutPanel.Visible = true;
                aboutPanel.Location = new Point(12, 68);
                navActive = aboutPanel;
            }
        }

        private void navSettings_Click(object sender, EventArgs e)
        {
            if (navActive != settingsPanel) 
            { 
                navActive.Visible = false;
                settingsPanel.Visible = true;
                settingsPanel.Location = new Point(12, 68);
                navActive = settingsPanel;
            }
        }

        public void resetNav()
        {
            navActive = homePanel;
            homePanel.Visible = true;
            homePanel.Location = new Point(12, 68);
            createPanel.Visible = false;
            aboutPanel.Visible = false;
            settingsPanel.Visible = false;
        }


        Request request = new Request();
        static string PostURL, responce;

        private void blogPostBtn_Click(object sender, EventArgs e)
        {
            if(blogTitle.Texts != string.Empty || blogContent.Texts != string.Empty)
            {
                PostURL = "https://ceneje.org/csharp/csharp.php?title=" + blogTitle.Texts + "&content=" + blogContent.Texts;
                responce = request.Get(PostURL);

                MessageBox.Show("Post Created");
            } else
                MessageBox.Show("Title and Content must not be empty!");
        }

        public Graphics graphics;
        public Rectangle gradient_rectangle;
        public Brush brush;

        private void blogContent__TextChanged(object sender, EventArgs e)
        {
            previewBlog.DocumentText = blogContent.Texts;
        }

        private void dark_background(Object sender, PaintEventArgs e)          
        {
            graphics = e.Graphics;

            gradient_rectangle = new Rectangle(0, 0, Width, Height);

            brush = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(20, 20, 20), 65f);

            graphics.FillRectangle(brush, gradient_rectangle);
        }
        /*
        private void light_background(Object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;

            gradient_rectangle = new Rectangle(0, 0, Width, Height);

            brush = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(189, 195, 199), Color.WhiteSmoke, 65f);

            graphics.FillRectangle(brush, gradient_rectangle);
        }
        

        public bool lightTheme = false;
        private void themeBtn_Click(object sender, EventArgs e)
        {
            if (!lightTheme)
            {
                lightTheme = true;
                backgroundPanel.BackColor = Color.WhiteSmoke;
                themeBtn.Text = "Switch to Dark";
                themeBtn.IconChar = FontAwesome.Sharp.IconChar.Moon;
            }
            else
            {
                lightTheme = false;
                backgroundPanel.BackColor = Color.FromArgb(20,20,20);
                themeBtn.Text = "Switch to Light";
                themeBtn.IconChar = FontAwesome.Sharp.IconChar.Sun;
                themeBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            }
        }
        */
    }
}
