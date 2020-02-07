using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // This is technically this.Close();
            Close();
        }

        private void SearchQuotesSearchButton_Click(object sender, EventArgs e)
        {
            List<DeskQuote> resultsList = new List<DeskQuote>();

            string[] lines = new string[] { };
            string json = "";

            try
            {
                json = File.ReadAllText("..\\..\\quotes.json");
                lines = File.ReadAllLines("..\\..\\quotes.json");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(e);
            }
            for (int i = 0; i < lines.Length; i++)
            {
                // ViewQuotesTextBox.AppendText(lines[i] + Environment.NewLine);
            }


            List<DeskQuote> DeskList = new List<DeskQuote>();

            var convertedJson = JsonConvert.SerializeObject(DeskList, Formatting.Indented);

            List<DeskQuote> quoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(json);

            // Control kc = comment, control ku = uncomment.

            for (int i = 0; i < quoteList.Count; i++)
            {
                if (quoteList[i].Desk.DeskMaterial == chosenMaterial)
                {
                    resultsList.Add(quoteList[i]);
                }
            }

            //if (quoteList[0].Desk.DeskMaterial == chosenMaterial)
            //{
            //    MessageBox.Show("The material matches.");
            //}
            //else
            //{
            //    MessageBox.Show("The material does not match.");
            //}

            // resultsGridView.DataSource = quoteList.Where(x => x.Desk.DeskMaterial == SurfaceMaterial.Rosewood);
            resultsGridView.DataSource = resultsList;
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
        }

        private void ResultsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
