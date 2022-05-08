namespace Exponents
{
    partial class Form1
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
            this.uxInputTextBox = new System.Windows.Forms.TextBox();
            this.uxInputLabel = new System.Windows.Forms.Label();
            this.uxOutputLabel = new System.Windows.Forms.Label();
            this.uxGoButton = new System.Windows.Forms.Button();
            this.uxResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxInputTextBox
            // 
            this.uxInputTextBox.Location = new System.Drawing.Point(200, 96);
            this.uxInputTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.uxInputTextBox.Name = "uxInputTextBox";
            this.uxInputTextBox.Size = new System.Drawing.Size(228, 35);
            this.uxInputTextBox.TabIndex = 0;
            // 
            // uxInputLabel
            // 
            this.uxInputLabel.AutoSize = true;
            this.uxInputLabel.Location = new System.Drawing.Point(220, 60);
            this.uxInputLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.uxInputLabel.Name = "uxInputLabel";
            this.uxInputLabel.Size = new System.Drawing.Size(189, 29);
            this.uxInputLabel.TabIndex = 3;
            this.uxInputLabel.Text = "Enter an integer:";
            this.uxInputLabel.Click += new System.EventHandler(this.xInputLabel_Click);
            // 
            // uxOutputLabel
            // 
            this.uxOutputLabel.AutoSize = true;
            this.uxOutputLabel.Location = new System.Drawing.Point(220, 404);
            this.uxOutputLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.uxOutputLabel.Name = "uxOutputLabel";
            this.uxOutputLabel.Size = new System.Drawing.Size(0, 29);
            this.uxOutputLabel.TabIndex = 4;
            this.uxOutputLabel.Visible = false;
            // 
            // uxGoButton
            // 
            this.uxGoButton.Location = new System.Drawing.Point(220, 214);
            this.uxGoButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.uxGoButton.Name = "uxGoButton";
            this.uxGoButton.Size = new System.Drawing.Size(175, 149);
            this.uxGoButton.TabIndex = 6;
            this.uxGoButton.Text = "Go!";
            this.uxGoButton.UseVisualStyleBackColor = true;
            this.uxGoButton.Click += new System.EventHandler(this.xGoButton_Click);
            // 
            // uxResetButton
            // 
            this.uxResetButton.Location = new System.Drawing.Point(220, 462);
            this.uxResetButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.uxResetButton.Name = "uxResetButton";
            this.uxResetButton.Size = new System.Drawing.Size(175, 51);
            this.uxResetButton.TabIndex = 7;
            this.uxResetButton.Text = "Reset";
            this.uxResetButton.UseVisualStyleBackColor = true;
            this.uxResetButton.Click += new System.EventHandler(this.xResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 584);
            this.Controls.Add(this.uxResetButton);
            this.Controls.Add(this.uxGoButton);
            this.Controls.Add(this.uxOutputLabel);
            this.Controls.Add(this.uxInputLabel);
            this.Controls.Add(this.uxInputTextBox);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Exponents Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxInputTextBox;
        private System.Windows.Forms.Label uxInputLabel;
        private System.Windows.Forms.Label uxOutputLabel;
        private System.Windows.Forms.Button uxGoButton;
        private System.Windows.Forms.Button uxResetButton;
    }
}

