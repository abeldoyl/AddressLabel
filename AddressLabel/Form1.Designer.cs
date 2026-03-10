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
            LastNameLabel = new Label();
            LastNameTextBox = new TextBox();
            StreetAddressLabel = new Label();
            StreetAddressTextBox = new TextBox();
            CityLabel = new Label();
            CityTextBox = new TextBox();
            StateLabel = new Label();
            StateTextBox = new TextBox();
            ZipCodeLabel = new Label();
            ZipCodeTextBox = new TextBox();
            MailingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MailingGroupBox
            // 
            MailingGroupBox.Controls.Add(ZipCodeLabel);
            MailingGroupBox.Controls.Add(ZipCodeTextBox);
            MailingGroupBox.Controls.Add(StateLabel);
            MailingGroupBox.Controls.Add(StateTextBox);
            MailingGroupBox.Controls.Add(CityLabel);
            MailingGroupBox.Controls.Add(CityTextBox);
            MailingGroupBox.Controls.Add(StreetAddressLabel);
            MailingGroupBox.Controls.Add(StreetAddressTextBox);
            MailingGroupBox.Controls.Add(LastNameLabel);
            MailingGroupBox.Controls.Add(LastNameTextBox);
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
            FirstNameTextBox.Size = new Size(298, 23);
            FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(32, 93);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(63, 15);
            LastNameLabel.TabIndex = 3;
            LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(32, 111);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(298, 23);
            LastNameTextBox.TabIndex = 2;
            // 
            // StreetAddressLabel
            // 
            StreetAddressLabel.AutoSize = true;
            StreetAddressLabel.Location = new Point(32, 147);
            StreetAddressLabel.Name = "StreetAddressLabel";
            StreetAddressLabel.Size = new Size(82, 15);
            StreetAddressLabel.TabIndex = 5;
            StreetAddressLabel.Text = "Street Address";
            // 
            // StreetAddressTextBox
            // 
            StreetAddressTextBox.Location = new Point(32, 165);
            StreetAddressTextBox.Name = "StreetAddressTextBox";
            StreetAddressTextBox.Size = new Size(298, 23);
            StreetAddressTextBox.TabIndex = 4;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(32, 204);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(28, 15);
            CityLabel.TabIndex = 7;
            CityLabel.Text = "City";
            CityLabel.Click += this.label1_Click;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(32, 222);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(298, 23);
            CityTextBox.TabIndex = 6;
            CityTextBox.TextChanged += textBox1_TextChanged;
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(32, 257);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(33, 15);
            StateLabel.TabIndex = 9;
            StateLabel.Text = "State";
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(32, 275);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(114, 23);
            StateTextBox.TabIndex = 8;
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new Point(32, 310);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(55, 15);
            ZipCodeLabel.TabIndex = 11;
            ZipCodeLabel.Text = "Zip Code";
            // 
            // ZipCodeTextBox
            // 
            ZipCodeTextBox.Location = new Point(32, 328);
            ZipCodeTextBox.Name = "ZipCodeTextBox";
            ZipCodeTextBox.Size = new Size(114, 23);
            ZipCodeTextBox.TabIndex = 10;
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
        private Label StreetAddressLabel;
        private TextBox StreetAddressTextBox;
        private Label LastNameLabel;
        private TextBox LastNameTextBox;
        private Label CityLabel;
        private TextBox CityTextBox;
        private Label ZipCodeLabel;
        private TextBox ZipCodeTextBox;
        private Label StateLabel;
        private TextBox StateTextBox;
    }
}
