namespace MegaDesk_Alkire
{
    partial class MainMenu
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
            this.AddQuoteButton = new System.Windows.Forms.Button();
            this.ViewQuotesButton = new System.Windows.Forms.Button();
            this.SearchQuotesButton = new System.Windows.Forms.Button();
            this.ExitMainMenuButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQuoteButton
            // 
            this.AddQuoteButton.Location = new System.Drawing.Point(12, 12);
            this.AddQuoteButton.Name = "AddQuoteButton";
            this.AddQuoteButton.Size = new System.Drawing.Size(135, 50);
            this.AddQuoteButton.TabIndex = 0;
            this.AddQuoteButton.Tag = "AddQuoteButton";
            this.AddQuoteButton.Text = "Add New Quote";
            this.AddQuoteButton.UseVisualStyleBackColor = true;
            this.AddQuoteButton.Click += new System.EventHandler(this.AddQuoteButton_Click);
            // 
            // ViewQuotesButton
            // 
            this.ViewQuotesButton.Location = new System.Drawing.Point(12, 68);
            this.ViewQuotesButton.Name = "ViewQuotesButton";
            this.ViewQuotesButton.Size = new System.Drawing.Size(135, 50);
            this.ViewQuotesButton.TabIndex = 1;
            this.ViewQuotesButton.Tag = "ViewQuotesButton";
            this.ViewQuotesButton.Text = "View Quotes";
            this.ViewQuotesButton.UseVisualStyleBackColor = true;
            this.ViewQuotesButton.Click += new System.EventHandler(this.ViewQuotesButton_Click);
            // 
            // SearchQuotesButton
            // 
            this.SearchQuotesButton.Location = new System.Drawing.Point(12, 124);
            this.SearchQuotesButton.Name = "SearchQuotesButton";
            this.SearchQuotesButton.Size = new System.Drawing.Size(135, 50);
            this.SearchQuotesButton.TabIndex = 2;
            this.SearchQuotesButton.Tag = "SearchQuotesButton";
            this.SearchQuotesButton.Text = "Search Quotes";
            this.SearchQuotesButton.UseVisualStyleBackColor = true;
            this.SearchQuotesButton.Click += new System.EventHandler(this.SearchQuotesButton_Click);
            // 
            // ExitMainMenuButton
            // 
            this.ExitMainMenuButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitMainMenuButton.Location = new System.Drawing.Point(12, 180);
            this.ExitMainMenuButton.Name = "ExitMainMenuButton";
            this.ExitMainMenuButton.Size = new System.Drawing.Size(135, 50);
            this.ExitMainMenuButton.TabIndex = 3;
            this.ExitMainMenuButton.Tag = "ExitMainMenuButton";
            this.ExitMainMenuButton.Text = "Exit";
            this.ExitMainMenuButton.UseVisualStyleBackColor = true;
            this.ExitMainMenuButton.Click += new System.EventHandler(this.ExitMainMenuButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk_Alkire.Properties.Resources.TheActualDesk;
            this.pictureBox1.Location = new System.Drawing.Point(156, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 174);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitMainMenuButton;
            this.ClientSize = new System.Drawing.Size(333, 243);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitMainMenuButton);
            this.Controls.Add(this.SearchQuotesButton);
            this.Controls.Add(this.ViewQuotesButton);
            this.Controls.Add(this.AddQuoteButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuoteButton;
        private System.Windows.Forms.Button ViewQuotesButton;
        private System.Windows.Forms.Button SearchQuotesButton;
        private System.Windows.Forms.Button ExitMainMenuButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

