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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void ExitSearchQuotesButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            // This is technically this.Close();
            Close();
        }

        private void SearchQuotesSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchQuotesMaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
