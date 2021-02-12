using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace CH_s_amburr
{
    public partial class SpammerForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        public SpammerForm()
        {
            InitializeComponent();
            int UniqueHotkeyId = 1;
            int HotKeyCode = (int)Keys.F9;
            bool F9Registered = RegisterHotKey(
                this.Handle, UniqueHotkeyId, 0x0000, HotKeyCode
            );
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();

                if (id == 1)
                {
                    CommandButton.PerformClick();
                }
            }

            base.WndProc(ref m);
        }

        private void EnterAdd(object sender, KeyPressEventArgs e)
        {
            Char intervalkey = e.KeyChar;
            if (intervalkey == 13)
            {
                e.Handled = true;
                AddSpamContentButton.PerformClick();
            }
        }

        private void PlaceholderText(object sender, EventArgs e)
        {
            if (AddSpamContentTextBox.Text == "Enter text here...")
            {
                AddSpamContentTextBox.Text = "";
            }
        }

        private void PlaceholderText1(object sender, EventArgs e)
        {
            if (AddSpamContentTextBox.Text == "")
            {
                AddSpamContentTextBox.Text = "Enter text here...";
            }
        }

        private List<string> SpamTextList = new List<string>();
        private void AddSpamContent(object sender, EventArgs e)
        {
            SpamTextList.Add(AddSpamContentTextBox.Text);
            SpamContentTextBox.Text = "";
            foreach (string _SpamText in SpamTextList)
            {
                SpamContentTextBox.AppendText(_SpamText + "\n");
            }
            AddSpamContentTextBox.Text = "Enter text here...";
            BindingSource SpamBindingSource = new BindingSource
            {
                DataSource = SpamTextList
            };
            RemoveSpamContentComboBox.DataSource = SpamBindingSource;
        }

        private void RemoveSpamContent(object sender, EventArgs e)
        {
            SpamTextList.Remove(RemoveSpamContentComboBox.Text);
            RemoveSpamContentComboBox.Text = "";
            SpamContentTextBox.Text = "";
            foreach (string _SpamText in SpamTextList)
            {
                SpamContentTextBox.AppendText(_SpamText + "\n");
            }
            BindingSource SpamBindingSource = new BindingSource
            {
                DataSource = SpamTextList
            };
            RemoveSpamContentComboBox.DataSource = SpamBindingSource;
        }

        private void SpamTimer_Tick(object sender, EventArgs e)
        {
            string SpamText = SpamTextList[line];
            SendKeys.Send(SpamText + support);
            SendKeys.Send("{Enter}");
            line++;
            if (line == SpamTextList.Count)
            {
                line = 0;
            }
        }

        private void RandomSpamTimer_Tick(object sender, EventArgs e)
        {
            randomline = rnd.Next(0, SpamTextList.Count);
            string SpamText = SpamTextList[randomline];
            SendKeys.Send(SpamText + support);
            SendKeys.Send("{ENTER}");
        }

        private Random rnd = new Random();
        private int line;
        private int randomline;
        private string support;
        private void StartStopSpam(object sender, EventArgs e)
        {
            line = 0;
            if (SupportCheckBox.Checked == false)
            {
                support = "";
            }
            else support = "Created by CHamburr#2591. Join us here: https://discord.gg/TYe3U4w";
            int SpamInterval = Convert.ToInt32(IntervalSpinEditor.Value * 1000);
            SpamTimer.Interval = SpamInterval;
            RandomSpamTimer.Interval = SpamInterval;
            if (CommandButton.Text == "Start (F9)")
            {
                CommandButton.Text = "Stop (F9)";
                AddSpamContentButton.Enabled = false;
                RemoveSpamContentComboBox.Enabled = false;
                RemoveSpamContentButton.Enabled = false;
                SupportCheckBox.Enabled = false;
                IntervalSpinEditor.Enabled = false;
                ClearButton.Enabled = false;
                InOrderRadioButton.Enabled = false;
                RandomRadioButton.Enabled = false;
                AddSpamContentTextBox.Enabled = false;
                if (RandomRadioButton.Checked == true)
                {
                    RandomSpamTimer.Enabled = true;
                }
                else if (InOrderRadioButton.Checked == true)
                {
                    SpamTimer.Enabled = true;
                }
            }
            else if (CommandButton.Text == "Stop (F9)")
            {
                CommandButton.Text = "Start (F9)";
                AddSpamContentButton.Enabled = true;
                RemoveSpamContentComboBox.Enabled = true;
                RemoveSpamContentButton.Enabled = true;
                SupportCheckBox.Enabled = true;
                IntervalSpinEditor.Enabled = true;
                ClearButton.Enabled = true;
                InOrderRadioButton.Enabled = true;
                RandomRadioButton.Enabled = true;
                RandomSpamTimer.Enabled = false;
                DiscordSpamTimer.Enabled = false;
                DiscordRandomSpamTimer.Enabled = false;
                AddSpamContentTextBox.Enabled = true;
                SpamTimer.Enabled = false;
            }
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        public static IntPtr FindWindow(string caption)
        {
            return FindWindow(string.Empty, caption);
        }

        private void Clear(object sender, EventArgs e)
        {
            SpamTextList.Clear();
            RemoveSpamContentComboBox.Text = "";
            SpamContentTextBox.Text = "";
            BindingSource SpamBindingSource = new BindingSource
            {
                DataSource = SpamTextList
            };
            RemoveSpamContentComboBox.DataSource = SpamBindingSource;
        }

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

        private void TestButton_Click(object sender, EventArgs e)
        {
            Process[] procs = Process.GetProcesses();
            foreach (Process p in procs)
            {
                if (p.ProcessName.Equals("Discord"))
                {
                    var ProgramID = p.Id;
                    MessageBox.Show("SUCCESS");
                }
            }
            
        }

        private void PIDTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char intervalkey = e.KeyChar;
            if (!Char.IsDigit(intervalkey) && intervalkey != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid PID.", "Error");
            }
        }

        private void SpellChecker(object sender, EventArgs e)
        {
            if (SpellCheckerCheckBox.Checked == false)
            {
                radSpellChecker1.AutoSpellCheckControl = null;
            }
            else radSpellChecker1.AutoSpellCheckControl = AddSpamContentTextBox;

        }

        private void PIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
