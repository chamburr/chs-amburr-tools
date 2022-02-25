using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH_s_amburr
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private static string _username;
        MainForm MainForm = new MainForm();
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text == "")
            {
                _username = "Anonymous";
            }
            else _username = UsernameTextbox.Text;
            MessageBox.Show("Join our Discord server: https://discord.gg/TYe3U4w", "Welcome, " + Username);
            MainForm.Show();
            MainForm.ChangeUsername();
            this.Hide();
        }

        public static string Username
        {
            get { return _username; }
        }
    }
}
