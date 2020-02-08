using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk2
{
    public partial class ViewQuotes : Form
    {
        public ViewQuotes()
        {
            InitializeComponent();
        }

        private void ExitViewQuotesButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void ViewQuotes_Load(object sender, EventArgs e)
        {
            string json = "";

            try
            {
                json = File.ReadAllText("..\\..\\quotes.json");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(e);
            }

            List<DeskQuote> quoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
            dataGridView1.DataSource = quoteList;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "d";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "c";
        }
    }
}
