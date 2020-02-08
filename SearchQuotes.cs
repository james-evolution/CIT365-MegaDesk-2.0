using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk2
{
    public partial class SearchQuotes : Form
    {
        SurfaceMaterial chosenMaterial;

        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void ExitSearchQuotesButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void SearchQuotesMaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchQuotesMaterialComboBox.Text == "Laminate")
            {
                chosenMaterial = SurfaceMaterial.Laminate;
            }
            else if (SearchQuotesMaterialComboBox.Text == "Oak")
            {
                chosenMaterial = SurfaceMaterial.Oak;
            }
            else if (SearchQuotesMaterialComboBox.Text == "Rosewood")
            {
                chosenMaterial = SurfaceMaterial.Rosewood;
            }
            else if (SearchQuotesMaterialComboBox.Text == "Veneer")
            {
                chosenMaterial = SurfaceMaterial.Veneer;
            }
            else if (SearchQuotesMaterialComboBox.Text == "Pine")
            {
                chosenMaterial = SurfaceMaterial.Pine;
            }
            List<DeskQuote> resultsList = new List<DeskQuote>();
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

            for (int i = 0; i < quoteList.Count; i++)
            {
                if (quoteList[i].Desk.DeskMaterial == chosenMaterial)
                {
                    resultsList.Add(quoteList[i]);
                }
            }

            resultsGridView.DataSource = resultsList;
            Count.Text = resultsGridView.RowCount.ToString() + " Results";
            resultsGridView.Columns[3].DefaultCellStyle.Format = "d";
            resultsGridView.Columns[4].DefaultCellStyle.Format = "c";
        }
    }
}
