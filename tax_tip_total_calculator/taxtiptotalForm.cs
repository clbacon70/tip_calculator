using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
    Project      Tax Tip Total Calculator
    Programmer   Carole Bacon
    Date         1.22.2015
                
    	         Calculates the total amount of the bill, tip and tax
*/
namespace tax_tip_total_calculator
{
    public partial class taxtiptotalForm : Form
    {
        public taxtiptotalForm()
        {
            InitializeComponent();
        }

        //Declarations

        double bill;        // the amount of the bill
        double tip;         // the amount of the tip
        double tax;         // the amount of the tax
        double billPlusTip; // the amount of the bill + tip
        double subtotal;    // the amount of the billPlusTip * .07
        double total;       // the amount of the billPlusTip + the subtotal

        private void taxtiptotalForm_Load(object sender, EventArgs e)
        {
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear text boxes and output
            billTextBox.Clear();
            tipTextBox.Clear();
            taxTextBox.Clear();
            totalTextBox.Clear();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // calculates the bill amount, tax and tip entered by user
            totalTextBox.Text = "";

            try
            {
                double bill, tip, tax, total;

                bill = double.Parse(billTextBox.Text);
                try
                {
                    tip = double.Parse(tipTextBox.Text);
                    try
                    {
                        tax = double.Parse(taxTextBox.Text);
                        billPlusTip = bill + tip;
                        subtotal = billPlusTip * tax;
                        total = billPlusTip + subtotal;
                        totalTextBox.Text = total.ToString("c2");
                    }
                    // catches error with tax = double.Parse(taxTextBox.Text);
                    catch
                    {
                        MessageBox.Show("Please enter .07 for the tax amount");
                        taxTextBox.Focus();
                        taxTextBox.SelectAll();
                    }
                }


                // catches error with tip - double.Parse(tipTextBox.Text);
                catch
                {
                    MessageBox.Show("Please enter the tip amount");
                    tipTextBox.Focus();
                    tipTextBox.SelectAll();
                }
                    
                }
             // catches error with bill - double.Parse(billTextBox.Text);
                catch
                {
                    MessageBox.Show("Please enter the bill amount");
                    billTextBox.Focus();
                    billTextBox.SelectAll();
                }
            }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // The user wants to exit the application. Close everything down.
                 Application.Exit();
 
        }

            }
        }

   
