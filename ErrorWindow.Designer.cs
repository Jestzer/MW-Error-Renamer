namespace MW_Error_Renamer
{
    partial class ErrorWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorWindow));
            MainLabel = new Label();
            HelpButton = new Button();
            GiveUpButton = new Button();
            ErrorIcon = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MainLabel
            // 
            MainLabel.Location = new Point(63, 30);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(368, 231);
            MainLabel.TabIndex = 0;
            MainLabel.Text = "You're an idiot and you made some big mistakes.";
            // 
            // HelpButton
            // 
            HelpButton.Location = new Point(255, 18);
            HelpButton.Margin = new Padding(3, 4, 3, 4);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(86, 29);
            HelpButton.TabIndex = 1;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // GiveUpButton
            // 
            GiveUpButton.Location = new Point(348, 18);
            GiveUpButton.Margin = new Padding(3, 4, 3, 4);
            GiveUpButton.Name = "GiveUpButton";
            GiveUpButton.Size = new Size(86, 29);
            GiveUpButton.TabIndex = 2;
            GiveUpButton.Text = "Give up";
            GiveUpButton.UseVisualStyleBackColor = true;
            GiveUpButton.Click += GiveUpButton_Click;
            // 
            // ErrorIcon
            // 
            ErrorIcon.Location = new Point(19, 30);
            ErrorIcon.Margin = new Padding(3, 4, 3, 4);
            ErrorIcon.Name = "ErrorIcon";
            ErrorIcon.Size = new Size(45, 47);
            ErrorIcon.TabIndex = 3;
            ErrorIcon.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(GiveUpButton);
            panel1.Controls.Add(HelpButton);
            panel1.Location = new Point(0, 265);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 64);
            panel1.TabIndex = 4;
            // 
            // ErrorWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(443, 325);
            Controls.Add(panel1);
            Controls.Add(ErrorIcon);
            Controls.Add(MainLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ErrorWindow";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "You idiot";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label MainLabel;
        private new Button HelpButton;
        private Button GiveUpButton;
        private PictureBox ErrorIcon;
        private Panel panel1;
    }
}
