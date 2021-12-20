using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class demoForm : Form
    {
        // Database db = new Database();    Za class Database, ki je inactive zaradi varnosti
        encode encode = new encode();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public demoForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        Request request = new Request();
        static string PasswordURL, responce, encrypted;

        private void loginBtn_Click(object sender, EventArgs e)
        {
            PasswordURL = "https://ceneje.org/csharp/csharp.php?user=" + username.Texts;
            responce = request.Get(PasswordURL);
            

            if (!(String.IsNullOrEmpty(responce)))
            {
                encrypted = encode.MD5Encode(password.Texts, responce);
                if (responce == encrypted)
                { 
                    if (rememberMe.Checked)
                    {
                        Properties.Settings.Default.userName = username.Texts;
                        Properties.Settings.Default.userPass = password.Texts;
                        Properties.Settings.Default.Save();
                    }
                    // MessageBox.Show("Success You will Log in as " + username.Text);
                    this.Hide();
                    MainForm MainForm = new MainForm();
                    MainForm.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username and password combination");
                }

            } else
            {
                MessageBox.Show("The username you provided does not exist!");
            }
            
        }

        private void demoForm_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.userName != string.Empty)
            {
                username.Texts = Properties.Settings.Default.userName;
                password.Texts = Properties.Settings.Default.userPass;
            }

            /* Da se izogleš login screenu!
             * this.Hide();
             * MainForm MainForm = new MainForm();
             * MainForm.Show();
             */

        }

        private bool mouseDown;
        private Point lastLocation;
        private void demoForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ceneje.org/wp-login.php?action=register");
        }

        private void demoForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void demoForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

    }
}
