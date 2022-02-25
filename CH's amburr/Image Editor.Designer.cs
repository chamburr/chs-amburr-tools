namespace CH_s_amburr
{
    partial class ImageEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageEditorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ThemeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LightThemeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkThemeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlueThemeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TouchThemeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.ImageEditor = new Telerik.WinControls.UI.RadImageEditor();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemeMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(778, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ThemeMenu
            // 
            this.ThemeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LightThemeMenuItem,
            this.DarkThemeMenuItem,
            this.BlueThemeMenuItem,
            this.TouchThemeMenuItem});
            this.ThemeMenu.Name = "ThemeMenu";
            this.ThemeMenu.Size = new System.Drawing.Size(87, 32);
            this.ThemeMenu.Text = "Theme";
            // 
            // LightThemeMenuItem
            // 
            this.LightThemeMenuItem.Name = "LightThemeMenuItem";
            this.LightThemeMenuItem.Size = new System.Drawing.Size(150, 32);
            this.LightThemeMenuItem.Text = "Light";
            this.LightThemeMenuItem.Click += new System.EventHandler(this.LightThemeMenuItem_Click);
            // 
            // DarkThemeMenuItem
            // 
            this.DarkThemeMenuItem.Name = "DarkThemeMenuItem";
            this.DarkThemeMenuItem.Size = new System.Drawing.Size(150, 32);
            this.DarkThemeMenuItem.Text = "Dark";
            this.DarkThemeMenuItem.Click += new System.EventHandler(this.DarkThemeMenuItem_Click);
            // 
            // BlueThemeMenuItem
            // 
            this.BlueThemeMenuItem.Name = "BlueThemeMenuItem";
            this.BlueThemeMenuItem.Size = new System.Drawing.Size(150, 32);
            this.BlueThemeMenuItem.Text = "Blue";
            this.BlueThemeMenuItem.Click += new System.EventHandler(this.BlueThemeMenuItem_Click);
            // 
            // TouchThemeMenuItem
            // 
            this.TouchThemeMenuItem.Name = "TouchThemeMenuItem";
            this.TouchThemeMenuItem.Size = new System.Drawing.Size(150, 32);
            this.TouchThemeMenuItem.Text = "Touch";
            this.TouchThemeMenuItem.Click += new System.EventHandler(this.TouchThemeMenuItem_Click);
            // 
            // ImageEditor
            // 
            this.ImageEditor.AllowDrop = true;
            this.ImageEditor.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImageEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageEditor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageEditor.Location = new System.Drawing.Point(0, 38);
            this.ImageEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImageEditor.Name = "ImageEditor";
            this.ImageEditor.Size = new System.Drawing.Size(778, 506);
            this.ImageEditor.TabIndex = 2;
            this.ImageEditor.Text = "radImageEditor1";
            this.ImageEditor.ThemeName = "Fluent";
            // 
            // ImageEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.ImageEditor);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ImageEditorForm";
            this.Text = "CH\'s amburr Tools --Image Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private System.Windows.Forms.ToolStripMenuItem ThemeMenu;
        private System.Windows.Forms.ToolStripMenuItem LightThemeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DarkThemeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlueThemeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TouchThemeMenuItem;
        private Telerik.WinControls.UI.RadImageEditor ImageEditor;
    }
}