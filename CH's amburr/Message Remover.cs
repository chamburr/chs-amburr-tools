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

namespace CH_s_amburr
{
    public partial class MessageRemoverForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        public MessageRemoverForm()
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

        private void Command(object sender, EventArgs e)
        {
            if (CommandButton.Text == "Start (F9)")
            {
                CommandButton.Text = "Stop (F9)";
                MessageRemoverTimer.Interval = Convert.ToInt32(IntervalSpinEditor.Value * 1000);
                StatusLabel.Text = "Status: Waiting";
                System.Threading.Thread.Sleep(5000);
                MessageRemoverTimer.Enabled = true;
                StatusLabel.Text = "Status: Running";
            }
            else if (CommandButton.Text == "Stop (F9)")
            {
                CommandButton.Text = "Start (f9)";
                MessageRemoverTimer.Enabled = false;
                StatusLabel.Text = "Status: Stopped";
            }
        }

        private void MessageRemoveTimer(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
            SendKeys.Send("^(a)");
            SendKeys.Send("{BACKSPACE}");
            SendKeys.Send("{ENTER 2}");
        }
    }
}
