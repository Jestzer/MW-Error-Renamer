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
            MainLabel.Location = new Point(55, 24);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(249, 142);
            MainLabel.TabIndex = 0;
            MainLabel.Text = "You're an idiot and you made some big mistakes.";
            // 
            // HelpButton
            // 
            HelpButton.Location = new Point(156, 10);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(75, 23);
            HelpButton.TabIndex = 1;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = true;
            // 
            // GiveUpButton
            // 
            GiveUpButton.Location = new Point(237, 10);
            GiveUpButton.Name = "GiveUpButton";
            GiveUpButton.Size = new Size(75, 23);
            GiveUpButton.TabIndex = 2;
            GiveUpButton.Text = "Give up";
            GiveUpButton.UseVisualStyleBackColor = true;
            GiveUpButton.Click += GiveUpButton_Click;
            // 
            // ErrorIcon
            // 
            ErrorIcon.Location = new Point(17, 24);
            ErrorIcon.Name = "ErrorIcon";
            ErrorIcon.Size = new Size(39, 37);
            ErrorIcon.TabIndex = 3;
            ErrorIcon.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(GiveUpButton);
            panel1.Controls.Add(HelpButton);
            panel1.Location = new Point(0, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 45);
            panel1.TabIndex = 4;
            // 
            // ErrorWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(319, 232);
            Controls.Add(panel1);
            Controls.Add(ErrorIcon);
            Controls.Add(MainLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ErrorWindow";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "You idiot";
            ((System.ComponentModel.ISupportInitialize)ErrorIcon).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label MainLabel;
        private Button HelpButton;
        private Button GiveUpButton;
        private PictureBox ErrorIcon;
        private Panel panel1;
    }
}
