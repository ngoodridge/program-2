namespace Program2
{
    partial class Program2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NamePromptLabel = new System.Windows.Forms.Label();
            this.LastInitialBox = new System.Windows.Forms.TextBox();
            this.ClassPromptLabel = new System.Windows.Forms.Label();
            this.FreshmanButton = new System.Windows.Forms.RadioButton();
            this.SophmoreButton = new System.Windows.Forms.RadioButton();
            this.JuniorButton = new System.Windows.Forms.RadioButton();
            this.SeniorButton = new System.Windows.Forms.RadioButton();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateOutputLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeOutputLabel = new System.Windows.Forms.Label();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NamePromptLabel
            // 
            this.NamePromptLabel.AutoSize = true;
            this.NamePromptLabel.Location = new System.Drawing.Point(12, 18);
            this.NamePromptLabel.Name = "NamePromptLabel";
            this.NamePromptLabel.Size = new System.Drawing.Size(215, 13);
            this.NamePromptLabel.TabIndex = 0;
            this.NamePromptLabel.Text = "Please enter the first letter of your last name:";
            // 
            // LastInitialBox
            // 
            this.LastInitialBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.LastInitialBox.Location = new System.Drawing.Point(233, 15);
            this.LastInitialBox.MaxLength = 1;
            this.LastInitialBox.Name = "LastInitialBox";
            this.LastInitialBox.Size = new System.Drawing.Size(22, 20);
            this.LastInitialBox.TabIndex = 1;
            // 
            // ClassPromptLabel
            // 
            this.ClassPromptLabel.AutoSize = true;
            this.ClassPromptLabel.Location = new System.Drawing.Point(12, 56);
            this.ClassPromptLabel.Name = "ClassPromptLabel";
            this.ClassPromptLabel.Size = new System.Drawing.Size(230, 13);
            this.ClassPromptLabel.TabIndex = 2;
            this.ClassPromptLabel.Text = "Please select you current class standing below:";
            // 
            // FreshmanButton
            // 
            this.FreshmanButton.AutoSize = true;
            this.FreshmanButton.Location = new System.Drawing.Point(15, 72);
            this.FreshmanButton.Name = "FreshmanButton";
            this.FreshmanButton.Size = new System.Drawing.Size(71, 17);
            this.FreshmanButton.TabIndex = 3;
            this.FreshmanButton.TabStop = true;
            this.FreshmanButton.Text = "Freshman";
            this.FreshmanButton.UseVisualStyleBackColor = true;
            // 
            // SophmoreButton
            // 
            this.SophmoreButton.AutoSize = true;
            this.SophmoreButton.Location = new System.Drawing.Point(142, 72);
            this.SophmoreButton.Name = "SophmoreButton";
            this.SophmoreButton.Size = new System.Drawing.Size(73, 17);
            this.SophmoreButton.TabIndex = 4;
            this.SophmoreButton.TabStop = true;
            this.SophmoreButton.Text = "Sophmore";
            this.SophmoreButton.UseVisualStyleBackColor = true;
            // 
            // JuniorButton
            // 
            this.JuniorButton.AutoSize = true;
            this.JuniorButton.Location = new System.Drawing.Point(15, 95);
            this.JuniorButton.Name = "JuniorButton";
            this.JuniorButton.Size = new System.Drawing.Size(53, 17);
            this.JuniorButton.TabIndex = 5;
            this.JuniorButton.TabStop = true;
            this.JuniorButton.Text = "Junior";
            this.JuniorButton.UseVisualStyleBackColor = true;
            // 
            // SeniorButton
            // 
            this.SeniorButton.AutoSize = true;
            this.SeniorButton.Location = new System.Drawing.Point(142, 95);
            this.SeniorButton.Name = "SeniorButton";
            this.SeniorButton.Size = new System.Drawing.Size(55, 17);
            this.SeniorButton.TabIndex = 6;
            this.SeniorButton.TabStop = true;
            this.SeniorButton.Text = "Senior";
            this.SeniorButton.UseVisualStyleBackColor = true;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(12, 128);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(188, 13);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "You can register on the following date:";
            // 
            // DateOutputLabel
            // 
            this.DateOutputLabel.AutoSize = true;
            this.DateOutputLabel.Location = new System.Drawing.Point(206, 128);
            this.DateOutputLabel.Name = "DateOutputLabel";
            this.DateOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.DateOutputLabel.TabIndex = 8;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(12, 155);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(183, 13);
            this.TimeLabel.TabIndex = 9;
            this.TimeLabel.Text = "You can register at the following time:";
            // 
            // TimeOutputLabel
            // 
            this.TimeOutputLabel.AutoSize = true;
            this.TimeOutputLabel.Location = new System.Drawing.Point(206, 155);
            this.TimeOutputLabel.Name = "TimeOutputLabel";
            this.TimeOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.TimeOutputLabel.TabIndex = 10;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(85, 199);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(110, 21);
            this.RegistrationButton.TabIndex = 11;
            this.RegistrationButton.Text = "When do I register?";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // Program2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.TimeOutputLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DateOutputLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SeniorButton);
            this.Controls.Add(this.JuniorButton);
            this.Controls.Add(this.SophmoreButton);
            this.Controls.Add(this.FreshmanButton);
            this.Controls.Add(this.ClassPromptLabel);
            this.Controls.Add(this.LastInitialBox);
            this.Controls.Add(this.NamePromptLabel);
            this.Name = "Program2";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NamePromptLabel;
        private System.Windows.Forms.TextBox LastInitialBox;
        private System.Windows.Forms.Label ClassPromptLabel;
        private System.Windows.Forms.RadioButton FreshmanButton;
        private System.Windows.Forms.RadioButton SophmoreButton;
        private System.Windows.Forms.RadioButton JuniorButton;
        private System.Windows.Forms.RadioButton SeniorButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DateOutputLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TimeOutputLabel;
        private System.Windows.Forms.Button RegistrationButton;
    }
}

