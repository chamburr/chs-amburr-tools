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
    public partial class ImageEditorForm : Form
    {
        public ImageEditorForm()
        {
            InitializeComponent();
        }

        private void LightThemeMenuItem_Click(object sender, EventArgs e)
        {
            ImageEditor.ThemeName = "Fluent";
        }

        private void DarkThemeMenuItem_Click(object sender, EventArgs e)
        {
            ImageEditor.ThemeName = "FluentDark";
        }

        private void BlueThemeMenuItem_Click(object sender, EventArgs e)
        {
            ImageEditor.ThemeName = "TelerikMetroBlue";
        }

        private void TouchThemeMenuItem_Click(object sender, EventArgs e)
        {
            ImageEditor.ThemeName = "TelerikMetroTouch";
        }

        private void Font10MenuItem_Click(object sender, EventArgs e)
        {
            ImageEditor.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
        }

        private void Font11MenuItem_Click(object sender, EventArgs e)
        {
            ImageEditor.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
        }

        private void Font12MenuItem_Click(object sender, EventArgs e)
        {
            ImageEditor.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
        }

    }
}
