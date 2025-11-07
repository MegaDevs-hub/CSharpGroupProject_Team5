// File: GitHubAssignmentFall2025Team5
// Developer: pitchert1, RooneyA3, MegaDevs
// Written: 11/06/2025

// Collaborate with your team using GitHub while building a small C# .NET project in Visual Studio

namespace GitHubAssignmentFall2025Team5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FToCButton_Click(object sender, EventArgs e) // Converts Fahrenheit to Celcius.
        {
            if (double.TryParse(InputTextBox.Text, out double fahrenheit)) // Tests the input textbox for a double value and passes the value if true.
            {
                double celcius = (fahrenheit - 32) * (5.0 / 9.0); // Fahrenheit to Celcius expression.
                OutputLabel.Text = celcius.ToString(); // Outputs the Fahrenheit to Celcius conversion result to the output label.
            }
            else
            {
                MessageBox.Show("Enter a Numeric Value"); // Prompts the user to enter a valid value in the input textbox.
            }
        }

        private void CToFButton_Click(object sender, EventArgs e) // Converts Celcius to Fahrenheit.
        {
            if (double.TryParse(InputTextBox.Text, out double celcius)) // Tests the input textbox for a double value and passes the value if true.
            {
                double fahrenheit = (celcius * 9.0 / 5.0) + 32; // Celcius to Fahrenheit expression.
                OutputLabel.Text = fahrenheit.ToString(); // Outputs the Fahrenheit to Celcius conversion result to the output label.
            }
            else
            {
                MessageBox.Show("Enter a Numeric Value"); // Prompts the user to enter a valid value in the input textbox.
            }
        }

        private void ClearButton_Click(object sender, EventArgs e) // Clears the input textbox and output label.
        {
            InputTextBox.Clear(); // Clears the input textbox.
            OutputLabel.Text = string.Empty; // Clears the output label.
        }
    }
}
