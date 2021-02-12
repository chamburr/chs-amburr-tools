namespace CH_s_amburr
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.Panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.AlwaysOnTopButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.AlwaysOnTopButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ExitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MenuPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.MenuPictureBox2 = new System.Windows.Forms.PictureBox();
            this.MenuPictureBox = new System.Windows.Forms.PictureBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.GamesButton = new System.Windows.Forms.Button();
            this.ToolsButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.PokemonFinderButton = new System.Windows.Forms.Button();
            this.PDFViewerButton = new System.Windows.Forms.Button();
            this.TextEditorButton = new System.Windows.Forms.Button();
            this.MessageRemoverButton = new System.Windows.Forms.Button();
            this.SpammerButton = new System.Windows.Forms.Button();
            this.ImageEditorButton = new System.Windows.Forms.Button();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.GamesPanel = new System.Windows.Forms.Panel();
            this.ConwayButton = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.SettingsComingSoonLabel = new System.Windows.Forms.Label();
            this.ThemeGroupBox = new System.Windows.Forms.GroupBox();
            this.LightThemeRadioButton = new System.Windows.Forms.RadioButton();
            this.DarkThemeRadioButton = new System.Windows.Forms.RadioButton();
            this.BugSuggestionsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DiscordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.HelpTipsButton = new System.Windows.Forms.Button();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlwaysOnTopButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlwaysOnTopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBox2)).BeginInit();
            this.MenuPictureBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBox)).BeginInit();
            this.ToolsPanel.SuspendLayout();
            this.GamesPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.ThemeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.ImageActive = null;
            this.MinimizeButton.Location = new System.Drawing.Point(570, 3);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(35, 35);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.TabStop = false;
            this.toolTip1.SetToolTip(this.MinimizeButton, "Minimize");
            this.MinimizeButton.Zoom = 10;
            this.MinimizeButton.Click += new System.EventHandler(this.Minimize);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.Transparent;
            this.TitlePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TitlePanel.BackgroundImage")));
            this.TitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TitlePanel.Controls.Add(this.AlwaysOnTopButton2);
            this.TitlePanel.Controls.Add(this.AlwaysOnTopButton);
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Controls.Add(this.ExitButton);
            this.TitlePanel.Controls.Add(this.MinimizeButton);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.GradientBottomLeft = System.Drawing.Color.Red;
            this.TitlePanel.GradientBottomRight = System.Drawing.Color.OrangeRed;
            this.TitlePanel.GradientTopLeft = System.Drawing.Color.Orange;
            this.TitlePanel.GradientTopRight = System.Drawing.Color.RoyalBlue;
            this.TitlePanel.Location = new System.Drawing.Point(130, 0);
            this.TitlePanel.Margin = new System.Windows.Forms.Padding(2);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Quality = 10;
            this.TitlePanel.Size = new System.Drawing.Size(670, 40);
            this.TitlePanel.TabIndex = 2;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // AlwaysOnTopButton2
            // 
            this.AlwaysOnTopButton2.BackColor = System.Drawing.Color.Transparent;
            this.AlwaysOnTopButton2.Image = ((System.Drawing.Image)(resources.GetObject("AlwaysOnTopButton2.Image")));
            this.AlwaysOnTopButton2.ImageActive = null;
            this.AlwaysOnTopButton2.Location = new System.Drawing.Point(520, 3);
            this.AlwaysOnTopButton2.Margin = new System.Windows.Forms.Padding(2);
            this.AlwaysOnTopButton2.Name = "AlwaysOnTopButton2";
            this.AlwaysOnTopButton2.Size = new System.Drawing.Size(35, 35);
            this.AlwaysOnTopButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlwaysOnTopButton2.TabIndex = 5;
            this.AlwaysOnTopButton2.TabStop = false;
            this.toolTip1.SetToolTip(this.AlwaysOnTopButton2, "Always-on-top");
            this.AlwaysOnTopButton2.Visible = false;
            this.AlwaysOnTopButton2.Zoom = 10;
            this.AlwaysOnTopButton2.Click += new System.EventHandler(this.AlwaysOnTop);
            // 
            // AlwaysOnTopButton
            // 
            this.AlwaysOnTopButton.BackColor = System.Drawing.Color.Transparent;
            this.AlwaysOnTopButton.Image = ((System.Drawing.Image)(resources.GetObject("AlwaysOnTopButton.Image")));
            this.AlwaysOnTopButton.ImageActive = null;
            this.AlwaysOnTopButton.Location = new System.Drawing.Point(520, 3);
            this.AlwaysOnTopButton.Margin = new System.Windows.Forms.Padding(2);
            this.AlwaysOnTopButton.Name = "AlwaysOnTopButton";
            this.AlwaysOnTopButton.Size = new System.Drawing.Size(35, 35);
            this.AlwaysOnTopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlwaysOnTopButton.TabIndex = 4;
            this.AlwaysOnTopButton.TabStop = false;
            this.toolTip1.SetToolTip(this.AlwaysOnTopButton, "Always-on-top");
            this.AlwaysOnTopButton.Zoom = 10;
            this.AlwaysOnTopButton.Click += new System.EventHandler(this.AlwaysOnTop);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(221, 5);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(177, 28);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "CH\'s amburr Tools";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageActive = null;
            this.ExitButton.Location = new System.Drawing.Point(620, 3);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(35, 35);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 2;
            this.ExitButton.TabStop = false;
            this.toolTip1.SetToolTip(this.ExitButton, "Exit");
            this.ExitButton.Zoom = 10;
            this.ExitButton.Click += new System.EventHandler(this.Exit);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuPanel.BackgroundImage")));
            this.MenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuPanel.Controls.Add(this.MenuPictureBox2);
            this.MenuPanel.Controls.Add(this.SettingsButton);
            this.MenuPanel.Controls.Add(this.GamesButton);
            this.MenuPanel.Controls.Add(this.ToolsButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.GradientBottomLeft = System.Drawing.Color.DarkViolet;
            this.MenuPanel.GradientBottomRight = System.Drawing.Color.Red;
            this.MenuPanel.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.MenuPanel.GradientTopRight = System.Drawing.Color.Blue;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Quality = 10;
            this.MenuPanel.Size = new System.Drawing.Size(130, 450);
            this.MenuPanel.TabIndex = 3;
            // 
            // MenuPictureBox2
            // 
            this.MenuPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.MenuPictureBox2.Controls.Add(this.MenuPictureBox);
            this.MenuPictureBox2.Controls.Add(this.WelcomeLabel);
            this.MenuPictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("MenuPictureBox2.Image")));
            this.MenuPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.MenuPictureBox2.Name = "MenuPictureBox2";
            this.MenuPictureBox2.Size = new System.Drawing.Size(130, 120);
            this.MenuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuPictureBox2.TabIndex = 8;
            this.MenuPictureBox2.TabStop = false;
            // 
            // MenuPictureBox
            // 
            this.MenuPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.MenuPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MenuPictureBox.Image")));
            this.MenuPictureBox.Location = new System.Drawing.Point(35, 3);
            this.MenuPictureBox.Name = "MenuPictureBox";
            this.MenuPictureBox.Size = new System.Drawing.Size(50, 50);
            this.MenuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuPictureBox.TabIndex = 7;
            this.MenuPictureBox.TabStop = false;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(0, 55);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(130, 60);
            this.WelcomeLabel.TabIndex = 6;
            this.WelcomeLabel.Text = "Welcome,\r\nAnonymous\r\n";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Location = new System.Drawing.Point(0, 250);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(130, 60);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.ChangePanel);
            // 
            // GamesButton
            // 
            this.GamesButton.BackColor = System.Drawing.Color.Transparent;
            this.GamesButton.FlatAppearance.BorderSize = 0;
            this.GamesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.GamesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.GamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GamesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamesButton.ForeColor = System.Drawing.Color.White;
            this.GamesButton.Location = new System.Drawing.Point(0, 190);
            this.GamesButton.Name = "GamesButton";
            this.GamesButton.Size = new System.Drawing.Size(130, 60);
            this.GamesButton.TabIndex = 5;
            this.GamesButton.Text = "Games";
            this.GamesButton.UseVisualStyleBackColor = false;
            this.GamesButton.Click += new System.EventHandler(this.ChangePanel);
            // 
            // ToolsButton
            // 
            this.ToolsButton.BackColor = System.Drawing.Color.Transparent;
            this.ToolsButton.FlatAppearance.BorderSize = 0;
            this.ToolsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.ToolsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.ToolsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolsButton.ForeColor = System.Drawing.Color.White;
            this.ToolsButton.Location = new System.Drawing.Point(0, 130);
            this.ToolsButton.Name = "ToolsButton";
            this.ToolsButton.Size = new System.Drawing.Size(130, 60);
            this.ToolsButton.TabIndex = 4;
            this.ToolsButton.Text = "Tools";
            this.ToolsButton.UseVisualStyleBackColor = false;
            this.ToolsButton.Click += new System.EventHandler(this.ChangePanel);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.Controls.Add(this.PokemonFinderButton);
            this.ToolsPanel.Controls.Add(this.PDFViewerButton);
            this.ToolsPanel.Controls.Add(this.TextEditorButton);
            this.ToolsPanel.Controls.Add(this.MessageRemoverButton);
            this.ToolsPanel.Controls.Add(this.SpammerButton);
            this.ToolsPanel.Controls.Add(this.ImageEditorButton);
            this.ToolsPanel.Location = new System.Drawing.Point(130, 40);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(670, 410);
            this.ToolsPanel.TabIndex = 4;
            // 
            // PokemonFinderButton
            // 
            this.PokemonFinderButton.BackColor = System.Drawing.Color.Gold;
            this.PokemonFinderButton.FlatAppearance.BorderSize = 0;
            this.PokemonFinderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PokemonFinderButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokemonFinderButton.ForeColor = System.Drawing.Color.White;
            this.PokemonFinderButton.Location = new System.Drawing.Point(345, 286);
            this.PokemonFinderButton.Name = "PokemonFinderButton";
            this.PokemonFinderButton.Size = new System.Drawing.Size(210, 60);
            this.PokemonFinderButton.TabIndex = 13;
            this.PokemonFinderButton.Text = "Pokémon Finder";
            this.PokemonFinderButton.UseVisualStyleBackColor = false;
            this.PokemonFinderButton.Click += new System.EventHandler(this.PokemonFinderButton_Click);
            // 
            // PDFViewerButton
            // 
            this.PDFViewerButton.BackColor = System.Drawing.Color.DeepPink;
            this.PDFViewerButton.FlatAppearance.BorderSize = 0;
            this.PDFViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PDFViewerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDFViewerButton.ForeColor = System.Drawing.Color.White;
            this.PDFViewerButton.Location = new System.Drawing.Point(95, 286);
            this.PDFViewerButton.Name = "PDFViewerButton";
            this.PDFViewerButton.Size = new System.Drawing.Size(210, 60);
            this.PDFViewerButton.TabIndex = 12;
            this.PDFViewerButton.Text = "PDF Viewer";
            this.PDFViewerButton.UseVisualStyleBackColor = false;
            this.PDFViewerButton.Click += new System.EventHandler(this.PDFViewer);
            // 
            // TextEditorButton
            // 
            this.TextEditorButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.TextEditorButton.FlatAppearance.BorderSize = 0;
            this.TextEditorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextEditorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEditorButton.ForeColor = System.Drawing.Color.White;
            this.TextEditorButton.Location = new System.Drawing.Point(345, 174);
            this.TextEditorButton.Name = "TextEditorButton";
            this.TextEditorButton.Size = new System.Drawing.Size(210, 60);
            this.TextEditorButton.TabIndex = 11;
            this.TextEditorButton.Text = "Text Editor";
            this.TextEditorButton.UseVisualStyleBackColor = false;
            this.TextEditorButton.Click += new System.EventHandler(this.TextEditor);
            // 
            // MessageRemoverButton
            // 
            this.MessageRemoverButton.BackColor = System.Drawing.Color.LimeGreen;
            this.MessageRemoverButton.FlatAppearance.BorderSize = 0;
            this.MessageRemoverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageRemoverButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageRemoverButton.ForeColor = System.Drawing.Color.White;
            this.MessageRemoverButton.Location = new System.Drawing.Point(345, 64);
            this.MessageRemoverButton.Name = "MessageRemoverButton";
            this.MessageRemoverButton.Size = new System.Drawing.Size(210, 60);
            this.MessageRemoverButton.TabIndex = 10;
            this.MessageRemoverButton.Text = "Message Remover";
            this.MessageRemoverButton.UseVisualStyleBackColor = false;
            this.MessageRemoverButton.Click += new System.EventHandler(this.MessageRemover);
            // 
            // SpammerButton
            // 
            this.SpammerButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SpammerButton.FlatAppearance.BorderSize = 0;
            this.SpammerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpammerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpammerButton.ForeColor = System.Drawing.Color.White;
            this.SpammerButton.Location = new System.Drawing.Point(95, 64);
            this.SpammerButton.Name = "SpammerButton";
            this.SpammerButton.Size = new System.Drawing.Size(210, 60);
            this.SpammerButton.TabIndex = 9;
            this.SpammerButton.Text = "Spammer";
            this.SpammerButton.UseVisualStyleBackColor = false;
            this.SpammerButton.Click += new System.EventHandler(this.Spammer);
            // 
            // ImageEditorButton
            // 
            this.ImageEditorButton.BackColor = System.Drawing.Color.OrangeRed;
            this.ImageEditorButton.FlatAppearance.BorderSize = 0;
            this.ImageEditorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageEditorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageEditorButton.ForeColor = System.Drawing.Color.White;
            this.ImageEditorButton.Location = new System.Drawing.Point(95, 174);
            this.ImageEditorButton.Name = "ImageEditorButton";
            this.ImageEditorButton.Size = new System.Drawing.Size(210, 60);
            this.ImageEditorButton.TabIndex = 8;
            this.ImageEditorButton.Text = "Image Editor";
            this.ImageEditorButton.UseVisualStyleBackColor = false;
            this.ImageEditorButton.Click += new System.EventHandler(this.ImageEditor);
            // 
            // GamesPanel
            // 
            this.GamesPanel.Controls.Add(this.ConwayButton);
            this.GamesPanel.Location = new System.Drawing.Point(130, 40);
            this.GamesPanel.Name = "GamesPanel";
            this.GamesPanel.Size = new System.Drawing.Size(670, 410);
            this.GamesPanel.TabIndex = 12;
            // 
            // ConwayButton
            // 
            this.ConwayButton.BackColor = System.Drawing.Color.OrangeRed;
            this.ConwayButton.FlatAppearance.BorderSize = 0;
            this.ConwayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConwayButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConwayButton.ForeColor = System.Drawing.Color.White;
            this.ConwayButton.Location = new System.Drawing.Point(200, 150);
            this.ConwayButton.Name = "ConwayButton";
            this.ConwayButton.Size = new System.Drawing.Size(260, 60);
            this.ConwayButton.TabIndex = 8;
            this.ConwayButton.Text = "Conway\'s Game of Life";
            this.ConwayButton.UseVisualStyleBackColor = false;
            this.ConwayButton.Click += new System.EventHandler(this.Conway);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.SettingsComingSoonLabel);
            this.SettingsPanel.Controls.Add(this.ThemeGroupBox);
            this.SettingsPanel.Controls.Add(this.BugSuggestionsLabel);
            this.SettingsPanel.Controls.Add(this.pictureBox1);
            this.SettingsPanel.Controls.Add(this.DiscordLinkLabel);
            this.SettingsPanel.Controls.Add(this.HelpTipsButton);
            this.SettingsPanel.Controls.Add(this.SettingsLabel);
            this.SettingsPanel.Controls.Add(this.AboutButton);
            this.SettingsPanel.Location = new System.Drawing.Point(130, 40);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(670, 410);
            this.SettingsPanel.TabIndex = 13;
            this.SettingsPanel.Visible = false;
            // 
            // SettingsComingSoonLabel
            // 
            this.SettingsComingSoonLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsComingSoonLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsComingSoonLabel.ForeColor = System.Drawing.Color.Black;
            this.SettingsComingSoonLabel.Location = new System.Drawing.Point(46, 237);
            this.SettingsComingSoonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SettingsComingSoonLabel.Name = "SettingsComingSoonLabel";
            this.SettingsComingSoonLabel.Size = new System.Drawing.Size(305, 148);
            this.SettingsComingSoonLabel.TabIndex = 37;
            this.SettingsComingSoonLabel.Text = "This program is discontinued. Find out more by joining the Discord community.";
            this.SettingsComingSoonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThemeGroupBox
            // 
            this.ThemeGroupBox.Controls.Add(this.LightThemeRadioButton);
            this.ThemeGroupBox.Controls.Add(this.DarkThemeRadioButton);
            this.ThemeGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeGroupBox.Location = new System.Drawing.Point(46, 101);
            this.ThemeGroupBox.Name = "ThemeGroupBox";
            this.ThemeGroupBox.Size = new System.Drawing.Size(305, 98);
            this.ThemeGroupBox.TabIndex = 34;
            this.ThemeGroupBox.TabStop = false;
            this.ThemeGroupBox.Text = "Theme";
            // 
            // LightThemeRadioButton
            // 
            this.LightThemeRadioButton.AutoSize = true;
            this.LightThemeRadioButton.Checked = true;
            this.LightThemeRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightThemeRadioButton.Location = new System.Drawing.Point(12, 40);
            this.LightThemeRadioButton.Name = "LightThemeRadioButton";
            this.LightThemeRadioButton.Size = new System.Drawing.Size(83, 32);
            this.LightThemeRadioButton.TabIndex = 31;
            this.LightThemeRadioButton.TabStop = true;
            this.LightThemeRadioButton.Text = "Light";
            this.LightThemeRadioButton.UseVisualStyleBackColor = true;
            this.LightThemeRadioButton.CheckedChanged += new System.EventHandler(this.ChangeTheme);
            // 
            // DarkThemeRadioButton
            // 
            this.DarkThemeRadioButton.AutoSize = true;
            this.DarkThemeRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarkThemeRadioButton.Location = new System.Drawing.Point(150, 40);
            this.DarkThemeRadioButton.Name = "DarkThemeRadioButton";
            this.DarkThemeRadioButton.Size = new System.Drawing.Size(79, 32);
            this.DarkThemeRadioButton.TabIndex = 32;
            this.DarkThemeRadioButton.Text = "Dark";
            this.DarkThemeRadioButton.UseVisualStyleBackColor = true;
            this.DarkThemeRadioButton.CheckedChanged += new System.EventHandler(this.ChangeTheme);
            // 
            // BugSuggestionsLabel
            // 
            this.BugSuggestionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.BugSuggestionsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BugSuggestionsLabel.ForeColor = System.Drawing.Color.Black;
            this.BugSuggestionsLabel.Location = new System.Drawing.Point(395, 20);
            this.BugSuggestionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BugSuggestionsLabel.Name = "BugSuggestionsLabel";
            this.BugSuggestionsLabel.Size = new System.Drawing.Size(260, 104);
            this.BugSuggestionsLabel.TabIndex = 14;
            this.BugSuggestionsLabel.Text = "Show us some support by joining our official Discord server below. Thanks!";
            this.BugSuggestionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(476, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // DiscordLinkLabel
            // 
            this.DiscordLinkLabel.AutoSize = true;
            this.DiscordLinkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscordLinkLabel.Location = new System.Drawing.Point(404, 213);
            this.DiscordLinkLabel.Name = "DiscordLinkLabel";
            this.DiscordLinkLabel.Size = new System.Drawing.Size(232, 28);
            this.DiscordLinkLabel.TabIndex = 12;
            this.DiscordLinkLabel.TabStop = true;
            this.DiscordLinkLabel.Text = "Join Discord community";
            this.DiscordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DiscordLink);
            // 
            // HelpTipsButton
            // 
            this.HelpTipsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.HelpTipsButton.FlatAppearance.BorderSize = 0;
            this.HelpTipsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpTipsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpTipsButton.ForeColor = System.Drawing.Color.White;
            this.HelpTipsButton.Location = new System.Drawing.Point(395, 272);
            this.HelpTipsButton.Name = "HelpTipsButton";
            this.HelpTipsButton.Size = new System.Drawing.Size(260, 60);
            this.HelpTipsButton.TabIndex = 10;
            this.HelpTipsButton.Text = "Help";
            this.HelpTipsButton.UseVisualStyleBackColor = false;
            this.HelpTipsButton.Click += new System.EventHandler(this.HelpTips);
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.ForeColor = System.Drawing.Color.Black;
            this.SettingsLabel.Location = new System.Drawing.Point(71, 20);
            this.SettingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(210, 60);
            this.SettingsLabel.TabIndex = 9;
            this.SettingsLabel.Text = "Settings";
            this.SettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.OrangeRed;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Location = new System.Drawing.Point(395, 338);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(260, 60);
            this.AboutButton.TabIndex = 8;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutBox);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToolsPanel);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.GamesPanel);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.Text = "CH\'s amburr";
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlwaysOnTopButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlwaysOnTopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBox2)).EndInit();
            this.MenuPictureBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuPictureBox)).EndInit();
            this.ToolsPanel.ResumeLayout(false);
            this.GamesPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ThemeGroupBox.ResumeLayout(false);
            this.ThemeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton MinimizeButton;
        private Bunifu.Framework.UI.BunifuGradientPanel TitlePanel;
        private System.Windows.Forms.Label TitleLabel;
        private Bunifu.Framework.UI.BunifuImageButton ExitButton;
        private Bunifu.Framework.UI.BunifuGradientPanel MenuPanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuImageButton AlwaysOnTopButton2;
        private Bunifu.Framework.UI.BunifuImageButton AlwaysOnTopButton;
        private System.Windows.Forms.PictureBox MenuPictureBox;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button GamesButton;
        private System.Windows.Forms.Button ToolsButton;
        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.Button ImageEditorButton;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.Button MessageRemoverButton;
        private System.Windows.Forms.Button SpammerButton;
        private System.Windows.Forms.Button TextEditorButton;
        private System.Windows.Forms.PictureBox MenuPictureBox2;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Panel GamesPanel;
        private System.Windows.Forms.Button ConwayButton;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button PDFViewerButton;
        private System.Windows.Forms.LinkLabel DiscordLinkLabel;
        private System.Windows.Forms.Button HelpTipsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BugSuggestionsLabel;
        private System.Windows.Forms.GroupBox ThemeGroupBox;
        private System.Windows.Forms.RadioButton LightThemeRadioButton;
        private System.Windows.Forms.RadioButton DarkThemeRadioButton;
        private System.Windows.Forms.Label SettingsComingSoonLabel;
        private System.Windows.Forms.Button PokemonFinderButton;
    }
}
