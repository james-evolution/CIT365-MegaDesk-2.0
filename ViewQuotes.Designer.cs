namespace MegaDesk2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitViewQuotesButton
            // 
            this.ExitViewQuotesButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitViewQuotesButton.Location = new System.Drawing.Point(853, 491);
            this.ExitViewQuotesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitViewQuotesButton.Name = "ExitViewQuotesButton";
            this.ExitViewQuotesButton.Size = new System.Drawing.Size(112, 35);
            this.ExitViewQuotesButton.TabIndex = 0;
            this.ExitViewQuotesButton.Tag = "ExitViewQuotesButton";
            this.ExitViewQuotesButton.Text = "Close";
            this.ExitViewQuotesButton.UseVisualStyleBackColor = true;
            this.ExitViewQuotesButton.Click += new System.EventHandler(this.ExitViewQuotesButton_Click);
            // 
            // ViewQuotesTextBox
            // 
            this.ViewQuotesTextBox.Location = new System.Drawing.Point(18, 277);
            this.ViewQuotesTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewQuotesTextBox.Multiline = true;
            this.ViewQuotesTextBox.Name = "ViewQuotesTextBox";
            this.ViewQuotesTextBox.Size = new System.Drawing.Size(947, 198);
            this.ViewQuotesTextBox.TabIndex = 1;
            this.ViewQuotesTextBox.Tag = "ViewQuotesTextBox";
            this.ViewQuotesTextBox.TextChanged += new System.EventHandler(this.ViewQuotesTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(947, 249);
            this.dataGridView1.TabIndex = 2;
            // 
            // ViewQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitViewQuotesButton;
            this.ClientSize = new System.Drawing.Size(982, 540);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ViewQuotesTextBox);
            this.Controls.Add(this.ExitViewQuotesButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Quotes";
            this.Load += new System.EventHandler(this.ViewQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitViewQuotesButton;
        private System.Windows.Forms.TextBox ViewQuotesTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}