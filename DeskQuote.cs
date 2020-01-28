using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* DeskQuote.cs (Class): This class will define the attributes of a quote 
 * including Desk, rush days, customer name, and quote date. This class will 
 * also hold the logic in determining the desk quote total.*/
namespace MegaDesk_Alkire
{
    class DeskQuote
    {
        public Desk _desk { get; set; }
        public int _rushDays { get; set; } // 3, 5, or 7 days. Normal production time = 14 days.
        public string _customerName { get; set; }
        public DateTime _quoteDate { get; set; }
        public double _quoteTotal { get; set; }
        public const int CUBICPRICE = 200;
        public const int DRAWERPRICE = 50;

        public void writeQuoteToFile(string customerName, Desk desk, int width, int depth, 
            SurfaceMaterial material, int numberOfDrawers, int rushOrderOptions)
        {
            DeskQuote deskQuote = new DeskQuote();
            deskQuote._customerName = customerName;
            deskQuote._desk = desk;
            deskQuote._desk.Width = width;
            deskQuote._desk.Depth = depth;
            deskQuote._desk.DeskMaterial = material;
            deskQuote._desk.NumberOfDrawers = numberOfDrawers;
            deskQuote._rushDays = rushOrderOptions;
            deskQuote._quoteTotal = calculateTotalQuote(deskQuote._desk, deskQuote._desk.Width, 
                deskQuote._desk.Depth, deskQuote._desk.DeskMaterial, deskQuote._desk.NumberOfDrawers, deskQuote._rushDays);

            StreamWriter writer;
            writer = new StreamWriter(@"c:\tmp\DeskQuotes.txt");
            string output = "Customer Name: " + deskQuote._customerName + "\n" +
                            "Desk Width: " + deskQuote._desk.Width + "\n" +
                            "Desk Depth: " + deskQuote._desk.Depth + "\n" +
                            "Desk Material: " + deskQuote._desk.DeskMaterial + "\n" +
                            "Desk Drawer Count: " + deskQuote._desk.NumberOfDrawers + "\n" +
                            "Rush Order: " + deskQuote._rushDays + "\n" +
                            "Quote Total: $" + deskQuote._quoteTotal;
            writer.WriteLine(output);
            writer.Close();

            string displayOutput = "Customer Name: " + deskQuote._customerName + Environment.NewLine +
                            "Desk Width: " + deskQuote._desk.Width + Environment.NewLine +
                            "Desk Depth: " + deskQuote._desk.Depth + Environment.NewLine +
                            "Desk Material: " + deskQuote._desk.DeskMaterial + Environment.NewLine +
                            "Desk Drawer Count: " + deskQuote._desk.NumberOfDrawers + Environment.NewLine +
                            "Rush Order: " + deskQuote._rushDays + Environment.NewLine +
                            "Quote Total: $" + deskQuote._quoteTotal;
            
            DisplayQuote.Quote = displayOutput;
        }

        public double calculateTotalQuote(Desk desk, int width, int depth,
            SurfaceMaterial material, int numberOfDrawers, int rushOrderOptions)
        {
            double rushPrice = 0;
            double materialPrice = 0;
            double surfaceArea = width * depth;

            // Calculate materialPrice.
            if (material == SurfaceMaterial.Oak)
            {
                materialPrice = 200;
            }
            else if (material == SurfaceMaterial.Laminate)
            {
                materialPrice = 100;
            }
            else if (material == SurfaceMaterial.Pine)
            {
                materialPrice = 50;
            }
            else if (material == SurfaceMaterial.Rosewood)
            {
                materialPrice = 300;
            }
            else if (material == SurfaceMaterial.Veneer)
            {
                materialPrice = 125;
            }

            // Calculate rushPrice.
            switch (rushOrderOptions)
            {
                case 3:
                    if (surfaceArea < 1000)
                    {
                        rushPrice = 60;
                    }
                    else if (surfaceArea >= 1000 || surfaceArea <= 2000)
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
                    else if (surfaceArea >= 1000 || surfaceArea <= 2000)
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
                    else if (surfaceArea >= 1000 || surfaceArea <= 2000)
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

            double total = (surfaceArea * CUBICPRICE) + (numberOfDrawers * DRAWERPRICE) + rushPrice + materialPrice;
            return total;
        }
    }
}
