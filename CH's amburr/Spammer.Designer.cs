namespace CH_s_amburr
{
    partial class SpammerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpammerForm));
            this.CommandButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddSpamContentTextBox = new System.Windows.Forms.TextBox();
            this.SpamContentTextBox = new System.Windows.Forms.TextBox();
            this.AddSpamContentButton = new System.Windows.Forms.Button();
            this.RemoveSpamContentComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveSpamContentButton = new System.Windows.Forms.Button();
            this.IntervalSpinEditor = new Telerik.WinControls.UI.RadSpinEditor();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.SupportCheckBox = new System.Windows.Forms.CheckBox();
            this.SpamTimer = new System.Windows.Forms.Timer(this.components);
            this.RandomSpamTimer = new System.Windows.Forms.Timer(this.components);
            this.InOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.RandomRadioButton = new System.Windows.Forms.RadioButton();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.DiscordSpamTimer = new System.Windows.Forms.Timer(this.components);
            this.DiscordRandomSpamTimer = new System.Windows.Forms.Timer(this.components);
            this.radSpellChecker1 = new Telerik.WinControls.UI.RadSpellChecker();
            this.SpellCheckerCheckBox = new System.Windows.Forms.CheckBox();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.SettingsComingSoonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalSpinEditor)).BeginInit();
            this.OrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommandButton
            // 
            this.CommandButton.BackColor = System.Drawing.Color.OrangeRed;
            this.CommandButton.FlatAppearance.BorderSize = 0;
            this.CommandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommandButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandButton.ForeColor = System.Drawing.Color.White;
            this.CommandButton.Location = new System.Drawing.Point(597, 0);
            this.CommandButton.Name = "CommandButton";
            this.CommandButton.Size = new System.Drawing.Size(200, 60);
            this.CommandButton.TabIndex = 10;
            this.CommandButton.Text = "Start (F9)";
            this.CommandButton.UseVisualStyleBackColor = false;
            this.CommandButton.Click += new System.EventHandler(this.StartStopSpam);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(286, 250);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(305, 45);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.Clear);
            // 
            // AddSpamContentTextBox
            // 
            this.AddSpamContentTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.AddSpamContentTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSpamContentTextBox.Location = new System.Drawing.Point(286, 0);
            this.AddSpamContentTextBox.Multiline = true;
            this.AddSpamContentTextBox.Name = "AddSpamContentTextBox";
            this.AddSpamContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.AddSpamContentTextBox.Size = new System.Drawing.Size(305, 80);
            this.AddSpamContentTextBox.TabIndex = 22;
            this.AddSpamContentTextBox.Text = "Enter text here...";
            this.AddSpamContentTextBox.WordWrap = false;
            this.AddSpamContentTextBox.Enter += new System.EventHandler(this.PlaceholderText);
            this.AddSpamContentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterAdd);
            this.AddSpamContentTextBox.Leave += new System.EventHandler(this.PlaceholderText1);
            // 
            // SpamContentTextBox
            // 
            this.SpamContentTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SpamContentTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpamContentTextBox.Location = new System.Drawing.Point(0, 0);
            this.SpamContentTextBox.Multiline = true;
            this.SpamContentTextBox.Name = "SpamContentTextBox";
            this.SpamContentTextBox.ReadOnly = true;
            this.SpamContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SpamContentTextBox.Size = new System.Drawing.Size(280, 450);
            this.SpamContentTextBox.TabIndex = 23;
            this.SpamContentTextBox.WordWrap = false;
            // 
            // AddSpamContentButton
            // 
            this.AddSpamContentButton.BackColor = System.Drawing.Color.LimeGreen;
            this.AddSpamContentButton.FlatAppearance.BorderSize = 0;
            this.AddSpamContentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSpamContentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSpamContentButton.ForeColor = System.Drawing.Color.White;
            this.AddSpamContentButton.Location = new System.Drawing.Point(286, 89);
            this.AddSpamContentButton.Name = "AddSpamContentButton";
            this.AddSpamContentButton.Size = new System.Drawing.Size(305, 45);
            this.AddSpamContentButton.TabIndex = 25;
            this.AddSpamContentButton.Text = "Add";
            this.AddSpamContentButton.UseVisualStyleBackColor = false;
            this.AddSpamContentButton.Click += new System.EventHandler(this.AddSpamContent);
            // 
            // RemoveSpamContentComboBox
            // 
            this.RemoveSpamContentComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveSpamContentComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSpamContentComboBox.FormattingEnabled = true;
            this.RemoveSpamContentComboBox.Location = new System.Drawing.Point(286, 157);
            this.RemoveSpamContentComboBox.Name = "RemoveSpamContentComboBox";
            this.RemoveSpamContentComboBox.Size = new System.Drawing.Size(305, 36);
            this.RemoveSpamContentComboBox.TabIndex = 26;
            // 
            // RemoveSpamContentButton
            // 
            this.RemoveSpamContentButton.BackColor = System.Drawing.Color.Red;
            this.RemoveSpamContentButton.FlatAppearance.BorderSize = 0;
            this.RemoveSpamContentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSpamContentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSpamContentButton.ForeColor = System.Drawing.Color.White;
            this.RemoveSpamContentButton.Location = new System.Drawing.Point(286, 199);
            this.RemoveSpamContentButton.Name = "RemoveSpamContentButton";
            this.RemoveSpamContentButton.Size = new System.Drawing.Size(305, 45);
            this.RemoveSpamContentButton.TabIndex = 27;
            this.RemoveSpamContentButton.Text = "Remove";
            this.RemoveSpamContentButton.UseVisualStyleBackColor = false;
            this.RemoveSpamContentButton.Click += new System.EventHandler(this.RemoveSpamContent);
            // 
            // IntervalSpinEditor
            // 
            this.IntervalSpinEditor.AutoSize = false;
            this.IntervalSpinEditor.DecimalPlaces = 1;
            this.IntervalSpinEditor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalSpinEditor.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.IntervalSpinEditor.Location = new System.Drawing.Point(597, 233);
            this.IntervalSpinEditor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.IntervalSpinEditor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.IntervalSpinEditor.Name = "IntervalSpinEditor";
            this.IntervalSpinEditor.NullableValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntervalSpinEditor.Size = new System.Drawing.Size(200, 40);
            this.IntervalSpinEditor.TabIndex = 29;
            this.IntervalSpinEditor.TabStop = false;
            this.IntervalSpinEditor.ThemeName = "Fluent";
            this.IntervalSpinEditor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.BackColor = System.Drawing.Color.Transparent;
            this.IntervalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntervalLabel.Location = new System.Drawing.Point(597, 187);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(200, 40);
            this.IntervalLabel.TabIndex = 30;
            this.IntervalLabel.Text = "Interval (seconds):";
            this.IntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SupportCheckBox
            // 
            this.SupportCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.SupportCheckBox.Checked = true;
            this.SupportCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SupportCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupportCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupportCheckBox.Location = new System.Drawing.Point(597, 68);
            this.SupportCheckBox.Name = "SupportCheckBox";
            this.SupportCheckBox.Size = new System.Drawing.Size(200, 40);
            this.SupportCheckBox.TabIndex = 28;
            this.SupportCheckBox.Text = "Support Us";
            this.SupportCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SupportCheckBox.UseVisualStyleBackColor = false;
            // 
            // SpamTimer
            // 
            this.SpamTimer.Tick += new System.EventHandler(this.SpamTimer_Tick);
            // 
            // RandomSpamTimer
            // 
            this.RandomSpamTimer.Tick += new System.EventHandler(this.RandomSpamTimer_Tick);
            // 
            // InOrderRadioButton
            // 
            this.InOrderRadioButton.AutoSize = true;
            this.InOrderRadioButton.Checked = true;
            this.InOrderRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InOrderRadioButton.Location = new System.Drawing.Point(12, 94);
            this.InOrderRadioButton.Name = "InOrderRadioButton";
            this.InOrderRadioButton.Size = new System.Drawing.Size(110, 32);
            this.InOrderRadioButton.TabIndex = 32;
            this.InOrderRadioButton.TabStop = true;
            this.InOrderRadioButton.Text = "In order";
            this.InOrderRadioButton.UseVisualStyleBackColor = true;
            // 
            // RandomRadioButton
            // 
            this.RandomRadioButton.AutoSize = true;
            this.RandomRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomRadioButton.Location = new System.Drawing.Point(12, 56);
            this.RandomRadioButton.Name = "RandomRadioButton";
            this.RandomRadioButton.Size = new System.Drawing.Size(113, 32);
            this.RandomRadioButton.TabIndex = 31;
            this.RandomRadioButton.Text = "Random";
            this.RandomRadioButton.UseVisualStyleBackColor = true;
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Controls.Add(this.RandomRadioButton);
            this.OrderGroupBox.Controls.Add(this.InOrderRadioButton);
            this.OrderGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGroupBox.Location = new System.Drawing.Point(597, 284);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(200, 154);
            this.OrderGroupBox.TabIndex = 33;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Sending order";
            // 
            // radSpellChecker1
            // 
            this.radSpellChecker1.AutoSpellCheckControl = this.AddSpamContentTextBox;
            this.radSpellChecker1.ThemeName = "Fluent";
            // 
            // SpellCheckerCheckBox
            // 
            this.SpellCheckerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.SpellCheckerCheckBox.Checked = true;
            this.SpellCheckerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpellCheckerCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpellCheckerCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpellCheckerCheckBox.Location = new System.Drawing.Point(597, 114);
            this.SpellCheckerCheckBox.Name = "SpellCheckerCheckBox";
            this.SpellCheckerCheckBox.Size = new System.Drawing.Size(200, 40);
            this.SpellCheckerCheckBox.TabIndex = 38;
            this.SpellCheckerCheckBox.Text = "Spell Checker";
            this.SpellCheckerCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SpellCheckerCheckBox.UseVisualStyleBackColor = false;
            this.SpellCheckerCheckBox.CheckedChanged += new System.EventHandler(this.SpellChecker);
            // 
            // SettingsComingSoonLabel
            // 
            this.SettingsComingSoonLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsComingSoonLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsComingSoonLabel.ForeColor = System.Drawing.Color.Black;
            this.SettingsComingSoonLabel.Location = new System.Drawing.Point(287, 302);
            this.SettingsComingSoonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SettingsComingSoonLabel.Name = "SettingsComingSoonLabel";
            this.SettingsComingSoonLabel.Size = new System.Drawing.Size(305, 148);
            this.SettingsComingSoonLabel.TabIndex = 39;
            this.SettingsComingSoonLabel.Text = "Some options are removed. Find out more by joining our Discord server.\r\n";
            this.SettingsComingSoonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpammerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsComingSoonLabel);
            this.Controls.Add(this.SpellCheckerCheckBox);
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.IntervalSpinEditor);
            this.Controls.Add(this.IntervalLabel);
            this.Controls.Add(this.SupportCheckBox);
            this.Controls.Add(this.RemoveSpamContentButton);
            this.Controls.Add(this.RemoveSpamContentComboBox);
            this.Controls.Add(this.AddSpamContentButton);
            this.Controls.Add(this.SpamContentTextBox);
            this.Controls.Add(this.AddSpamContentTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CommandButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SpammerForm";
            this.Text = "CH\'s amburr Tools --Spammer";
            ((System.ComponentModel.ISupportInitialize)(this.IntervalSpinEditor)).EndInit();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CommandButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox AddSpamContentTextBox;
        private System.Windows.Forms.TextBox SpamContentTextBox;
        private System.Windows.Forms.Button AddSpamContentButton;
        private System.Windows.Forms.ComboBox RemoveSpamContentComboBox;
        private System.Windows.Forms.Button RemoveSpamContentButton;
        private Telerik.WinControls.UI.RadSpinEditor IntervalSpinEditor;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.CheckBox SupportCheckBox;
        private System.Windows.Forms.Timer SpamTimer;
        private System.Windows.Forms.Timer RandomSpamTimer;
        private System.Windows.Forms.RadioButton InOrderRadioButton;
        private System.Windows.Forms.RadioButton RandomRadioButton;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.Timer DiscordSpamTimer;
        private System.Windows.Forms.Timer DiscordRandomSpamTimer;
        private Telerik.WinControls.UI.RadSpellChecker radSpellChecker1;
        private System.Windows.Forms.CheckBox SpellCheckerCheckBox;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private System.Windows.Forms.Label SettingsComingSoonLabel;
    }
}