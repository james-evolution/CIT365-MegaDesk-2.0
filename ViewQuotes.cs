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

namespace MegaDesk_Alkire
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
            // This is technically this.Close();
            Close();
        }

        private void ViewQuotes_Load(object sender, EventArgs e)
        {
            // string line = File.ReadAllText(@"c:\tmp\DeskQuotes.txt");
            // MessageBox.Show(line);
            string[] lines = new string[] { };

            try
            {
                lines = File.ReadAllLines(@"c:\tmp\DeskQuotes.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(e);
            }
            

            for (int i = 0; i < lines.Length; i++)
            {
                ViewQuotesTextBox.AppendText(lines[i] + Environment.NewLine);
            }
        }

        private void ViewQuotesTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
