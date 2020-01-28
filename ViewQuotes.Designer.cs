namespace MegaDesk_Alkire
{
    partial class ViewQuotes
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
            this.ExitViewQuotesButton = new System.Windows.Forms.Button();
            this.ViewQuotesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExitViewQuotesButton
            // 
            this.ExitViewQuotesButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitViewQuotesButton.Location = new System.Drawing.Point(210, 316);
            this.ExitViewQuotesButton.Name = "ExitViewQuotesButton";
            this.ExitViewQuotesButton.Size = new System.Drawing.Size(75, 23);
            this.ExitViewQuotesButton.TabIndex = 0;
            this.ExitViewQuotesButton.Tag = "ExitViewQuotesButton";
            this.ExitViewQuotesButton.Text = "Close";
            this.ExitViewQuotesButton.UseVisualStyleBackColor = true;
            this.ExitViewQuotesButton.Click += new System.EventHandler(this.ExitViewQuotesButton_Click);
            // 
            // ViewQuotesTextBox
            // 
            this.ViewQuotesTextBox.Location = new System.Drawing.Point(11, 12);
            this.ViewQuotesTextBox.Multiline = true;
            this.ViewQuotesTextBox.Name = "ViewQuotesTextBox";
            this.ViewQuotesTextBox.Size = new System.Drawing.Size(274, 298);
            this.ViewQuotesTextBox.TabIndex = 1;
            this.ViewQuotesTextBox.Tag = "ViewQuotesTextBox";
            this.ViewQuotesTextBox.TextChanged += new System.EventHandler(this.ViewQuotesTextBox_TextChanged);
            // 
            // ViewQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitViewQuotesButton;
            this.ClientSize = new System.Drawing.Size(297, 351);
            this.Controls.Add(this.ViewQuotesTextBox);
            this.Controls.Add(this.ExitViewQuotesButton);
            this.Name = "ViewQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Quotes";
            this.Load += new System.EventHandler(this.ViewQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitViewQuotesButton;
        private System.Windows.Forms.TextBox ViewQuotesTextBox;
    }
}