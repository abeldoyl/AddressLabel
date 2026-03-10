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
            ZipCodeLabel = new Label();
            ZipCodeTextBox = new TextBox();
            StateLabel = new Label();
            StateTextBox = new TextBox();
            CityLabel = new Label();
            CityTextBox = new TextBox();
            StreetAddressLabel = new Label();
            StreetAddressTextBox = new TextBox();
            LastNameLabel = new Label();
            LastNameTextBox = new TextBox();
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            DisplayLabelButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            AddressLabelGroupBox = new GroupBox();
            AddressLabel = new Label();
            MailingGroupBox.SuspendLayout();
            AddressLabelGroupBox.SuspendLayout();
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
            MailingGroupBox.Location = new Point(12, 25);
            MailingGroupBox.Name = "MailingGroupBox";
            MailingGroupBox.Size = new Size(397, 402);
            MailingGroupBox.TabIndex = 0;
            MailingGroupBox.TabStop = false;
            MailingGroupBox.Text = "Mailing Address";
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
            ZipCodeTextBox.TabIndex = 5;
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
            StateTextBox.TabIndex = 4;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(32, 204);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(28, 15);
            CityLabel.TabIndex = 7;
            CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(32, 222);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(298, 23);
            CityTextBox.TabIndex = 3;
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
            StreetAddressTextBox.TabIndex = 2;
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
            LastNameTextBox.TabIndex = 1;
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
            // DisplayLabelButton
            // 
            DisplayLabelButton.Location = new Point(434, 372);
            DisplayLabelButton.Name = "DisplayLabelButton";
            DisplayLabelButton.Size = new Size(105, 55);
            DisplayLabelButton.TabIndex = 1;
            DisplayLabelButton.Text = "&Display Label";
            DisplayLabelButton.UseVisualStyleBackColor = true;
            DisplayLabelButton.Click += DisplayLabelButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(545, 372);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(105, 55);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(656, 371);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(121, 56);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // AddressLabelGroupBox
            // 
            AddressLabelGroupBox.Controls.Add(AddressLabel);
            AddressLabelGroupBox.Location = new Point(450, 33);
            AddressLabelGroupBox.Name = "AddressLabelGroupBox";
            AddressLabelGroupBox.Size = new Size(327, 290);
            AddressLabelGroupBox.TabIndex = 4;
            AddressLabelGroupBox.TabStop = false;
            AddressLabelGroupBox.Text = "Address Label";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(27, 52);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(0, 15);
            AddressLabel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddressLabelGroupBox);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(DisplayLabelButton);
            Controls.Add(MailingGroupBox);
            Name = "MainForm";
            Text = "Address Label Viewer";
            MailingGroupBox.ResumeLayout(false);
            MailingGroupBox.PerformLayout();
            AddressLabelGroupBox.ResumeLayout(false);
            AddressLabelGroupBox.PerformLayout();
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
        private Button DisplayLabelButton;
        private Button ClearButton;
        private Button ExitButton;
        private GroupBox AddressLabelGroupBox;
        private Label AddressLabel;
    }
}
