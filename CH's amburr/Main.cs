using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Telerik.WinControls;

namespace CH_s_amburr
{
    public partial class MainForm : Form
    {

        private string Username()
        {
            return LoginForm.Username;
        }
        public MainForm()
        {
            InitializeComponent();
        }
        
        public void ChangeUsername()
        {
            WelcomeLabel.Text = "Welcome,\n" + Username();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AlwaysOnTop(object sender, EventArgs e)
        {
            FormCollection formCollection = Application.OpenForms;
            if (TopMost == false)
            {
                foreach (Form form in formCollection)
                {
                    form.TopMost = true;
                }
                AlwaysOnTopButton2.Visible = true;
            }
            else
            {
                foreach (Form form in formCollection)
                {
                    form.TopMost = false;
                }
                AlwaysOnTopButton2.Visible = false;
            }
        }

        private void Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;
        private void MoveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
            else lastPoint = new Point(e.X, e.Y);
        }

        private void ChangePanel(object sender, EventArgs e)
        {
            ToolsPanel.Visible = false;
            GamesPanel.Visible = false;
            SettingsPanel.Visible = false;
            if (sender == ToolsButton)
            {
                ToolsPanel.Visible = true;
            }
            else if (sender == GamesButton)
            {
                GamesPanel.Visible = true;
            }
            else if (sender == SettingsButton)
            {
                SettingsPanel.Visible = true;
            }
        }

        private ImageEditorForm ImageEditorForm;
        private void ImageEditor(object sender, EventArgs e)
        {
            ImageEditorForm = new ImageEditorForm();
            ImageEditorForm.Show();
            ImageEditorForm.BringToFront();
        }

        private TextEditorForm TextEditorForm;
        private void TextEditor(object sender, EventArgs e)
        {
            TextEditorForm = new TextEditorForm();
            TextEditorForm.Show();
            TextEditorForm.BringToFront();
        }

        private SpammerForm SpammerForm;
        private void Spammer(object sender, EventArgs e)
        {
            SpammerForm = new SpammerForm();
            SpammerForm.Show();
            SpammerForm.BringToFront();
        }

        private ConwayForm ConwayForm;
        private void Conway(object sender, EventArgs e)
        {
            ConwayForm = new ConwayForm();
            ConwayForm.Show();
            ConwayForm.BringToFront();
        }

        private PDFViewerForm PDFViewerForm;
        private void PDFViewer(object sender, EventArgs e)
        {
            PDFViewerForm = new PDFViewerForm();
            PDFViewerForm.Show();
            PDFViewerForm.BringToFront();
        }

        private AboutBoxForm AboutBoxForm;
        private void AboutBox(object sender, EventArgs e)
        {
            AboutBoxForm = new AboutBoxForm();
            AboutBoxForm.Show();
            AboutBoxForm.BringToFront();
        }

        private void DiscordLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://discord.gg/TYe3U4w");
            int j = 1;
            int charj = Convert.ToChar(j);
        }

        private MessageRemoverForm MessageRemoverForm;
        private void MessageRemover(object sender, EventArgs e)
        {
            MessageRemoverForm = new MessageRemoverForm();
            MessageRemoverForm.Show();
            MessageRemoverForm.BringToFront();
        }

        private Color brush;
        private void ChangeTheme(object sender, EventArgs e)
        {
            if (LightThemeRadioButton.Checked == true)
            {
                ToolsPanel.BackColor = Color.FromKnownColor(KnownColor.Control);
                GamesPanel.BackColor = Color.FromKnownColor(KnownColor.Control);
                SettingsPanel.BackColor = Color.FromKnownColor(KnownColor.Control);
                brush = Color.Black;
            }
            else if (DarkThemeRadioButton.Checked == true)
            {
                ToolsPanel.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                GamesPanel.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                SettingsPanel.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                brush = Color.White;
            }
            BugSuggestionsLabel.ForeColor = brush;
            SettingsLabel.ForeColor = brush;
            ThemeGroupBox.ForeColor = brush;
            DarkThemeRadioButton.ForeColor = brush;
            LightThemeRadioButton.ForeColor = brush;
            SettingsComingSoonLabel.ForeColor = brush;
        }

        private void HelpTips(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\Manual.pdf");
        }

        private void PokemonFinderButton_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\FindSimilarImage.exe");
        }
    }
}
