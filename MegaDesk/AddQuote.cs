using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {

        #region Declarations
        string CustomerName = String.Empty;
        int DeskWidth = 0;
        int DeskDepth = 0;
        int Drawers = 0;
        DesktopMaterial DesktopMaterial;
        int RushOrderDays = 0;
        int DeskQuoteTotal = 0;
        #endregion


        public List<int> DrawerNumber = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7 };

        public AddQuote()
        {
            InitializeComponent();
            comboBoxSurfaceMaterial.DataSource = Enum.GetValues(typeof(DesktopMaterial));

            NumDrawersComboBox.DataSource = DrawerNumber;

        }

        private void cancelQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var ReturnMainMenu = (MainMenu)Tag;
            ReturnMainMenu.Show();
        }

        private void WidthBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(int.TryParse(WidthTextBox.Text, out int WidthInput))
            {
                if(WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Text = "Please enter a width from 24 to 96 inches squared.";
                    WidthTextBox.Text = String.Empty;
                    WidthTextBox.BackColor = Color.Red;
                    WidthTextBox.Focus();
                }
                else
                {
                    WidthTextBox.BackColor = Color.GreenYellow;
                    MessageBox.Text = String.Empty;
                }
            }
        }

        private void DepthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }



        private void CalcQuote_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerName = textBoxCustomerName.Text;
                DeskWidth = int.Parse(WidthTextBox.Text);
                DeskDepth = int.Parse(DepthTextBox.Text);
                Drawers = int.Parse(NumDrawersComboBox.SelectedItem.ToString()); ;
                DesktopMaterial = (DesktopMaterial)comboBoxSurfaceMaterial.SelectedValue;

                //rush order selection
                if (radioRush3.Checked)
                {
                    RushOrderDays = 3;
                }
                if (radioRush5.Checked)
                {
                    RushOrderDays = 3;
                }
                if (radioRush5.Checked)
                {
                    RushOrderDays = 3;
                }
                if (noRush.Checked)
                {
                    RushOrderDays = 0;
                }


                //Create New quote
                DeskQuote NewQuote = new DeskQuote(CustomerName, DateTime.Now, DeskWidth, DeskDepth, Drawers, DesktopMaterial, RushOrderDays);
                DeskQuoteTotal = NewQuote.CalculateQuoteTotal();

                //build CSV output
                var DeskRecord = CustomerName + ", " + DateTime.Now + ", " + DeskWidth + ", " + DeskDepth + ", " + Drawers + ", " + DesktopMaterial + ", " + RushOrderDays + ", $" + DeskQuoteTotal;
                string cFile = @"quotes.txt";
                if (!File.Exists(cFile))
                {
                    using (StreamWriter sw = File.CreateText("quotes.txt")) { }
                }
                using (StreamWriter swa = File.AppendText("quotes.txt")) { swa.WriteLine(DeskRecord); }

                ThankYouMessage.Text = "Thank you for Submitting a quote!";
                DisplayDeskQuote.Text = "Your quote is: " + DeskRecord;
                cancelQuote.Text = "Main Menu";

            }
            catch (Exception ex)
            {

                MessageBox.Text = ex.Message;
            }


        }



    }
}
