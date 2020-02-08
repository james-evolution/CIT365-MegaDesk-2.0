namespace MegaDesk2
{
    partial class AddQuote
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
            this.ExitAddQuoteButton = new System.Windows.Forms.Button();
            this.CustomerNameTextField = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.DeskWidthLabel = new System.Windows.Forms.Label();
            this.DeskDepthLabel = new System.Windows.Forms.Label();
            this.DrawerCountLabel = new System.Windows.Forms.Label();
            this.DesktopMaterialLabel = new System.Windows.Forms.Label();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.SubmitAddQuoteButton = new System.Windows.Forms.Button();
            this.DesktopMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.RushOrderComboBox = new System.Windows.Forms.ComboBox();
            this.DrawersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DepthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DrawersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitAddQuoteButton
            // 
            this.ExitAddQuoteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitAddQuoteButton.Location = new System.Drawing.Point(306, 405);
            this.ExitAddQuoteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitAddQuoteButton.Name = "ExitAddQuoteButton";
            this.ExitAddQuoteButton.Size = new System.Drawing.Size(260, 35);
            this.ExitAddQuoteButton.TabIndex = 8;
            this.ExitAddQuoteButton.Tag = "ExitAddQuoteButon";
            this.ExitAddQuoteButton.Text = "Close";
            this.ExitAddQuoteButton.UseVisualStyleBackColor = true;
            this.ExitAddQuoteButton.Click += new System.EventHandler(this.ExitAddQuoteButton_Click);
            // 
            // CustomerNameTextField
            // 
            this.CustomerNameTextField.Location = new System.Drawing.Point(306, 38);
            this.CustomerNameTextField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomerNameTextField.Name = "CustomerNameTextField";
            this.CustomerNameTextField.Size = new System.Drawing.Size(253, 26);
            this.CustomerNameTextField.TabIndex = 1;
            this.CustomerNameTextField.Tag = "CustomerNameTextField";
            this.CustomerNameTextField.Text = "Please enter your full name.";
            this.CustomerNameTextField.TextChanged += new System.EventHandler(this.CustomerNameTextField_TextChanged);
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(18, 23);
            this.CustomerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Padding = new System.Windows.Forms.Padding(15);
            this.CustomerNameLabel.Size = new System.Drawing.Size(184, 55);
            this.CustomerNameLabel.TabIndex = 2;
            this.CustomerNameLabel.Tag = "CustomerNameLabel";
            this.CustomerNameLabel.Text = "Customer Name";
            this.CustomerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeskWidthLabel
            // 
            this.DeskWidthLabel.AutoSize = true;
            this.DeskWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthLabel.Location = new System.Drawing.Point(18, 80);
            this.DeskWidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeskWidthLabel.Name = "DeskWidthLabel";
            this.DeskWidthLabel.Padding = new System.Windows.Forms.Padding(15);
            this.DeskWidthLabel.Size = new System.Drawing.Size(219, 55);
            this.DeskWidthLabel.TabIndex = 4;
            this.DeskWidthLabel.Tag = "DeskWidthLabel";
            this.DeskWidthLabel.Text = "Desk Width (inches)";
            this.DeskWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeskDepthLabel
            // 
            this.DeskDepthLabel.AutoSize = true;
            this.DeskDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthLabel.Location = new System.Drawing.Point(18, 137);
            this.DeskDepthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeskDepthLabel.Name = "DeskDepthLabel";
            this.DeskDepthLabel.Padding = new System.Windows.Forms.Padding(15);
            this.DeskDepthLabel.Size = new System.Drawing.Size(220, 55);
            this.DeskDepthLabel.TabIndex = 6;
            this.DeskDepthLabel.Tag = "DeskDepthLabel";
            this.DeskDepthLabel.Text = "Desk Depth (inches)";
            this.DeskDepthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DrawerCountLabel
            // 
            this.DrawerCountLabel.AutoSize = true;
            this.DrawerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawerCountLabel.Location = new System.Drawing.Point(18, 194);
            this.DrawerCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrawerCountLabel.Name = "DrawerCountLabel";
            this.DrawerCountLabel.Padding = new System.Windows.Forms.Padding(15);
            this.DrawerCountLabel.Size = new System.Drawing.Size(209, 55);
            this.DrawerCountLabel.TabIndex = 8;
            this.DrawerCountLabel.Tag = "DrawerCountLabel";
            this.DrawerCountLabel.Text = "Number of Drawers";
            this.DrawerCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DesktopMaterialLabel
            // 
            this.DesktopMaterialLabel.AutoSize = true;
            this.DesktopMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesktopMaterialLabel.Location = new System.Drawing.Point(18, 251);
            this.DesktopMaterialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DesktopMaterialLabel.Name = "DesktopMaterialLabel";
            this.DesktopMaterialLabel.Padding = new System.Windows.Forms.Padding(15);
            this.DesktopMaterialLabel.Size = new System.Drawing.Size(188, 55);
            this.DesktopMaterialLabel.TabIndex = 10;
            this.DesktopMaterialLabel.Tag = "DesktopMaterialLabel";
            this.DesktopMaterialLabel.Text = "Desktop Material";
            this.DesktopMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.AutoSize = true;
            this.RushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderLabel.Location = new System.Drawing.Point(18, 308);
            this.RushOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Padding = new System.Windows.Forms.Padding(15);
            this.RushOrderLabel.Size = new System.Drawing.Size(168, 55);
            this.RushOrderLabel.TabIndex = 12;
            this.RushOrderLabel.Tag = "RushOrderLabel";
            this.RushOrderLabel.Text = "Shipping Time";
            this.RushOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SubmitAddQuoteButton
            // 
            this.SubmitAddQuoteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SubmitAddQuoteButton.Location = new System.Drawing.Point(18, 405);
            this.SubmitAddQuoteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitAddQuoteButton.Name = "SubmitAddQuoteButton";
            this.SubmitAddQuoteButton.Size = new System.Drawing.Size(260, 35);
            this.SubmitAddQuoteButton.TabIndex = 7;
            this.SubmitAddQuoteButton.Tag = "SubmitAddQuoteButton";
            this.SubmitAddQuoteButton.Text = "Submit";
            this.SubmitAddQuoteButton.UseVisualStyleBackColor = true;
            this.SubmitAddQuoteButton.Click += new System.EventHandler(this.SubmitAddQuoteButton_Click);
            // 
            // DesktopMaterialComboBox
            // 
            this.DesktopMaterialComboBox.FormattingEnabled = true;
            this.DesktopMaterialComboBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.DesktopMaterialComboBox.Location = new System.Drawing.Point(306, 265);
            this.DesktopMaterialComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DesktopMaterialComboBox.Name = "DesktopMaterialComboBox";
            this.DesktopMaterialComboBox.Size = new System.Drawing.Size(253, 28);
            this.DesktopMaterialComboBox.TabIndex = 5;
            this.DesktopMaterialComboBox.Tag = "DesktopMaterialComboBox";
            this.DesktopMaterialComboBox.Text = "Laminate";
            this.DesktopMaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.DesktopMaterialComboBox_SelectedIndexChanged);
            // 
            // RushOrderComboBox
            // 
            this.RushOrderComboBox.FormattingEnabled = true;
            this.RushOrderComboBox.Items.AddRange(new object[] {
            "14 Days",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.RushOrderComboBox.Location = new System.Drawing.Point(306, 322);
            this.RushOrderComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RushOrderComboBox.Name = "RushOrderComboBox";
            this.RushOrderComboBox.Size = new System.Drawing.Size(253, 28);
            this.RushOrderComboBox.TabIndex = 6;
            this.RushOrderComboBox.Tag = "RushOrderComboBox";
            this.RushOrderComboBox.Text = "14 Days";
            this.RushOrderComboBox.SelectedIndexChanged += new System.EventHandler(this.RushOrderComboBox_SelectedIndexChanged);
            // 
            // DrawersNumericUpDown
            // 
            this.DrawersNumericUpDown.Location = new System.Drawing.Point(306, 209);
            this.DrawersNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DrawersNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.DrawersNumericUpDown.Name = "DrawersNumericUpDown";
            this.DrawersNumericUpDown.Size = new System.Drawing.Size(255, 26);
            this.DrawersNumericUpDown.TabIndex = 4;
            this.DrawersNumericUpDown.Tag = "DrawersNumericUpDown";
            this.DrawersNumericUpDown.ValueChanged += new System.EventHandler(this.DrawersNumericUpDown_ValueChanged);
            this.DrawersNumericUpDown.Enter += new System.EventHandler(this.DrawersNumericUpDown_Enter);
            // 
            // WidthNumericUpDown
            // 
            this.WidthNumericUpDown.Location = new System.Drawing.Point(306, 95);
            this.WidthNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WidthNumericUpDown.Name = "WidthNumericUpDown";
            this.WidthNumericUpDown.Size = new System.Drawing.Size(255, 26);
            this.WidthNumericUpDown.TabIndex = 2;
            this.WidthNumericUpDown.Tag = "WidthNumericUpDown";
            this.WidthNumericUpDown.ValueChanged += new System.EventHandler(this.WidthNumericUpDown_ValueChanged);
            this.WidthNumericUpDown.Enter += new System.EventHandler(this.WidthNumericUpDown_Enter);
            this.WidthNumericUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.WidthNumericUpDown_Validating);
            // 
            // DepthNumericUpDown
            // 
            this.DepthNumericUpDown.Location = new System.Drawing.Point(306, 152);
            this.DepthNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DepthNumericUpDown.Name = "DepthNumericUpDown";
            this.DepthNumericUpDown.Size = new System.Drawing.Size(255, 26);
            this.DepthNumericUpDown.TabIndex = 3;
            this.DepthNumericUpDown.Tag = "DepthNumericUpDown";
            this.DepthNumericUpDown.ValueChanged += new System.EventHandler(this.DepthNumericUpDown_ValueChanged);
            this.DepthNumericUpDown.Enter += new System.EventHandler(this.DepthNumericUpDown_Enter);
            this.DepthNumericUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.DepthValidating);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitAddQuoteButton;
            this.ClientSize = new System.Drawing.Size(584, 458);
            this.Controls.Add(this.DepthNumericUpDown);
            this.Controls.Add(this.WidthNumericUpDown);
            this.Controls.Add(this.DrawersNumericUpDown);
            this.Controls.Add(this.RushOrderComboBox);
            this.Controls.Add(this.DesktopMaterialComboBox);
            this.Controls.Add(this.SubmitAddQuoteButton);
            this.Controls.Add(this.RushOrderLabel);
            this.Controls.Add(this.DesktopMaterialLabel);
            this.Controls.Add(this.DrawerCountLabel);
            this.Controls.Add(this.DeskDepthLabel);
            this.Controls.Add(this.DeskWidthLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerNameTextField);
            this.Controls.Add(this.ExitAddQuoteButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.DrawersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitAddQuoteButton;
        private System.Windows.Forms.TextBox CustomerNameTextField;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label DeskWidthLabel;
        private System.Windows.Forms.Label DeskDepthLabel;
        private System.Windows.Forms.Label DrawerCountLabel;
        private System.Windows.Forms.Label DesktopMaterialLabel;
        private System.Windows.Forms.Label RushOrderLabel;
        private System.Windows.Forms.Button SubmitAddQuoteButton;
        private System.Windows.Forms.ComboBox DesktopMaterialComboBox;
        private System.Windows.Forms.ComboBox RushOrderComboBox;
        private System.Windows.Forms.NumericUpDown DrawersNumericUpDown;
        private System.Windows.Forms.NumericUpDown WidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown DepthNumericUpDown;
    }
}