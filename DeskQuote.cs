using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

/* DeskQuote.cs (Class): This class will define the attributes of a quote 
 * including Desk, rush days, customer name, and quote date. This class will 
 * also hold the logic in determining the desk quote total.*/
namespace MegaDesk2
{
    class DeskQuote
    {
        public SurfaceMaterial DeskMaterial { get; set; }
        public Desk Desk { get; set; }
        public int RushDays { get; set; } // 3, 5, or 7 days. Normal production time = 14 days.
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public double QuoteTotal { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public const int SQUAREPRICE = 1;
        public const int DRAWERPRICE = 50;
        public List<DeskQuote> deskQuotes = new List<DeskQuote>();
        public void writeQuoteToFile(string customerName, Desk desk, int width, int depth, 
            SurfaceMaterial material, int numberOfDrawers, int rushOrderOptions)
        {
            DeskQuote deskQuote = new DeskQuote();
            deskQuote.CustomerName = customerName;
            deskQuote.Desk = desk;
            deskQuote.Desk.Width = width;
            deskQuote.Desk.Depth = depth;
            deskQuote.Desk.DeskMaterial = material;            
            deskQuote.Desk.NumberOfDrawers = numberOfDrawers;
            deskQuote.RushDays = rushOrderOptions;
            deskQuote.QuoteTotal = calculateTotalQuote(deskQuote.Desk, deskQuote.Desk.Width, 
            deskQuote.Desk.Depth, deskQuote.Desk.DeskMaterial, deskQuote.Desk.NumberOfDrawers, deskQuote.RushDays);

            deskQuote.DeskMaterial = material;
            deskQuote.NumberOfDrawers = numberOfDrawers;
            deskQuote.Depth = depth;
            deskQuote.Width = width;

            string displayOutput = "Customer Name: " + deskQuote.CustomerName + Environment.NewLine +
                            "Desk Width: " + deskQuote.Desk.Width + Environment.NewLine +
                            "Desk Depth: " + deskQuote.Desk.Depth + Environment.NewLine +
                            "Desk Material: " + deskQuote.Desk.DeskMaterial + Environment.NewLine +
                            "Desk Drawer Count: " + deskQuote.Desk.NumberOfDrawers + Environment.NewLine +
                            "Rush Order: " + deskQuote.RushDays + Environment.NewLine +
                            "Quote Total: $" + deskQuote.QuoteTotal;
            DisplayQuote.Quote = displayOutput;

            if (!File.Exists("..\\..\\quotes.json")) 
            {
                File.Create("..\\..\\quotes.json").Close();
            }

            var data = File.ReadAllText("..\\..\\quotes.json");

            var listQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(data) ?? new List<DeskQuote>();

            listQuotes.Add(deskQuote);

            data = JsonConvert.SerializeObject(listQuotes.ToArray());
            File.WriteAllText("..\\..\\quotes.json", data);

        }

        public double calculateTotalQuote(Desk desk, int width, int depth,
            SurfaceMaterial material, int numberOfDrawers, int rushOrderOptions)
        {
            double rushPrice = 0;
            double materialPrice = 0;
            double surfaceArea = width * depth;

            List<int> materialPriceList = new List<int>() {200, 100, 50, 300, 125};


            // Calculate materialPrice.
            if (material == SurfaceMaterial.Oak)
            {
                materialPrice = materialPriceList[0];
            }
            else if (material == SurfaceMaterial.Laminate)
            {
                materialPrice = materialPriceList[1];
            }
            else if (material == SurfaceMaterial.Pine)
            {
                materialPrice = materialPriceList[2];
            }
            else if (material == SurfaceMaterial.Rosewood)
            {
                materialPrice = materialPriceList[3];
            }
            else if (material == SurfaceMaterial.Veneer)
            {
                materialPrice = materialPriceList[4];
            }

            // TextReader reader = File.OpenText("..\\Resources\\rushOrderPrices.txt");

            // Read file as a list of strings, assign it to rushPriceStrings[]
            string[] rushPriceStrings = File.ReadAllLines("..\\..\\Resources\\rushOrderPrices.txt");

            // Create list of doubles to hold rushPrices as a list.
            List<double> rushPricesList = new List<double>();

            for (int i = 0; i < rushPriceStrings.Length; i++)
            {
                // Add rushPriceStrings[] elements to rushPricesList.
                rushPricesList.Add(Convert.ToDouble(rushPriceStrings[i]));
            }

            // Cast rushPricesList to array, assign to rushPrices[].
            double[] rushPrices = rushPricesList.ToArray();

            // Calculate rushPrice.
            switch (rushOrderOptions)
            {
                case 3:
                    if (surfaceArea < 1000)
                    {
                        rushPrice = rushPrices[0];
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        rushPrice = 70;
                    }
                    else if (surfaceArea > 2000)
                    {
                        rushPrice = 80;
                    }
                    break;
                case 5:
                    if (surfaceArea < 1000)
                    {
                        rushPrice = 40;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        rushPrice = 50;
                    }
                    else if (surfaceArea > 2000)
                    {
                        rushPrice = 60;
                    }
                    break;
                case 7:
                    if (surfaceArea < 1000)
                    {
                        rushPrice = 30;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        rushPrice = 35;
                    }
                    else if (surfaceArea > 2000)
                    {
                        rushPrice = 40;
                    }
                    break;
                default:
                    Console.WriteLine("Something probably went wrong.");
                    break;
            }

            if (surfaceArea > 1000)
            {
                double total = (surfaceArea * SQUAREPRICE) + (numberOfDrawers * DRAWERPRICE) + rushPrice + materialPrice + 200;
                return total;
            }
            else
            {
                double total = (numberOfDrawers * DRAWERPRICE) + rushPrice + materialPrice + 200;
                return total;
            }
        }
    }
}
