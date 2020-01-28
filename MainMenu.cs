using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Alkire
{
    public partial class MainMenu : Form
    {
        // MainMenu currentMenu { get; set; }

        public MainMenu()
        {
            InitializeComponent();
        }

/*        public static void showMenu()
        {
            currentMenu.Show();
        } */

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {

            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            // This is technically this.Hide();
            Hide();
        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewQuotes viewViewQuotes = new ViewQuotes();
            viewViewQuotes.Tag = this;
            viewViewQuotes.Show(this);
            // This is technically this.Hide();
            Hide();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes();
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show(this);
            // This is technically this.Hide();
            Hide();
        }

        private void ExitMainMenuButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
