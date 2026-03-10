namespace AddressLabel
{
    partial class MainForm
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
            MailingGroupBox = new GroupBox();
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            MailingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MailingGroupBox
            // 
            MailingGroupBox.Controls.Add(FirstNameLabel);
            MailingGroupBox.Controls.Add(FirstNameTextBox);
            MailingGroupBox.Location = new Point(12, 12);
            MailingGroupBox.Name = "MailingGroupBox";
            MailingGroupBox.Size = new Size(397, 402);
            MailingGroupBox.TabIndex = 0;
            MailingGroupBox.TabStop = false;
            MailingGroupBox.Text = "Mailing Address";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(32, 42);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(64, 15);
            FirstNameLabel.TabIndex = 1;
            FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(32, 60);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(165, 23);
            FirstNameTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MailingGroupBox);
            Name = "MainForm";
            Text = "Address Label Viewer";
            MailingGroupBox.ResumeLayout(false);
            MailingGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MailingGroupBox;
        private Label FirstNameLabel;
        private TextBox FirstNameTextBox;
    }
}
