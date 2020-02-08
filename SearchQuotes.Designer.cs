namespace MegaDesk2
{
    partial class SearchQuotes
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
            this.ExitSearchQuotesButton = new System.Windows.Forms.Button();
            this.SearchQuotesMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.SearchQuotesSearchMaterialLabel = new System.Windows.Forms.Label();
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            this.Count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitSearchQuotesButton
            // 
            this.ExitSearchQuotesButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitSearchQuotesButton.Location = new System.Drawing.Point(1295, 533);
            this.ExitSearchQuotesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitSearchQuotesButton.Name = "ExitSearchQuotesButton";
            this.ExitSearchQuotesButton.Size = new System.Drawing.Size(170, 35);
            this.ExitSearchQuotesButton.TabIndex = 0;
            this.ExitSearchQuotesButton.Tag = "ExitSearchQuotesButton";
            this.ExitSearchQuotesButton.Text = "Close";
            this.ExitSearchQuotesButton.UseVisualStyleBackColor = true;
            this.ExitSearchQuotesButton.Click += new System.EventHandler(this.ExitSearchQuotesButton_Click);
            // 
            // SearchQuotesMaterialComboBox
            // 
            this.SearchQuotesMaterialComboBox.FormattingEnabled = true;
            this.SearchQuotesMaterialComboBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.SearchQuotesMaterialComboBox.Location = new System.Drawing.Point(217, 14);
            this.SearchQuotesMaterialComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchQuotesMaterialComboBox.Name = "SearchQuotesMaterialComboBox";
            this.SearchQuotesMaterialComboBox.Size = new System.Drawing.Size(166, 28);
            this.SearchQuotesMaterialComboBox.TabIndex = 1;
            this.SearchQuotesMaterialComboBox.Tag = "SearchQuotesMaterialComboBox";
            this.SearchQuotesMaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchQuotesMaterialComboBox_SelectedIndexChanged);
            // 
            // SearchQuotesSearchMaterialLabel
            // 
            this.SearchQuotesSearchMaterialLabel.AutoSize = true;
            this.SearchQuotesSearchMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotesSearchMaterialLabel.Location = new System.Drawing.Point(13, 9);
            this.SearchQuotesSearchMaterialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchQuotesSearchMaterialLabel.Name = "SearchQuotesSearchMaterialLabel";
            this.SearchQuotesSearchMaterialLabel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.SearchQuotesSearchMaterialLabel.Size = new System.Drawing.Size(190, 41);
            this.SearchQuotesSearchMaterialLabel.TabIndex = 2;
            this.SearchQuotesSearchMaterialLabel.Tag = "SearchQuotesSearchMaterialLabel";
            this.SearchQuotesSearchMaterialLabel.Text = "Search by material";
            // 
            // resultsGridView
            // 
            this.resultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGridView.Location = new System.Drawing.Point(18, 68);
            this.resultsGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.RowHeadersWidth = 62;
            this.resultsGridView.Size = new System.Drawing.Size(1447, 455);
            this.resultsGridView.TabIndex = 4;
            this.resultsGridView.Tag = "resultsGridView";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(390, 22);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(0, 20);
            this.Count.TabIndex = 5;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitSearchQuotesButton;
            this.ClientSize = new System.Drawing.Size(1478, 579);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.resultsGridView);
            this.Controls.Add(this.SearchQuotesSearchMaterialLabel);
            this.Controls.Add(this.SearchQuotesMaterialComboBox);
            this.Controls.Add(this.ExitSearchQuotesButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitSearchQuotesButton;
        private System.Windows.Forms.ComboBox SearchQuotesMaterialComboBox;
        private System.Windows.Forms.Label SearchQuotesSearchMaterialLabel;
        private System.Windows.Forms.DataGridView resultsGridView;
        private System.Windows.Forms.Label Count;
    }
}