using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk2
{
    public partial class AddQuote : Form
    {
        Desk desk = new Desk();
        DeskQuote deskQuote = new DeskQuote();

        public AddQuote()
        {
            InitializeComponent();
            deskQuote.ShippingDays = 14;
        }

        private void ExitAddQuoteButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void CustomerNameTextField_TextChanged(object sender, EventArgs e)
        {
            // Assign the entered customer name to the _customerName variable of the new deskQuote object.
            deskQuote.CustomerName = CustomerNameTextField.Text;

            try
            {

            }
            catch(Exception)
            {
                MessageBox.Show("");
            }

        }

        private void WidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            desk.Width = Convert.ToInt32(WidthNumericUpDown.Value);
        }

        private void WidthNumericUpDown_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(WidthNumericUpDown.Value) < Desk.MINWIDTH)
            {
                MessageBox.Show("You need to enter a value of at least 24 inches.");
                WidthNumericUpDown.Text = String.Empty;
                WidthNumericUpDown.Focus();
            }
            else if (Convert.ToInt32(WidthNumericUpDown.Value) > Desk.MAXWIDTH)
            {
                MessageBox.Show("You need to enter a value equal to or less than 96 inches.");
                WidthNumericUpDown.Text = String.Empty;
                WidthNumericUpDown.Focus();
            }
        }

        private void WidthNumericUpDown_Enter(object sender, EventArgs e)
        {
            {
                if (WidthNumericUpDown.Value == 0)
                {
                    int lengthOfAnswer = WidthNumericUpDown.Value.ToString().Length;
                    WidthNumericUpDown.Select(0, lengthOfAnswer);
                }
            }
        }

        private void DepthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            desk.Depth = Convert.ToInt32(DepthNumericUpDown.Value);
        }

        private void DepthNumericUpDown_Enter(object sender, EventArgs e)
        {
            {
                if (DepthNumericUpDown.Value == 0)
                {
                    int lengthOfAnswer = DepthNumericUpDown.Value.ToString().Length;
                    DepthNumericUpDown.Select(0, lengthOfAnswer);
                }
            }
        }

        private void DrawersNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            desk.NumberOfDrawers = Convert.ToInt32(DrawersNumericUpDown.Value);
        }

        private void DrawersNumericUpDown_Enter(object sender, EventArgs e)
        {
            {
                if (DrawersNumericUpDown.Value == 0)
                {
                    int lengthOfAnswer = DrawersNumericUpDown.Value.ToString().Length;
                    DrawersNumericUpDown.Select(0, lengthOfAnswer);
                }
            }
        }

        private void DesktopMaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DesktopMaterialComboBox.Text == "Laminate")
            {
                desk.DeskMaterial = SurfaceMaterial.Laminate;
            }
            else if (DesktopMaterialComboBox.Text == "Oak")
            {
                desk.DeskMaterial = SurfaceMaterial.Oak;
            }
            else if (DesktopMaterialComboBox.Text == "Rosewood")
            {
                desk.DeskMaterial = SurfaceMaterial.Rosewood;
            }
            else if (DesktopMaterialComboBox.Text == "Veneer")
            {
                desk.DeskMaterial = SurfaceMaterial.Veneer;
            }
            else if (DesktopMaterialComboBox.Text == "Pine")
            {
                desk.DeskMaterial = SurfaceMaterial.Pine;
            }
        }

        private void RushOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RushOrderComboBox.Text == "3 Days")
            {
                deskQuote.ShippingDays = 3;
            }
            else if (RushOrderComboBox.Text == "5 Days")
            {
                deskQuote.ShippingDays = 5;
            }
            else if (RushOrderComboBox.Text == "7 Days")
            {
                deskQuote.ShippingDays = 7;
            }
            else if (RushOrderComboBox.Text == "14 Days")
            {
                deskQuote.ShippingDays = 14;
            }
        }

        private void SubmitAddQuoteButton_Click(object sender, EventArgs e)
        {
            // Write quote data to file to submit order. This method will also handle quote total calculations within the DeskQuote class.
            deskQuote.writeQuoteToFile(deskQuote.CustomerName, desk, desk.Width, desk.Depth, desk.DeskMaterial, desk.NumberOfDrawers, deskQuote.ShippingDays);
            MessageBox.Show("Order submitted!");
            DisplayQuote viewDisplayQuote = new DisplayQuote();
            viewDisplayQuote.Tag = this;
            viewDisplayQuote.Show(this);
            Hide();
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
        }

        private void DepthValidating(object sender, CancelEventArgs e)
        {
            string text = Convert.ToString(DepthNumericUpDown.Value);

            /* I utilized the IsControl and IsDigit methods here due to assignment requirements.
             * It wasn't a necessary form of validation for this field because this is a NumericUpDown and they
             * can only enter numbers to begin with, so I simply used console write lines to show when such characters
             * were detected. I hope this sufficiently demonstrates my ability to use the methods. If I wanted
             * to use them for validation I'd probably have to use a text field rather than a NumericUpDown. */
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsControl(text, i))
                {
                    Console.WriteLine("Control character detected at position: " + i);
                }
                if (Char.IsDigit(text, i))
                {
                    Console.WriteLine("Digit detected.");
                }
            }

            if (Convert.ToInt32(DepthNumericUpDown.Value) < Desk.MINDEPTH)
            {
                MessageBox.Show("You need to enter a value of at least 12 inches.");
                DepthNumericUpDown.Focus();
            }
            else if (Convert.ToInt32(DepthNumericUpDown.Value) > Desk.MAXDEPTH)
            {
                MessageBox.Show("You need to enter a value equal to or less than 48 inches.");
                DepthNumericUpDown.Focus();
            }
        }
    }
}
