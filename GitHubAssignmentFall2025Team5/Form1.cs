// File: GitHubAssignmentFall2025Team5
// Developer: pitchert1, RooneyA3, waupoosa1
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

        private void fToCButton_Click(object sender, EventArgs e) // Converts Fahrenheit to Celcius.
        {
            if (double.TryParse(inputTextBox.Text, out double fahrenheit)) // Tests the input textbox for a double value and passes the value if true.
            {
                double celcius = (fahrenheit - 32) * (5.0 / 9.0); // Fahrenheit to Celcius expression.
                outputLabel.Text = celcius.ToString(); // Outputs the Fahrenheit to Celcius conversion result to the output label.
            }
            else
            {
                MessageBox.Show("Enter a Numeric Value"); // Prompts the user to enter a valid value in the input textbox.
            }
        }

        private void cToFButton_Click(object sender, EventArgs e) // Converts Celcius to Fahrenheit.
        {
            if (double.TryParse(inputTextBox.Text, out double celcius)) // Tests the input textbox for a double value and passes the value if true.
            {
                double fahrenheit = (celcius * 9.0 / 5.0) + 32; // Celcius to Fahrenheit expression.
                outputLabel.Text = fahrenheit.ToString(); // Outputs the Fahrenheit to Celcius conversion result to the output label.
            }
            else
            {
                MessageBox.Show("Enter a Numeric Value"); // Prompts the user to enter a valid value in the input textbox.
            }
        }

        private void clearButton_Click(object sender, EventArgs e) // Clears the input textbox and output label.
        {
            inputTextBox.Clear(); // Clears the input textbox.
            outputLabel.Text = string.Empty; // Clears the output label.
        }

        private void btnAlex_Click(object sender, EventArgs e) // Displays a message in a listbox.
        {
            nameListBox.Items.Add("The Alex W button was clicked"); // Adds a message to a listbox.
        }

        private void btnAiden_Click(object sender, EventArgs e)
        {
            // i hate typing out my name so let's at least minimize how many times it has to be done
            listBox1.Items.Add("The " + ((Button)sender).Text + " button was clicked");
        }

        private void tylerButton_Click(object sender, EventArgs e)
        {
            String name; //  declare varible to hold string text
                         
            name = "The Tyler P button was clicked!"; //  intialize variable with desired message
            tylerListBox.Items.Add(name); // add string to listbox to display text
        }
    }
}
