namespace MegaDesk_Alkire
{
    partial class DisplayQuote
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
            this.DisplayQuoteTextBox = new System.Windows.Forms.TextBox();
            this.ExitDisplayQuoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayQuoteTextBox
            // 
            this.DisplayQuoteTextBox.Location = new System.Drawing.Point(12, 12);
            this.DisplayQuoteTextBox.Multiline = true;
            this.DisplayQuoteTextBox.Name = "DisplayQuoteTextBox";
            this.DisplayQuoteTextBox.Size = new System.Drawing.Size(331, 397);
            this.DisplayQuoteTextBox.TabIndex = 0;
            this.DisplayQuoteTextBox.Tag = "DisplayQuoteTextBox";
            this.DisplayQuoteTextBox.TextChanged += new System.EventHandler(this.DisplayQuoteTextBox_TextChanged);
            // 
            // ExitDisplayQuoteButton
            // 
            this.ExitDisplayQuoteButton.Location = new System.Drawing.Point(268, 415);
            this.ExitDisplayQuoteButton.Name = "ExitDisplayQuoteButton";
            this.ExitDisplayQuoteButton.Size = new System.Drawing.Size(75, 23);
            this.ExitDisplayQuoteButton.TabIndex = 1;
            this.ExitDisplayQuoteButton.Tag = "ExitDisplayQuoteButton";
            this.ExitDisplayQuoteButton.Text = "Cancel";
            this.ExitDisplayQuoteButton.UseVisualStyleBackColor = true;
            this.ExitDisplayQuoteButton.Click += new System.EventHandler(this.ExitDisplayQuoteButton_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.ExitDisplayQuoteButton);
            this.Controls.Add(this.DisplayQuoteTextBox);
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayQuoteTextBox;
        private System.Windows.Forms.Button ExitDisplayQuoteButton;
    }
}