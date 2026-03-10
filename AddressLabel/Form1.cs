namespace AddressLabel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SetDefaults()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            StreetAddressTextBox.Text = "";
            CityTextBox.Text = "";
            StateTextBox.Text = "";
            ZipCodeTextBox.Text = "";
            AddressLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void DisplayLabelButton_Click(object sender, EventArgs e)
        {
            AddressLabel.Text = (FirstNameTextBox.Text + " " +
            LastNameTextBox.Text + "\n" +
            StreetAddressTextBox.Text + "\n" +
            CityTextBox.Text + ", " +
            StateTextBox.Text + " " +
            ZipCodeTextBox.Text);
        }

    }
}
