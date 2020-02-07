namespace MegaDesk_Alkire
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
            this.SearchQuotesSearchButton = new System.Windows.Forms.Button();
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitSearchQuotesButton
            // 
            this.ExitSearchQuotesButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitSearchQuotesButton.Location = new System.Drawing.Point(446, 509);
            this.ExitSearchQuotesButton.Name = "ExitSearchQuotesButton";
            this.ExitSearchQuotesButton.Size = new System.Drawing.Size(113, 23);
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
            this.SearchQuotesMaterialComboBox.Location = new System.Drawing.Point(136, 17);
            this.SearchQuotesMaterialComboBox.Name = "SearchQuotesMaterialComboBox";
            this.SearchQuotesMaterialComboBox.Size = new System.Drawing.Size(423, 21);
            this.SearchQuotesMaterialComboBox.TabIndex = 1;
            this.SearchQuotesMaterialComboBox.Tag = "SearchQuotesMaterialComboBox";
            this.SearchQuotesMaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchQuotesMaterialComboBox_SelectedIndexChanged);
            // 
            // SearchQuotesSearchMaterialLabel
            // 
            this.SearchQuotesSearchMaterialLabel.AutoSize = true;
            this.SearchQuotesSearchMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotesSearchMaterialLabel.Location = new System.Drawing.Point(13, 13);
            this.SearchQuotesSearchMaterialLabel.Name = "SearchQuotesSearchMaterialLabel";
            this.SearchQuotesSearchMaterialLabel.Padding = new System.Windows.Forms.Padding(5);
            this.SearchQuotesSearchMaterialLabel.Size = new System.Drawing.Size(117, 27);
            this.SearchQuotesSearchMaterialLabel.TabIndex = 2;
            this.SearchQuotesSearchMaterialLabel.Tag = "SearchQuotesSearchMaterialLabel";
            this.SearchQuotesSearchMaterialLabel.Text = "Search Material";
            // 
            // SearchQuotesSearchButton
            // 
            this.SearchQuotesSearchButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SearchQuotesSearchButton.Location = new System.Drawing.Point(12, 509);
            this.SearchQuotesSearchButton.Name = "SearchQuotesSearchButton";
            this.SearchQuotesSearchButton.Size = new System.Drawing.Size(113, 23);
            this.SearchQuotesSearchButton.TabIndex = 3;
            this.SearchQuotesSearchButton.Tag = "SearchQuotesSearchButton";
            this.SearchQuotesSearchButton.Text = "Search";
            this.SearchQuotesSearchButton.UseVisualStyleBackColor = true;
            this.SearchQuotesSearchButton.Click += new System.EventHandler(this.SearchQuotesSearchButton_Click);
            // 
            // resultsGridView
            // 
            this.resultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGridView.Location = new System.Drawing.Point(12, 44);
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.Size = new System.Drawing.Size(547, 172);
            this.resultsGridView.TabIndex = 4;
            this.resultsGridView.Tag = "resultsGridView";
            this.resultsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultsGridView_CellContentClick);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitSearchQuotesButton;
            this.ClientSize = new System.Drawing.Size(571, 544);
            this.Controls.Add(this.resultsGridView);
            this.Controls.Add(this.SearchQuotesSearchButton);
            this.Controls.Add(this.SearchQuotesSearchMaterialLabel);
            this.Controls.Add(this.SearchQuotesMaterialComboBox);
            this.Controls.Add(this.ExitSearchQuotesButton);
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
        private System.Windows.Forms.Button SearchQuotesSearchButton;
        private System.Windows.Forms.DataGridView resultsGridView;
    }
}