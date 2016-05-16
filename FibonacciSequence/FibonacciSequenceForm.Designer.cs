namespace WindowsFormsApplication5
{
    partial class FibonacciForm
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
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.CountInput = new System.Windows.Forms.TextBox();
            this.PortfolioLink = new System.Windows.Forms.LinkLabel();
            this.output = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Location = new System.Drawing.Point(123, 9);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(155, 13);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "Fibonacci Sequence Generator";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(0, 31);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(256, 13);
            this.CountLabel.TabIndex = 1;
            this.CountLabel.Text = "How many numbers of the sequence would you like?";
            // 
            // CountInput
            // 
            this.CountInput.Location = new System.Drawing.Point(265, 28);
            this.CountInput.Name = "CountInput";
            this.CountInput.Size = new System.Drawing.Size(123, 20);
            this.CountInput.TabIndex = 2;
            // 
            // PortfolioLink
            // 
            this.PortfolioLink.AutoSize = true;
            this.PortfolioLink.Location = new System.Drawing.Point(123, 191);
            this.PortfolioLink.Name = "PortfolioLink";
            this.PortfolioLink.Size = new System.Drawing.Size(143, 13);
            this.PortfolioLink.TabIndex = 3;
            this.PortfolioLink.TabStop = true;
            this.PortfolioLink.Text = "http://www.mikaeltaylor.com";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 86);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(375, 90);
            this.output.TabIndex = 4;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(163, 57);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // FibonacciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 213);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.output);
            this.Controls.Add(this.PortfolioLink);
            this.Controls.Add(this.CountInput);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.HeadingLabel);
            this.Name = "FibonacciForm";
            this.Text = "Fibonacci Sequence Generator v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.TextBox CountInput;
        private System.Windows.Forms.LinkLabel PortfolioLink;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button submitButton;
    }
}

