namespace GitHubAssignmentFall2025Team5
{
    partial class Form1
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
            InputTextBox = new TextBox();
            FToCButton = new Button();
            CToFButton = new Button();
            OutputLabel = new Label();
            ClearButton = new Button();
            btnAiden = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(12, 12);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(230, 23);
            InputTextBox.TabIndex = 0;
            InputTextBox.Text = "98";
            InputTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // FToCButton
            // 
            FToCButton.Location = new Point(12, 41);
            FToCButton.Name = "FToCButton";
            FToCButton.Size = new Size(230, 23);
            FToCButton.TabIndex = 1;
            FToCButton.Text = "°F -> °C";
            FToCButton.UseVisualStyleBackColor = true;
            FToCButton.Click += FToCButton_Click;
            // 
            // CToFButton
            // 
            CToFButton.Location = new Point(12, 70);
            CToFButton.Name = "CToFButton";
            CToFButton.Size = new Size(230, 23);
            CToFButton.TabIndex = 2;
            CToFButton.Text = "°C -> °F";
            CToFButton.UseVisualStyleBackColor = true;
            CToFButton.Click += CToFButton_Click;
            // 
            // OutputLabel
            // 
            OutputLabel.Location = new Point(12, 96);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(230, 23);
            OutputLabel.TabIndex = 3;
            OutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(12, 122);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(230, 23);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // btnAiden
            // 
            btnAiden.Location = new Point(12, 151);
            btnAiden.Name = "btnAiden";
            btnAiden.Size = new Size(104, 23);
            btnAiden.TabIndex = 5;
            btnAiden.Text = "Aiden R";
            btnAiden.UseVisualStyleBackColor = true;
            btnAiden.Click += btnAiden_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(122, 151);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 109);
            listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 269);
            Controls.Add(listBox1);
            Controls.Add(btnAiden);
            Controls.Add(ClearButton);
            Controls.Add(OutputLabel);
            Controls.Add(CToFButton);
            Controls.Add(FToCButton);
            Controls.Add(InputTextBox);
            Name = "Form1";
            Text = "°F <-> °C";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Button FToCButton;
        private Button CToFButton;
        private Label OutputLabel;
        private Button ClearButton;
        private Button btnAiden;
        private ListBox listBox1;
    }
}
