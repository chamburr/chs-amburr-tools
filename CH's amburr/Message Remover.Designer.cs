namespace CH_s_amburr
{
    partial class MessageRemoverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageRemoverForm));
            this.CommandButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.MessageRemoverTimer = new System.Windows.Forms.Timer(this.components);
            this.IntervalSpinEditor = new Telerik.WinControls.UI.RadSpinEditor();
            this.IntervalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalSpinEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // CommandButton
            // 
            this.CommandButton.BackColor = System.Drawing.Color.LimeGreen;
            this.CommandButton.FlatAppearance.BorderSize = 0;
            this.CommandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommandButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandButton.ForeColor = System.Drawing.Color.White;
            this.CommandButton.Location = new System.Drawing.Point(138, 181);
            this.CommandButton.Name = "CommandButton";
            this.CommandButton.Size = new System.Drawing.Size(300, 60);
            this.CommandButton.TabIndex = 9;
            this.CommandButton.Text = "Start (F9)";
            this.CommandButton.UseVisualStyleBackColor = false;
            this.CommandButton.Click += new System.EventHandler(this.Command);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(138, 273);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(300, 28);
            this.StatusLabel.TabIndex = 10;
            this.StatusLabel.Text = "Status: Stopped";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageRemoverTimer
            // 
            this.MessageRemoverTimer.Tick += new System.EventHandler(this.MessageRemoveTimer);
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
            this.IntervalSpinEditor.Location = new System.Drawing.Point(138, 112);
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
            this.IntervalSpinEditor.Size = new System.Drawing.Size(300, 40);
            this.IntervalSpinEditor.TabIndex = 31;
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
            this.IntervalLabel.Location = new System.Drawing.Point(138, 66);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(300, 40);
            this.IntervalLabel.TabIndex = 32;
            this.IntervalLabel.Text = "Interval (seconds):";
            this.IntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageRemoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 344);
            this.Controls.Add(this.IntervalSpinEditor);
            this.Controls.Add(this.IntervalLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CommandButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MessageRemoverForm";
            this.Text = "CH\'s amburr Tools --Message Remover";
            ((System.ComponentModel.ISupportInitialize)(this.IntervalSpinEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CommandButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Timer MessageRemoverTimer;
        private Telerik.WinControls.UI.RadSpinEditor IntervalSpinEditor;
        private System.Windows.Forms.Label IntervalLabel;
    }
}