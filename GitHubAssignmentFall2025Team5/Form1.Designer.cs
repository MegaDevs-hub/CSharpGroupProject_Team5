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
            inputTextBox = new TextBox();
            fToCButton = new Button();
            cToFButton = new Button();
            outputLabel = new Label();
            clearButton = new Button();
            btnAlex = new Button();
            nameListBox = new ListBox();
            btnAiden = new Button();
            listBox1 = new ListBox();
            tylerButton = new Button();
            tylerListBox = new ListBox();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(12, 12);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(227, 23);
            inputTextBox.TabIndex = 0;
            inputTextBox.Text = "98";
            inputTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // fToCButton
            // 
            fToCButton.Location = new Point(12, 41);
            fToCButton.Name = "fToCButton";
            fToCButton.Size = new Size(227, 23);
            fToCButton.TabIndex = 1;
            fToCButton.Text = "°F -> °C";
            fToCButton.UseVisualStyleBackColor = true;
            fToCButton.Click += fToCButton_Click;
            // 
            // cToFButton
            // 
            cToFButton.Location = new Point(12, 70);
            cToFButton.Name = "cToFButton";
            cToFButton.Size = new Size(227, 23);
            cToFButton.TabIndex = 2;
            cToFButton.Text = "°C -> °F";
            cToFButton.UseVisualStyleBackColor = true;
            cToFButton.Click += cToFButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.Location = new Point(12, 96);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(227, 23);
            outputLabel.TabIndex = 3;
            outputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(12, 122);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(227, 23);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // btnAlex
            // 
            btnAlex.Location = new Point(12, 205);
            btnAlex.Name = "btnAlex";
            btnAlex.Size = new Size(227, 23);
            btnAlex.TabIndex = 5;
            btnAlex.Text = "Alex W";
            btnAlex.UseVisualStyleBackColor = true;
            btnAlex.Click += btnAlex_Click;
            // 
            // nameListBox
            // 
            nameListBox.FormattingEnabled = true;
            nameListBox.ItemHeight = 15;
            nameListBox.Location = new Point(12, 234);
            nameListBox.Name = "nameListBox";
            nameListBox.Size = new Size(227, 19);
            nameListBox.TabIndex = 6;
            // 
            // btnAiden
            // 
            btnAiden.Location = new Point(12, 151);
            btnAiden.Name = "btnAiden";
            btnAiden.Size = new Size(227, 23);
            btnAiden.TabIndex = 5;
            btnAiden.Text = "Aiden R";
            btnAiden.UseVisualStyleBackColor = true;
            btnAiden.Click += btnAiden_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 180);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(227, 19);
            listBox1.TabIndex = 6;
            // 
            // tylerButton
            // 
            tylerButton.Location = new Point(12, 258);
            tylerButton.Name = "tylerButton";
            tylerButton.Size = new Size(227, 23);
            tylerButton.TabIndex = 7;
            tylerButton.Text = "Tyler P";
            tylerButton.UseVisualStyleBackColor = true;
            tylerButton.Click += tylerButton_Click;
            // 
            // tylerListBox
            // 
            tylerListBox.FormattingEnabled = true;
            tylerListBox.ItemHeight = 15;
            tylerListBox.Location = new Point(13, 285);
            tylerListBox.Name = "tylerListBox";
            tylerListBox.Size = new Size(227, 19);
            tylerListBox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 595);
            Controls.Add(tylerListBox);
            Controls.Add(tylerButton);
            Controls.Add(listBox1);
            Controls.Add(btnAiden);
            Controls.Add(nameListBox);
            Controls.Add(btnAlex);
            Controls.Add(clearButton);
            Controls.Add(outputLabel);
            Controls.Add(cToFButton);
            Controls.Add(fToCButton);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "°F <-> °C";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private Button fToCButton;
        private Button cToFButton;
        private Label outputLabel;
        private Button clearButton;
        private Button btnAlex;
        private ListBox nameListBox;
        private Button btnAiden;
        private ListBox listBox1;
        private Button tylerButton;
        private ListBox tylerListBox;
    }
}
