using System;
using System.Windows.Forms;

namespace MegaDesk2
{
    public partial class DisplayQuote : Form
    {
        public static string Quote { get; set; }

        public DisplayQuote()
        {
            InitializeComponent();
            printQuote(Quote);
        }

        public void printQuote(string quote)
        {
            DisplayQuoteTextBox.Text = quote;
        }

        private void ExitDisplayQuoteButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
